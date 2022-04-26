using System;
using System.Numerics;
namespace Small_factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int array = Convert.ToInt16(Console.ReadLine());
            BigInteger result =1;
            int[] numbers = new int[array];
            for(int i=0; i<array; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            for(int j=0;j<array;j++)
            {             
                for(int k=1; k<=numbers[j];k++)
                {
                    result = result * k;
                }
                Console.WriteLine(result);
                result = 1;
            }
        }
    }
}
