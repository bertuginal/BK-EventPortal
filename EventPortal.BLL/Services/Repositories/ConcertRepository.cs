using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPortal.BLL.Services.Interfaces;
using EventPortal.DAL.Models;

namespace EventPortal.BLL.Services.Repositories
{
    public class ConcertRepository : GenericRepository<Concert>, IConcertRepository
    {
    }
}
