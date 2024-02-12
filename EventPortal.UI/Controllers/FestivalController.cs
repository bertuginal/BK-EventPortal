using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;
using EventPortal.DAL.EventRepository;

namespace EventPortal.UI.Controllers
{
    public class FestivalController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var searchedFestivals = FestivalRepository.SearchFestivals(value);

                return View("Index", new Home { FestivalList = searchedFestivals });
            }
            var model = new Home()
            {
                FestivalList = FestivalRepository.Festivals
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(FestivalRepository.GetById(id));
        }
    }
}
