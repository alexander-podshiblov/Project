using System;
using Task_Manager_Classes;
using System.Windows.Forms;

namespace Task_Manager_Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        



        [STAThread]
        static void Main()
        {
            //--------------------
            

            //--------------------


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
