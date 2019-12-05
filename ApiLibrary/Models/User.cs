using System;
using System.ComponentModel.DataAnnotations;

namespace ApiLibrary.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [StringLength(250, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string Nome { get; set; }
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(250)]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6)]
        [Required]
        public string Password { get; set; }

        public DateTime DateCreate;
        

    }
}
