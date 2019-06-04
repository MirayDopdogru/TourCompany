using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class FaturaMapping : EntityTypeConfiguration<Fatura>
    {
        public FaturaMapping()
        {
            HasKey(a => new { a.FaturaID });
            Property(a => a.ToplamUcret)
                .HasPrecision(6, 2);
            Property(a => a.Dolar)
                .HasPrecision(6, 2);
            Property(a => a.Euro)
                .HasPrecision(6, 2);
        }
    }
}
