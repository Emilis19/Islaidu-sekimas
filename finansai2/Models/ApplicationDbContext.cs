using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace finansai2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Islaida> Islaidos { get; set; }
        public DbSet<Kategorija> Kategorijos { get; set; }


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