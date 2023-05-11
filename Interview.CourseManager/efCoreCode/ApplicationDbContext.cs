using Interview.CourseManager.efCoreCode.efCoreClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Interview.CourseManager.efCoreCode
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<ClubBranch> ClubBranches { get; set; }
        public DbSet<Academy> Academys { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseReservation> CourseReservations { get; set; }
        public DbSet<Staduim> Staduims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region seeding 
            builder.Entity<Academy>()
              .HasData(

                new Academy { Id = 1, Name = "Academy1" },
                new Academy { Id = 2, Name = "Academy2" }
               );
            builder.Entity<SportType>()
              .HasData(

                new SportType { Id = 1, Name = "SportType1" },
                new SportType { Id = 2, Name = "SportType2" }
               );
            builder.Entity<Staduim>()
              .HasData(

                new Staduim { Id = 1, Name = "Staduim1" },
                new Staduim { Id = 2, Name = "Staduim2" }
               );
            #endregion
        }

    }
}
