using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SegundaFase.WebApp.Models;

namespace SegundaFase.Data.Mappings
{
    public class ImageMapping
    {
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasKey(i => i.Id);

			builder.Property(i => i.ImagePath)
				.IsRequired()
				.HasColumnType("varchar(200)");


			builder.ToTable("Tb_Images");
		}
	}
}
