using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;                       
            for (int n = 1; n <= N; n++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (numbers < 200)
                {
                    p1 += 1;

                }
                if (200 <= numbers && 399 >= numbers)
                {
                    p2 += 1;
                }
                if (400 <= numbers && 599 >= numbers)
                {
                    p3 += 1;
                }
                if (600 <= numbers && 799 >= numbers)
                {
                    p4 += 1;
                }
                if (800 <= numbers)
                {
                    p5 += 1;
                }
            }
            Console.WriteLine($"{((p1 / N) * 100):f2}%");
            Console.WriteLine($"{((p2 / N) * 100):f2}%");
            Console.WriteLine($"{((p3 / N) * 100):f2}%");
            Console.WriteLine($"{((p4 / N) * 100):f2}%");
            Console.WriteLine($"{((p5 / N) * 100):f2}%");
        }
    }
}
