using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EventPortal.DAL.Models;

namespace EventPortal.BLL.Services.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T? GetByID(int id);
        List<T> GetList();
    }
}
