using System;

namespace ArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] arrNum = new int[5];
            Console.Write("Enter the number of elements to be stored in the array:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} number in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arrNum[i] = Convert.ToInt32(Console.ReadLine());
              
            }

            Console.Write("The values storedinto the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arrNum[i]);
            }

            Console.Write("\n\n The values stored in the array in reverse order");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arrNum[i]);
            }
            Console.Write("\n\n");
        }
    }
}
