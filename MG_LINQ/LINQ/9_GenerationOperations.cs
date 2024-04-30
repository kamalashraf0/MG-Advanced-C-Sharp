namespace MG_LINQ.LINQ
{
    public class GenerationOperations
    {
        public static void PGeneration()
        {

            //Console.WriteLine(default(int));        //0
            //Console.WriteLine(default(DateTime));   //01-01-0001  12:00:00 AM
            //Console.WriteLine(default(object));     //NULL



            var result = Enumerable.Empty<Employee>();   //Empty list (better performance)

            var question2 = result.DefaultIfEmpty();     // better for handling 


            #region Range Operation
            #endregion


            var range = Enumerable.Range(1, 10);   //better than using nested for loop to print from1 to 10

            foreach (var r in range)
            {
                //Console.WriteLine(r);
            }

            #region Repeat
            #endregion

            var result2 = Enumerable.Repeat(question2, 10);  //repeat methods 10 times





        }
    }
}
