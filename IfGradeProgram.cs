using System;

namespace IfGradeProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the mark scored (0-10)");
            int mark=Convert.ToInt32(Console.ReadLine());

            if (mark <= 4)
            {
                Console.WriteLine("Fail");
            }
            else if (mark == 9 || mark == 10)
            {
                Console.WriteLine("Excellent");
            }

            else if (mark == 7 || mark == 8)
            {
                Console.WriteLine("Notable");
            }
            else if (mark == 5 )
            {
                Console.WriteLine("Pass");
            }
            else if (mark == 6)
            {
                Console.WriteLine("Good");
            }
            else
            Console.ReadLine();
        }
    }
}
