using System;
using Task_Manager_Classes;
using System.ServiceModel;
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

            Uri tcpUri = new Uri(CommonData.serverUri);
            EndpointAddress address = new EndpointAddress(tcpUri);
            NetTcpBinding binding = new NetTcpBinding();
            //-----
            binding.TransactionFlow = false;
            binding.Security.Transport.ProtectionLevel =
               System.Net.Security.ProtectionLevel.EncryptAndSign;
            binding.Security.Transport.ClientCredentialType =
               TcpClientCredentialType.Windows;
            binding.Security.Mode = SecurityMode.None;
            //-----

            ChannelFactory<CommunicationInterface> factory = new ChannelFactory<CommunicationInterface>(binding, address);
            CommunicationInterface service = factory.CreateChannel();

            //--------------------


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(service));
            
        }
    }
}
