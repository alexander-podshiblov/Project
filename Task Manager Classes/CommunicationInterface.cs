using System;
using Task_Manager_Classes;
using System.ServiceModel;
using System.Collections.Generic;

namespace Task_Manager_Classes
{
    [ServiceContract]
    public interface CommunicationInterface
    {

        [OperationContract]
        bool changePassword(string login, string hash, string newhash);

        [OperationContract]
        int identify(string login, string hash);

        [OperationContract]
        Dictionary<string, int> getMemberForTask(User user);

        [OperationContract]
        Tuple<int, int> getDepAndLevel(int id);

        [OperationContract]
        string addTask(User user, Task task);

        [OperationContract]
        List<Task> getOrders(User user, int status);

        [OperationContract]
        List<Task> getTasks(User user, int status);

        [OperationContract]
        string getShortName(int id);

        [OperationContract]
        List<Comment> getComments(User user, int task_id);

        [OperationContract]
        void addComment(User user, Comment comment);

        [OperationContract]
        string setTaskStatus(User user, int taskId, int newStatus);
    }
}
