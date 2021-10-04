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
            string result = "";
            if(X == 0 || Y == 0)
            {
                if(X==0 && Y == 0)
                {
                    result = "Точка находится в центре координатой оси";
                }else
                {
                    result = "Точка находится на координатой оси";
                }
            }else if (X > 0)
            {
                if (Y > 0)
                {
                    result = $"Точка с координатами {X},{Y} пренаделжит первой четверти";
                }
                else
                {
                    result = $"Точка с координатами {X},{Y} пренаделжит четвертой четверти";
                }
            }
            else
            {
                if (Y > 0)
                {
                    result = $"Точка с координатами {X},{Y} пренаделжит второй четверти";
                }
                else if (X != 0 && Y !=0)
                {
                    result = $"Точка с координатами {X},{Y} пренаделжит третьей четверти";
                }
            }
            Console.WriteLine(result);
        }
    }
}
