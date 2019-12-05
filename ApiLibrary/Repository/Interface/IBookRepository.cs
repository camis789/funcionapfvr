using System;
using System.Collections.Generic;
using ApiLibrary.Models;

namespace ApiLibrary.Repository.Interface
{
    public interface IBookRepository
    {
        void Add(Book book);
        Book FindByCode(int barCode);
        List<Book> ListBooks();

        void Update(Book book);
    }
}
