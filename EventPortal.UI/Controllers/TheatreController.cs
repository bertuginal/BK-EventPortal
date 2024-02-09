using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace EventPortal.UI.Controllers
{
    public class TheatreController : Controller
    {
        public IActionResult Index()
        {
            var theatreList = new List<Theatre>()
            {
                new Theatre
                {
                    TheatreName = "OTOMATİK PORTAKAL",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "10 Şubat Cumartesi, 20.30",
                    TheatreLocation = "Ahmed Adnan Saygun Sanat Merkezi",
                    TheatrePrice = 962.50,
                    TheatreImage = "otomatik-portakal.jpg"
                },
                new Theatre
                {
                    TheatreName = "VEDA OYUNU",
                    TheatreDescription = "Tiyatro",
                    TheatreType = "Tiyatro",
                    TheatreTime = "10 Şubat Cumartesi, 20.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatrePrice = 400.00,
                    TheatreImage = "veda-oyunu.jpeg"
                },
                new Theatre
                {
                    TheatreName = "GÜLÜMSETEN HATIRALAR",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "09 Şubat Cuma, 20.00",
                    TheatreLocation = "Mall Of Antalya",
                    TheatrePrice = 250.00,
                    TheatreImage = "gulumseten-hatiralar.jpg"
                },
                new Theatre
                {
                    TheatreName = "MADONNA KÜRK MANTOLU",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "14 Şubat Çarşamba, 20.00",
                    TheatreLocation = "Aralık Sahne",
                    TheatrePrice = 250.00,
                    TheatreImage = "madonna-kurk-mantolu.jpeg"
                },
                new Theatre
                {
                    TheatreName = "SÜT KARDEŞLER",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "13 Mart Çarşamba, 20.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatrePrice = 250.00,
                    TheatreImage = "sut-kardesler.jpg"
                },
                new Theatre
                {
                    TheatreName = "JEKYLL&HYDE",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "18 Şubat Pazar, 21.00",
                    TheatreLocation = "Ahmed Adnan Saygun Sanat Merkezi",
                    TheatrePrice = 741.00,
                    TheatreImage = "jekyll-hyde.jpg"
                },
                new Theatre
                {
                    TheatreName = "HÜCRELER",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "21 Şubat Çarşamba",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatrePrice = 240.00,
                    TheatreImage = "hucreler.jpg"
                },
                new Theatre
                {
                    TheatreName = "ÇOK GÜZEL HAREKETLER 2",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "17 Mart Pazar, 15.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatrePrice = 500.00,
                    TheatreImage = "cok-guzel-hareketler-2.jpeg"
                },
                new Theatre
                {
                    TheatreName = "ÖLÜ'N BİZİ AYIRANA DEK",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "17 Şubat Cumartesi, 20.00",
                    TheatreLocation = "Hikmet Şimşek Sanat Merkezi",
                    TheatrePrice = 500.00,
                    TheatreImage = "olun-bizi-ayirana-dek-oyunu.png"
                },

            };
            return View(theatreList);
        }
    }
}
