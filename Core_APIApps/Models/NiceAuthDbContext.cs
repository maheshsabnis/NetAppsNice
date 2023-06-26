using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Core_APIApps.Models
{
    public class NiceAuthDbContext : IdentityDbContext
    {
        /// <summary>
        /// Used to Register the NiceAuthDbContext in DI Cintainer and read the
        /// Connection string from appSettins.json
        /// </summary>
        /// <param name="options"></param>
        public NiceAuthDbContext(DbContextOptions<NiceAuthDbContext> options):base(options) 
        {

        }

      /// <summary>
      /// Mapping to Database tables
      /// </summary>
      /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        /// <summary>
        /// Use the connection string to connect to database
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
