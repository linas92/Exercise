using System.Collections.Generic;

namespace Exercise
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            /*
            Create a user Login System, where the user can first register and then Login in. 
            The Program should check if the user has entered the correct username and password, 
            when login in (so the same ones that he used when registering).
            As we haven't covered storing data yet, just create the program in a way, 
            that registering and logging in, happen in the same execution of it.
            User If statements and User Input and Methods to solve the challenge.
            */
            //Code Exercise
            Register();
            Login();
            Console.Read();
            
        }
        public static void Register()
        {
            Console.WriteLine("Please enter the username:\n");
            username = Console.ReadLine();
            Console.WriteLine("Please enter the password:\n");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete");
            Console.WriteLine("______________________________________________________");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine($"Login successful! Welcome {username}");
                }
                else
                {
                    Console.WriteLine("Login failed. Wrong password. Restart Program");
                }
            }
            else
            {
                Console.WriteLine("Login failed. Wrong password. Restart Program");
            }
        }
    }
}