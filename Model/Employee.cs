using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Model
{
    public class Employee
    {
        [Key]
        public int E_ID { get; set; }

        [NotNull]
        public string E_Name { get; set; }

        public int E_Age { get; set; }

        public decimal E_Salary { get; set; }

        public string E_City { get; set; }

        public override string ToString()
        {
            using (var context = new DBContext())
            {
                var books = context.Employees.ToList();
                foreach (var book in books)
                    return $"Title: {book.E_ID}, Author: {book.E_Salary}";

                return $"Title: {E_ID}, Author: {E_Salary}";

            }

        }

    }
}
