using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infass_RIVERA.Data
{
    // ApplicationUser extends IdentityUser in case we want extra profile
    // fields later (full name, etc.) without touching the schema everywhere.
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
