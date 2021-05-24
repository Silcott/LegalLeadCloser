using Microsoft.EntityFrameworkCore;

namespace LegalLeadCloser.Data
{
    public class LegalLeadCloserContext : DbContext
    {
        public LegalLeadCloserContext(DbContextOptions<LegalLeadCloserContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public LegalLeadCloserContext()
            : base()
        {

        }
        public DbSet<LegalLeadCloser.Models.Clients> Clients { get; set; }

        public DbSet<LegalLeadCloser.Models.Users> Users { get; set; }
    }
}