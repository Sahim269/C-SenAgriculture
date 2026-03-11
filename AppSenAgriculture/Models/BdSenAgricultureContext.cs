using System.Data.Entity;
using AppSenAgriculture.Config;



namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(NpgsqlConfiguration))]
    public class BdSenAgricultureContext : DbContext
    {
        public BdSenAgricultureContext() : base("connSenAgriculture")
        {
            Database.SetInitializer<BdSenAgricultureContext>(
            new CreateDatabaseIfNotExists<BdSenAgricultureContext>()
            );
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<UniteMesure> UniteMesures { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Agriculteur> Agriculteurs { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Champ> Champs { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Client> Clients { get; set; }
     protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

             // Applique le schéma "public" uniquement pour PostgreSQL
            // MySQL n'utilise pas de schéma
            if (Database.Connection.GetType().Name.Contains("Npgsql"))
            {
                modelBuilder.HasDefaultSchema("public");
            }
            base.OnModelCreating(modelBuilder);
                    
        }
    
    }
}