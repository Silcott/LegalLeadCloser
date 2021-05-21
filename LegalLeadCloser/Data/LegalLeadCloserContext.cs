using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LegalLeadCloser.Models;

namespace LegalLeadCloser.Data
{
    public class LegalLeadCloserContext : DbContext
    {
        public LegalLeadCloserContext (DbContextOptions<LegalLeadCloserContext> options)
            : base(options)
        {
        }

        public DbSet<LegalLeadCloser.Models.Clients> Clients { get; set; }

        public DbSet<LegalLeadCloser.Models.Users> Users { get; set; }
    }
}
