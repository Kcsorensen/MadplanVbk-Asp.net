using MadplanVbkAsp.Models;
using Microsoft.EntityFrameworkCore;

namespace MadplanVbkAsp.Data
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        { }

        public DbSet<Food> Foods { get; set; }
    }
}
