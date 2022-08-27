using Microsoft.EntityFrameworkCore;

namespace src.db
{
    public class PuppiesContext : DbContext
    {
        public DbSet<Puppy> Puppies { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public PuppiesContext()
        {
            Database.EnsureCreated();
        }

        //public PuppiesContext(DbContextOptions options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source=PuppiesDB.db");
        }
    }
}
