namespace MG_LINQ.LINQ
{
    public class _97_IEnumerablevsIQueryable
    {

        #region IEnumerable
        //Better if the data in the memory 
        //Query local objects
        #endregion
        public static void PIEnumerable()
        {

            var emps = Load.LoadEmpoyees();

            IEnumerable<Employee> employees = emps;

            var morethan5000 = employees.Where(x => x.Salary > 5000);

            foreach (var employee in morethan5000)
            {
                //Console.WriteLine(employee);
            }

        }

        #region iQueryable
        //Better if the data from another data source 
        //LINQ to SQL
        #endregion
        public static void PIQueryable()
        {
            var emps = Load.LoadEmpoyees();

            //IQueryable<Employee> employees = (IQueryable<Employee>)emps;

            //var morethan5000 = employees.Where(x => x.Salary > 5000);

            //foreach (var employee in morethan5000)
            //{
            //    //Console.WriteLine(employee);
            //}


        }
    }
}
