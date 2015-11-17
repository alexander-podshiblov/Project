using System;
using System.Collections.Generic;
using Task_Manager_Classes;
using System.Windows.Forms;
using System.Linq;

namespace Task_Manager_Client
{
    public partial class TaskForm : Form
    {
        User user;
        CommunicationInterface service;
        Task task;
        List<Comment> comments;
        
        public TaskForm(User u, CommunicationInterface s, Task t)
        {
            InitializeComponent();
            user = u;
            service = s;
            task = t;

            Text = task.name;
            updateComments();

            updateState();

        }

        private void updateState()
        {
            if (task.status == 1)
            {
                commentBox.Enabled = true;
                sendCommButton.Enabled = true;
            }
        }

        private void updateComments()
        {

            try
            {
                comments = service.getComments(user, task.id);

                commOrdPanel.Controls.Clear();
                commOrdPanel.RowCount = 1;

                //---------------------------------------
                Label ll = new Label();
                ll.Text = task.build();
                ll.AutoSize = true;
                ll.MaximumSize = new System.Drawing.Size(commOrdPanel.Width - 20, 0);
                ll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                ll.Show();


                commOrdPanel.Controls.Add(ll, 0, 0);
                //---------------------------------------

                foreach (Comment c in comments)
                {
                    Label l = new Label();
                    l.Text = c.build();
                    l.AutoSize = true;
                    l.MaximumSize = new System.Drawing.Size(commOrdPanel.Width - 20, 0);
                    l.Show();
                    
                    int row = commOrdPanel.RowCount;
                    commOrdPanel.RowCount++;

                    commOrdPanel.Controls.Add(l, 0, row);
                }

                commOrdPanel.HorizontalScroll.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sendCommButton_Click(object sender, EventArgs e)
        {
            if (commentBox.Text.Any(c => char.IsLetter(c)))
            {
                Comment c = new Comment();
                c.task_id = task.id;
                c.from = user.id;
                c.datetime = DateTime.Now.ToBinary();
                c.text = commentBox.Text;

                try
                {
                    service.addComment(user, c);
                    
                    updateComments();
                    commentBox.Clear();
                    commOrdPanel.VerticalScroll.Value = commOrdPanel.VerticalScroll.Maximum;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Comments not informative");
            }
        }

        private void updateCommButton_Click(object sender, EventArgs e)
        {
            updateComments();
        }        
    }
}
