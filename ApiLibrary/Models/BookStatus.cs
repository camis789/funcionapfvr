using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiLibrary.Models
{
    public class BookStatus
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public string Nome { get; set; }
        public DateTime DateCreate { get; set; }

        public ICollection<Book> Books { get; set; }


    }
}
