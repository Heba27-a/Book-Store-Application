using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Sections
    {
        public SectionType type { get; protected set; }
        public Book[] Books { get; protected set; }
        private int BookCount = 0;

        public Sections(SectionType type, int MaxBooks)
        {
            this.type = type;
            Books = new Book[MaxBooks];
        }
        protected void AddBook(Book book)
        {
            if (BookCount < Books.Length)
            {

                Books[BookCount++] = book;
            }
            else
            {
                Console.WriteLine(" there is no space anymore");

            }
        }
        /*  public void DisplayBooks()
          {
              for (int i = 0; i < Books.Length; i++)
              {
                  Book book = Books[i];
                  Console.WriteLine("Title :\t\t" + book.Title + "\nAuthor: \t" + book.Author + "\nDescription : \t" + book.Description + "\nPrice : \t" + book.Price);
                  Console.WriteLine("\n");

              }
              if (BookCount == 0)
              {

                  Console.WriteLine(" This Section is empty  ");
              }*/

    }
}





