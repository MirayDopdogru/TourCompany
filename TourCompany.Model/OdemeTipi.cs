using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class OdemeTipi
    {
        public OdemeTipi()
        {
            Faturalar = new HashSet<Fatura>();
        }
        public int TipID { get; set; }
        public string Tip { get; set; }

        public virtual ICollection<Fatura> Faturalar { get; set; }

    }
}
