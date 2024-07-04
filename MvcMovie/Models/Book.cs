using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        [RegularExpression(@"^(\d{4})$", ErrorMessage ="Enter a valid 4 digit Year")]
        public int? Year { get; set; }              
        public string Genre { get; set; }
        
        [Range(0,100)]        
        public decimal Price { get; set; }

    }
}
