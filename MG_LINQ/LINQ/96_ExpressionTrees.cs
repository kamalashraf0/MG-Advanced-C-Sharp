
using System.Linq.Expressions;

namespace MG_LINQ.LINQ
{
    internal class ExpressionTrees
    {
        public static void PExTree()
        {
            //Expression class is the parent of all Expressions like (Lambda ,parameter , binary)


            Expression<Func<int, bool>> isEvenEx = num => num % 2 == 0;
            Func<int, bool> isEven = isEvenEx.Compile();
            //Console.WriteLine(isEven(10));


            #region Example 2 
            #endregion

            //how the expression tree works 

            ParameterExpression numparam = isEvenEx.Parameters[0];
            BinaryExpression operation = (BinaryExpression)isEvenEx.Body;
            ConstantExpression O1right = (ConstantExpression)operation.Right;
            BinaryExpression operation2 = (BinaryExpression)operation.Left;
            ParameterExpression numparam2 = (ParameterExpression)operation2.Left;
            ConstantExpression O2right = (ConstantExpression)operation2.Right;




            //Console.WriteLine(
            //    $"Expression Tree : {numparam.Name} " +
            //    $" => {numparam2.Name} {operation2.NodeType} {O2right.Value} {operation.NodeType} {O1right.Value} ");



            #region Example 3 
            #endregion
            //using lambda expression for more dynamic   (num) => num % 2 == 0

            ParameterExpression LNum = Expression.Parameter(typeof(int), "num");

            ConstantExpression Lnum2 = Expression.Constant(2);

            BinaryExpression modulexp = Expression.Modulo(LNum, Lnum2);

            ConstantExpression Lnum0 = Expression.Constant(0);

            BinaryExpression Equiexp = Expression.Equal(modulexp, Lnum0);

            Expression<Func<int, bool>> IsEvenLambdaEx =
                Expression.Lambda<Func<int, bool>>(Equiexp, new ParameterExpression[] { LNum });


            Func<int, bool> isLambdaEven = IsEvenLambdaEx.Compile();
            //Console.WriteLine(isLambdaEven(10));








        }
    }
}