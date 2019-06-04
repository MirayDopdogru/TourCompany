using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompany.Model
{
    public class Dil
    {
        public Dil()
        {
            Rehberler = new HashSet<Rehber>();
        }
        public int DilID { get; set; }
        public string DilTanim { get; set; }

        public virtual ICollection<Rehber> Rehberler { get; set; }
    }
}
