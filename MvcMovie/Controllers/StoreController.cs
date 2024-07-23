using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class StoreController : Controller
    {
        private readonly MvcAlbumContext _context;
        public StoreController(MvcAlbumContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var genres = _context.Genres.ToList();
            return View(genres);
           
        }

        public IActionResult Browse(string genre)
        {
			//var genreModel = new Genre { Name = genre };
			//return View(genreModel);
			var genreModel = _context.Genres.Include("Albums").Single(g => g.Name == genre);
			return View(genreModel);
		}

        public IActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}
