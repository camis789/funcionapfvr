using System;
using System.ComponentModel.DataAnnotations;

namespace ApiLibrary.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime DateCreate;
        

    }
}
