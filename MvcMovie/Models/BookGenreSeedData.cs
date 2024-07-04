using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class BookGenreSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBookGenreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBookGenreContext>>()))
            {
                // Look for any movies.
                if (context.BookGenre.Any())
                {
                    return;   // DB has been seeded
                }
                context.BookGenre.AddRange(
                    new BookGenre
                    {
                        Name="Fiction",
                        Books =
                        {
                            new Book{Title="How I met your mother", Author="David Jones", Price=15, Year=2005 },
                            new Book{Title="The girl with a dragon tatoo", Author="Daniel Craigs", Price=17, Year=2008 },
                        }
                    },
                    new BookGenre
                    {
                        Name = "Non-Fiction",
                        Books =
                        {
                            new Book{Title="Facing the torturer", Author="Francois Bizot", Price=18, Year=2023 },
                            new Book{Title="The Handbook of forgotten skills", Author="Edward de Bono", Price=26, Year=2019 },
                        }
                    }
                  
                );
                context.SaveChanges();
            }
        }
    }
}
