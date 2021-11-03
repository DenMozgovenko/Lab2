using System;

namespace ConsoleApp2
{
    class User
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }

        public User(string Id, string Name, string Surname, string Age)
        {
            id = Id;
            name = Name;
            surname = Surname;
            age = Age;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool c = true;
            User Dn = new User("1", "Den", "Mozgovenko", "21");
            User Vl = new User("2", "Valentin", "Boychas", "21");
            User Al = new User("3", "Alex", "Starovoytov", "22");
            User V = new User("4", "Vi", "Cyber", "69");
            User[] m = new User[4];
            m[0] = Dn;
            m[1] = Vl;
            m[2] = Al;
            m[3] = V;

            string str_search = Console.ReadLine();
            foreach (User i in m)
            {
                if (i.id == str_search || i.name == str_search || i.surname == str_search || i.age == str_search)
                {
                    c = false;
                    Console.WriteLine($"ID: {i.id}, Name: {i.name}, Surname: {i.surname}, Age: {i.age}");
                }
            }
            if (c == true)
            {
                Console.WriteLine($"Errororro!");
            }
        }
    }

}
