using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
	public static void Initialize(IServiceProvider serviceProvider)
	{
		using (var genreContext = new MvcAlbumContext(serviceProvider.GetRequiredService<
		   DbContextOptions<MvcAlbumContext>>()))
		{
			if (!genreContext.Genres.Any())
			{
				new List<Genre>
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
				}.ForEach(g => genreContext.Genres.Add(g));
				genreContext.SaveChanges();
			}

		}

		using (var artistContext = new MvcAlbumContext(serviceProvider.GetRequiredService<
		   DbContextOptions<MvcAlbumContext>>()))
		{
			if (!artistContext.Album.Any())
			{
				new List<Artist>
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
				}.ForEach(artist => artistContext.Add(artist));
				artistContext.SaveChanges();
			}


		}


		using (var albumContext = new MvcAlbumContext(serviceProvider.GetRequiredService<
		   DbContextOptions<MvcAlbumContext>>()))
		{
			if (!albumContext.Album.Any())
			{
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

				new List<Album>
				{
					new Album { Title = "Audioslave", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
					new Album { Title = "The Last Night of the Proms", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Barry Wordsworth & BBC Concert Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
					new Album { Title = "A Copland Celebration, Vol. I", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Copland & London Symphony Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
					new Album { Title = "Worlds", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
					new Album { Title = "For Those About To Rock We Salute You", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
					new Album { Title = "Let There Be Rock", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" }

				}.ForEach(a => albumContext.Album.Add(a));

				albumContext.SaveChanges();
			}			

		}

		using (var context = new MvcMovieContext(
			serviceProvider.GetRequiredService<
				DbContextOptions<MvcMovieContext>>()))
		{
			//// Look for any movies.
			if (context.Movie.Any())
			{
				return;   // DB has been seeded
			}
			if (context.Movie == null)
			{
				context.Movie.AddRange(
				new Movie
				{
					Title = "When Harry Met Sally",
					ReleaseDate = DateTime.Parse("1989-2-12"),
					Genre = "Romantic Comedy",
					Rating = "R",
					Price = 7.99M
				},
				new Movie
				{
					Title = "Ghostbusters ",
					ReleaseDate = DateTime.Parse("1984-3-13"),
					Genre = "Comedy",
					Price = 8.99M
				},
				new Movie
				{
					Title = "Ghostbusters 2",
					ReleaseDate = DateTime.Parse("1986-2-23"),
					Genre = "Comedy",
					Price = 9.99M
				},
				new Movie
				{
					Title = "Rio Bravo",
					ReleaseDate = DateTime.Parse("1959-4-15"),
					Genre = "Western",
					Price = 3.99M
				}
			);
				context.SaveChanges();
			}

		}


	}
}