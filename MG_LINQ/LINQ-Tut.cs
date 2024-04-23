namespace MG_LINQ
{
    public static class LINQ_Tut
    {
        public static void LINQ()
        {
            List<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbersUsingWhereMethod = ints.Where(x => x % 2 == 0);  // Where (return bool)

            var evenNumbersUsingEnumerableWhereMethod = Enumerable.Where(ints, x => x % 2 == 0);

            #region QuerySyntax
            #endregion

            var evenNumbersUsingQuerySyntax =
                from x in ints
                where x % 2 == 0
                select x;

            //IEnumerable<int> evenNumbers = ints.Where(x => x % 2 == 0);   //var = IEnumerable

            ints.Add(10);
            ints.Remove(6);

            foreach (var i in evenNumbersUsingQuerySyntax)    //Where method execute sequential 
            {
                //Console.WriteLine(i);
            }





        }

    }
}
