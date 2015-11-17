using System;
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
    public partial class SetIp : Form
    {
        Form1 mainForm;
        public SetIp(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                Properties.Settings.Default.serverUri = maskedTextBox1.Text;
                Properties.Settings.Default.Save();
                mainForm.connectToServer();
                this.Close();
            }
            else
                MessageBox.Show("IP incorrect");
        }
    }
}
