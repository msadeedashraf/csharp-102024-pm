using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace chapter7
{
    internal class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        
        //public bool IsCheckedOut { get; set; }



        public LibraryBook(string title, string author,string isbn, int totalCopies)
        { 
            Title = title;  
            Author = author;
            ISBN = isbn;
            TotalCopies = totalCopies;
            AvailableCopies = totalCopies;
            
        }

        public void CheckOut()
        {
            if (AvailableCopies<=0) 
                {
                    Console.WriteLine($"Sorry, all the copies of {Title} are not avaialble.");
                }
                else
                {
                AvailableCopies--;
                DateTime returnDate = DateTime.Now.AddDays(7);
                Console.WriteLine($"You have successfully checked out {Title}. {AvailableCopies} / {TotalCopies} Remaning");
                Console.WriteLine($"Please return it by {returnDate:dddd, MMMM d, yyyy}.");
                }
         }


        public void ReturnBook()
        {
            if (AvailableCopies>=TotalCopies)
            {
                Console.WriteLine($"All Copies of {Title} are available in the library.");
            }
            else
            {
                AvailableCopies++;
                Console.WriteLine($"Thank you for returning {Title}. Its now available for others.");
            }
        }
        public void DisplayBookInfo()
        {

            Console.WriteLine("Book Information");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Total Copies: {TotalCopies}");
            Console.WriteLine($"Available Copies: {AvailableCopies}");
            //Console.WriteLine($"Available: {IsCheckedOut}");


        }


    }
}
