namespace MG_LINQ.LINQ
{
    public class JoinOperations
    {
        public static void PJoins()
        {
            //  Employee  key  = department value 
            var emps = Load.LoadEmpoyees();
            var deps = Load.LoadDepartment();

            var result = emps.Join(deps, emp => emp.DepartmentID, dep => dep.ID,
                (emp, dep) => new EmployeeDTo { FullName = emp.FirstName, Department = dep.Name });

            foreach (var item in result)
            {
                //Console.WriteLine($"{item.FullName} [{item.Department}]");
            }

            #region GroupJoins
            #endregion

            //Get Employee Records for every Department

            var res2 = deps.GroupJoin(emps, dep => dep.ID, emp => emp.DepartmentID,
                (dep, emp) => new Group { Department = dep.Name, Employees = emp.Select(e => e.FirstName).ToList() });



            var res2QuerySyntax =
                    from dep in deps
                    join emp in emps on dep.ID equals emp.DepartmentID into empGroup
                    select empGroup;

            foreach (var item in res2)
            {
                // Console.WriteLine($"\n{item.Department}\n");

                foreach (var name in item.Employees)
                {
                    //Console.WriteLine(name);
                }
            }
        }
    }
}
