using System;

namespace LR20_Sydorenko
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введіть довжину сторони а:");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0 || a < 0)
                {
                    throw new Exception("не правильно введена довжина сторони а");
                }
                Console.Write("Введіть довжину сторони б:");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b == 0 || b < 0)
                {
                    throw new Exception("не правильно введена довжина сторони б");
                }
                Console.Write("Введіть довжину сторони с:");
                double c = Convert.ToDouble(Console.ReadLine());
                if (c == 0 || c < 0)
                {
                    throw new Exception("не правильно введена довжина сторони с");
                }
                double p = (a + b + c) / 2;
                double s = Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
                Console.WriteLine($"Площа трикутника: {s}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Помилка: {e.Message}");
                //throw;
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }

        }
    }
}