using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using LNDCodeFirstV2.EntityConfigurations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LNDCodeFirstV2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Semat> Semats { get; set; }

        public DbSet<TelType> TelTypes { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<FieldOfActivity> FieldOfActivities { get; set; }

        public DbSet<Setad> Setads { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<IpRange> IpRanges { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Bajje> Bajjes { get; set; }

        public DbSet<Atm> Atms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SematConfiguration());

            modelBuilder.Configurations.Add(new TelTypeConfiguration());

            modelBuilder.Configurations.Add(new CompanyConfiguration());

            modelBuilder.Configurations.Add(new FieldOfActivityConfiguration());
            
            modelBuilder.Configurations.Add(new SetadConfiguration());

            modelBuilder.Configurations.Add(new SectionConfiguration());

            modelBuilder.Configurations.Add(new IpRangeConfiguration());

            modelBuilder.Configurations.Add(new BranchConfiguration());

            modelBuilder.Configurations.Add(new BajjeConfiguration());

            modelBuilder.Configurations.Add(new AtmConfiguration());

            modelBuilder.Configurations.Add(new PersonConfiguration());

            modelBuilder.Configurations.Add(new TelNumberConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}