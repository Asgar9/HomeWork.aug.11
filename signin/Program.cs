using signin.Models;
using System;

namespace signin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username:");
            User admin = new User(Console.ReadLine());
            Console.WriteLine("Enter the password");
            admin.Password=Console.ReadLine();
            
        }
    }
}
