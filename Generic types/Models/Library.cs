using Generic_types.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types.Models
{
    internal class Library
    {
        public int Booklimit { get; set; }

        private List<Book> _books;
        private int BookLimit;

        public Library(int bookLimit)
        {
            _books = new List<Book>();
            Booklimit = bookLimit;
        }
        public void AddBook(Book book)
        {
            if (_books.Count < BookLimit)
            {
                _books.Add(book);
                return;
            }

            throw new CapacityLimitException("doldu");
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmezz");
            foreach (var book in _books)
            {
                if (book.Id == id)
                    return book;
            }

            return null;
        }
        public void RemoveById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null ola bilmezz");
            foreach(var book in _books)
            {
                if (book.Id == id)
                {
                    _books.Remove(book);
                    return;
                }
                
            }
            throw new NotFoundException($"tapilmadi");
        }


    }
}
