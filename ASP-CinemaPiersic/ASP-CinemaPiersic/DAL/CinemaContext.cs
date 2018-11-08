using CinemaPiersic.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CinemaPiersic.DAL
{
    public class CinemaContext : DbContext
    {
        public CinemaContext()
        : base("CinemaContext") //string de conexiune
        { }
        public DbSet<Tichete> Tichete { get; set; }
        public DbSet<PromotiiTichete> PromotiiTichete { get; set; }
        public DbSet<Filme> Filme { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
