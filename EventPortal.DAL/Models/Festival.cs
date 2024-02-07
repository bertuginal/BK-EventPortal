using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class Festival : BaseModel
    {
        public string FestivalName { get; set; }
        public string FestivalDescription { get; set; }
        public string FestivalType { get; set; }
        public string FestivalTime { get; set; }
        public string FestivalLocation { get; set; }
        public double FestivalPrice { get; set; }
        public string FestivalImage { get; set; }
        
        
    }
}
