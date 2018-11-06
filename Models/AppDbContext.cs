using Microsoft.EntityFrameworkCore;

namespace dot_net_core_webapi_lesson.Models {

    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        public DbSet<User> Users { get; set; }
    }
}