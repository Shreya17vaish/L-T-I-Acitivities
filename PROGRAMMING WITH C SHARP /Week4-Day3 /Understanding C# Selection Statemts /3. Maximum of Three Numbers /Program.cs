using System;

namespace MaxOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            //Console.WriteLine("Enter three numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            Console.WriteLine($"{max} is the maximum number");
        }
    }
}
