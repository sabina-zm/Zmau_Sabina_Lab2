using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zmau_Sabina_Lab2.Models;

namespace Zmau_Sabina_Lab2.Data
{
    public class Zmau_Sabina_Lab2Context : DbContext
    {
        public Zmau_Sabina_Lab2Context (DbContextOptions<Zmau_Sabina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Zmau_Sabina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Zmau_Sabina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Zmau_Sabina_Lab2.Models.Author> Author { get; set; }

        public DbSet<Zmau_Sabina_Lab2.Models.Category> Category { get; set; }
    }
}
