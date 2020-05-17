using System;
using System.Globalization;

namespace DisplayEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = new int[10];
            int[] arrayEven = new int[10];
            int j=0;
            Console.Write("Enter the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter {0} numbers to the array: \n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number-{0} :", i);
                arrayNum[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {

                if (arrayNum[i] % 2 == 0)
                {
                    arrayEven[j] = arrayNum[i];
                    j++;
                  
                }
            }
                Console.Write("\nThe Even numbers are : \n");
                for (int i = 0; i < j; i++)
                {
                    Console.Write("{0} ", arrayEven[i]);
                }
                Console.ReadLine();
            }
        }
    }

