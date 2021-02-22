using PPSAMPLE_BOOKSHOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPSAMPLE_BOOKSHOP.Service
{

    public class BookService : IBookService
    {
        private IList<Book> _bookList = new List<Book>();

        public BookService()
        {
            _bookList.Add( new Book { ID = 1, Title = "Heimweg", Author = "Fritzek", Price=10.99m});
            _bookList.Add( new Book { ID = 2, Title = "The Green Mile", Author = "Steven King", Price = 9.99m });
            _bookList.Add( new Book { ID = 3, Title = "ASP.NET WebForms", Author = "Hannes Preishuber", Price = 49.95m});
            _bookList.Add( new Book { ID = 4, Title = "Ein verheißenes Land", Author = "Obama", Price = 49.95m});
            _bookList.Add( new Book { ID = 5, Title = "Ohne Schuld", Author = "Charlotte Link", Price = 19.99m });
            _bookList.Add( new Book { ID = 6, Title = "Ostfriesenzorn", Author = "Klaus-Peter Wolf", Price = 10.99m, AudioBook = true});
            _bookList.Add( new Book { ID = 7, Title = "Arbeitsweg", Author = "Fritzek", Price = 20m});
            _bookList.Add( new Book { ID = 8, Title = "Westfriesenlieb", Author = "Klaus-Peter Wolf", Price = 9.99m});
            _bookList.Add( new Book { ID = 9, Title = "Ostfriesenmelodie", Author = "Klaus-Peter Wolf", Price = 9.99m});
            _bookList.Add( new Book { ID = 10, Title = "Coding des Schreckens - Ein JavaScript Rundumblick", Author = "Kevin Winter", Price = 8.99m, AudioBook = true});
            _bookList.Add( new Book { ID = 11, Title = "Relaxed Yoga", Author = "Wiebkle Roland", Price = 12.99m });
            _bookList.Add( new Book { ID = 12, Title = "Der neunte Arm des Oktopus", Author = "Rossmann", Price = 19.99m, AudioBook = true });
        }

        public IList<Book> GetBooks(string query, bool onlyAudioBooks = false)
        {
            IList<Book> results;
            if (string.IsNullOrEmpty(query))
            {
                if (onlyAudioBooks)
                    results = _bookList.Where(q => q.AudioBook == onlyAudioBooks).ToList(); //Anzeige der gesamten Audio

                else
                    results = _bookList.ToList();

            }
            else
            {
                if (onlyAudioBooks)
                    results = _bookList.Where(q => q.Title.Contains(query) && q.AudioBook == onlyAudioBooks).ToList();
                else
                    results = _bookList.Where(q => q.Title.Contains(query)).ToList();
            }

            return results;
        }

        public int GetCount()
        {
            return _bookList.Count;
        }

        public Book GetById(int id)
        {
            return _bookList.Where(n => n.ID == id).FirstOrDefault();
        }

        public Book InserBook(Book book)
        {
            book.ID = _bookList.Max(n => n.ID) + 1;
            _bookList.Add(book);

            return book;
        }
    }
}
