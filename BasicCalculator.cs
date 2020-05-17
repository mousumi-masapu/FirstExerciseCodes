using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed(+,-,*,%):");
            String operation = Console.ReadLine();
            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());
            if (operation == "+")
            {
                int result = num1 + num2 ;
                Console.WriteLine("The result is :" + num1  +operation + num2 + "=" + result);
                //Console.WriteLine("{0} + {1} = {2}", first, second, result);


            }
            else if (operation == "-")
            {
                int result = num1 - num2;
                Console.WriteLine("The result is : " + num1 + operation + num2 + "=" + result);
            }
            else if (operation == "*")
            {
                int result = num1 * num2;
                Console.WriteLine("The result is : " + num1 + operation + num2 + "=" + result);
            }
            else if (operation == "%")
            {
                int result = num1 % num2;
                Console.WriteLine("The result is : " + num1 + operation + num2 + "=" + result);
            }
            else
            {
                Console.WriteLine("Enter a valid operation");
                Console.ReadLine();
            }



        }
    }
}
