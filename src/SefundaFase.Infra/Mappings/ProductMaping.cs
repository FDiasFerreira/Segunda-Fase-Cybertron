using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    public class ProductMaping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                 .IsRequired()
                 .HasColumnType("varchar(200)");

            builder.Property(p => p.BarCode)
                 .IsRequired()
                 .HasColumnType("varchar(13)");

            builder.Property(p => p.QuantityStock)
                 .IsRequired()
                 .HasColumnType("varchar(200)");

            builder.Property(p => p.PricePurchase)
                .IsRequired()
                .HasColumnType("decimal(5, 2");

            builder.Property(p => p.PriceSales)
            .IsRequired()
            .HasColumnType("decimal(5, 2");

       
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            builder.HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId);

            builder.ToTable("Tb_Produtos");
        }
    }
}
