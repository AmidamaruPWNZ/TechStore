using System.Web;
using System.Data.Entity;

namespace GameStore.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nikit\Desktop\TechStore\App_Data\TechStore.mdf;Integrated Security=True"
                    + ";Integrated Security=True")
        {  }

        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}