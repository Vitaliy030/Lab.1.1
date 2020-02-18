using System;
namespace ConsoleApp2
{
    public class Program
    {
        static public double Example1(int a, int b)
        {
            double c;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }

        static public double Example2(int a, int b, double c)
        {
            double P;
            P = a + b + c;
            return P;
        }
        static int Main()
        {
            int a, b;
            double P, c;
            Console.Write("Перший катет (a):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Другий катет (b):");
            b = Convert.ToInt32(Console.ReadLine());
            Example1(a, b);
            Example2(a, b, Example1(a, b));
            c = Example1(a, b);
            P= Example2(a, b, Example1(a, b));
            Console.Write("Гiпотенуза (с): " + c);
            Console.WriteLine("\nПериметр (Р): " + P);
            return 0;
        }
    }
}
