using System;
using System.Collections.Generic;
using ApiLibrary.Models;
using ApiLibrary.Repository.Interface;
using ApiLibrary.Service.Interface;

namespace ApiLibrary.Service.Class
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly ICategoryRepository categoryRepository;

        public BookService(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            this.bookRepository = bookRepository;
            this.categoryRepository = categoryRepository;
        }

        public bool AddBook(Book book)
        {
            if (bookRepository.FindByCode(book.Code) == null)
            {
                book.Category = categoryRepository.FindById(book.Category.Id);
                bookRepository.Add(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Book> ListAllBooks()
        {
            return bookRepository.ListBooks();
        }
    }
}

