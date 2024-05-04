namespace MG_LINQ.LINQ
{
    public class _95_SetsOperations
    {
        public static void PSets()
        {
            var emps = Load.LoadEmpoyees();
            var emps2 = Load.LoadEmpoyees();



            #region Distinct 
            #endregion


            var result = emps.Distinct();
            var result0 = emps.DistinctBy(e => e.DepartmentID);



            foreach (var item in result)
            {
                //Console.WriteLine(item);
            }

            #region Union 

            //combining elements from two collections
            //while filtering out duplicates based on a specific property.
            //(UnionBy) inherently eliminates duplicates
            #endregion

            var result1 = emps.Union(emps2);

            var result12 = emps.UnionBy(emps2, x => x.FirstName);

            foreach (var item in result1)
            {
                //Console.WriteLine(item);
            }



            #region Intersect 

            //get the records that in first list and second one
            #endregion

            var result2 = emps.Intersect(emps2);
            var result21 = emps.IntersectBy(emps2.Select(x => x.FirstName), x => x.FirstName);

            foreach (var item in result2)
            {
                //Console.WriteLine(item);
            }


            #region Except 
            //get all in left side (emps) but not in right side

            //it compare the identical based on Equals method (override)
            #endregion


            var result3 = emps.Except(emps2);
            var result4 = emps.ExceptBy(emps2.Select(x => x.Id), x => x.Id);

            foreach (var item in result4)
            {
                //Console.WriteLine(item);
            }

        }
    }
}
