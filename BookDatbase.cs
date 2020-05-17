using System;
using System.Dynamic;

namespace BookDatabse
{
    
    class Program
    {
        struct Books
        {
            public String Title;
            public String Author;
            //public int bookId;
        }
        static void Main(string[] args)
        {
           // int noBooks =1000;(total Books)
            int noBooks = 3;
            Books[] book = new Books[noBooks];
            int booksIn = 0;

            // ADD DATA FOR  BOOK

            /* for (int i = 0; i < noBooks; i++)
             {
                 Console.WriteLine("Enter data for book {0}", booksIn + 1);
                 Console.Write("Enter the name of the book :");
                 book[booksIn].Title = Console.ReadLine();
                 Console.Write("Enter the author of the book :");
                 book[booksIn].Author = Console.ReadLine();
                 booksIn++;
                Console.WriteLine();
             }*/


            //Display all the books

            /*for (int i = 0; i < booksIn ; i++)
             {
                 Console.WriteLine("{0}: Title = {1},Author = {2}", i+1 , book[i].Title, book[i].Author);
                 Console.WriteLine();

             }*/
            //Adding data for 1 book
            if (booksIn < noBooks)
            {
                for (int i = booksIn; i < noBooks; i++) {

                    Console.WriteLine("Enter data for book {0}", booksIn + 1);
                    Console.WriteLine(booksIn);
                    Console.Write("Enter the name of the book :  ");
                    book[booksIn].Title = Console.ReadLine();
                    Console.Write("Enter the author of the book :  ");
                    book[booksIn].Author = Console.ReadLine();
                    booksIn++;
                    Console.WriteLine(booksIn);
                    Console.WriteLine(i);
                    Console.WriteLine();

                }


            }
            else { 
                Console.WriteLine("Sorry ! No space to enter more books");
                //break;
            }
            if(booksIn==0)
                Console.WriteLine("No books to be added");
            else
            {
                for (int i = 0; i < booksIn; i++)
                {
                    Console.WriteLine("{0} : Title = {1}, Author = {2}", i + 1, book[i].Title, book[i].Author);

                    Console.WriteLine();

                }

            }
            //Search for book with a given title
            Console.WriteLine("Enter the name of the book to be searched : ");

            String findBook = Console.ReadLine();

            //Console.WriteLine("findBook" + findBook);

            Boolean found=false;

            Console.WriteLine("booksIn" + booksIn);

            for (int i = 1; i < booksIn; i++) {

               Console.WriteLine("book[i].Title" + book[i].Title);

                if (book[i].Title == findBook)
                {

                    Console.WriteLine("Book {0} found .", book[i].Title);

                    found = true;
                    break;
                }
                if(!found)
                {
                    Console.WriteLine("Sorry the book {0} is not found .", findBook);
                    Console.WriteLine();
                    break;
                }

                
            }
            //Delete a Book according to number

            if (booksIn == 0)
            {

                Console.WriteLine("No books to delete");
            }
            else
            {
                Console.WriteLine("Enter the book number to be deleted from 1 to {0}", booksIn);

                int numDelete = Convert.ToInt32(Console.ReadLine()) - 1;

               // Console.WriteLine("numDelete" + numDelete);

                // Console.WriteLine("booksIn " + booksIn);

                for (int i = numDelete; i < booksIn-1; i++)

                {
                    Console.WriteLine("Delete book : " + book[i].Title);

                    book[i] = book[i + 1];
                   // Console.WriteLine("Delete book   : " + book[i].Title);
                    booksIn--;

                    //Console.WriteLine("Deleted book");

                }
            }
                

            Console.ReadLine();
         

            }
    }
}
