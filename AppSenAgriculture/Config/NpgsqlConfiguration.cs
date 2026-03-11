using System.Data.Entity;

namespace AppSenAgriculture.Config
{
    /// <summary>
    /// Force Entity Framework à utiliser Npgsql (PostgreSQL)
    /// même si MySql.Data est présent dans les références.
    /// </summary>
    public class NpgsqlConfiguration : DbConfiguration
    {
        public NpgsqlConfiguration()
        {
            SetDefaultConnectionFactory(new Npgsql.NpgsqlConnectionFactory());
            SetProviderServices("Npgsql", Npgsql.NpgsqlServices.Instance);
            SetProviderFactory("Npgsql", Npgsql.NpgsqlFactory.Instance);
        }
    }
}