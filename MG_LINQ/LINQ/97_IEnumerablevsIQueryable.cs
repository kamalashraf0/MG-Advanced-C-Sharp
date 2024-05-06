using DataModel;
using Model;
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




            var Db = new TrainingContext();

            IEnumerable<EmployeeModel> emps = Db.EmpModel;

            var bigSalary = emps.Where(x => x.E_Salary > 30000);

            foreach (var emp in bigSalary)
            {

                //Console.WriteLine(emp);
            }


        }

        #region iQueryable
        //Better if the data from another data source 
        //LINQ to SQL
        #endregion
        public static void PIQueryable()
        {
            var Db = new TrainingContext();

            IQueryable<EmployeeModel> emps = Db.EmpModel;

            var bigSalary = emps.Where(x => x.E_Salary > 30000);

            foreach (var emp in bigSalary)
            {

                //Console.WriteLine(emp);
            }


        }
    }
}
