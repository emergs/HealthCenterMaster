using HealthCenterMaster.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthCenterMaster.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Client { get; set; }
    public DbSet<Physiotherapist> Physiotherapist { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
}
