using Microsoft.EntityFrameworkCore;
using debooth.Models;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	public DbSet<Post> Posts => Set<Post>();
}