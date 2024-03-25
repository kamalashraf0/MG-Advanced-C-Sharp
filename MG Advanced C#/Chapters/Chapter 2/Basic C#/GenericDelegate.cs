namespace MG_Advanced_C_.Basic_C_
{

    class GenericDelegate
    {
        //public delegate bool Filter<T>(T F);

        public void PrintNums<T>(IEnumerable<T> numbers, Predicate<T> filter)
        {

            foreach (var i in numbers)
            {
                if (filter(i))
                {
                    Console.WriteLine(i);
                }
            }

        }






        //Built in GenericDelegate



        public void Print(string s1) => Console.WriteLine(s1);

        public int add(int x, int y) => x + y;

        public bool ISEven(int n) => n % 2 == 0;



    }
}
