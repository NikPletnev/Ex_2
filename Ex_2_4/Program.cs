using System;

namespace Ex_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите три числа:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double x1, x2;
            double discriminant = Math.Pow(B,2)-4*A*C;
            if (discriminant >= 0)
            {
                x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                if (discriminant > 0)
                {
                    x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                    Console.WriteLine($"У такого квадратного уравнения будет два корня x1 = {x1} и x2 = {x2}");

                }
                else
                {
                    Console.WriteLine($"У такого квадратного уравнения будет один корeнь x1 = {x1}");
                }

            }
            else
            {
                Console.WriteLine($"У такого квадратного уравнения нет корней");
            }

        }
    }
}
