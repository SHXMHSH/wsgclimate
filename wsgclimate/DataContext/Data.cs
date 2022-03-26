using Microsoft.EntityFrameworkCore;
using wsgclimate.Models;

namespace wsgclimate.DataContext
{
    public class Data : DbContext
    {
       public DbSet<RoomModel> RoomModels { get; set; }
        public Data() { }
        public Data(DbContextOptions<Data> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=climate;Integrated Security=True;");
        }
    }
}
