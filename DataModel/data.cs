using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class DBContextMain : DbContext
    {

        public DbSet<Team> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //using sql server
            //  optionsBuilder.UseSqlServer("Server=localhost;Database=EntityConsole;Integrated Security=SSPI;Trusted_Connection=true;TrustServerCertificate=True;");
            optionsBuilder.UseSqlite($"Data source={Environment.GetEnvironmentVariable("EntityDataBase",EnvironmentVariableTarget.User)}");
           //optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    ID = 1,
                    Name = "legia",
                    MyProperty = 121
                }

                );
        }
    }
    public class Team : DataAbstract
    {
        public int MyProperty { get; set; }
        public string Name { get; set; }
    }

    [PrimaryKey("ID")]
    public class DataAbstract
    {

        public int ID { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
