namespace ProjekatAsgardiansWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AsgardiansModel : DbContext
    {
        public AsgardiansModel()
            : base("name=AsgardiansModel")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Putnik> Putniks { get; set; }
        public virtual DbSet<Uposlenik> Uposleniks { get; set; }
        public virtual DbSet<Vodic> Vodics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lokacija>()
                .HasMany(e => e.Putniks)
                .WithOptional(e => e.Lokacija)
                .HasForeignKey(e => e.Lokacija_LokacijaId);

            modelBuilder.Entity<Vodic>()
                .HasMany(e => e.Lokacijas)
                .WithOptional(e => e.Vodic)
                .HasForeignKey(e => e.Vodic_VodicId);
        }
    }
}
