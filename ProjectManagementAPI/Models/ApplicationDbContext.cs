using Microsoft.EntityFrameworkCore;
using ProjectManagementAPI.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Board> Boards { get; set; }
    public DbSet<Task> Tasks { get; set; }
}