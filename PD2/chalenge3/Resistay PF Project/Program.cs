using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistay_PF_Project
{
    class Users
    {
        public string username;
        public string role;
        public string password;
        public string year;
        public string gender;
        public string alloted;
        public string hostel;
        public string aggregate;
        public string isReplyed;
        public string complain;
        public int attendance;
        public int messBill;
        public int rooms;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = new List<Users>();
            int option = 0;
            option = int.Parse(Console.ReadLine());
            while (option == 3)
            {
                Console.Clear();
                loginPage();
                if (option == 1)
                {
                    users.Add(takeInput());
                }
                else if (option == 2)
                {
                    Console.Write("Enter the Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter the password: ");
                    string password = Console.ReadLine();
                    string role = signInConditions(username, password, users);
                    if (role == "warden")
                    {
                        Console.WriteLine("\t\t\t\t\tWarden Menu");
                        int wardenOption = 0;
                        wardenOption = int.Parse(Console.ReadLine());
                        if (wardenOption == 1)
                        {
                            users.Add(addRt());
                        }
                        if (wardenOption == 2)
                        {
                            Console.Write("Enter the name of rt which you want to remove: ");
                            string usernames = Console.ReadLine();
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (usernames == users[i].username)
                                {
                                    users.RemoveAt(i);
                                }
                            }
                        }
                        if (wardenOption == 3)
                        {
                            Console.Write("Enter the Old Password: ");
                            string passwords = Console.ReadLine();
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (passwords == password)
                                {
                                    users[i].password = Console.ReadLine();
                                    Console.WriteLine("Pssword Updated Successfully");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Pssword does not Change");
                                    Console.ReadLine();
                                }
                            }
                        }

                    }
                }
            }
        }
      static  Users takeInput()
        {
            Users s = new Users();
            Console.Write("Enter the Username: ");
            s.username=Console.ReadLine();
            Console.Write("Enter the password: ");
            s.password = Console.ReadLine();
            Console.Write("Enter the role: ");
            s.role = Console.ReadLine();
            if (s.role == "student")
            {
                Console.Write("Enter the gender: ");
                s.gender = Console.ReadLine();
                Console.Write("Enter the year: ");
                s.year = Console.ReadLine();
                Console.Write("Enter the aggregate: ");
                s.aggregate = Console.ReadLine();
            }
            return s;
        }
        static void loginPage()
        {
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");
        }
        static string signInConditions(string username,string password,List<Users>users )
        {
            for (int i = 0; i< users.Count; i++)
            {
            // Check if the entered username and password match stored credentials
                 if (username == users[i].username && password == users[i].password)
                    {
            // Return the role of the authenticated user
                  return users[i].role;
                    }
            }
                // Return "undefined" if no match is found
                return "undefined";
        }
        static Users addRt()
        {
            Users s = new Users();
            Console.Write("Enter the Username: ");
            s.username = Console.ReadLine();
            Console.Write("Enter the password: ");
            s.password = Console.ReadLine();
            Console.Write("Enter the Hostel: ");
            s.hostel = Console.ReadLine();
            s.role = "rt";
            return s;
        }


    }

}
