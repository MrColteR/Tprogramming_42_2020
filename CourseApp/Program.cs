using System;

namespace CourseApp
{
    public class Program
    {
        public static void TaskA(double a, double b)
        {
            double y;
            double numerator;
            double denominator;
            Console.WriteLine("------- TASK A -------");
            for (double x = 0.08; x <= 1.08; x += 0.2)
            {
                numerator = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(x, 2)), a);
                denominator = Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2)), 1 / 5.0);
                y = numerator / denominator;
                Console.WriteLine($"y =  {y}, x =  {x}");
            }
        }

        public static void TaskB(double a, double b)
        {
            Console.WriteLine("------- TASK B -------");
            double y;
            double numerator;
            double denominator;
            double[] mas = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };
            for (int i = 0; i < mas.Length; i++)
            {
                numerator = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(mas[i], 2)), a);
                denominator = Math.Pow(Math.Abs(Math.Pow(mas[i], 2) - Math.Pow(a, 2)), 1 / 5.0);
                y = numerator / denominator;
                Console.WriteLine($"y =  {y}, x =  {mas[i]}");
            }
        }

        public static void Main(string[] args)
        {
            double a = 2.0;
            double b = 1.1;
            TaskA(a, b);
            TaskB(a, b);
        }
    }
}
