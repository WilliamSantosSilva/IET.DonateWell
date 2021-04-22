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
    public class DonorAddressMap : IEntityTypeConfiguration<Domain.Entities.DonorAddress>
    {
        public void Configure(EntityTypeBuilder<DonorAddress> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.AliasTypication)
                .IsRequired()
                .HasMaxLength(100);

            #region Relationship

            builder.HasOne(x => x.Address)
                .WithMany()
                .HasForeignKey(x => x.AddressId);

            builder.HasOne(x => x.Donor)
                .WithMany()
                .HasForeignKey(x => x.DonorId);

            #endregion
        }
    }
}
