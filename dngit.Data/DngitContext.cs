using dngit.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dngit.Data
{
    public class DngitContext : DbContext
    {
        public DngitContext(DbContextOptions<DngitContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Rating> Ratings { get; set; }

    }
}
