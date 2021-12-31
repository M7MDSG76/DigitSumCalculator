using System;

namespace DIGITCOUNT
{
    class Program
    {
        static int getSum(int n)
        {
            if (n == 0)
                return 0;
            Console.WriteLine(n);
            return (n % 10 + getSum(n / 10));
            

          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number of digit: ");
            int num = int.Parse(Console.ReadLine());
            int result = getSum(num);
            Console.WriteLine("the sum of digit in " + num + " is " + result);
        }
    }
}
