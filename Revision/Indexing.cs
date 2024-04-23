using System;
using System.Collections.Generic;

namespace Revision
{
    class Indexing
    {

        public delegate void ProcessIDHandler(Employee e, int ID);

        public event ProcessIDHandler ProcessID;


        public void ProcessSalary(List<Employee> employees, Predicate<Employee> predicate)
        {
            foreach (var item in employees)

            {
                if (predicate(item))
                {
                    ProcessID?.Invoke(item, item.Id);
                }

            }

        }





    }


    class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public int Salary { get; set; }
    }
}
