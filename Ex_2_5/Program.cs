using System;

namespace Ex_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите двузначное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            string resultString="";
            string leftPart, rightPart;
            if(number > 10 && number < 100)
            {
                if(number < 20)
                {
                    resultString = number switch
                    {
                        11 => "Одинадцать",
                        12 => "Двенадцать",
                        13 => "Тринадцать",
                        14 => "Четырнадцать",
                        15 => "Пятнадцать",
                        16 => "Шестнадцать",
                        17 => "Семнадцать",
                        18 => "Восемнадцать",
                        19 => "Девятнадцать",
                        _ => "Error",
                    };
                }
                else
                {
                    leftPart = (number / 10) switch
                    {
                        2 => "Двадцать",
                        3 => "Тридцать",
                        4 => "Сорок",
                        5 => "Пятдесят",
                        6 => "Шесдесят",
                        7 => "Семдесят",
                        8 => "Восемдесят",
                        9 => "Девяносто",
                        _ => "Error",
                    };
                    rightPart = (number % 10) switch
                    {
                        1 => "Один",
                        2 => "Два",
                        3 => "Три",
                        4 => "Четыре",
                        5 => "Пять",
                        6 => "Шесть",
                        7 => "Семь",
                        8 => "Восемь",
                        9 => "Девять",
                        _ => "Error",
                    };
                    resultString = leftPart + " " +rightPart;
                }
                Console.WriteLine(resultString);
            }
            else
            {
                Console.WriteLine("Число не двузначное! Вам бан!");
            }
        }
    }
}
