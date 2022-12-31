using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SuperSevens2023.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .Property(e => e.FirstName)
                .HasMaxLength(50);

            builder.Entity<ApplicationUser>()
                .Property(e => e.LastName)
                .HasMaxLength(50);

            builder.Entity<ApplicationUser>()
                .Property(e => e.AdditionalEmail)
                .HasMaxLength(256);
        }
    }
}