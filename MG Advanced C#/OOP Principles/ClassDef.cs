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


        }


        //private ClassDef(float radius)
        //{
        //    this.radius = radius;


        //    //A private constructor in a class is a constructor that can only be accessed within the same class.
        //    //It cannot be accessed or called from outside the class
        //    //This can be useful for implementing design patterns like the Singleton pattern,
        //    //where only one instance of a class is allowed.


        //}


        //default Constructor with a single parameter
        public ClassDef(float radius)           //Constructor initialize
        {
            this.radius = radius;
        }



        // Parameterless constructor
        public ClassDef() : this(2.5f)
        {
            //Overload Constructor
            //you need to pass a default value to a Constructor with a single parameter or more parameters 

        }

        ~ClassDef()        // Destructor (Optional Garbage Collector)
        {
            //However, in C#, it's not common to use destructors (~ClassName)
            //because the garbage collector handles memory cleanup for you.
            //Destructors are only necessary in specific scenarios where you need to release unmanaged resources,
            //such as closing files or network connections.

        }



        public static ClassDef CreateIntance(float radius)           //To Create Instance for private constructor
        {

            return new ClassDef(radius);
        }

        public double CircleArea()
        {
            return Math.PI * radius * radius;
        }

        public ClassDef Circle()
        {
            int x = 5;
            return new ClassDef(x);
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
