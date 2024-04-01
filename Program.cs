using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace LoggingCode
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string username;
            string password;
            int attempts = 3;

            while (attempts > 0)
            {

                {
                   
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    if (username == "Admin" && password == "Admin1234")
                    {
                        Console.WriteLine("Logging in successful");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input");
                        attempts--;

                        Console.WriteLine("Remaining attempts:" + attempts + "\n");
                    }
                }
                if (attempts == 0)
                {
                    Console.WriteLine("Maximum attempts reached. Try again later");
                }
            }
        }
    }
}


                    