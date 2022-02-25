using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
               string tabs = Console.ReadLine();
                if(tabs == "Facebook")
                {
                    sum += 150;
                }
                if (tabs == "Instagram")
                {
                    sum += 100;
                }
                if (tabs == "Reddit")
                {
                    sum += 50;
                }
                if(salary == sum)
                {
                    break;
                }             
            }
            if (salary == sum)
            { 
                Console.WriteLine("You have lost your salary.");               
            }else
            {
                double yourMoney = salary - sum;
                Console.WriteLine($"{yourMoney}");
            }
        }
    }
}
