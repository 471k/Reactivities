using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //<Activity> -> The name of the model we will be working with.
        //Activities -> Represents our table name inside our database when it gets created
        public DbSet<Activity> Activities { get; set; }
    }
}