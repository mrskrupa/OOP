using System;

namespace Лабораторная_2._2
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        public double PerimeterCalculator()
        {
            double perimetr = (side1 + side2) * 2;
            return perimetr;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
 
                    Console.WriteLine("Введите длину:");
                    side1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите ширину:");
                    side2 = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(side1, side2);
                    Console.WriteLine($"Периметер равен:" + rectangle.Perimeter);
                    Console.WriteLine($"Площадь равна:" + rectangle.Area);
                    Console.ReadLine();

        }
    }
}
