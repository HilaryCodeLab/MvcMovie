namespace MvcMovie.Models
{
    public class BookGenreViewModel
    {
        public List<BookGenre> GenreList = new List<BookGenre>();
    }

    public class BookGenre
    {
        public int BookGenreId { get; set; }
        public string BookGenreName { get; set; }


    }
}
