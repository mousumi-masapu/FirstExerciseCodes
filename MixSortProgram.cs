using System;
using System.Collections;
using System.IO;

namespace MixSortProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first file name :");
            String FirstFile = Console.ReadLine();

            Console.Write("Enter second file name :");
            String SecondFile = Console.ReadLine();
            //Console.WriteLine(!File.Exists(FirstFile)); 
            if ((!File.Exists(FirstFile)) || (!File.Exists(SecondFile)))
            {
                Console.Write("Specified files do not exsist");
                return;

            }
            try
            {
                StreamReader newFile = File.OpenText(FirstFile);
                Console.WriteLine("StreamReader newFile"+ newFile);
                ArrayList list = new ArrayList();
                String line;
                do
                {
                    line = newFile.ReadLine();
                    //Console.WriteLine("line" + line);
                    if (line != null) { 

                    list.Add(line);
                   //Console.WriteLine("list.Add(line)" + list.Add(line));
                    }
                }

                while (line != null);

                    newFile.Close();

                    newFile = File.OpenText(SecondFile);
                    line = "";

                do
                {
                    line = newFile.ReadLine();
                    //Console.WriteLine("line1" + line);
                    if (line != null) { 
                        list.Add(line);
                        //Console.WriteLine("list.Add(line)" + list.Add(line));
                    }
                }


                while (line != null); 

                newFile.Close();

                list.Sort();

                //Console.WriteLine("list.Count" + list.Count);

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
            

        }catch(Exception e)
            {
                Console.WriteLine("Error");
            }
            }

        }
    }



