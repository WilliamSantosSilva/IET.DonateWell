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
    public class GaleryPhotoMap : IEntityTypeConfiguration<Domain.Entities.GaleryPhoto>
    {
        public void Configure(EntityTypeBuilder<GaleryPhoto> builder)
        {
            builder
                 .HasKey(x => x.Id);

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Archive)
                .IsRequired();

            builder.Property(x => x.Format)
                .IsRequired();

            builder.Property(x => x.Size)
                .IsRequired();
        }
    }
}
