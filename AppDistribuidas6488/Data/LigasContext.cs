using AppDistribuidas6488.Models;
using Microsoft.EntityFrameworkCore;

namespace AppDistribuidas6488.Data
{
    public class LigasContext : DbContext
    {
        public LigasContext(DbContextOptions<LigasContext> options) : base(options)
        {

        }

        public DbSet<Ligas> Ligas { get; set; }

    }
}
