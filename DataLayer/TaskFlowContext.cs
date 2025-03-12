using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class TaskFlowContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:TaskFlowConnection"]);
        }

        public DbSet<EntityLayer.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
