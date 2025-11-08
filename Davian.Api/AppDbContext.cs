using Davian.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Davian.Api;
public class AppDbContext (DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Artwork> Artworks => Set<Artwork>();
    public DbSet<Collection> Collections => Set<Collection>();
    public DbSet<User> Users => Set<User>();
}