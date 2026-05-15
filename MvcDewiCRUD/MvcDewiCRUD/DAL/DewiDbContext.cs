using Microsoft.EntityFrameworkCore;
using MvcDewiCRUD.Models;

namespace MvcDewiCRUD.DAL
{
    public class DewiDbContext : DbContext
    {
        public DewiDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Dewi> dewis { get; set; }
    }
}
