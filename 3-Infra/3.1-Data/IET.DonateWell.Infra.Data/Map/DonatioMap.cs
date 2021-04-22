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
    public class DonatioMap : IEntityTypeConfiguration<Domain.Entities.Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder.Property(x => x.DataCadastro)
                .IsRequired();

            builder.Property(x => x.UsuarioCriacao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.DtWithdrawal)
                .IsRequired();

            builder.Property(x => x.IsEmergencial)
                .IsRequired();

            builder.Property(x => x.IsDelivered)
                .IsRequired();

            builder.Property(x => x.OwnVehicleDonor)
                .IsRequired();

            #region RelationShip

            builder.HasOne(x => x.Donor)
                .WithMany()
                .HasForeignKey(x => x.DonorId);

            builder.HasOne(x => x.Receiver)
                .WithMany()
                .HasForeignKey(x => x.ReceiverId);

            #endregion

        }
    }
}
