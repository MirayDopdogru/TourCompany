using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;

namespace TourCompany.BLL
{
    public class GezilecekYerBLL
    {
        GezilecekYerRepository _gezilecekYerRepository;
        public GezilecekYerBLL()
        {
            _gezilecekYerRepository = new GezilecekYerRepository();
        }

        public bool Add(GezilecekYer yeniYer)
        {
            return _gezilecekYerRepository.Add(yeniYer) > 0;
        }

        public bool Update(GezilecekYer guncelGezilecekYer)
        {
            return _gezilecekYerRepository.Update(guncelGezilecekYer) > 0;
        }

        public bool Remove(GezilecekYer silinecekGezilecekYer)
        {
            return _gezilecekYerRepository.Remove(silinecekGezilecekYer) > 0;
        }

        public GezilecekYer GetByID(int GezilecekYerID)
        {
            return _gezilecekYerRepository.GetByID(GezilecekYerID);
        }

        public List<GezilecekYer> GetAll()
        {
            return _gezilecekYerRepository.GetAll();
        }
    }
}
