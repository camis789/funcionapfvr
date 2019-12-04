using ApiLibrary.Context;
using ApiLibrary.Models;
using ApiLibrary.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiLibrary.Repository.Class
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DbContextBooks _context;

        public CategoryRepository(DbContextBooks ctx)
        {
            _context = ctx;
        }

        public void Add(Category category)
        {
            _context.Categorys.Add(category);
            _context.SaveChanges();
        }

        public Category FindByName(string nome)
        {
            return _context.Categorys.Where(x => x.Nome == nome).FirstOrDefault();
        }

        public Category FindById(int Id)
        {
            return _context.Categorys.Where(x => x.Id == Id).FirstOrDefault();
        }
        public List<Category> ListCategorys()
        {
            return _context.Categorys.ToList();
        }
    }

}

