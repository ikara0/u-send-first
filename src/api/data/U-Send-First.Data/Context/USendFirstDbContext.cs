using Microsoft.EntityFrameworkCore;
using U_Send_First.Entities.Media;
using U_Send_First.Entities.Profile;

namespace U_Send_First.Data.Context
{
    public class USendFirstDbContext : DbContext
    {
        public USendFirstDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}