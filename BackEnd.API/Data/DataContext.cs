using BackEnd.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.API.Data
{
    // Make this available as a Service, because we need to consume this in other parts of our application.
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Values> Values { get; set; }
    }
}