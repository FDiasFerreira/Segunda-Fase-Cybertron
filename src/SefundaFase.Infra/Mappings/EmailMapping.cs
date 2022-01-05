using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.EmailAddress)
                .IsRequired()
                .HasColumnType("varchar(100)");

           
            builder.ToTable("Tb_E-mails");
        }
    }
}
