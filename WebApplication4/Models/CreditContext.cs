using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace WebApplication4.Models
{
    public class CreditContext : DbContext
    {
        public CreditContext(DbContextOptions<CreditContext> options) : base(options)
        {
        }

        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids { get; set; }


    }
}
