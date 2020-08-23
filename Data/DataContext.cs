using Microsoft.EntityFrameworkCore;
using NetCoreAngularOne.Model;

namespace NetCoreAngularOne.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Value> Home {get;set;}
    }
}