using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventPortal.BLL.Services.Interfaces;
using EventPortal.DAL.Models;

namespace EventPortal.BLL.Services.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        public void Delete(T t)
        {
            using var context = new EventPortalContext();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public T? GetByID(int id)
        {
            using var context = new EventPortalContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new EventPortalContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new EventPortalContext();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new EventPortalContext();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
    }
}
