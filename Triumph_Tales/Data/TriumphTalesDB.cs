using Microsoft.EntityFrameworkCore;
using Triumph_Tales.Models;

namespace Triumph_Tales.Data;

public class TriumphTalesDB : DbContext
{
    public TriumphTalesDB(DbContextOptions<TriumphTalesDB> options) 
        : base(options) { }

    public DbSet<SuccessStory> Stories { get; set; }

}
