using EventPortal.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.EventRepository
{
    public class ConcertRepository
    {
        private static readonly List<Concert> _concerts = null;

        static ConcertRepository()
        {
            _concerts = new List<Concert>()
            {
                new Concert
                {
                    Id = 1,
                    ConcertName = "HADİSE",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "19 Haziran Çarşamba, 21.30",
                    ConcertLocation = "Jolly Joker, Beyoğlu/İstanbul",
                    ConcertPrice = 500.00,
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
                    ConcertPrice = 350.10,
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
                    ConcertPrice = 300.00,
                    ConcertImage = "aysegul-aldinc-konseri.jpg"
                },
                new Concert
                {
                    Id = 4,
                    ConcertName = "CEM ADRIAN",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "10 Şubat Cumartesi, 23.00",
                    ConcertLocation = "Ooze Venue",
                    ConcertPrice = 500.00,
                    ConcertImage = "cem-adrian-konseri.jpg"
                },
                new Concert
                {
                    Id = 5,
                    ConcertName = "ADAMLAR",
                    ConcertType = "Konser",
                    ConcertDescription = "Rock Müzik",
                    ConcertTime = "23 Şubat Cuma, 22.00",
                    ConcertLocation = "Sponge Pub Konyaaltı",
                    ConcertPrice = 650.00,
                    ConcertImage = "adamlar-konseri.jpg"
                },
                new Concert
                {
                    Id = 6,
                    ConcertName = "HAYKO CEPKİN",
                    ConcertType = "Konser",
                    ConcertDescription = "Rock Müzik",
                    ConcertTime = "16 Mart Cumartesi, 22.00",
                    ConcertLocation = "Hangout PSM",
                    ConcertPrice = 500.00,
                    ConcertImage = "hayko-cepkin-konseri.jpg"
                },
                new Concert
                {
                    Id = 7,
                    ConcertName = "MANUŞ BABA",
                    ConcertType = "Konser",
                    ConcertDescription = "Alternatif Rock",
                    ConcertTime = "08 Mart Cuma, 21.30",
                    ConcertLocation = "Dorock XL Kadıköy",
                    ConcertPrice = 150.00,
                    ConcertImage = "manus-baba-konseri.jpg"
                },
                new Concert
                {
                    Id = 8,
                    ConcertName = "LEVENT YÜKSEL",
                    ConcertType = "Konser",
                    ConcertDescription = "Pop Müzik",
                    ConcertTime = "24 Mart Pazar, 20.30",
                    ConcertLocation = "EKM Erciyes Kültür Merkezi",
                    ConcertPrice = 200.0,
                    ConcertImage = "levent-yuksel-konseri.jpg"
                },
                new Concert
                {
                    Id = 9,
                    ConcertName = "HAKAN ALTUN",
                    ConcertType = "Konser",
                    ConcertDescription = "Arabesk Müzik",
                    ConcertTime = "01 Mart Cuma, 23.00",
                    ConcertLocation = "Ooze Venue",
                    ConcertPrice = 200.0,
                    ConcertImage = "hakan-altun-konseri.jpg"
                }
            };
        }
        public static List<Concert> SearchConcerts(string search)
        {
            search = search.ToLower();

            return _concerts.Where(concert => concert.ConcertName.ToLower().Contains(search)).ToList();
        }

        public static List<Concert> Concerts
        {
            get
            {
                return _concerts;
            }
        }

        public static Concert GetById(int id)
        {
            return _concerts.FirstOrDefault(c => c.Id == id);
        }
    }
}
