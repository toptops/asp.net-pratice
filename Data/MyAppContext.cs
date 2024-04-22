using Microsoft.EntityFrameworkCore;
using TestDotNetWebApplication.Models;

namespace TestDotNetWebApplication.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
