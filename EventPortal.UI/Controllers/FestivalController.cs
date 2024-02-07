using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace EventPortal.UI.Controllers
{
    public class FestivalController : Controller
    {
        public IActionResult Index()
        {
            var festivalList = new List<Festival>()
            {
                new Festival
                {
                    FestivalName = "SONAR ISTANBUL 2024",
                    FestivalDescription = "Festival",
                    FestivalTime = "26-28 Nisan",
                    FestivalLocation = "Zorlu PSM",
                    FestivalImage = "86b347b9-f785-4204-b5f1-33240cfde830.jpg"
                },
                 new Festival
                {
                    FestivalName = "HOLIFEST",
                    FestivalDescription = "Festival",
                    FestivalTime = "25-27 Mayıs",
                    FestivalLocation = "Life Park",
                    FestivalImage = "edaae3cf-d08c-47bc-9ebe-6a708efb7ba3.jpg"
                },
                  new Festival
                {
                    FestivalName = "AKDENİZ GENÇLİK FESTİVALİ",
                    FestivalDescription = "Festival",
                    FestivalTime = "3-5 Mayıs",
                    FestivalLocation = "Adana",
                    FestivalImage = "indir (1).jpg"
                },
                   new Festival
                {
                    FestivalName = "KOCAELİ MÜZİK FESTİVALİ",
                    FestivalDescription = "Festival",
                    FestivalTime = "10-12 Mayıs",
                    FestivalLocation = "Kocaeli",
                    FestivalImage = "kocaeli-muzik-festivali.jpg"
                },
                    new Festival
                {
                    FestivalName = "KÜÇÜKÇİFTLİK BARK",
                    FestivalDescription = "Festival",
                    FestivalTime = "12 Mayıs Pazar",
                    FestivalLocation = "KüçükÇiftlik Park",
                    FestivalImage = "DhxaZJ0W0AETOu1.jpg"
                },
                     new Festival
                {
                    FestivalName = "GEZGİNFEST",
                    FestivalDescription = "Festival",
                    FestivalTime = "14-16 Haziran",
                    FestivalLocation = "Kocaeli",
                    FestivalImage = "gezginfest.jpg"
                }

            };
            return View(festivalList);

        }
    }
}
