using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;

namespace TourCompany.BLL
{
    public class DilBLL
    {
        DilRepository _dilRepository;
        public DilBLL()
        {
            _dilRepository = new DilRepository();
        }

        public bool Add(Dil yeniDil)
        {
            return _dilRepository.Add(yeniDil) > 0;
        }

        public bool Update(Dil guncelDil)
        {
            return _dilRepository.Update(guncelDil) > 0;
        }

        public bool Remove(Dil silinecekDil)
        {
            return _dilRepository.Remove(silinecekDil) > 0;
        }

        public Dil GetByID(int DilID)
        {
            return _dilRepository.GetByID(DilID);
        }

        public List<Dil> GetAll()
        {
            return _dilRepository.GetAll();
        }
    }
}
