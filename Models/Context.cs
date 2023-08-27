using Microsoft.EntityFrameworkCore;

namespace LocacaoCarros.Models
{
    // aqui fica a conexão com o banco de dados
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) 
        { 
        }

        public DbSet<Carros> Carros { get; set; }
    }

}
