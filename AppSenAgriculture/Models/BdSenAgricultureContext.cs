using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdSenAgricultureContext : DbContext
    {
        public BdSenAgricultureContext() : base("name=bdSenAgriculture")
        {
        }
        public DbSet<Categorie> Categories { get; set; }

        public DbSet<UniteMesure> UniteMesures { get; set; }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Agriculteur> Agriculteurs { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Commune> Communes { get; set; }

        public DbSet<Champ> Champs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
