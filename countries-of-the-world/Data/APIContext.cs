using CountriesOfTheWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace CountriesOfTheWorld.Data {
    public class ApiContext : DbContext {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options) {
        }

        public DbSet<CountryInfo> Countries { get; set; } = null!;
    }
}
