using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace AppSenAgriculture.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenAgricultureContext : DbContext
    {
        public BdSenAgricultureContext() : base("connSenAgriculture")
        {
        }

        public DbSet<UniteMesure> UniteMesures { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Agriculteur> Agriculteurs { get; set; }
        public DbSet<Facilitateur> Facilitateurs { get; set; }
    }
}
