using System.Collections.Generic;

namespace LINQ
{

    class PureAndImPure : Program
    {

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
}
