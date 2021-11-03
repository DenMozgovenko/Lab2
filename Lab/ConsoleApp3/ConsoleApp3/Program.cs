using System;

namespace ConsoleApp3
{
    class Worker
    {
        public double sum { get; set; }
        public static double operator + (Worker salary, double prem)
        {
            return salary.sum + prem;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double prem = 15000;
            Worker salary = new Worker { sum = 30000 };
            double result = salary + prem;
            Console.WriteLine($"Salary = {result} eurotugrikov");
            Console.ReadKey();
        }
    }
}