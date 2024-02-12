using EventPortal.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.EventRepository
{
    public class FestivalRepository
    {
        private static readonly List<Festival> _festivals = null;

        static FestivalRepository()
        {
            _festivals = new List<Festival>
            {
                new Festival
                {
                    Id = 1,
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
                    Id = 2,
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
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
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
                    Id = 6,
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
                    Id = 7,
                    FestivalName = "GRAND VALENTINE'S DAY FEST",
                    FestivalType = "Festival",
                    FestivalDescription = "Festival",
                    FestivalTime = "14 Şubat Çarşamba, 19.00",
                    FestivalLocation = "Club Mirador",
                    FestivalPrice = 200.00,
                    FestivalImage = "grand-valentines-day-fest.jpg"
                }
            };
        }

        public static List<Festival> SearchFestivals(string search)
        {
            search = search.ToLower();

            return _festivals.Where(festival => festival.FestivalName.ToLower().Contains(search)).ToList();
        }

        public static List<Festival> Festivals
        {
            get
            {
                return _festivals;
            }
        }

        public static Festival GetById(int id)
        {
            return _festivals.FirstOrDefault(f => f.Id == id);
        }
    }
}
