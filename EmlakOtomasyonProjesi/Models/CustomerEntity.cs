using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonProjesi.Models
{
    public class CustomerEntity:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public string MobilNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public List<HousingEntity>? Housings { get; set; }






    }

    public class CustomerEntityConfiguration : BaseConfiguration<CustomerEntity>
    {
        public override void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TelNumber).IsRequired(false).HasMaxLength(20);
            builder.Property(x => x.MobilNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Email).IsRequired(false);
            base.Configure(builder);
        }
    }
}
