using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;

namespace TourCompany.BLL
{
    public class RehberBLL
    {
        RehberRepository _rehberRepository;
        public RehberBLL()
        {
            _rehberRepository = new RehberRepository();
        }

        public bool Add(Rehber yeniRehber)
        {
            return _rehberRepository.Add(yeniRehber) > 0;
        }

        public bool Update(Rehber guncelRehber)
        {
            return _rehberRepository.Update(guncelRehber) > 0;
        }

        public bool Remove(Rehber silinecekRehber)
        {
            return _rehberRepository.Remove(silinecekRehber) > 0;
        }

        public Rehber GetByID(int RehberID)
        {
            return _rehberRepository.GetByID(RehberID);
        }

        public List<Rehber> GetAll()
        {
            return _rehberRepository.GetAll();
        }

    }
}
