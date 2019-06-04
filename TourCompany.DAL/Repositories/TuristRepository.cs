using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class TuristRepository
    {
        TourCompanyDbContext context;
        public TuristRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(Turist yeniTurist)
        {
            context.Turistler.Add(yeniTurist);
            return context.SaveChanges();
        }

        public int Update(Turist guncelTurist)
        {
            context.Entry(guncelTurist).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(Turist silinecekTurist)
        {
            context.Turistler.Remove(silinecekTurist);
            return context.SaveChanges();
        }

        public Turist GetByID(int turistID)
        {
            return context.Turistler.SingleOrDefault(a => a.TuristID == turistID);
        }

        public List<Turist> GetAll()
        {
            return context.Turistler.ToList();
        }
    }
}
