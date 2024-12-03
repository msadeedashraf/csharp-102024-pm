using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Book> libraryBooks = new List<Book>
            {
            new Book("The Great Gatsby", "F. Scott Fitzgerald"),
            new Book("1984", "George Orwell"),
            new Book("To Kill a Mockingbird", "Harper Lee")
            };

            Dictionary<string , int> bookAvailability = new Dictionary<string , int>
            {
                  { "The Great Gatsby", 2 },
            { "1984", 3 },
            { "To Kill a Mockingbird", 1 }

            }   ;

            Queue<string> bookRequests = new Queue<string>();

            Console.WriteLine("Books in the Library:");

            foreach (var book in libraryBooks)
            {
                Console.WriteLine(book);
            }

            
            Console.WriteLine("\nRequesting a book: '1984'");
            string requestedBook = "1984";

            if (bookAvailability.ContainsKey(requestedBook) && bookAvailability[requestedBook] > 0)
            {
                bookRequests.Enqueue(requestedBook); // Add to the request queue
                bookAvailability[requestedBook]--; // Decrease availability
                Console.WriteLine($"'{requestedBook}' has been issued. Remaining copies: {bookAvailability[requestedBook]}");
            }
            else
            {
                Console.WriteLine($"Sorry, '{requestedBook}' is not available.");
            }


            // Handle another request
            Console.WriteLine("\nRequesting a book: 'The Great Gatsby'");
            requestedBook = "The Great Gatsby";

            if (bookAvailability.ContainsKey(requestedBook) && bookAvailability[requestedBook] > 0)
            {
                bookRequests.Enqueue(requestedBook);
                bookAvailability[requestedBook]--;
                Console.WriteLine($"'{requestedBook}' has been issued. Remaining copies: {bookAvailability[requestedBook]}");
            }
            else
            {
                Console.WriteLine($"Sorry, '{requestedBook}' is not available.");
            }


            // Print the queue of requests
            Console.WriteLine("\nBooks in Request Queue:");
            foreach (var book in bookRequests)
            {
                Console.WriteLine(book);
            }


            Console.ReadLine();

        }
    }
}
