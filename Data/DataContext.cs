using Microsoft.EntityFrameworkCore;
using AspNetCoreMvcBlog.Models;

namespace AspNetCoreMvcBlog.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}