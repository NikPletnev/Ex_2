using System;

namespace Ex_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите два числа:");
            double X = Convert.ToDouble(Console.ReadLine());
            double Y = Convert.ToDouble(Console.ReadLine());
            if (X > 0)
            {
                if (Y > 0)
                {
                    Console.WriteLine($"Точка с координатами {X},{Y} пренаделжит первой четверти");
                }
                else
                {
                    Console.WriteLine($"Точка с координатами {X},{Y} пренаделжит четвертой четверти");
                }
            }
            else
            {
                if (Y > 0)
                {
                    Console.WriteLine($"Точка с координатами {X},{Y} пренаделжит второй четверти");
                }
                else
                {
                    Console.WriteLine($"Точка с координатами {X},{Y} пренаделжит третьей четверти");
                }
            }
        }
    }
}
