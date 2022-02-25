using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
              int numberFirst = int.Parse(Console.ReadLine());
              int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                int numberSecond = int.Parse(Console.ReadLine());
                sum += numberSecond;
                if(sum >= numberFirst)
                {
                    Console.WriteLine(sum);
                    break;
                }                  
            }
        }
    }
}
