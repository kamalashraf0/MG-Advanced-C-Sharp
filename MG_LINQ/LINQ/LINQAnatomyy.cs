using DataModel.DBContext;

namespace MG_LINQ.LINQ
{
    public class LINQAnatomy
    {
        public static void PLINQ()
        {
            #region FluentAPI
            //Method Chaining and Extension Method to make statement look like a sentence (Readability)
            #endregion

            var DB = new ApplicationDbContext();

            var Model = DB.EmpModel;

            var Result = Model.
                OrderBy(x => x.E_Name).Skip(4).Take(6).
                OrderBy(x => x.E_Salary).ToList();

            #region IQueryable&IEnumerable

            #endregion

            //LINQ to objects
            //it does literally what it is told 

            var IEresult = Model.
                OrderBy(x => x.E_Name).Skip(4).Take(6).
                OrderBy(x => x.E_Salary).ThenByDescending(x => x.E_ID).AsEnumerable();

            //LINQ to SQL
            //Composed (Expression Tree)
            //build the most suitable implementation possible

            var IQresult = Model.
                OrderBy(x => x.E_Name).Skip(4).Take(6).
                OrderBy(x => x.E_Salary).ThenByDescending(x => x.E_ID).AsQueryable();


        }
    }
}
