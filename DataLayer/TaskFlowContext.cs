using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class TaskFlowContext : DbContext
    {
        protected TaskFlowContext()
        {
        }

        public TaskFlowContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-G13T04V9\\SQLEXPRESS; Database=TaskFlowDB; Trusted_Connection=true;TrustServerCertificate=True;");
        }

        public DbSet<EntityLayer.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
