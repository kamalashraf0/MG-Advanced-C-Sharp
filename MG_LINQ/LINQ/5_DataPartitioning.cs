namespace MG_LINQ.LINQ
{
    static class DataPartitioning
    {
        public static void PDataP()
        {




            var emps = Load.LoadEmpoyees();

            var q1 = emps.Skip(10);             // skip first 10 records

            var q2 = emps.SkipLast(10);         // ignore last 10 records

            var q3 = emps.SkipWhile(x => x.FirstName != "Ahmed50");   // retrieve from the condition




            var querySyntax =
                (from x in emps.SkipWhile(x => x.Id != 13)
                 where x.Salary > 50000
                 select x);

            foreach (var e in querySyntax)
            {
                //Console.WriteLine(e);
            }

            #region Take
            #endregion

            var q1query = emps.Take(10);        // get only first 10 records

            var q2query = emps.TakeLast(10);        // get only last 10 records

            var q3query = emps.TakeWhile(x => x.Id != 50);        // get records till not equal the condition


            foreach (var item in q3query)
            {
                //Console.WriteLine(item);
            }

            #region Chunck
            #endregion

            var c1 = emps.Chunk(10).ToList();     // split into groups



            //for (int i = 0; i < c1.Count; i++)
            //{
            //    Console.WriteLine($"Chunk #{i + 1}\n");
            //    foreach (var item in c1[i])
            //    {
            //        Console.WriteLine(item);

            //    }

            //    Console.WriteLine("\n");
            //}

            #region Pagination
            #endregion

            var p = emps.Paginate(0, 0);      // split into pages and get number of records







        }

        #region Pagination
        #endregion

        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page = 1, int size = 10)
            where T : class

        {
            if (page <= 0)
            {
                page = 1;
            }

            if (size <= 0)
            {
                size = 10;
            }

            var total = source.Count();

            var pages = Math.Ceiling((decimal)total / size);  //Ceiling 3,6  => 4

            var result = source.Skip((page - 1) * size).Take(size);


            return result;



        }
    }
}
