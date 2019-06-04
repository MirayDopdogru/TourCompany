using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class FaturaRepository
    {
        TourCompanyDbContext context;
        public FaturaRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(Fatura yeniFatura)
        {
            context.Faturalar.Add(yeniFatura);
            return context.SaveChanges();
        }

        public int Update(Fatura guncelFatura)
        {
            context.Entry(guncelFatura).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(Fatura silinecekFatura)
        {
            context.Faturalar.Remove(silinecekFatura);
            return context.SaveChanges();
        }

        public Fatura GetByID(int faturaID)
        {
            return context.Faturalar.SingleOrDefault(a => a.FaturaID == faturaID);
        }

        public List<Fatura> GetAll()
        {
            return context.Faturalar.ToList();
        }

    }
}
