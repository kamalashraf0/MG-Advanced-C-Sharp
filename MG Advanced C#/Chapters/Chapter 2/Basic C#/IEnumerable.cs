using System.Collections;

namespace MG_Advanced_C_.Basic_C_
{
    class emp : IEnumerable
    {

        private int[] _values;
        public int ID { get; set; }
        public string name { get; set; }





        public emp()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            _values = new int[] { x, y, z };
        }


        public IEnumerator GetEnumerator()
        {
            foreach (var x in _values)
            {
                yield return x;
            }

        }




        //without ctor

        //Equals override for content comparison
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj is emp)
                return true;

            var emp = (emp)obj;

            return this.ID == emp.ID && this.name == emp.name;
        }







        //Operator overloading   for (objects)
        public static bool operator ==(emp em1, emp em2)
        {
            return em1.ID == em2.ID && em1.name == em2.name;
        }

        public static bool operator !=(emp em1, emp em2)
        {
            return em1 != em2;
        }
    }
}
