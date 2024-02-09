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
                    FestivalName = "MUSICFEST:SAKARYA",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "06 Mart Çarşamba, 16.00",
                    FestivalLocation = "Serdivan Kapalı Spor Salonu",
                    FestivalPrice = 300.00,
                    FestivalImage = "musicfest-sakarya.jpg"
                },
                 new Festival
                {
                    FestivalName = "MUSICFEST:NİĞDE",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "02 Mart Cumartesi, 17.00",
                    FestivalLocation = "Niğde Merkez Spor Salonu",
                    FestivalPrice = 300.00,
                    FestivalImage = "musicfest-nigde.jpg"
                },
                  new Festival
                {
                    FestivalName = "WHAT A FEST",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "22 Ağustos - 25 Ağustos",
                    FestivalLocation = "Foça Acar Camping, Foça/İzmir",
                    FestivalPrice = 500.00,
                    FestivalImage = "what-a-fest.png"
                },
                new Festival
                {
                    FestivalName = "SAKARYA MÜZİK FESTİVALİ",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "16 Mayıs - 18 Mayıs",
                    FestivalLocation = "Del Lago Hotel, Sakarya",
                    FestivalPrice = 450.00,
                    FestivalImage = "sakarya-muzik-festivali.jpg"
                },
                new Festival
                {
                    FestivalName = "HOLİFEST İSTANBUL",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "25 Mayıs - 26 Mayıs",
                    FestivalLocation = "Life Park, İstanbul",
                    FestivalPrice = 250.00,
                    FestivalImage = "holi-fest.png"
                },
                new Festival
                {
                    FestivalName = "İZMİR TATTOO FEST",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "08 Mart Cuma, 11.00",
                    FestivalLocation = "Fuar İzmir - Gaziemir",
                    FestivalPrice = 350.00,
                    FestivalImage = "izmir-tattoo-fest.jpg"
                },                         
                new Festival
                {
                    FestivalName = "GRAND VALENTINE'S DAY FEST",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "14 Şubat Çarşamba, 19.00",
                    FestivalLocation = "Club Mirador",
                    FestivalPrice = 200.00,
                    FestivalImage = "grand-valentines-day-fest.jpg"
                }

            };
            return View(festivalList);

        }
    }
}
