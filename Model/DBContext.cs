using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class DBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DBContext()
        {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = optionsBuilder.UseSqlServer($"Data Source= .; Initial Catalog = Training ; INTEGRATED SECURITY = True; TrustServerCertificate = True; ",
                b => b.MigrationsAssembly("Model"));

        }


    }
}
