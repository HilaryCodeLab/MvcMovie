using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Album
    {
		public int AlbumId { get; set; }

		[Display(Name = "Genre")]
		[Required]
		[ForeignKey("Genre")]
        public int? GenreId { get; set; }
        [Display(Name = "Artist")]
        [Required]
        [ForeignKey("Artist")]
        public int? ArtistId { get; set; }
		public string Title { get; set; }
		public decimal Price { get; set; }
		public string? AlbumArtUrl { get; set; }
		public Genre Genre { get; set; }
		public Artist Artist { get; set; }
	}
}
