namespace MG_Advanced_C_
{
    class ClassDef
    {
        protected float radius { get; set; }    //Encapsulation Access Modifier 
                                                //The protected keyword specifies that the field
                                                //can be accessed within the class and its derived classes.






        static ClassDef()
        {
            //A static constructor in C# is a special type of constructor
            //that is used to initialize any static data
            //or perform any actions that need to be taken only once for the entire class

            Console.WriteLine("Hello from Base Class");
            Console.Write("CircleArea =   ");

        }





        // Constructor with a single parameter
        public ClassDef(float radius)           //Constructor initialize
        {
            this.radius = radius;
        }



        // Parameterless constructor 
        public ClassDef() : this(2.5f)
        {
            //Overload Constructor
            //you need to pass a default value to a Constructor with a single parameter

        }

        ~ClassDef()        // Destructor (Optional Garbage Collector)
        {
            //However, in C#, it's not common to use destructors (~ClassName)
            //because the garbage collector handles memory cleanup for you.
            //Destructors are only necessary in specific scenarios where you need to release unmanaged resources,
            //such as closing files or network connections.

        }


        public double CircleArea()
        {
            return Math.PI * this.radius * this.radius;
        }


    }

    class ChildClassDef : ClassDef
    {


        public ChildClassDef(float radius) : base(radius)
        {

        }

        public double CalculateCirclePerimeter()
        {

            return 2 * Math.PI * radius;

        }
    }
}
