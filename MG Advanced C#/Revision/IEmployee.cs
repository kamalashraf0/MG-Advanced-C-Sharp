using MG_Advanced_C_.Basic_C_;
using System.Collections;

namespace MG_Advanced_C_.Revision
{
    public class IEmployee : IEnumerable<Employee>
    {
        private readonly List<Employee> lemployees = new();

        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public decimal totalSales { get; set; }

        public int Salary { get; set; }



        public void EmpSalary(string Name, int salary)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("name");
            }

            lemployees.Add(new Employee { Name = Name, Salary = salary });
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (var item in lemployees)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
