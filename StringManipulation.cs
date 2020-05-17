using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message : ");
            String message = Console.ReadLine();
            Console.WriteLine("Your message is {0}", message);

            //-Replaces all spaces with underscores (storing the result in a new string)

            var replaceSpace = message.Replace(' ', '_');
            Console.WriteLine(replaceSpace);
            String newMessage = Console.ReadLine();

            //Removes leading and trailing spaces (storing the result in another string)
            var trimmedMessage = message.Trim();
            Console.WriteLine(trimmedMessage);
            String newtrimMessage= Console.ReadLine();

            //eplaces all lowercase A by uppercase A (storing the result in another string)

            int length = message.Length;
            //Console.WriteLine("length = message.Length;" + length);
            char[] strArray = message.ToCharArray(0, length);
            for (int i = 0; i < length; i++)
            {
                Char check = strArray[i];
                // Console.WriteLine("Char check = strArray[i]" +check);

                //Console.WriteLine("check value" + check);
                if (check == 'A')
                    Console.Write(Char.ToLower(check));
                else
                    Console.Write(check);
            }

            Console.Write("\n\n ");

        }
    }
}
