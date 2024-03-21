using MG_Advanced_C_.Basic_C_;

namespace MG_Advanced_C_.Revision
{
    class CalculateEvent
    {
        public delegate bool CalculateDeleagte(Employee e);

        public event CalculateSalaryEventHandler ECalculateSalary;

        public delegate void CalculateSalaryEventHandler(Employee e, int salary);



        public void Calculatesalary(List<Employee> emps, CalculateDeleagte predicate)
        {
            foreach (var emp in emps)
            {
                if (predicate(emp))    // if delegate is True (so the delegate is bool ) 
                {

                    ECalculateSalary?.Invoke(emp, emp.Salary);    //is not null

                    //Console.WriteLine($"ID ; {emp.ID}  Name : {emp.Name} Salary :  {emp.Salary}");
                }

            }

        }
    }
}
