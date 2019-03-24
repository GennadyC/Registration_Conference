using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace TomskNipi.Models
{
    public class SectionsContext : DbContext
    {
        public DbSet<Sections> Sectionss { get; set; }

        public SectionsContext(DbContextOptions<SectionsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
