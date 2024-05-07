namespace MG_LINQ.LINQ
{
    static class Load
    {
        public static IEnumerable<Employee> LoadEmpoyees()
        {

            for (int i = 1; i <= 99; i++)
            {


                string firstname = Random.Shared.Next(2) == 0 ? $"Ahmed{i}" : $"kamal{i}";
                yield return new Employee
                {
                    Id = i,
                    FirstName = firstname,
                    Email = Random.Shared.Next(2) == 0 ? $"{firstname}@gmail.com" : $"{firstname}@yahoo.com",
                    LastName = Random.Shared.Next(2) == 0 ? $"Ashraf{i}" : null,
                    DepartmentID = Random.Shared.Next(1, 5),
                    Salary = Random.Shared.Next(5000, 80000),



                };
            }

        }

        public static IEnumerable<Departments> LoadDepartment()
        {

            return new List<Departments>
                {
                    new Departments {ID= 1, Name ="HR"},
                    new Departments {ID= 2,Name ="IT"},
                    new Departments {ID= 3,Name ="Finance"},
                    new Departments {ID= 4,Name ="Sales"},
                    new Departments {ID= 5,Name="Accounting"}

                };

        }
    }
}
