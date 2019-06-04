using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Repositories
{
    public class GezilecekYerRepository
    {
        TourCompanyDbContext context;
        public GezilecekYerRepository()
        {
            context = new TourCompanyDbContext();
        }

        public int Add(GezilecekYer yer)
        {
            context.GezilecekYerler.Add(yer);
            return context.SaveChanges();
        }

        public int Update(GezilecekYer yer)
        {
            context.Entry(yer).State = System.Data.Entity.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Remove(GezilecekYer yer)
        {
            context.GezilecekYerler.Remove(yer);
            return context.SaveChanges();
        }

        public GezilecekYer GetByID(int yerID)
        {
            return context.GezilecekYerler.SingleOrDefault(a => a.YerID == yerID);
        }
        
        public List<GezilecekYer> GetAll()
        {
            return context.GezilecekYerler.ToList();
        }
    }
}
