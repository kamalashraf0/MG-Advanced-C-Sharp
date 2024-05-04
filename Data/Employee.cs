using System.ComponentModel.DataAnnotations;
namespace Data
{
    public class Employee
    {
        [Key]
        public int E_ID { get; set; }

        public string E_Name { get; set; }

        public int E_Age { get; set; }

        public decimal Salary { get; set; }

        public string E_City { get; set; }


    }
}
