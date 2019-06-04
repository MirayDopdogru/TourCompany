using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;

namespace TourCompany.BLL
{
    public class TuristBLL
    {
        TuristRepository _turistRepository;
        public TuristBLL()
        {
            _turistRepository = new TuristRepository();
        }

        public bool Add(Turist yeniTurist)
        {
            return _turistRepository.Add(yeniTurist) > 0;
        }

        public bool Update(Turist guncelTurist)
        {
            return _turistRepository.Update(guncelTurist) > 0;
        }

        public bool Remove(Turist silinecekTurist)
        {
            return _turistRepository.Remove(silinecekTurist) > 0;
        }

        public Turist GetByID(int turistID)
        {
            return _turistRepository.GetByID(turistID);
        }

        public List<Turist> GetAll()
        {
            return _turistRepository.GetAll();
        }
    }
}
