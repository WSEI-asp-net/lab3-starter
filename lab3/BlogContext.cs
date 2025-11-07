using lab3.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace lab3
{
    public class BlogContext : DbContext
    {
        public DbSet<BlogArticle> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=blog.db");
        }
    }

}
