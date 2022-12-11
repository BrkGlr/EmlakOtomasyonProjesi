using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyonProjesi.Models
{
    public class HousingEntity:BaseEntity
    {
        [Display(Name ="Durum")]
        public string RealEstate { get; set; }
        public string RealEstateType { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public decimal LandSpace { get; set; }
        public int Room { get; set; }
        public int Saloon { get; set; }
        public int BuldingAge { get; set; }
        public int Floor { get; set; }
        public int BuildinFloor { get; set; }
        public string Heating { get; set; }
        public int Balcony { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }


        public CustomerEntity Customer { get; set; }









    }

    public class HousingEntityConfiguration : BaseConfiguration<HousingEntity>
    {
        public override void Configure(EntityTypeBuilder<HousingEntity> builder)
        {
           
            builder.Property(x => x.RealEstate).IsRequired();
            builder.Property(x => x.RealEstateType).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.LandSpace).IsRequired();
            builder.Property(x => x.Room).IsRequired();
            builder.Property(x => x.Saloon).IsRequired();
            builder.Property(x => x.BuldingAge).IsRequired();
            builder.Property(x => x.Floor).IsRequired();
            builder.Property(x => x.BuildinFloor).IsRequired();
            builder.Property(x => x.Heating).IsRequired();
            builder.Property(x => x.Balcony).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            base.Configure(builder);
        }
    }
}
