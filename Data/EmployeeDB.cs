using System.ComponentModel.DataAnnotations;
namespace Data.Emp
{
    public class EmployeeDB
    {
        [Key]
        public int E_ID { get; set; }

        public string E_Name { get; set; }

        public int E_Age { get; set; }

        public decimal Salary { get; set; }

        public string E_City { get; set; }


        public override string ToString()
        {
            return $"{E_ID}\t{E_Name}\t{E_Age}\t{Salary}";
            //return $"{Salary}";
        }

    }
}
