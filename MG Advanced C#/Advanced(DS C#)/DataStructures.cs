
namespace MG_Advanced_C_.Advanced_DS_C__
{
    class DataStructures
    {
        public void Chapter3()
        {

            var hl = new hello { name = "loay", num = 10 };
            var hl1 = new hello { name = "sameh", num = 18 };

            hello[] arr = { hl, hl1 };

            //List (LinkedList for insertion and deletion)

            //Constructor
            List<hello> values = new List<hello>();

            //Methods
            values.Add(new hello { name = "ahmed", num = 5 });

            values.Add(new hello { num = 20 });
            values.AddRange(arr);
            values.Insert(1, new hello { name = "medhat" });
            values.Insert(1, new hello { num = 50 });
            values.RemoveAt(1);

            foreach (var value in values)
            {
                //Console.WriteLine($"{value.name} => {value.num}");

            }
            //Console.WriteLine();
            //Console.WriteLine($"Count = {values.Count} \n Capacity = {values.Capacity}");



            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //Dictionary (Key & value )
            var article = "My name is Kamal AShraf , I'm 24 years old " +
                          "I have a degree in computer science from alshorouk academy  " +
                          "Having just completed my military services";


            Dictionary d = new Dictionary();
            // d.Dictionariees(article);


            ///////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////

            //

        }
    }


    class hello
    {
        public int num { get; set; }
        public string name { get; set; }

    }

}
