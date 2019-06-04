using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class DilRepository
    {
        TourCompanyDbContext context;
        public DilRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(Dil yeniDil)
        {
            context.Diller.Add(yeniDil);
            return context.SaveChanges();
        }

        public int Update(Dil guncelDil)
        {
            context.Entry(guncelDil).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(Dil silinecekDil)
        {
            context.Diller.Remove(silinecekDil);
            return context.SaveChanges();
        }

        public Dil GetByID(int DilID)
        {
            return context.Diller.SingleOrDefault(a => a.DilID == DilID);
        }

        public List<Dil> GetAll()
        {
            return context.Diller.ToList();
        }
    }
}
