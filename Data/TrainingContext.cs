using Data.Emp;
using Microsoft.EntityFrameworkCore;
namespace Data.Data
{
    public class TrainContext : DbContext
    {

        public DbSet<EmployeeDB> Employees { get; set; }


        public TrainContext()
        {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = optionsBuilder.UseSqlServer($"Data Source= .; Initial Catalog = Training ; INTEGRATED SECURITY = SSPI; TrustServerCertificate = True; ",
                b => b.MigrationsAssembly("MG_LINQ"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDB>().HasData(
                new[] {
            new EmployeeDB {E_ID = 10, E_Name = "Ahmed", E_Age = 22 ,Salary =5000m },
            new EmployeeDB {E_ID = 11, E_Name = "Mahmoud" ,E_Age = 23,Salary =50000m },
            new EmployeeDB {E_ID = 12, E_Name = "Mohamed ",E_Age = 24,Salary =35000m},
            new EmployeeDB {E_ID = 13, E_Name = "Sayed", E_Age = 25,Salary =5040m  },
            new EmployeeDB {E_ID = 14, E_Name = "Loay", E_Age = 26,Salary =40000m  },
            new EmployeeDB {E_ID = 15, E_Name = "Medhat",E_Age = 30,Salary =5600m }


            }
                );
        }
    }
}