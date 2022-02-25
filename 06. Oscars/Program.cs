using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int comisia = int.Parse(Console.ReadLine());
            double sum = pointsFromAcademy;
            for (int i = 1; i <= comisia; i++)
            {
                string nameComisia = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                sum += ( nameComisia.Length * points )/ 2;
                if (sum > 1250.5)
                {
                    double sumNeeded = sum;
                    Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {sumNeeded:f1}!");
                    break;
                }
            }
            if (sum <= 1250.5)
            {
                double sumNeeded =1250.5 - sum;
                Console.WriteLine($"Sorry, {nameActor} you need {sumNeeded:f1} more!");
            }
        }
    }
}
