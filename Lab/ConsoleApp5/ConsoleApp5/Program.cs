using System;

namespace ConsoleApp5
{
    class User
    {
        private static int id { get; } = 1;
        private static string name { get; } = "Den";
        private static string surname { get; } = "Mozgovenko";
        public static void GetInfo()
        {
            System.Console.WriteLine($"User #{id} have name: {name}, and surname: {surname}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User Den = new User();
            User.GetInfo();
        }
    }
}
