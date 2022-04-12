using DataRetrievalFromDB.Models;
using Microsoft.EntityFrameworkCore;

namespace DataRetrievalFromDB.Helpers
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<DbOrder> Orders { get; set; }
    }
}
