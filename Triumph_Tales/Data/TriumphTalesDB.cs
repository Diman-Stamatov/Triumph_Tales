using Microsoft.EntityFrameworkCore;

namespace Triumph_Tales.Data;

public class TriumphTalesDB : DbContext
{
    public TriumphTalesDB(DbContextOptions<TriumphTalesDB> options) : base(options) { }
}
