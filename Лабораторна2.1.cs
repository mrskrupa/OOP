using System;

namespace Лабораторная_2._1
{
    class Adress
    {
        public int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();

                    Console.WriteLine("Введите индекс: ");
                    adress.Index = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите страну: ");
                    adress.Country = Console.ReadLine();

                    Console.WriteLine("Введите город: ");
                    adress.City = Console.ReadLine();

                    Console.WriteLine("Введите улицу: ");
                    adress.Street = Console.ReadLine();

                    Console.WriteLine("Введите номер дома: ");
                    adress.House = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите номер квартиры: ");
                    adress.Apartment = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Индекс: {adress.Index}, страна: {adress.Country}, город: {adress.City}, номер дома: {adress.House}, номер квартиры: {adress.Apartment}");
            Console.ReadLine();
        }
    }
}
