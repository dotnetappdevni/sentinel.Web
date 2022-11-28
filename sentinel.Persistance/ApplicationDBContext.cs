using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sentinelapi.Domain.Entities;

namespace sentinelapi.Domain
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
          : base(options)
        {

        }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Locker> Lockers { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Ref_Lockers> Ref_Lockers { get; set; }

        public DbSet<Ref_LockerSizes> Ref_LockerSizes { get; set; }

    }

}