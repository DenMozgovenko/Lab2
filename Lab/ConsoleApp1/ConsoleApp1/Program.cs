using System;

namespace ConsoleApp1
{
    class Person
    {
        public static int count = 0;
        public Person()
        {
            count++;
        }
        public static void GetInfo()
        {
            System.Console.WriteLine($"Sozdano {count} obyekta");

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
                Person Den = new Person();
                Person Max = new Person();
                Person Alu = new Person();
                Person Sas = new Person();
                Person Vuy = new Person();

                Person.GetInfo();
            }
        }
}
