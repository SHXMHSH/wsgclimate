using Microsoft.EntityFrameworkCore;

namespace wsgclimate.DataContext
{
    public class Data : DbContext
    {
        public Data(DbContextOptions options) : base(options) 
        {

        }
    }
}
