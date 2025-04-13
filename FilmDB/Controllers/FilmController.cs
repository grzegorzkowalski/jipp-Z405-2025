using FilmDB.Data;
using FilmDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmDB.Controllers
{
    public class FilmController : Controller
    {
        private FilmContext _context;
        public FilmController(FilmContext context) 
        { 
            _context = context;
        }

        public IActionResult Index()
        {
            var film = new FilmModel();
            film.ID = 0;
            film.Title = "Titanic";
            film.Year = "2000";
            _context.Films.Add(film);
            _context.SaveChanges();

            return View();
        }
    }
}
