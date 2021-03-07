using Microsoft.EntityFrameworkCore;
using ProntMed.UI.AppTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProntMed.UI.AppTest.Data
{
    public class TodoDbContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDbContext).Assembly);
        }
        public  TodoDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
