using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class TuristMapping :EntityTypeConfiguration<Turist>
    {
        public TuristMapping()
        {
            HasKey(a => new { a.TuristID });
            Property(a => a.Ad).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
            Property(a => a.Soyad).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
        }
    }
}
