using DataModel.DBContext;

namespace MG_LINQ.LINQ
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> Paginates<T>(this IEnumerable<T> source, int page = 1, int pagesize = 10)
            where T : class
        {
            if (source == null) throw new ArgumentNullException($"{nameof(source)}");

            if (page < 0)
                page = 1;

            if (pagesize < 0)
                pagesize = 10;


            if (!source.Any())
            {
                return Enumerable.Empty<T>();
            }

            var pages = source.Skip((page - 1) * pagesize).Take(pagesize);

            return pages;
        }

        public static IEnumerable<T> WhereWithPaginates<T>(this IEnumerable<T> source,
            Func<T, bool> predicate, int page = 1, int pagesize = 10)
            where T : class
        {
            if (source == null) throw new ArgumentNullException($"{nameof(source)}");

            var pages = source.Skip((page - 1) * pagesize).Take(pagesize);

            var result = Enumerable.Where(source, predicate);

            return Paginates(result, page, pagesize);
        }

        public static void PMethod()
        {
            var DB = new TrainingContext();

            var model = DB.EmpModel;

            var pages = model.Paginates(1, 5);  //page number and the nums of records

            foreach (var page in pages)
            {
                //Console.WriteLine(page);
            }

            var result = model.WhereWithPaginates(x => x.E_Salary > 20000, 1, 3);

            foreach (var page in result)
            {
                //Console.WriteLine(page);
            }
        }
    }


}
