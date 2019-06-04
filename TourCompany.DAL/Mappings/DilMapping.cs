using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourCompany.Model;

namespace TourCompany.DAL.Mappings
{
    class DilMapping : EntityTypeConfiguration<Dil>
    {
        public DilMapping()
        {
            HasKey(a => new { a.DilID });
            Property(a => a.DilTanim).IsRequired().HasMaxLength(30).HasColumnType("nvarchar");
        }
    }
}
