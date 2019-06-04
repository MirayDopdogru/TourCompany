using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class Fatura
    {
        public Fatura()
        {
            Turistler = new HashSet<Turist>();
        }
        public int FaturaID { get; set; }
        public int YerID { get; set; }
        public int RehberID { get; set; }
        public int TipID { get; set; }
        public int KisiSayisi { get; set; }
        public decimal ToplamUcret { get; set; }
        public decimal Dolar { get; set; }
        public decimal Euro { get; set; }
        public DateTime KayıtTarihi { get; set; }

        public virtual GezilecekYer GezilecekYer { get; set; }
        public virtual Rehber Rehber { get; set; }
        public virtual ICollection<Turist> Turistler { get; set; }
        public OdemeTipi OdemeTipi { get; set; }
    }
}
