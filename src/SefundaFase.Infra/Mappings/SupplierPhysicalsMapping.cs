using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    class SupplierPhysicalsMapping : IEntityTypeConfiguration<SupplierPhysical>
    {
        public void Configure(EntityTypeBuilder<SupplierPhysical> builder)
        {          

            builder.Property(p => p.FullName)
                 .IsRequired()
                 .HasColumnType("varchar(200)");
           
            builder.Property(p => p.CPF)
                .IsRequired()
                .HasColumnType("varchar(14)");
            
        }
    }
}
