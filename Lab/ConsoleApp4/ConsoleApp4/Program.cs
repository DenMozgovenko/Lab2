using System;

namespace ConsoleApp4
{
    class Person
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }

        public Person(string Id, string Name, string Surname, string Age)
        {
            id = Id;
            name = Name;
            surname = Surname;
            age = Age;
        }
        public Person()
        {
            id = "nun";
            name = "Default";
            surname = "Default";
            age = "NUN";
        }
        public Person(string ID, string NAME)
        {
            id = ID;
            name = NAME;
            surname = "Default";
            age = "NUN";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Id: {id}; Name: {name}; Surname: {surname};  Age: {age}. ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person None = new Person();
            Person Den = new Person("1", "Den", "Mozgovenko", "21");
            Person Alex = new Person("2", "Alex");
            None.GetInfo();
            Den.GetInfo();
            Alex.GetInfo();
        }
    }
}
