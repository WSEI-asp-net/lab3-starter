namespace lab3
{
    using aspNetMVC.Models.Entities;
    using Microsoft.EntityFrameworkCore;

    namespace YourProjectName.Data
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
}
