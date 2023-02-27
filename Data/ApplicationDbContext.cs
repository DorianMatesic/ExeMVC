using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectsMVC.Models;

namespace ProjectsMVC.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ProjectsMVC.Models.Subject> Subjects { get; set; }
    public DbSet<ProjectsMVC.Models.Project> Projects { get; set; }
}
