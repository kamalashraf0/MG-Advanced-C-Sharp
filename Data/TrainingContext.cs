using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class TrainContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }


        public TrainContext()
        {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = optionsBuilder.UseSqlServer($"Data Source= .; initial catalog = Training ; INTEGRATED SECURITY = True; TrustServerCertificate = False\"",
                b => b.MigrationsAssembly("Data"));

        }
    }
}