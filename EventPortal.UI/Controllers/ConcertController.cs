using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace EventPortal.UI.Controllers
{
    public class ConcertController : Controller
    {
        public IActionResult Index()
        {
            var concertList = new List<Concert>()
            {
                new Concert
                {
                    ConcertName = "INNELLEA",
                    ConcertDescription = "Elektronik Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertPrice = 500.0,
                    ConcertImage = "innellea-web-mx3vo2qjss57-crop-480-480.jpg"
                },
                new Concert
                {
                    ConcertName = "SILA",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Zorlu PSM",
                    ConcertPrice = 350.0,
                    ConcertImage = "channels4_profile.jpg"
                },
                new Concert
                {
                    ConcertName = "MABEL MATİZ",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "14 Şubat Çarşamba",
                    ConcertLocation = "Volkswagen Arena",
                    ConcertPrice = 450.0,
                    ConcertImage = "mabel.jpg"
                },
                new Concert
                {
                    ConcertName = "ADRIATIQUE",
                    ConcertDescription = "Elektronik Müzik",
                    ConcertTime = "2 Mart Cumartesi",
                    ConcertLocation = "Volkswagen Arena",
                    ConcertPrice = 500.0,
                    ConcertImage = "maxresdefault.jpg"
                },
                new Concert
                {
                    ConcertName = "EVGENY GRINKO",
                    ConcertDescription = "Klasik Müzik",
                    ConcertTime = "9 Mart Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertPrice = 650.0,
                    ConcertImage = "b48f5c93c5d492fdb8c5b4108741450b.jpg"
                },
                new Concert
                {
                    ConcertName = "BERKAY",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "10 Şubat Cumartesi",
                    ConcertLocation = "Bostancı Gösteri Merkezi",
                    ConcertPrice = 250.0,
                    ConcertImage = "ab6761610000e5ebefc7e159821a28351587cfba.jpg"
                },
                new Concert
                {
                    ConcertName = "PERDENİN ARDINDAKİLER",
                    ConcertDescription = "Alternatif Müzik",
                    ConcertTime = "18 Şubat Pazar",
                    ConcertLocation = "Bostancı Gösteri Merkezi",
                    ConcertPrice = 150.0,
                    ConcertImage = "indir (4).jpg"
                },
                new Concert
                {
                    ConcertName = "GÖKHAN TÜRKMEN",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "9 Mart Cumartesi",
                    ConcertLocation = "Zorlu PSM",
                    ConcertPrice = 200.0,
                    ConcertImage = "ab67616d0000b273db01344ed89dc17b6062b7a3.jpg"
                },
            };
            return View(concertList);
        }
    }
}
