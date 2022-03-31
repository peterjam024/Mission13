using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Mission13.Models
{
    public class BowlerContext : DbContext
    {
        public BowlerContext()
        {
        }

        public BowlerContext(DbContextOptions<BowlerContext> options)
            : base(options)
        {
        }

        public DbSet<Bowler> Bowler { get; set; }


    }
}
