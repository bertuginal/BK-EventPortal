using Microsoft.AspNetCore.Mvc;
using EventPortal.DAL.Models;

namespace EventPortal.UI.Controllers
{
    public class TheatreController : Controller
    {
        public IActionResult Index()
        {
            var theatreList = new List<Theatre>()
            {
                new Theatre
                {
                    TheatreName = "CİMRİ",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "14 Şubat Çarşamba",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatreImage = "0000190_cimri.jpg"
                },
                new Theatre
                {
                    TheatreName = "AYDINLIKEVLER",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "15 Şubat Perşembe",
                    TheatreLocation = "Bostancı Gösteri Merkezi",
                    TheatreImage = "aydinlikevler-yatay.jpg"
                },
                new Theatre
                {
                    TheatreName = "ZENGİN MUTFAĞI",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "16 Şubat Cuma",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatreImage = "zengin-mutfagi-04.jpg"
                },
                new Theatre
                {
                    TheatreName = "MONTAİGNE",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "17 Şubat Cumartesi",
                    TheatreLocation = "Oda Tiyatrosu",
                    TheatreImage = "396024018_18391995217028468_7905172375322033882_n-2-1024x574.jpg"
                },
                new Theatre
                {
                    TheatreName = "İBRAHİM SELİM İLE BU GECE",
                    TheatreDescription = "Talk Show",
                    TheatreTime = "18 Şubat Pazar",
                    TheatreLocation = "Zorlu PSM",
                    TheatreImage = "indir (6).jpg"
                },
                new Theatre
                {
                    TheatreName = "SAATLERİ AYARLAMA ENSTİTÜSÜ",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "19 Şubat Pazartesi",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatreImage = "9a1f44e4140943a69876550fa02a5c39.jpg"
                },
                new Theatre
                {
                    TheatreName = "HÜCRELER",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "21 Şubat Çarşamba",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatreImage = "hucreler.jpg"
                },
                new Theatre
                {
                    TheatreName = "TİMSAH ATEŞİ",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "22 Şubat Perşembe",
                    TheatreLocation = "Zorlu PSM",
                    TheatreImage = "indir (7).jpg"
                },
                new Theatre
                {
                    TheatreName = "KÜHEYLAN",
                    TheatreDescription = "Tiyatro",
                    TheatreTime = "24 Şubat Cumartesi",
                    TheatreLocation = "Maximum UNIQ Hall",
                    TheatreImage = "indir (8).jpg"
                },

            };
            return View(theatreList);
        }
    }
}
