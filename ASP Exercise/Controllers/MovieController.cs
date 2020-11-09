using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ASP_Exercise.Models;
using PagedList;
using PagedList.Mvc;

namespace ASP_Exercise.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shark" };
            var customers = new List<Customer>()
            {
                new Customer {Name = "Zed" },
                new Customer {Name = "Y" }
            };

            var viewModel = new ViewModel.RandomMoviceViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index(int? page)
        {
            if(!page.HasValue)
            {
                page = 1;
            }
            //int p_no = Convert.ToInt32(page);
            //int cout_to_remove = (p_no-1) * 7;
            var movies = _context.Movie.Include(x => x.GenreType).ToList().ToPagedList(page ?? 1, 6);

            //paging
            //movies.RemoveRange(0,cout_to_remove);
            //movies.RemoveRange(7, movies.Count - 7);
            return View(movies);
        }

        public ActionResult Details(int? Id)
        {
            if(!Id.HasValue)
            {
                Id = 0;
            }
            var movie = _context.Movie.Include(m => m.GenreType).SingleOrDefault(m=>m.ID == Id);
            return View(movie);
        }


        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(string.Format("Year {0}, Month {1}", year, month));
        }

        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(string.Format("Year {0}, Month {1}", year, month));
        }
    }
}