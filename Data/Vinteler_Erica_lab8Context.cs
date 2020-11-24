using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vinteler_Erica_lab8.Models;

namespace Vinteler_Erica_lab8.Data
{
    public class Vinteler_Erica_lab8Context : DbContext
    {
        public Vinteler_Erica_lab8Context (DbContextOptions<Vinteler_Erica_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Vinteler_Erica_lab8.Models.Book> Book { get; set; }

        public DbSet<Vinteler_Erica_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Vinteler_Erica_lab8.Models.Category> Category { get; set; }
    }
}
