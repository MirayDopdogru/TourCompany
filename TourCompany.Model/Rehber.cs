using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class Rehber
    {
        public Rehber()
        {
            Diller = new HashSet<Dil>();
            Faturalar = new HashSet<Fatura>();
        }
        public int RehberID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public string IletisimBilgileri { get; set; }

        public virtual ICollection<Dil> Diller { get; set; }
        public virtual ICollection<Fatura> Faturalar { get; set; }
    }
}
