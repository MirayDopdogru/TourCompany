using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class OdemeTipiRepository
    {
        TourCompanyDbContext context;
        public OdemeTipiRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(OdemeTipi odemetipi)
        {
            context.OdemeTipleri.Add(odemetipi);
            return context.SaveChanges();
        }

        public int Update(OdemeTipi guncelOdemeTipi)
        {
            context.Entry(guncelOdemeTipi).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(OdemeTipi silinecekOdemeTipi)
        {
            context.OdemeTipleri.Remove(silinecekOdemeTipi);
            return context.SaveChanges();
        }

        public OdemeTipi GetByID(int tipID)
        {
            return context.OdemeTipleri.SingleOrDefault(a => a.TipID == tipID);
        }

        public List<OdemeTipi> GetAll()
        {
            return context.OdemeTipleri.ToList();
        }
    }
}
