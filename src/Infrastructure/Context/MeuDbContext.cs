using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class MeuDbContext: DbContext
    {
        public MeuDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
