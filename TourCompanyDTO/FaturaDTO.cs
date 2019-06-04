using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourCompanyDTO
{
    public class FaturaDTO  //Turist'e gösterileceğinden dgv'de kolaylık olsun diye İngilizce yapmayı tercih ettim.
    {
        public string Destination { get; set; }
        public string TourGuide { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime DateOfBill { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Dollar { get; set; }
        public decimal Euro { get; set; }
    }
}
