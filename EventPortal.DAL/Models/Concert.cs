using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class Concert : BaseModel
    {
        public string ConcertName { get; set; }
        public string ConcertDescription { get; set; }
        public string ConcertType { get; set; }
        public string ConcertTime { get; set; }
        public string ConcertLocation { get; set; }
        public double ConcertPrice { get; set; }
        public string ConcertImage { get; set; }
        
        
    }
}
