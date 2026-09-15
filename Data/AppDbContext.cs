using Microsoft.EntityFrameworkCore;
using debooth.Models;

namespace debooth.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
	public DbSet<UserPost> UserPosts => Set<Post>();
}