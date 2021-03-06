using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class projectContext : DbContext
    {
        public projectContext (DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public DbSet<project.Models.Abonament> Abonament { get; set; }

        public DbSet<project.Models.Antrenor> Antrenor { get; set; }

        public DbSet<project.Models.Curs> Curs { get; set; }
    }
}
