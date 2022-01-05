using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    class SupplierJuridicalMapping : IEntityTypeConfiguration<SupplierJuridical>
    {
        public void Configure(EntityTypeBuilder<SupplierJuridical> builder)
        {          

            builder.Property(p => p.CompanyName)
                .IsRequired()
                .HasColumnType("varchar(200)");
            

            builder.Property(p => p.CNPJ)
                .IsRequired()
                .HasColumnType("varchar(14)");                    
                       
        }
    }
}
