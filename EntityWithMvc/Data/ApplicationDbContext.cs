using EntityWithMvc.Models;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EntityWithMvc.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        string Employee = "Employee", Supervizor = "Supervizor", Adninistator = "Adninistator";
        builder.Entity<IdentityRole>().HasData
               (
            new IdentityRole()
            {

                Id = "73e5a692-d96a-4062-bdd1-cd9a50de75d2",
                Name = Employee,
                NormalizedName = Employee
            },

            new IdentityRole()
            {
                Id = "83908276-c25b-4eed-be8f-c29b939e86b3",
                Name = Supervizor,
                NormalizedName = Supervizor
            },

            new IdentityRole()
            {
                Id = "9c04f943-eb1b-4355-aacf-1b58a9533f8d",
                Name = Adninistator,
                NormalizedName = Adninistator,

            }
            );
        var login = "admin@localhost.com";
        var hasher = new PasswordHasher<IdentityUser>();
        builder.Entity<IdentityUser>().HasData(
            new IdentityUser()
            {
                Id = "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a",
                Email = login,
                NormalizedEmail = login,
                NormalizedUserName = login,
                UserName = login,
                PasswordHash = hasher.HashPassword(null, "ps1"),
                EmailConfirmed = true
            }
            );
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
        {
            UserId = "426e7c43-b617-4ddc-a7af-fa5b5e6f4e6a",
            RoleId = "9c04f943-eb1b-4355-aacf-1b58a9533f8d"
        });


        base.OnModelCreating(builder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer
        base.OnConfiguring(optionsBuilder);
    }
}
