using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class Home
    {
        public List<Concert> ConcertList { get; set; }
        public List<Festival> FestivalList { get; set; }
        public List<Theatre> TheatreList { get; set; }
        public List<Exhibition> ExhibitionList { get; set; }
        public List<HomeImage> ImageList { get; set; }
    }
}
