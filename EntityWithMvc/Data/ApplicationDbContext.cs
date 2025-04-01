using EntityWithMvc.Models;
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
}
