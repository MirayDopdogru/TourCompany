using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class RehberRepository
    {
        TourCompanyDbContext context;
        public RehberRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(Rehber yeniRehber)
        {
            context.Rehberler.Add(yeniRehber);
            return context.SaveChanges();
        }

        public int Update(Rehber guncelRehber)
        {
            context.Entry(guncelRehber).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(Rehber silinecekRehber)
        {
            context.Rehberler.Remove(silinecekRehber);
            return context.SaveChanges();
        }

        public Rehber GetByID(int rehberID)
        {
            return context.Rehberler.SingleOrDefault(a => a.RehberID == rehberID);
        }

        public List<Rehber> GetAll()
        {
            return context.Rehberler.ToList();
        }
    }
}
