using Microsoft.EntityFrameworkCore;

namespace BioLister.Models
{
    public class BioContext : DbContext
    {
        public DbSet<Bio> Bio { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbconn = System.Environment.GetEnvironmentVariable("SPEAKR_DBCONN");
            optionsBuilder.UseSqlServer(dbconn);
        }
    }
}
