using System;

namespace Ex_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите три числа:");
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double min=A, max=B, medium=C;
            if (A > B)
            {
                if (A > C)
                {
                    max = A;
                    if(C > B)
                    {
                        medium = C;
                        min = B;
                    }
                    else
                    {
                        medium = B;
                        min = C;
                    }
                }
                else
                {
                    max = C;
                    medium = A;
                    min = B;
                }
            }
            else
            {
                if(B > C)
                {
                    max = B;
                    if (A > C)
                    {
                        medium = A;
                        min = C;
                    }
                    else
                    {
                        min = A;
                    }
                }else
                {
                    min = A;
                    medium = B;
                    max = C;
                }
            }
            Console.WriteLine($"Числа в порядке возрастания: {min},{medium},{max}");
        }
    }
}
