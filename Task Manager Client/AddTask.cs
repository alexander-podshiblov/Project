using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Task_Manager_Classes;
using System.Windows.Forms;

namespace Task_Manager_Client
{
    public partial class AddTask : Form
    {
        private CommunicationInterface service;
        private User user;
        private Dictionary<string, int> m;
        
        public AddTask(User u, CommunicationInterface s)
        {
            InitializeComponent();
            user = u;
            service = s;
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            m = service.getMemberForTask(user);
            foreach (var a in m)
            {
                toBox.Items.Add(a.Key);
            }

            deadlinePicker.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            deadlinePicker.MinDate = DateTime.Now;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleBox.Text.Length == 0)
            {
                MessageBox.Show("Fill the title");
            }
            else if (toBox.SelectedIndex == -1)
            {
                MessageBox.Show("Chose executor");
            }
            else if (! deadlinePicker.Checked)
            {
                MessageBox.Show("Set deadline");
            }
            else
            {
                Task task = new Task();

                task.from = user.id;
                m.TryGetValue((string)toBox.SelectedItem, out task.to);
                task.datetime = DateTime.Now.ToBinary();
                task.deadline = deadlinePicker.Value.ToBinary();
                task.name = titleBox.Text;
                task.text = textBox.Text;

                try
                {
                    MessageBox.Show(service.addTask(user, task));
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
