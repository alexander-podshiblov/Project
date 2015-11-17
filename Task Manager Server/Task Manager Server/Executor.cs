using System;
using Task_Manager_Classes;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Task_Manager_Server
{
    class Executor
    {
        private static SQLiteConnection conn = new SQLiteConnection("Data Source=" + CommonData.dataBasePath + "; Version=3;");
        public static void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }


        public static void registerNewMember(Member m, string login, string pass)
        {
                    SQLiteCommand cmd = conn.CreateCommand();

                    string sql_cmd = "INSERT INTO Members (fname, pat, lname, dep_id, level) "
                                   + "VALUES (" + "'" + m.fstName + "',"
                                                + "'" + m.patronymic + "',"
                                                + "'" + m.lstName + "',"
                                                + m.depID + ","
                                                + m.level +
                                              ");";

                    cmd.CommandText = sql_cmd;

                    //----------
                    
                    SQLiteCommand cmd_get_id = conn.CreateCommand();
                    cmd_get_id.CommandText = @"select last_insert_rowid()";
                    long id;
                    

                    try
                    {
                        cmd.ExecuteNonQuery();

                        id = (long)cmd_get_id.ExecuteScalar();

                        SQLiteCommand cmd_add_l_p = conn.CreateCommand();
                        cmd_add_l_p.CommandText = "INSERT INTO Pass (member_id, login, hash) "
                                                + "VALUES (" + id + ", "
                                                + "'" + login + "',"
                                                + "'" + CommonData.hash_with_salt(pass) + "');";

                        cmd_add_l_p.ExecuteNonQuery();

                        Console.WriteLine("Member was added");
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    
        }
        public static bool changePassword(string login, string hash)
        {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE Pass "
                                    + "SET hash = '" + hash + "' WHERE login = '" + login + "';";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                
        }
        
        public static bool isHashTrue(string login, string hash)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT hash FROM Pass WHERE login = '" + login + "';";

            string realHash;
            try
            {
                realHash = (string)cmd.ExecuteScalar();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            if (hash == realHash)
                return true;
            else
                return false;
        }
        public static int getId(string login)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT member_id FROM Pass WHERE login = '" + login + "';";

            try
            {
                return (int)(long)cmd.ExecuteScalar();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static int getDepId(int id)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT dep_id FROM Members WHERE id = " + id + ";";

            try
            {
                return (int)(long)cmd.ExecuteScalar();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static int getLevel(int id)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT level FROM Members WHERE id = " + id + ";";

            try
            {
                return (int)(long)cmd.ExecuteScalar();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public static Dictionary<string, int> getIdsLower(User user)
        {
            Dictionary<string, int> m = new Dictionary<string, int>();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, lname, fname, pat, level FROM Members WHERE (dep_id = " + user.dep + ")"
                            + "AND (level > " + user.level + ");";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string line = r["lname"].ToString() + " "
                                + r["fname"] + " "
                                + r["pat"] + ", Level "
                                + r["level"];
                    m.Add(line, (int)(long)r["id"]);
                }
                r.Close();
            }            
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return m;
        }

        public static string addTask(Task task)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Tasks (from_id, to_id, datetime, deadline, name, text, status) "
                            + "VALUES ("
                            + task.from + ", "
                            + task.to + ", "
                            + task.datetime + ", "
                            + task.deadline + ", "
                            + "'" + task.name + "', "
                            + "'" + task.text + "', "
                            + task.status + ");";

            try
            {
                cmd.ExecuteNonQuery();
                return "Task was added";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        public static List<Task> getOrders(int id, int status)
        {
            List<Task> ts = new List<Task>();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, from_id, to_id, datetime, deadline, name, text, status FROM Tasks "
                            + "WHERE (from_id = " + id + ")";

            if (status != -2)
                cmd.CommandText += " AND (status = " + status + ")";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Task t = new Task();
                    t.id = (int)(long)r["id"];
                    t.from = (int)(long)r["from_id"];
                    t.to = (int)(long)r["to_id"];
                    t.datetime = (long)r["datetime"];
                    t.deadline = (long)r["deadline"];
                    t.name = r["name"].ToString();
                    t.text = r["text"].ToString();
                    t.status = (int)(long)r["status"];

                    ts.Add(t);

                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return ts;
        }

        public static List<Task> getTasks(int id, int status)
        {
            List<Task> ts = new List<Task>();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, from_id, to_id, datetime, deadline, name, text, status FROM Tasks "
                            + "WHERE (to_id = " + id + ")";

            if (status != -2)
                cmd.CommandText += " AND (status = " + status + ")";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Task t = new Task();
                    t.id = (int)(long)r["id"];
                    t.from = (int)(long)r["from_id"];
                    t.to = (int)(long)r["to_id"];
                    t.datetime = (long)r["datetime"];
                    t.deadline = (long)r["deadline"];
                    t.name = r["name"].ToString();
                    t.text = r["text"].ToString();
                    t.status = (int)(long)r["status"];

                    ts.Add(t);

                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return ts;
        }

        public static string getShortName(int id)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT fname, pat, lname FROM Members WHERE id = " + id + ";";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                r.Read();

                string s = r["fname"].ToString().Substring(0, 1) + "."
                         + r["pat"].ToString().Substring(0, 1) + ". "
                         + r["lname"].ToString();
                return s;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public static List<Comment> getComments(int task_id)
        {
            List<Comment> comments = new List<Comment>();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT task_id, from_id, datetime, text FROM Comments "
                            + "WHERE (task_id = " + task_id + ");";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Comment c = new Comment();
                    c.task_id = (int)(long)r["task_id"];
                    c.from = (int)(long)r["from_id"];
                    c.from_shortname = getShortName((int)(long)r["from_id"]);
                    c.datetime = (long)r["datetime"];
                    c.text = r["text"].ToString();

                    comments.Add(c);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return comments;
        }

        public static void addComment(Comment comment)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Comments (task_id, from_id, datetime, text) "
                            + "VALUES ("
                            + comment.task_id + ", "
                            + comment.from + ", "
                            + comment.datetime + ", "
                            + "'" + comment.text + "')";

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string setTaskStatus(int taskId, int newStatus)
        {
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Tasks "
                            + "SET status = " + newStatus + " WHERE id = " + taskId + ";";

            try
            {
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }
    }
}
