using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Books
    {
        string BookName;
        string AuthorName;

        public Books(string BookName,string AuthorName)    // Constructor...
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine($"The Author of {BookName} is {AuthorName}");
        }
    }
    class BookShelf
    {
        Books[] bk = new Books[5];      // Array

        public Books this[int pos]          // Indexers of book object...
        {
            get { return bk[pos]; }
            set { bk[pos] = value; }
        }
        public static void AssignValue()
        {
            BookShelf bs = new BookShelf();
            Console.WriteLine("Enter Books names and Author name: ");
           
            for(int i=0; i<5;i++)
            {
                string Bname = Console.ReadLine();
                string AName = Console.ReadLine();
                bs[i] = new Books(Bname,AName);
            }
            for(int i=0;i<5;i++)   // Display...
            {
                bs[i].Display();
            }
        }
    }

}
