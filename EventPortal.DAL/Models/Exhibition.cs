using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class Exhibition : BaseModel
    {
        public string ExhibitionName { get; set; }
        public string ExhibitionDescription { get; set; }
        public string ExhibitionType { get; set; }
        public string ExhibitionTime { get; set; }
        public string ExhibitionLocation { get; set; }
        public double ExhibitionPrice { get; set; }
        public string ExhibitionImage { get; set; }
                
    }
}