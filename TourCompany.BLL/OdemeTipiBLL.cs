using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;

namespace TourCompany.BLL
{
    public class OdemeTipiBLL
    {
        OdemeTipiRepository _odemeTipiRepository;
        public OdemeTipiBLL()
        {
            _odemeTipiRepository = new OdemeTipiRepository();
        }

        public bool Add(OdemeTipi yeniOdemeTipi)
        {
            return _odemeTipiRepository.Add(yeniOdemeTipi) > 0;
        }

        public bool Update(OdemeTipi guncelOdemeTipi)
        {
            return _odemeTipiRepository.Update(guncelOdemeTipi) > 0;
        }

        public bool Remove(OdemeTipi silinecekOdemeTipi)
        {
            return _odemeTipiRepository.Remove(silinecekOdemeTipi) > 0;
        }

        public OdemeTipi GetByID(int OdemeTipiID)
        {
            return _odemeTipiRepository.GetByID(OdemeTipiID);
        }

        public List<OdemeTipi> GetAll()
        {
            return _odemeTipiRepository.GetAll();
        }
    }
}
