using System;
using System.ServiceModel;
using Task_Manager_Classes;

namespace Task_Manager_Server
{
    class Program
    {
        private static  Member collectMemberInfo()
        {
            Member m = new Member();

            Console.Write("Enter first name: ");
            m.fstName = Console.ReadLine();

            Console.Write("Enter patronymic: ");
            m.patronymic = Console.ReadLine();

            Console.Write("Enter last name: ");
            m.lstName = Console.ReadLine();

            Console.Write("Enter department id: ");
            m.depID = int.Parse(Console.ReadLine());

            Console.Write("Enter level: ");
            m.level = int.Parse(Console.ReadLine());

            return m;
        }

        private static string login = "";
        private static string hash = "";

        private static void mainCircle()
        {
            while (true)
            {
                Console.Write("Admin mode> ");
                string cmd = Console.ReadLine();
                if (cmd == "register_member")
                {
                    Member m = collectMemberInfo();
                    Console.Write("Enter login: ");
                    string login = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string pass = Console.ReadLine();

                    Executor.registerNewMember(m, login, pass);
                }
                else if (cmd == "logout")
                {
                    login = "";
                    hash = "";
                    return;
                }
                else
                {
                    Console.WriteLine("< unknown command : " + "\"" + cmd + "\"" + " >");
                }
            }
        }

        private static void waitRegistration()
        {
            while (true)
            {
                Console.Write("Admin reg mode>");
                string cmd = Console.ReadLine();
                if (cmd == "register_admin")
                {
                    Console.Write("Enter login: ");
                    string l = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string h = CommonData.hash_with_salt(Console.ReadLine());

                    Executor.registerAdmin(l, h);

                    return;
                }
                else
                {
                    Console.WriteLine("< unknown command : " + "\"" + cmd + "\"" + " >");
                }
            }
        }

        private static void signIn()
        {
            Console.Write("Enter login: ");
            login = Console.ReadLine();
            Console.Write("Enter password: ");
            hash = CommonData.hash_with_salt(Console.ReadLine());

            if (Executor.isHashTrue(login, hash))
                mainCircle();
            else
                Console.WriteLine("Wrong");
        }

        

        static void Main(string[] args)
        {
            Executor.openConnection();

            string serverUri;
            Console.Write("Enter ip: ");
            serverUri = Console.ReadLine();

            serverUri = CommonData.serverUriB + serverUri + CommonData.serverUriE;

            ServiceHost host = new ServiceHost(typeof(QueryHandler), new Uri(serverUri));
            NetTcpBinding binding = new NetTcpBinding();
            //-----
            binding.TransactionFlow = false;
            binding.Security.Transport.ProtectionLevel =
               System.Net.Security.ProtectionLevel.EncryptAndSign;
            binding.Security.Transport.ClientCredentialType =
               TcpClientCredentialType.Windows;
            binding.Security.Mode = SecurityMode.None;
            //-----

            host.AddServiceEndpoint(typeof(CommunicationInterface), binding, "");
            host.Open();
            Console.WriteLine("Start service...");

            if (!Executor.isAdminExist())
                waitRegistration();
            
            while (true)
            {
                Console.Write("Not admin mode>");
                string cmd = Console.ReadLine();
                if (cmd == "signin")
                {
                    signIn();
                }
                else
                {
                    Console.WriteLine("< unknown command : " + "\"" + cmd + "\"" + " >");
                }
            }
            
            

        }
    }
}
