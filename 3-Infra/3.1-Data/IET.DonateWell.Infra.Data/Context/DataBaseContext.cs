using Microsoft.EntityFrameworkCore;

namespace IET.DonateWell.Infra.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected string _conn { get; private set; }
        public DataBaseContext(string conn) : base()
        {
            _conn = conn;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(_conn))
                optionsBuilder.UseMySql(_conn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Mapear Entidades

            modelBuilder.ApplyConfiguration(new Map.AddressMap());
            modelBuilder.ApplyConfiguration(new Map.DonatioMap());
            modelBuilder.ApplyConfiguration(new Map.DonorMap());
            modelBuilder.ApplyConfiguration(new Map.DonorAddressMap());
            modelBuilder.ApplyConfiguration(new Map.GaleryPhotoMap());

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        //Maper Entity DbSet
        public DbSet<Domain.Entities.Address> Address { get; set; }
        public DbSet<Domain.Entities.Donation> Donation { get; set; }
        public DbSet<Domain.Entities.Donor> Donor { get; set; }
        public DbSet<Domain.Entities.DonorAddress> DonorAddress { get; set; }
        public DbSet<Domain.Entities.GaleryPhoto> GaleryPhoto { get; set; }
        public DbSet<Domain.Entities.Product> Product { get; set; }
        public DbSet<Domain.Entities.ProductGaleryPhoto> ProductGaleryPhoto { get; set; }
        public DbSet<Domain.Entities.Receiver> Receiver { get; set; }
        public DbSet<Domain.Entities.ReceiverAddress> ReceiverAddress { get; set; }
    }
}
