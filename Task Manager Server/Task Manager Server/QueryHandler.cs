using System;
using Task_Manager_Classes;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Task_Manager_Server
{
    class QueryHandler : CommunicationInterface
    {


        public bool changePassword(string login, string hash, string newhash)
        {
            if (Executor.isHashTrue(login, hash))
                return Executor.changePassword(login, newhash);
            else
                return false;
        }

        public int identify(string login, string hash)
        {
            if (Executor.isHashTrue(login, hash))
            {
                return Executor.getId(login);
            }
            else
            {
                return -1;
            }
        }

        public Tuple<int, int> getDepAndLevel(int id)
        {
            return new Tuple<int, int>(Executor.getDepId(id), Executor.getLevel(id));
        }

        public Dictionary<string, int> getMemberForTask(User user)
        {
            return Executor.getIdsLower(user);
        }

        public string addTask(User user, Task task)
        {
            if (Executor.isHashTrue(user.login, user.hash))
            {
                return Executor.addTask(task);
            }
            else
            {
                return "Insufficient access rights";
            }
        }

        public List<Task> getOrders(User user, int status)
        {
            if (!Executor.isHashTrue(user.login, user.hash))
                return null;
            else
                return Executor.getOrders(user.id, status);
        }

        public List<Task> getTasks(User user, int status)
        {
            if (!Executor.isHashTrue(user.login, user.hash))
                return null;
            else
                return Executor.getTasks(user.id, status);
        }

        public string getShortName(int id)
        {
            return Executor.getShortName(id);
        }

        public List<Comment> getComments(User user, int task_id)
        {
            if (!Executor.isHashTrue(user.login, user.hash))
                return null;
            else
                return Executor.getComments(task_id);
        }

        public void addComment(User user, Comment comment)
        {
            if (Executor.isHashTrue(user.login, user.hash))
            {
                Executor.addComment(comment);
            }
        }

        public string setTaskStatus(User user, int taskId, int newStatus)
        {
            if (Executor.isHashTrue(user.login, user.hash))
            {
                return Executor.setTaskStatus(taskId, newStatus);
            }
            else
            {
                return "Insufficient access rights";
            }
        }
    }
}
