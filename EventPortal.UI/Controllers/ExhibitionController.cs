using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;
using EventPortal.BLL.Services.Repositories;
using EventPortal.DAL.EventRepository;

namespace EventPortal.UI.Controllers
{
    public class ExhibitionController : Controller
    {
        public IActionResult Index(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var searchedExhibitions = ExhibitionRepository.SearchExhibitons(value);

                return View("Index", new Home { ExhibitionList = searchedExhibitions });
            }
            var model = new Home()
            {
                ExhibitionList = ExhibitionRepository.Exhibitions
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(ExhibitionRepository.GetById(id));
        }
    }
}