namespace MG_Advanced_C_
{
    interface Shape                                  //Can't Contain AccessModifiers (Public by default) or parameters
                                                     //(Public by default)
                                                     //Can't Inherit From Abstract Class            
    {


        string ColorCode { get; set; }              //Can Contain Properties , Should provide implementation when you inherit it

        //string name;                                //Can't Contain Fields


        void draw();                                // Methods (Just Declarations not Implementations)
                                                    // you should provide implementation when you inherit it 
    }

    interface ShapeColor : Shape                    //Can inherit from each other
    {


        void draw();
    }

    class Circle : Shape, ShapeColor                 //Can Provide (Multiple Interface Inheritance)
    {
        public string ColorCode { get; set; }

        void Shape.draw()
        {
            Console.WriteLine("Draw a Circle");
        }

        //We used here (Explicit Interface Implementation)
        void ShapeColor.draw()
        {
            Console.WriteLine("Color The Circle");
        }



    }

}
