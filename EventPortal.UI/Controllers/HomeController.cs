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
                    ConcertName = "HADİSE",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "19 Haziran Çarşamba, 21.30",
                    ConcertLocation = "Jolly Joker, Beyoğlu/İstanbul",
                    ConcertPrice = 500.0,
                    ConcertImage = "hadise-konseri.jpg"
                },
                 new Concert
                {
                    ConcertName = "ATHENA",
                    ConcertType = "Pop",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "02 Mart Cumartesi, 22.00",
                    ConcertLocation = "Hangout PSM, Bornova/İzmir",
                    ConcertPrice = 350.0,
                    ConcertImage = "athena-konseri.jpg"
                },
                new Concert
                {
                    ConcertName = "AYŞEGÜL ALDİNÇ",
                    ConcertType = "Pop",
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
                    FestivalName = "WHAT A FEST",
                    FestivalType = "Festival",
                    //FestivalDescription = "Festival",
                    FestivalTime = "22 Ağustos - 25 Ağustos",
                    FestivalLocation = "Foça Acar Camping, Foça/İzmir",
                    FestivalImage = "what-a-fest.png"
                },
                new Festival
                {
                    FestivalName = "SAKARYA MÜZİK FESTİVALİ",
                    FestivalType = "Festival",
                    //FestivalDescription = "Festival",
                    FestivalTime = "16 Mayıs - 18 Mayıs",
                    FestivalLocation = "Del Lago Hotel, Sakarya",
                    FestivalImage = "sakarya-muzik-festivali.jpg"
                },
                new Festival
                {
                    FestivalName = "HOLİFEST İSTANBUL",
                    FestivalType = "Festival",
                    //FestivalDescription = "Festival",
                    FestivalTime = "25 Mayıs - 26 Mayıs",
                    FestivalLocation = "Life Park, İstanbul",
                    FestivalImage = "holi-fest.png"
                }
            };
            var theatreList = new List<Theatre>()
            {                
                new Theatre
                {
                    TheatreName = "GÜLÜMSETEN HATIRALAR",
                    TheatreType = "Tiyatro",
                    //TheatreDescription = "Tiyatro",
                    TheatreTime = "09 Şubat Cuma, 20.00",
                    TheatreLocation = "Mall Of Antalya",
                    TheatreImage = "gulumseten-hatiralar.jpg"
                },
                new Theatre
                {
                    TheatreName = "MADONNA KÜRK MANTOLU",
                    TheatreType = "Tiyatro",
                    //TheatreDescription = "Tiyatro",
                    TheatreTime = "14 Şubat Çarşamba, 20.00",
                    TheatreLocation = "Aralık Sahne",
                    TheatreImage = "madonna-kurk-mantolu.jpeg"
                },
                new Theatre
                {
                    TheatreName = "SÜT KARDEŞLER",
                    TheatreType = "Tiyatro",
                    //TheatreDescription = "Tiyatro",
                    TheatreTime = "13 Mart Çarşamba, 20.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatreImage = "sut-kardesler.jpg"
                }
            };
            var exhibitionList = new List<Exhibition>()
            {
                new Exhibition
                {
                    ExhibitionName = "DOĞU DEMİRKOL",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "09 Şubat Cuma, 20.30",
                    ExhibitionLocation = "Bostanlu Suat Taşer Tiyatrosu",
                    ExhibitionImage = "dogu-demirkol.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "OKAN CABALAR",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "17 Şubat Cumartesi, 20.00",
                    ExhibitionLocation = "İzmir Performance Hall",
                    ExhibitionImage = "okan-cabalar.jpg"
                },
                new Exhibition
                {
                    ExhibitionName = "MEKSİKA AÇMAZI",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "16 Şubat Cuma",
                    ExhibitionLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    ExhibitionImage = "meksika-acmazi.png"
                }
            };
            var ımageList = new List<HomeImage>()
            {
                new HomeImage
                {
                    ImageUrl = "perdenin-ardindakiler-konseri-37379.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "gokhan-turkmen-202312281545432a30a0a4c2154d1196355b71880f6039.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "PIylWQIplEaSkhX4yhTxQA.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "unnamed.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "b48f5c93c5d492fdb8c5b4108741450b.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "Sefo.jpg",
                    Link = "#"
                },
                new HomeImage
                {
                    ImageUrl = "ab67616d0000b273f22f0a3ab76b923df54b73b0.jpg",
                    Link = "#"
                }
            };
            var viewModel = new Home
            {
                ConcertList = concertList,
                FestivalList = festivalList,
                TheatreList = theatreList,
                ExhibitionList = exhibitionList,
                ImageList = ımageList
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
