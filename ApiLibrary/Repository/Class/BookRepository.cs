using System;
using System.Collections.Generic;
using System.Linq;
using ApiLibrary.Context;
using ApiLibrary.Models;
using ApiLibrary.Repository.Interface;

namespace ApiLibrary.Repository.Class
{
    public class BookRepository : IBookRepository
    {
        private readonly DbContextBooks _context;

        public BookRepository(DbContextBooks ctx)
        {
            _context = ctx;
        }

        public void Add(Book book)
        {
            book.DateCreate = DateTime.Now;
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book FindByCode(int Code)
        {
            return _context.Books.Where(x => x.Code == Code).FirstOrDefault();
        }

        public void Update(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }

        public List<Book> ListBooks()
        {
            return _context.Books.ToList();
        }
    }
}
