using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WinFormsApp11.Models;

namespace WinFormsApp11.Service
{
    internal class Connect : DbContext
    {
        public DbSet<Login> Login { get; set; }
        public DbSet<Place> Place { get; set; }
        public DbSet<Pple> Pple { get; set; }
        public DbSet<ZppleLifePelmeni> ZppleLifePelmeni { get; set; }
        public DbSet<CheckArenda> CheckArenda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\dabe.db"));
            optionsBuilder.UseSqlite($"Data Source = {dbPath}");
        }
    }
}
