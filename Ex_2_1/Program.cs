using System;

namespace Ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите два числа:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine($"A+B = {A + B}");
            } else if (A < B)
            {
                Console.WriteLine($"A-B = {A - B}");
            }
            else
            {
                Console.WriteLine($"A*B = {A * B}");
            }

        }
    }
}
