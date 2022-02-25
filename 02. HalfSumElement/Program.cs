using System;

namespace _02._HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;
            for(int i =0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if(number > maxNum)
                {
                    maxNum =number;
                }
            }
            int sumWithoutMaxNumber = sum - maxNum;
            if(sumWithoutMaxNumber == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNum);
            }
            else
            {
                int diff = Math.Abs(maxNum - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
