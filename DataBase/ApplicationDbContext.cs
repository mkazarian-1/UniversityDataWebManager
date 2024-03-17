using Microsoft.EntityFrameworkCore;
using UniversityDataWebManager.Models;

namespace UniversityDataWebManager.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Сountry> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
