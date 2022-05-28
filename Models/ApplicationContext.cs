using Microsoft.EntityFrameworkCore;

namespace WebTest.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contact { get; set; } = null!;
        public DbSet<Roles> Roles { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
