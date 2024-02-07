using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPortal.DAL.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

