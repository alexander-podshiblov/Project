using System;
using Task_Manager_Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_Client
{
    public partial class SignIn : Form
    {
        private User user;
        private CommunicationInterface service;
        private Form1 mainForm;

        public SignIn(User u, CommunicationInterface s, Form1 mf)
        {
            InitializeComponent();
            user = u;
            service = s;
            mainForm = mf;
            TopMost = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            user.login = loginBox.Text;
            user.hash = CommonData.hash_with_salt(passBox.Text);
            try
            {
                user.id = service.identify(user.login, user.hash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            if (user.id == -1)
            {
                MessageBox.Show("Wrong login or password", "Error");
                
            }
            else
            {
                try
                {
                    user.shortname = service.getShortName(user.id);
                    var dl = service.getDepAndLevel(user.id);
                    user.dep = dl.Item1;
                    user.level = dl.Item2;
                    mainForm.enableTab();
                    mainForm.Text += " - " + user.shortname;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.Close();
            }
        }
        
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
