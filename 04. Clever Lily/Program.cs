using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsLily = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0.0;
            for (int i = 1; i <= yearsLily; i++)
            {
                if(i % 2 == 0)
                {
                    money += i * 5 - 1;                 
                }
                else
                {
                    money += toyPrice;                   
                }
            }
            if (washingMachinePrice <= money)
            {
                double priceDifference = money - washingMachinePrice;
                Console.WriteLine($"Yes! {priceDifference:f2}");
            }
            else
            {
                double priceDifference = washingMachinePrice - money;
                Console.WriteLine($"No! {priceDifference:f2}");
            }         
        }
    }
}
