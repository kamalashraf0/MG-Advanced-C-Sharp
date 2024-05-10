namespace MG_LINQ.LINQ
{
    public class Concatination
    {
        public static void PConcat()
        {
            var emps = Load.LoadEmpoyees();

            var emps2 = Load.LoadEmpoyees();


            // concatenation 2 lists of information together

            var result = emps.Concat(emps2);

            foreach (var e in result)
            {
                //Console.WriteLine(e);
            }

            var result2 = emps.Select(e => e.FirstName).Concat(emps2.Select(e => e.FirstName));

            foreach (var e in result2)
            {
                // Console.WriteLine(e);
            }



            //array concatenation
            var arr = new[] { emps, emps2 }.SelectMany(q => q);

            foreach (var item in arr)
            {
                // Console.WriteLine(item);
            }
        }

    }
}
