using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace TechCareerActivityProject.UI.ViewComponents
{
    public class TypesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var genreList = new List<EventPortal.DAL.Models.Type>()
            {
                new EventPortal.DAL.Models.Type { Name = "Konser"},
                new EventPortal.DAL.Models.Type { Name = "Festival"},
                new EventPortal.DAL.Models.Type { Name = "Sahne"},
                new EventPortal.DAL.Models.Type { Name = "Sergi"}
            };
            return View(genreList);
        }
    }
}
