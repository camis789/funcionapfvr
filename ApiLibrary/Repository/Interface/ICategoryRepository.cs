using ApiLibrary.Models;
using System;
using System.Collections.Generic;

namespace ApiLibrary.Repository.Interface
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        Category FindByName(string name);
        Category FindById(int Id);
        List<Category> ListCategorys();
    }
}
