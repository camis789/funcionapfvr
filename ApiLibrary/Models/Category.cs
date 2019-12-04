using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLibrary.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
