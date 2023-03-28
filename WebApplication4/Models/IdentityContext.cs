using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class IdentityContext: IdentityDbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {           
        }
    }
}
