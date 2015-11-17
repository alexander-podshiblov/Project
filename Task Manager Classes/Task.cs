using System;
using System.Collections.Generic;

namespace Task_Manager_Classes
{
    public class Comment
    {
        public int task_id;
        public int from;
        public string from_shortname;
        public long datetime;
        public string text;

        public string build()
        {
            return Environment.NewLine
                   + "< " + DateTime.FromBinary(datetime).ToString() + "  |  "
                   + from_shortname + " >" + Environment.NewLine + Environment.NewLine + text
                   + Environment.NewLine + Environment.NewLine
                   + "-------------------------------------------------------------------------"; 
        }
    }

    public class Task
    {
        public int id = 0;
        public int from;
        public string from_shortname;
        public int to;
        public string to_shortname;
        public long datetime;
        public long deadline;
        public string name;
        public string text;
        public int status = 1;

        public string strStatus()
        {
            if (status == 1)
                return "Active";
            else if (status == 0)
                return "Done";
            else if (status == -1)
                return "Failed";
            else
                return "Error";
        }
        public string build()
        {
            return "Title:  " + name + Environment.NewLine +
                   "From:  " + from_shortname + Environment.NewLine +
                   "To:  " + to_shortname + Environment.NewLine +
                   "Date:  " + DateTime.FromBinary(datetime) + Environment.NewLine +
                   "Deadline:  " + DateTime.FromBinary(deadline) + Environment.NewLine +
                   "Text:  " + text + Environment.NewLine + Environment.NewLine;
        }

    }
}
