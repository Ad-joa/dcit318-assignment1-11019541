using System;

namespace TriangleTypeApp
{
    public class Triangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public bool IsValid()
        {
            return (SideA + SideB > SideC) &&
                   (SideA + SideC > SideB) &&
                   (SideB + SideC > SideA);
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Equilateral";
            else if (SideA == SideB || SideB == SideC || SideA == SideC)
                return "Isosceles";
            else
                return "Scalene";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Triangle Type Classifier");
            Console.Write("Enter side A: ");
            double a = ReadSide();
            Console.Write("Enter side B: ");
            double b = ReadSide();
            Console.Write("Enter side C: ");
            double c = ReadSide();

            Triangle triangle = new Triangle(a, b, c);

            if (triangle.IsValid())
            {
                string type = triangle.GetTriangleType();
                Console.WriteLine($"The triangle is: {type}");
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }

        static double ReadSide()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double side) && side > 0)
                    return side;
                Console.Write("Invalid input. Enter a positive number: ");
            }
        }
    }
}
