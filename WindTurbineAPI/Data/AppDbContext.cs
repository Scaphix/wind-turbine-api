using Microsoft.EntityFrameworkCore;
using WindTurbineAPI.Models;

namespace WindTurbineAPI.Data;


public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<WindTurbine> WindTurbines { get; set; }
}