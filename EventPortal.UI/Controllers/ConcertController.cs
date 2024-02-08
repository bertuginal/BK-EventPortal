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
                    ConcertName = "HADİSE",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "19 Haziran Çarşamba, 21.30",
                    ConcertLocation = "Jolly Joker, Beyoğlu/İstanbul",
                    ConcertPrice = 500.00,
                    ConcertImage = "hadise-konseri.jpg"
                },
                 new Concert
                {
                    ConcertName = "ATHENA",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "02 Mart Cumartesi, 22.00",
                    ConcertLocation = "Hangout PSM, Bornova/İzmir",
                    ConcertPrice = 350.00,
                    ConcertImage = "athena-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "AYŞEGÜL ALDİNÇ",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "09 Şubat Cuma, 21.00",
                    ConcertLocation = "SoldOut Performance Hall",
                    ConcertPrice = 300.00,
                    ConcertImage = "aysegul-aldinc-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "CEM ADRIAN",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "10 Şubat Cumartesi, 23.00",
                    ConcertLocation = "Ooze Venue",
                    ConcertPrice = 500.00,
                    ConcertImage = "cem-adrian-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "ADAMLAR",
                    ConcertType = "Rock",
                    ConcertDescription = "Rock Müzik",
                    ConcertTime = "23 Şubat Cuma, 22.00",
                    ConcertLocation = "Sponge Pub Konyaaltı",
                    ConcertPrice = 650.00,
                    ConcertImage = "adamlar-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "HAYKO CEPKİN",
                    ConcertType = "Rock",
                    ConcertDescription = "Rock Müzik",
                    ConcertTime = "16 Mart Cumartesi, 22.00",
                    ConcertLocation = "Hangout PSM",
                    ConcertPrice = 500.00,
                    ConcertImage = "hayko-cepkin-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "MANUŞ BABA",
                    ConcertType = "Alternatif Rock",
                    ConcertDescription = "Alternatif Rock",
                    ConcertTime = "08 Mart Cuma, 21.30",
                    ConcertLocation = "Dorock XL Kadıköy",
                    ConcertPrice = 150.00,
                    ConcertImage = "manus-baba-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "LEVENT YÜKSEL",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "24 Mart Pazar, 20.30",
                    ConcertLocation = "EKM Erciyes Kültür Merkezi",
                    ConcertPrice = 200.0,
                    ConcertImage = "levent-yuksel-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "HAKAN ALTUN",
                    ConcertType = "Arabesk",
                    ConcertDescription = "Arabesk Müzik",
                    ConcertTime = "01 Mart Cuma, 23.00",
                    ConcertLocation = "Ooze Venue",
                    ConcertPrice = 200.0,
                    ConcertImage = "hakan-altun-konseri.jpg"
                }
            };            
            return View(concertList);
        }
    }
}
