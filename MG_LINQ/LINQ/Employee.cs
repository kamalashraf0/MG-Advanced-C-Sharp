namespace MG_LINQ.LINQ
{
    class Employee
    {
        private static bool iscalled = false;
        private bool staticConstructorPrinted = false;

        public int Id { get; set; }

        public string EmployeeNu { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string Department { get; set; }

        public int DepartmentID { get; set; }
        public string LastName { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public string Email { get; set; }
        public List<string> Skills { get; set; } = new();










        public override string ToString()
        {

            if (!iscalled && !staticConstructorPrinted)
            {
                Console.WriteLine($"ID \tName\t\tEmail\t\t\tDepartment\t\tSalary\n");
                Console.WriteLine("-----------------------------------------------------------------------------");
                staticConstructorPrinted = true;
            }

            iscalled = true;

            return string.Format($"" +
               $"{Id} \t " +
               $"{FirstName} \t " +
               $"{Email} \t " +
               $"{DepartmentID}\t\t" +
               $"{Salary} \t ");

            //return string.Format($"" +
            //    $"{Id}\t" +
            //    $"{FirstName}\t" +
            //    $"{LastName}\t\t" +
            //    $"{Skills[Random.Shared.Next(Skills.Count())]} ");

            // return $"{EmployeeNu}";
        }


        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;           // checks if other is empty

            if (ReferenceEquals(this, obj)) return true;           //checks if other is identical 

            if (obj.GetType() != this.GetType()) return false;      //check the types for them 

            var other = (Employee)obj;

            return EmployeeNu == other.EmployeeNu && FirstName == other.FirstName;
        }
    }
}
