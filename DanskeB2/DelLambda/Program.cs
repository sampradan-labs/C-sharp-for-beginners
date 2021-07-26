using System;
using System.Collections.Generic;

namespace DelLambda
{
    class Program
    {
        //Declaration
        delegate int Compute(int n1, int n2);
        static void Main(string[] args)
        {
            TraditionalDelegates();
            UsingFunc();
            UsingAction();
            UsingPredicate();
            DoSomething((work) => { 
                                    Console.WriteLine($"Working on: {work}"); 
                                  }
                        );
            LambdaWithList();
        }

        private static void LambdaWithList()
        {
            List<string> names = new List<string>() { "Eena", "Meena", "Deeka" };
            //Printing the above list
            names.ForEach((name) => { Console.WriteLine(name); });
        }

        private static void DoSomething(Action<string> action)
        {
            action("Conducting training");
        }

        private static void UsingPredicate()
        {
            Predicate<int> IsGreaterThanZero = (n1) => n1 > 0;
            Console.WriteLine($"Output of Predicate<> :: 100>0? {IsGreaterThanZero(100)}");
            Console.WriteLine($"Output of Predicate<> :: -100>0? {IsGreaterThanZero(-100)}");
        }

        private static void UsingAction()
        {
            Action<int, int, int> ReturnsNothing = (n1,n2,n3) => { 
                                                                    Console.WriteLine($"Output of Action<>: {n1 + n2 + n3}"); 
                                                                  };
            ReturnsNothing(100, 200, 300);
        }

        private static void UsingFunc()
        {
            Func<int, int, int> ComputeAsFunc = (n1,n2) => { return n1 + n2; };
            Console.WriteLine($"Output of Func<>: {ComputeAsFunc(100, 200)}");
        }

        private static void TraditionalDelegates()
        {
            //Instantiation
            Compute objCompute = new Compute(Add);
            objCompute += Subtract;
            objCompute += (int n1, int n2) =>
            {
                Console.WriteLine($"Product: {n1 * n2}");
                return n1 * n2;
            };
            //delegate object += lambda (()=>{})
            objCompute += (n1, n2) => n1 / n2;

            //Create a delegate that take a single param of type int / double / float
            // and returns int / double / float
            //Square, Cube, Random calculation

            //Invocation - Similar to function call
            Console.WriteLine($"Final Division output: {objCompute(100, 200)}");
        }

        private static int Subtract(int n1, int n2)
        {
            Console.WriteLine($"Result of Subtraction: {n1-n2}");
            return n1 - n2;
        }

        private static int Add(int n1, int n2)
        {
            Console.WriteLine($"Result of Addition: {n1 + n2}");
            return n1 + n2;
        }
    }
}
