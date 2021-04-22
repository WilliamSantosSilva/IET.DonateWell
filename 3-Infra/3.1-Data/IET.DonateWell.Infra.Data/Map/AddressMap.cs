using IET.DonateWell.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IET.DonateWell.Infra.Data.Map
{
    public class AddressMap : IEntityTypeConfiguration<Domain.Entities.Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Number)
                .IsRequired();

            builder
                .Property(x => x.PublicPlace)
                .HasMaxLength(2000);

            builder.Property(x => x.ZipCode)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.City)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.Country)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.Lat)
                .IsRequired();

            builder.Property(x => x.Long)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
