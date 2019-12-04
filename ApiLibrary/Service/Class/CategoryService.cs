using ApiLibrary.Models;
using ApiLibrary.Repository.Interface;
using ApiLibrary.Service.Interface;
using System;
using System.Collections.Generic;

namespace ApiLibrary.Service.Class
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<Category> ListAllCategorys()
        {
            return categoryRepository.ListCategorys();
        }

        public bool AddCategory(Category category)
        {
            if (categoryRepository.FindByName(category.Nome) == null)
            {
                categoryRepository.Add(category);
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
