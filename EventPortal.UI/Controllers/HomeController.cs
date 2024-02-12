using EventPortal.DAL.Models;
using EventPortal.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EventPortal.DAL.Models;
using EventPortal.UI.Models;

namespace EventPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var concertList = new List<Concert>()
            {                
                new Concert
                {
                    Id = 1,
                    ConcertName = "HADİSE",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "19 Haziran Çarşamba, 21.30",
                    ConcertLocation = "Jolly Joker, Beyoğlu/İstanbul",
                    ConcertPrice = 500.0,
                    ConcertImage = "hadise-konseri.jpg"
                },
                 new Concert
                {
                    Id = 2,
                    ConcertName = "ATHENA",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "02 Mart Cumartesi, 22.00",
                    ConcertLocation = "Hangout PSM, Bornova/İzmir",
                    ConcertPrice = 350.0,
                    ConcertImage = "athena-konseri.jpg"
                },
                new Concert
                {
                    Id = 3,
                    ConcertName = "AYŞEGÜL ALDİNÇ",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "09 Şubat Cuma, 21.00",
                    ConcertLocation = "SoldOut Performance Hall",
                    ConcertPrice = 300.0,
                    ConcertImage = "aysegul-aldinc-konseri.jpg"
                }
            };
            var festivalList = new List<Festival>()
            {                
                new Festival
                {
                    Id = 1,
                    FestivalName = "WHAT A FEST",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "22 Ağustos - 25 Ağustos",
                    FestivalLocation = "Foça Acar Camping, Foça/İzmir",
                    FestivalPrice = 200.00,
                    FestivalImage = "what-a-fest.png"
                },
                new Festival
                {
                    Id = 2,
                    FestivalName = "SAKARYA MÜZİK FESTİVALİ",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "16 Mayıs - 18 Mayıs",
                    FestivalLocation = "Del Lago Hotel, Sakarya",
                    FestivalPrice = 200.00,
                    FestivalImage = "sakarya-muzik-festivali.jpg"
                },
                new Festival
                {
                    Id = 3,
                    FestivalName = "HOLİFEST İSTANBUL",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "25 Mayıs - 26 Mayıs",
                    FestivalLocation = "Life Park, İstanbul",
                    FestivalPrice = 200.00,
                    FestivalImage = "holi-fest.png"
                }
            };
            var theatreList = new List<Theatre>()
            {                
                new Theatre
                {
                    Id = 1,
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
                    Id = 2,
                    TheatreName = "SÜT KARDEŞLER",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "13 Mart Çarşamba, 20.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatrePrice = 250.00,
                    TheatreImage = "sut-kardesler.jpg"
                }
            };
            var exhibitionList = new List<Exhibition>()
            {
                new Exhibition
                {
                    Id = 1,
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
                    Id = 2,
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
                    Id = 3,
                    ExhibitionName = "MEKSİKA AÇMAZI",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "16 Şubat Cuma",
                    ExhibitionLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    ExhibitionPrice = 350.00,
                    ExhibitionImage = "meksika-acmazi.png"
                }
            };
            var imageList = new List<HomeImage>()
            {
                new HomeImage
                {
                    ImageUrl = "hadise-konseri.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "athena-konseri.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "aysegul-aldinc-konseri.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "what-a-fest.png",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "saatleri-ayarlama-enstitusu.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "gulumseten-hatiralar.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "sut-kardesler.jpg",
                    Link = "details"
                },
                new HomeImage
                {
                    ImageUrl = "okan-cabalar.jpg",
                    Link = "details"
                }
            };
            var viewModel = new Home
            {
                ConcertList = concertList,
                FestivalList = festivalList,
                TheatreList = theatreList,
                ExhibitionList = exhibitionList,
                ImageList = imageList
            };
            return View(viewModel);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
