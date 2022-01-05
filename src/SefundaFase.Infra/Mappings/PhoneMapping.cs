using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    class PhoneMapping : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(p => p.Id); 

            builder.Property(p => p.Ddd)
                .IsRequired()
                .HasColumnType("varchar(2)");

            builder.Property(p => p.Number)
                .IsRequired()
                .HasColumnType("varchar(9)");
                        

            builder.ToTable("Tb_Telefones");
        }
    }
}
