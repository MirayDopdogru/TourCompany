using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class Turist
    {
        public Turist()
        {
            Faturalar = new HashSet<Fatura>();
        }
        public int TuristID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Ulke { get; set; }
        public string Uyruk { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public DateTime GelisTarihi { get; set; }

        public virtual ICollection<Fatura> Faturalar { get; set; }
    }
}
