using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.DAL.Repositories;
using TourCompany.Model;
using TourCompanyDTO;

namespace TourCompany.BLL
{
    public class FaturaBLL
    {
        FaturaRepository _faturaRepository;

        public FaturaBLL()
        {
            _faturaRepository = new FaturaRepository();
        }

        public bool Add(Fatura yeniFatura)
        {
            return _faturaRepository.Add(yeniFatura) > 0;
        }

        public bool Update(Fatura guncelFatura)
        {
            return _faturaRepository.Update(guncelFatura) > 0;
        }

        public bool Remove(Fatura silinecekFatura)
        {
            return _faturaRepository.Remove(silinecekFatura) > 0;
        }

        public Fatura GetByID(int FaturaID)
        {
            return _faturaRepository.GetByID(FaturaID);
        }

        public List<Fatura> GetAll()
        {
            return _faturaRepository.GetAll();
        }
    }
}
