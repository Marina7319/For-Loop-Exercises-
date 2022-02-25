using System;

namespace _07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double result = 0;
            double resultMusala = 0;
            double resultKilimandjaro = 0;
            double resultMonblan = 0;
            double resultK2 = 0;
            double resultEverest = 0;
            for (int i = 1; i <= num; i++)
            {
                int numGroup = int.Parse(Console.ReadLine());
                result += numGroup;
                if (numGroup <= 5) //Musala
                {
                    resultMusala += numGroup;
                }
                if (numGroup >= 6 && numGroup <= 12)//Kilimandjaro
                {
                    resultKilimandjaro += numGroup;
                }
                if (numGroup >= 13 && numGroup <= 25)//Monblan
                {
                    resultMonblan += numGroup;
                }
                if (numGroup >= 26 && numGroup <= 40)//K2
                {
                    resultK2 += numGroup;
                }
                if (numGroup >= 41)//Everest
                {
                    resultEverest += numGroup;
                }
            }
            double musala = resultMusala / result * 100;
            double kilimandjaro = resultKilimandjaro / result * 100;
            double monblan = resultMonblan / result * 100;
            double K2 = resultK2 / result * 100;
            double Everest = resultEverest / result * 100;
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{K2:f2}%");
            Console.WriteLine($"{Everest:f2}%");
        }
    }
}
