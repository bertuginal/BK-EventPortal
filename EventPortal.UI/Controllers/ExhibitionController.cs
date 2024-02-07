using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace EventPortal.UI.Controllers
{
    public class ExhibitionController : Controller
    {
        public IActionResult Index()
        {
            var exhibitionList = new List<Exhibition>()
            {
                new Exhibition
                {
                    ExhibitionName = "MAT COLLISHAW: ARİTMİ",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "18 Ağustos'a Kadar",
                    ExhibitionLocation = "Borusan Contemporary",
                    ExhibitionPrice = 150.00,
                    ExhibitionImage = "mat_collishaw_heterosis.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "YAŞASIN CUMHURİYET",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "31 Aralık'a Kadar",
                    ExhibitionLocation = "İş Bankası Müzesi",
                    ExhibitionPrice = 250.00,
                    ExhibitionImage = "yasasin-cumhuriyet-is-sanat-1.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "TAM YERİNDEN",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "25 Şubat'a Kadar",
                    ExhibitionLocation = "Pera Müzesi",
                    ExhibitionPrice = 550.00,
                    ExhibitionImage = "tam-yerinden-1.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "GELECEK HATIRALARI",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "25 Şubat'a Kadar",
                    ExhibitionLocation = "Pera Müzesi",
                    ExhibitionPrice = 450.00,
                    ExhibitionImage = "GH_salon_0051.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "RENKLİ ANADOLU",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Ara Güler Müzesi",
                    ExhibitionPrice = 170.00,
                    ExhibitionImage = "1695900048_Anamur__Mersin__1982.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "SPEKTRUM",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "31 Mart'a Kadar",
                    ExhibitionLocation = "Salt Beyoğlu",
                    ExhibitionPrice = 460.00,
                    ExhibitionImage = "13149.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "KENDİ GÖLGESİNDE",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "7 Nisan'a Kadar",
                    ExhibitionLocation = "Arter",
                    ExhibitionPrice = 230.00,
                    ExhibitionImage = "aac10b45914a69ae7bc7db3abf5d6bab.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "DÖRTNALA",
                    ExhibitionDescription = "Sergi",
                    ExhibitionTime = "1 Mart'a Kadar",
                    ExhibitionLocation = "Gallery 11.17",
                    ExhibitionPrice = 110.00,
                    ExhibitionImage = "indir (9).jpg"
                }

            };
            return View(exhibitionList);
        }
    }
}