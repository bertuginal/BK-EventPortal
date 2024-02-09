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
                    ExhibitionName = "SUNAY AKIN İLE YÜZ YÜZE",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "20 Şubat Salı, 20.00",
                    ExhibitionLocation = "BAOB Sahne",
                    ExhibitionPrice = 150.00,
                    ExhibitionImage = "sunay-akin-ile-yuz-yuze-gosterisi.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "SÜPERMAL",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Tek Kişilik Gösteri",
                    ExhibitionTime = "11 Şubat Pazar, 20.00",
                    ExhibitionLocation = "Palladium AVM",
                    ExhibitionPrice = 159.00,
                    ExhibitionImage = "supermal-tek-kisilik-gosteri.jpeg"
                },
                new Exhibition
                {
                    ExhibitionName = "DOĞU DEMİRKOL",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "09 Şubat Cuma, 20.30",
                    ExhibitionLocation = "Bostanlu Suat Taşer Tiyatrosu",
                    ExhibitionPrice = 350.00,
                    ExhibitionImage = "dogu-demirkol.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "OKAN CABALAR",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "17 Şubat Cumartesi, 20.00",
                    ExhibitionLocation = "İzmir Performance Hall",
                    ExhibitionPrice = 350.00,
                    ExhibitionImage = "okan-cabalar.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "MEKSİKA AÇMAZI",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "16 Şubat Cuma",
                    ExhibitionLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    ExhibitionPrice = 350.00,
                    ExhibitionImage = "meksika-acmazi.png"
                },
                new Exhibition
                {
                    ExhibitionName = "ANADOLU ATEŞİ",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Dans Gösterisi",
                    ExhibitionTime = "02 Haziran Pazar, 21.00",
                    ExhibitionLocation = "BJK Tüpraş Stadyumu",
                    ExhibitionPrice = 3000.00,
                    ExhibitionImage = "anadolu-atesi.png"
                },
                new Exhibition
                {
                    ExhibitionName = "BAR PSİKOLOĞU",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Psikogösteri (Seminer)",
                    ExhibitionTime = "17 Şubat Cumartesi, 19.30",
                    ExhibitionLocation = "Bodrum Nurol Kültür Merkezi",
                    ExhibitionPrice = 390.00,
                    ExhibitionImage = "bar-psikologu-psikogosteri.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "SERMET ERKİN - İLLÜZYON GÖSTERİSİ",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Çocuklar için interaktif illüzyon gösterisi",
                    ExhibitionTime = "17 Şubat Cumartesi, 13.00",
                    ExhibitionLocation = "House Of Performance - HoP",
                    ExhibitionPrice = 130.00,
                    ExhibitionImage = "sermet-erkin-interaktif-illuzyon-gosterisi.jpg"
                }

            };
            return View(exhibitionList);
        }
    }
}