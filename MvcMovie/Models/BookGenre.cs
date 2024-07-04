namespace MvcMovie.Models
{
    public class BookGenre
    {
        public int BookGenreId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
