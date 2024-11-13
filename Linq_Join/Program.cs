using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Books> books = new List<Books>();
            books.Add(new Books { AuthorId = 1, BookId = 1, Title = "Yalan" });
            books.Add(new Books { AuthorId = 2, BookId = 2, Title = "Dünya" });
            books.Add(new Books { AuthorId = 3, BookId = 3, Title = "Kırmızı" });
            books.Add(new Books { AuthorId = 4, BookId = 4, Title = "Tomris" });
            books.Add(new Books { AuthorId = 4, BookId = 5, Title = "Yıldırım" });




            List<Authors> authors = new List<Authors>();
            authors.Add(new Authors { AuthorId = 1, Name = "Ali" });
            authors.Add(new Authors { AuthorId = 2, Name = "Veli" });
            authors.Add(new Authors { AuthorId = 3, Name = "Ayşe" });
            authors.Add(new Authors { AuthorId = 4, Name = "Zeynep" });

            var BooksAndAuthors = books.Join(authors,
                                            Books => Books.AuthorId,
                                            Authors => Authors.AuthorId,
                                            (Books, Authors) => new
                                            {
                                                AuthorId = Authors.AuthorId,
                                                Name = Authors.Name,
                                                Title = Books.Title
                                            }
                                            );
            foreach(var  book in BooksAndAuthors)
            {
                Console.WriteLine($"Yazarın ID'si : {book.AuthorId} Yazarın Adı: {book.Name}  Kitabın Adı: {book.Title}");
               
            }
            Console.ReadKey();
        } 
    }
}
