using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum SectionType
    {
        Action,
        ScienceFiction,
        MentalHealth,
        Poetry,
    }
    public class Book
    {
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public int Price { get; protected set; }
        public string Author { get; protected set; }

        public Book(string title, string description, int price, string author)
        {
            Title = title;
            Description = description;
            Price = price;
            Author = author;

        }
        public string BookInfo()
        {
            return Title + "\n" + Description + "\n" + Price + "LE" + "\n" + Author;
        }
    }
}





