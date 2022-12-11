using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonProjesi.Models
{
    public class CompanyEntity : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Competent { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string TelNumber { get; set; }
        public string MobilNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }

    }

    public class CompanyEntityConfiguration : BaseConfiguration<CompanyEntity>
    {
        public override void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.Competent).IsRequired().HasMaxLength(75);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.TelNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.MobilNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.FaxNumber).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired();
            base.Configure(builder);
        }
    }
}
