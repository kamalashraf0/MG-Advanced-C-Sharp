using MG_Advanced_C_;
using MG_Advanced_C_.Advanced_DS_C__;
using MG_Advanced_C_.Revision;
using System.Numerics;

namespace Metigator_Advanced_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            KudvenOOP kudvenOOP = new KudvenOOP();
            kudvenOOP.Chapter1();

            //-------------------------------------------------------------------------//
            Training training = new Training();
            training.Train1();
            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//


            // ClassDef.cs

            //Console.Write("Enter The radius : ");
            //float rad = Convert.ToInt32(Console.ReadLine());
            //ChildClassDef CD = new ChildClassDef(rad);
            //int Pres = Convert.ToInt32(CD.CircleArea());
            //Console.WriteLine(Pres);

            //ClassDef PCD = ClassDef.CreateIntance(5);
            //Console.WriteLine(PCD.CircleArea());




            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            // PolymorphsimDef.cs

            // The Principle of Polymorphism  and flexibility 
            PolymorphsimDef pd = new childPolymorphsimDef();
            //pd.method();

            //sealeaded sd = new sealeaded();
            //sd.Sealeds= 5;



            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            // InterfaceDef.cs

            // we will use here (TypeCast EII)


            Circle c = new Circle();
            //((Shape)c).draw();
            //((ShapeColor)c).draw();


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//
            //AbstractClassDef.cs


            AbstractClassDef ab = new Child();                  //(Abstract Class Reference)
                                                                //ab.Print();                                    //This approach allows you to use polymorphism,
                                                                //meaning you can assign
                                                                //any subclass of AbstractClassDef to the ab variable.


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//

            Metigator_C_ MC = new Metigator_C_();
            MC.Chapter2();


            //-------------------------------------------------------------------------//
            //-------------------------------------------------------------------------//

            DataStructures ds = new DataStructures();
            ds.Chapter3();





            Console.ReadKey();

        }





    }
    delegate int CalculateDelegate(int num1, int num2);

    struct ahmed
    {
        public ahmed()
        {

        }
    }

    public static class Extensions
    {
        public static void Print<T>(this T[] value)
        {
            if (!value.Any())
            {
                Console.WriteLine("{}");
                return;
            }

            Console.Write("{ ");

            for (var i = 0; i < value.Length; i++)
            {
                Console.Write($"{value[i]}");
                Console.Write(i < value.Length - 1 ? "," : "");
            }
            Console.WriteLine(" }");

        }

        public static T EADD<T>(this T value, T value1, T value2, out T result) where T : INumber<T>
        {
            result = default;
            return value2 + value2;
        }
    }
}
