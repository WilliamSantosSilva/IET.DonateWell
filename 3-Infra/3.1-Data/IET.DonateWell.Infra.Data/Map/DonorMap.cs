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
    public class DonorMap : IEntityTypeConfiguration<Domain.Entities.Donor>
    {
        public void Configure(EntityTypeBuilder<Donor> builder)
        {
            builder
                 .HasKey(x => x.Id);

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Anonymous)
                .IsRequired();

            builder.Property(x => x.DtBirthday)
                .IsRequired();

            builder.Property(x => x.FirstName)
                .IsRequired();

            builder.Property(x => x.FullName)
                .IsRequired();

            builder.Property(x => x.RegisterNumber)
                .IsRequired();

            builder.Property(x => x.TypeRegister)
                .IsRequired();

        }
    }
}
