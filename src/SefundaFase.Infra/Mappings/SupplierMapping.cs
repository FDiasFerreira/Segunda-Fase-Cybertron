using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FantasyName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(s => s.Products)
                .WithOne(p => p.Supplier);

            builder.HasOne(s => s.Address)
            .WithOne(a => a.Supplier);

            builder.HasOne(s => s.Email)
                .WithOne(e => e.Supplier);

            builder.HasMany(s => s.Phones)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId);

            builder.HasMany(s => s.Products)
                .WithOne(p => p.Supplier)
                .HasForeignKey(p => p.SupplierId);

            builder.ToTable("Tb_Fornecedores");


        }

    }
}
