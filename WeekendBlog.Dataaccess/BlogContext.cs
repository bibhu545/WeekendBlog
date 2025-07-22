using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendBlog.Dataaccess
{
    public class BlogContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Models.BlogPost> BlogPosts { get; set; }
        public DbSet<Models.Category> Categories { get; set; }
        public DbSet<Models.Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.BlogPost>().ToTable("BlogPosts").Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Models.BlogPost>().Property(p => p.IsDeleted).HasDefaultValue(false);

            modelBuilder.Entity<Models.Category>().ToTable("Categories").Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            modelBuilder.Entity<Models.Category>().Property(p => p.IsActive).HasDefaultValue(true);

            modelBuilder.Entity<Models.Tag>().ToTable("Tags").Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
        }
    }
}
