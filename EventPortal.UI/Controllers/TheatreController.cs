using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;
using EventPortal.DAL.EventRepository;

namespace EventPortal.UI.Controllers
{
    public class TheatreController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var searchedTheatres = TheatreRepository.SearchTheatres(value);

                return View("Index", new Home { TheatreList = searchedTheatres });
            }
            var model = new Home()
            {
                TheatreList = TheatreRepository.Theatres
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(TheatreRepository.GetById(id));
        }
    }
}
