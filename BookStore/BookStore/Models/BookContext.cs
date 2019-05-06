using System;
using System.Data.Entity;
namespace BookStore.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
    public class BookDBInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book({ Name = "War & Peace", Author = "L. Tolstoy", Price = 220 });
            db.Books.Add(new Book({ Name = "Children & Fathers", Author = "I. Turgeniev", Price = 180 });
            db.Books.Add(new Book({ Name = "Gull", Author = "A. Chehov", Price = 220 });
        }
    }
}
