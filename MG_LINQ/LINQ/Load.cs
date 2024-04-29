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
                    Department = Random.Shared.Next(2) == 0 ? "HR" : "Technical",
                    Salary = Random.Shared.Next(5000, 80000),



                };
            }

        }
    }
}
