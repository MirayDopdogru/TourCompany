using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class GezilecekYer
    {
        public GezilecekYer()
        {
            Faturalar = new HashSet<Fatura>();
        }
        public int YerID { get; set; }
        public string YerAdi { get; set; }
        public decimal Ucret { get; set; }
        public decimal Dolar { get; set; }
        public decimal Euro { get; set; }

        public virtual ICollection<Fatura> Faturalar { get; set; }
    }
}
