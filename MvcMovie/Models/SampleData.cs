using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
	public class SampleData 
	{
		public static void SeedAlbums(IServiceProvider serviceProvider)
		{
			using (var albumContext = new MvcAlbumContext(serviceProvider.GetRequiredService<
			   DbContextOptions<MvcAlbumContext>>()))
			{
				if (albumContext.Album.Any())
				{
					return;
				}

				var genres = new List<Genre>
			{
				new Genre { Name = "Rock" },
				new Genre { Name = "Jazz" },
				new Genre { Name = "Metal" },
				new Genre { Name = "Alternative" },
				new Genre { Name = "Disco" },
				new Genre { Name = "Blues" },
				new Genre { Name = "Latin" },
				new Genre { Name = "Reggae" },
				new Genre { Name = "Pop" },
				new Genre { Name = "Classical" }
			};
				var artists = new List<Artist>
			{
				new Artist { Name = "Aaron Copland & London Symphony Orchestra" },
				new Artist { Name = "Aaron Goldberg" },
				new Artist { Name = "AC/DC" },
				new Artist { Name = "Accept" },
				new Artist { Name = "Adrian Leaper & Doreen de Feis" },
				new Artist { Name = "Aerosmith" },
				new Artist { Name = "Aisha Duo" },
				new Artist { Name = "Alanis Morissette" },
				new Artist { Name = "Alberto Turco & Nova Schola Gregoriana" },
				new Artist { Name = "Alice In Chains" },
				new Artist { Name = "Amy Winehouse" },
				new Artist { Name = "Anita Ward" },
				new Artist { Name = "Antônio Carlos Jobim" },
				new Artist { Name = "Apocalyptica" },
				new Artist { Name = "Audioslave" },
				new Artist { Name = "Barry Wordsworth & BBC Concert Orchestra" }
			};
				var albums = new List<Album>
			{
				new Album { Title = "The Best Of Men At Work", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Men At Work"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Worlds", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "For Those About To Rock We Salute You", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Let There Be Rock", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Balls to the Wall", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Restless and Wild", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Górecki: Symphony No. 3", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Big Ones", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aerosmith"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Quiet Songs", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aisha Duo"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Jagged Little Pill", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Alanis Morissette"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Facelift", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Alice In Chains"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Frank", Genre = genres.Single(g => g.Name == "Pop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Amy Winehouse"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Ring My Bell", Genre = genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Anita Ward"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Chill: Brazil (Disc 2)", Genre = genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Warner 25 Anos", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Plays Metallica By Four Cellos", Genre = genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
				new Album { Title = "Revelations", Genre = genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "/Content/Images/placeholder.gif" }
			};
				albumContext.AddRange(albums);
				albumContext.SaveChanges();

			}
		}
	}
}
