using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;
using EventPortal.BLL.Services.Repositories;
using EventPortal.DAL.EventRepository;

namespace EventPortal.UI.Controllers
{
    public class ConcertController : Controller
    {   

        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var searchedConcerts = ConcertRepository.SearchConcerts(value);

                return View("Index", new Home { ConcertList = searchedConcerts });
            }
            var model = new Home()
            {
                ConcertList = ConcertRepository.Concerts
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(ConcertRepository.GetById(id));
        }
    }
}
