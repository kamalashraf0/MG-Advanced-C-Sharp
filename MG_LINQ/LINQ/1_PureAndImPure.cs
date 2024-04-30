using LINQ;

namespace MG_LINQ.LINQ
{

    class PureAndImPure : Program
    {
        public List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        public void AddInteger(int num)
        {
            Numbers.Add(num);      //Impure function because it's affect on GLobal Variable like  {List}
        }


        public void AddInteger1(int num)
        {
            num++;
            Numbers.Add(num);      //Impure function because it's affect GLobal parameter
        }


        public List<int> AddInteger3(List<int> numbers, int num)    //Pure Function
        {
            var result = new List<int>(numbers);
            result.Add(num);
            return result;
        }

    }

    public static class Pprint
    {
        public static void Print()
        {
            PureAndImPure PI = new PureAndImPure();


            foreach (int i in PI.Numbers)
            {
                // Console.WriteLine(i);

            }


            //PI.AddInteger(4);
            //PI.AddInteger1(5);
            var newList = PI.AddInteger3(PI.Numbers, 5);

            Console.WriteLine();
            foreach (int i in newList)
            {
                //Console.WriteLine(i);
            }
        }
    }
}
