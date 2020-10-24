using Microsoft.EntityFrameworkCore;
using MinhasContas.Models;

namespace MinhasContas.Data
{
    public class RegisterContext : DbContext
    {
        public RegisterContext (DbContextOptions<RegisterContext> options): base(options)
        {

        }
        public DbSet<Register> Registers { get; set; }
    }
}
