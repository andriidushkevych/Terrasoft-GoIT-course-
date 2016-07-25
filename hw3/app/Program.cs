using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfUsers = 0;
            string nameOfUsers = "";

            string[] roles = { "Admin", "Moderator", "Moderator", "User", "User", "User" };
            string[] logins = { "admin", "moder1", "moder2", "user1", "user1", "user1" };
            string[] passwords = { "a1", "m1", "m2", "u1", "u2", "u3" };

            Console.Write("Please, enter your login:");
            string log = Console.ReadLine();

            int attempts = 3;

            for (int i = 0; i < logins.Length; i++)
            {
                if (log != logins[i])  continue; 

                for (int j = 0; j < attempts; j++)
                {
                    Console.Write("Please, enter your password:");
                    var pass = Console.ReadLine();

                    if (pass == passwords[i])
                    {
                        switch (roles[i])
                        {
                            case "Admin":
                                for (int k = 0; k < logins.Length; k++)
                                    Console.WriteLine("{0}: Login: {1}, Password: {2}", roles[k], logins[k], passwords[k]);
                                break;
                            case "Moderator":
                                Console.WriteLine("Quantity of all users: {0}", logins.Length);
                                break;
                            default:
                                for (int l = 0; l < roles.Length; l++)
                                    if (roles[l] == "User")
                                    {
                                        countOfUsers++;
                                        nameOfUsers += logins[l] + "; ";
                                    }

                                Console.WriteLine("Quantity with role users {0}-users. User names: {1}", countOfUsers, nameOfUsers);
                                break;
                        }
                        break;
                    }
                    Console.WriteLine("Password is incorrect. You have {0} more attempts left!", (2-j));
                }
            }
            
            Console.ReadKey();
        }
    }
}
