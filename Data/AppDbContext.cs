using Microsoft.EntityFrameworkCore;
using WearHouseMiniProject.Models;

namespace WearHouseMiniProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<UserData> UserData {  get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
