using System;

namespace SwitchProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from (0 to 10)");
            int numValue = Convert.ToInt32(Console.ReadLine());
            switch (numValue)
            {
                case 9:
                case 10:

                    Console.WriteLine(" Excellent");
                    Console.ReadLine();
                    break;
                case 7:
                case 8:

                    Console.WriteLine("Notable");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Good");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Pass");
                    Console.ReadLine();
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Fail");
                    Console.ReadLine();
                    break;


            }



        }
    }
}
