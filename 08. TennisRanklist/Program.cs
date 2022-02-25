using System;

namespace _08._TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = int.Parse(Console.ReadLine());
            double numTwo = int.Parse(Console.ReadLine());
            int W = 0;
            int F = 0;
            int SF = 0;
            for (int i = 1; i <= numOne; i++)
            {
                string text = Console.ReadLine();//W F SF
                if (text == "W")
                {
                    W += 1;
                }
                if (text == "F")
                {
                    F += 1;
                }
                if (text == "SF")
                {
                    SF += 1;
                }
            }
            double WSum = W * 2000;
            double FSum = F * 1200;
            double SFSum = SF * 720;
            double sum = WSum + FSum + SFSum + numTwo;
            double total = (WSum + FSum + SFSum) / numOne;
            double percent = W / numOne * 100;
            Console.WriteLine("Final points: " + sum);
            Console.WriteLine("Average points: " + Math.Floor(total));
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
