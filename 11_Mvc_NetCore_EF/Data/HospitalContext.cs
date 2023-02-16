using _11_Mvc_NetCore_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace _11_Mvc_NetCore_EF.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
             
        }

        public DbSet<Hospital> Hospitales { get; set; }
    }
}
