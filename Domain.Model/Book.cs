using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Название книги")]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "Автор")]
        public string Author { get; set; }
        
        [Required]
        [Display(Name = "Стоимость")]
        public decimal Price { get; set; }
    }
}
