using EventPortal.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.EventRepository
{
    public class TheatreRepository
    {
        private static readonly List<Theatre> _theatres = null;

        static TheatreRepository()
        {
            _theatres = new List<Theatre>
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
                    Id = 2,
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
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
                    TheatreName = "VEDA OYUNU",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "10 Şubat Cumartesi, 20.30",
                    TheatreLocation = "Bostanlı Suat Taşer Tiyatrosu",
                    TheatrePrice = 400.00,
                    TheatreImage = "veda-oyunu.jpeg"
                },

                new Theatre
                {
                    Id = 6,
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
                    Id = 7,
                    TheatreName = "HÜCRELER",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "21 Şubat Çarşamba",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatrePrice = 240.00,
                    TheatreImage = "hucreler.jpg"
                },
                new Theatre
                {
                    Id = 8,
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
                    Id = 9,
                    TheatreName = "ÖLÜ'N BİZİ AYIRANA DEK",
                    TheatreType = "Tiyatro",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "17 Şubat Cumartesi, 20.00",
                    TheatreLocation = "Hikmet Şimşek Sanat Merkezi",
                    TheatrePrice = 500.00,
                    TheatreImage = "olun-bizi-ayirana-dek-oyunu.png"
                },

            };        
        }
        public static List<Theatre> SearchTheatres(string search)
        {
            search = search.ToLower();

            return _theatres.Where(theatre => theatre.TheatreName.ToLower().Contains(search)).ToList();
        }

        public static List<Theatre> Theatres
        {
            get
            {
                return _theatres;
            }
        }

        public static Theatre GetById(int id)
        {
            return _theatres.FirstOrDefault(t => t.Id == id);
        }
    }
}
