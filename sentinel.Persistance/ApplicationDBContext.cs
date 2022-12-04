using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using sentinelapi.Entities;
namespace sentinel.Persistance { 

    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>

    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Locker> Lockers { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
 
        public DbSet<Ref_Lockers> Ref_Lockers { get; set; }

        public DbSet<Ref_LockerSizes> Ref_LockerSizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=SQL5105.site4now.net;Database=db_a828de_sentinel;User Id=db_a828de_sentinel_admin;Password=hooch2607d;MultipleActiveResultSets=true;TrustServerCertificate=True");
            options.EnableSensitiveDataLogging();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }

}