using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class Theatre : BaseModel
    {
        public string TheatreName { get; set; }
        public string TheatreDescription { get; set; }
        public string TheatreType { get; set; }
        public string TheatreTime { get; set; }
        public string TheatreLocation { get; set; }
        public string TheatreImage { get; set; }
                
    }
}
