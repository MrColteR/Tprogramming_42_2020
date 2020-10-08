using System;

namespace CourseApp
{
    public class Program
    {
        public static void TaskA(double a, double b, double xStart, double xEnd, double xd)
        {
            for (xStart = 0.08; xStart <= xEnd; xStart += xd)
            {
                double numerator = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(xStart, 2)), a);
                double denominator = Math.Pow(Math.Abs(Math.Pow(xStart, 2) - Math.Pow(a, 2)), 1 / 5.0);
                double y = numerator / denominator;
                Console.WriteLine($"y =  {y}, x =  {xStart}");
            }
        }

        public static void TaskB(double a, double b)
        {
            double[] mas = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };
            for (int i = 0; i < mas.Length; i++)
            {
                double numerator = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(mas[i], 2)), a);
                double denominator = Math.Pow(Math.Abs(Math.Pow(mas[i], 2) - Math.Pow(a, 2)), 1 / 5.0);
                double y = numerator / denominator;
                Console.WriteLine($"y =  {y}, x =  {mas[i]}");
            }
        }

        public static void Main(string[] args)
        {
            double a = 2.0;
            double b = 1.1;
            double xStart = 0.08;
            double xEnd = 1.08;
            double xd = 0.2;
            Console.WriteLine("------- TASK A -------");
            TaskA(a, b, xStart, xEnd, xd);
            Console.WriteLine("------- TASK B -------");
            TaskB(a, b);
        }
    }
}
