using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tema_DB.Models;

namespace Tema_DB.Data
{
    public class Tema_DBContext : DbContext
    {
        public DbSet<Tema_DB.Models.Book> Book { get; set; }
        public Tema_DBContext (DbContextOptions<Tema_DBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Book>().HasData(new Models.Book() { ID=Guid.NewGuid(), Author="Edward Snowden", Name="Permanent Record", FirstEdition=2019})
        }
    }
}
