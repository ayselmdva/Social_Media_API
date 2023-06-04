using Microsoft.EntityFrameworkCore;
using Social_Media_API.Models;

namespace Social_Media_API.DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }

        public DbSet<Like> Likes => Set<Like>();
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Media> Media => Set<Media>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<FriendShip> FriendShip => Set<FriendShip>();
    }
}
