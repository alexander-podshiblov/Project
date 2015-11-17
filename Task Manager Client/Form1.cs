using System;
using System.Collections;
using System.Collections.Generic;
using Task_Manager_Classes;
using System.Windows.Forms;

namespace Task_Manager_Client
{
    public partial class Form1 : Form
    {
        CommunicationInterface service;
        private User user = new User();
        List<Task> orders;
        List<Task> tasks;
        int statusFilter;
        int statusTaskFilter;
        
        public Form1(CommunicationInterface s)
        {
            InitializeComponent();
            service = s;

            statusFilter = 1;
            statusBox.SelectedIndex = 0;

            statusTaskFilter = 1;
            statusTaskBox.SelectedIndex = 0;
        }
        
        public void enableTab()
        {
            tab.Enabled = true;
            updateTasks();
            updateOrders();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            tab.Enabled = false;
            SignIn si = new SignIn(user, service, this);
            si.Show();
            

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(user, service);
            addTask.FormClosed += updateOrders;
            addTask.Show();
        }

        private void updateOrders(object sender, FormClosedEventArgs e)
        {
            updateOrders();
        }
        
        public void updateOrders()
        {
            try
            {
                orders = service.getOrders(user, statusFilter);

                ordersView.Items.Clear();
                foreach(Task t in orders)
                {
                    string status = t.strStatus();

                    t.to_shortname = service.getShortName(t.to);
                    t.from_shortname = service.getShortName(t.from);

                    ListViewItem item = new ListViewItem(new string[] {t.name,
                                                                       t.to_shortname,
                                                                       DateTime.FromBinary(t.datetime).ToString(),
                                                                       DateTime.FromBinary(t.deadline).ToString(),
                                                                       status});
                    ordersView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void updateTasks()
        {
            try
            {
                tasks = service.getTasks(user, statusTaskFilter);

                tasksView.Items.Clear();
                foreach (Task t in tasks)
                {
                    string status = t.strStatus();

                    t.to_shortname = service.getShortName(t.to);
                    t.from_shortname = service.getShortName(t.from);

                    ListViewItem item = new ListViewItem(new string[] {t.name,
                                                                       t.from_shortname,
                                                                       DateTime.FromBinary(t.datetime).ToString(),
                                                                       DateTime.FromBinary(t.deadline).ToString(),
                                                                       status});
                    tasksView.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {

            if (ordersView.SelectedIndices.Count == 0)
                MessageBox.Show("Task not selected");
            else
            {
                int ind = (int)ordersView.SelectedIndices[0];
                OrderForm of = new OrderForm(user, service, orders[ind]);
                of.FormClosed += updateOrders;
                of.Show();
            }
        }

        private void openTaskButton_Click(object sender, EventArgs e)
        {
            if (tasksView.SelectedIndices.Count == 0)
                MessageBox.Show("Task not selected");
            else
            {
                int ind = (int)tasksView.SelectedIndices[0];
                TaskForm tf = new TaskForm(user, service, tasks[ind]);
                tf.Show();
            }
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = statusBox.SelectedIndex;

            int newStatus;

            if (index == 0)
                newStatus = 1;
            else if (index == 1)
                newStatus = 0;
            else if (index == 2)
                newStatus = -1;
            else
                newStatus = -2;

            if (newStatus != statusFilter)
            {
                statusFilter = newStatus;
                updateOrders();
            }
        }

        private void statusTaskBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = statusTaskBox.SelectedIndex;

            int newStatus;

            if (index == 0)
                newStatus = 1;
            else if (index == 1)
                newStatus = 0;
            else if (index == 2)
                newStatus = -1;
            else
                newStatus = -2;

            if (newStatus != statusTaskFilter)
            {
                statusTaskFilter = newStatus;
                updateTasks();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateTasks();
        }

    }
}
