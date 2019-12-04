using ApiLibrary.Models;
using System;
using System.Collections.Generic;

namespace ApiLibrary.Service.Interface
{
    public interface ICategoryService
    {
        bool AddCategory(Category category);
        List<Category> ListAllCategorys();
    }
}
