using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> 
            {
                new Book(){Title= "price is 5", Price = 5},
                new Book(){Title= "price is 9.99f", Price = 9.99f},
                new Book(){Title= "price is 12", Price = 12},
                new Book(){Title= "price is 7", Price = 7},
                new Book(){Title= "price is 9", Price = 9},

            };
        }
    }
}
