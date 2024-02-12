using EventPortal.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.EventRepository
{
    public class ExhibitionRepository
    {
        private static readonly List<Exhibition> _exhibitions = null;

        static ExhibitionRepository()
        {
            _exhibitions = new List<Exhibition>
            {
                new Exhibition
                {
                    Id = 1,
                    ExhibitionName = "DOĞU DEMİRKOL",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Stand Up",
                    ExhibitionTime = "09 Şubat Cuma, 20.30",
                    ExhibitionLocation = "Bostanlı Suat Taşer Tiyatrosu",
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
                },
                new Exhibition
                {
                    Id = 4,
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
                    Id = 5,
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
                    Id = 6,
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
                    Id = 7,
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
                    Id = 8,
                    ExhibitionName = "SERMET ERKİN - İLLÜZYON GÖSTERİSİ",
                    ExhibitionType = "Gösteri",
                    ExhibitionDescription = "Çocuklar için interaktif illüzyon gösterisi",
                    ExhibitionTime = "17 Şubat Cumartesi, 13.00",
                    ExhibitionLocation = "House Of Performance - HoP",
                    ExhibitionPrice = 130.00,
                    ExhibitionImage = "sermet-erkin-interaktif-illuzyon-gosterisi.jpg"
                }
            };
        }
        public static List<Exhibition> SearchExhibitons(string search)
        {
            search = search.ToLower();

            return _exhibitions.Where(exhibition => exhibition.ExhibitionName.ToLower().Contains(search)).ToList();
        }

        public static List<Exhibition> Exhibitions
        {
            get
            {
                return _exhibitions;
            }
        }

        public static Exhibition GetById(int id)
        {
            return _exhibitions.FirstOrDefault(e => e.Id == id);
        }

    }
}
