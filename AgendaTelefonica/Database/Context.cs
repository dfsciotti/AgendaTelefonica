using AgendaTelefonica.Entities;
using MySql.Data.Entity;
using System.Data.Entity;

namespace AgendaTelefonica.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context() : base("connectionString")
        {
        }

        public DbSet<ContatoEntity> Contato { get; set; }
        public DbSet<TelefoneEntity> Telefone { get; set; }
    }
}
