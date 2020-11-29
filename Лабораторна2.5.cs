using System;

namespace Лабораторная_2._5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        DateTime Time { get; set; }

        public User(string login, string name, string surname, int age, DateTime Time)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Time = DateTime.Now;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введитe возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            DateTime Time = DateTime.Now;

            User user = new User(login, name, surname, age, Time);
            Console.WriteLine($"Ваш логин: {user.Login}, имя: {user.Name}, фамилия: {user.Surname}, возраст: {user.Age}, дата заполнения: {Time}");
            Console.ReadLine();
        }
    }
}
