using System;
using System.Collections.Generic;
using System.Text;

namespace DelLambda
{
    internal class ClassWithLambda
    {
        public int Id => 100;      //shorcut to a property. It also makes it readonly

        public List<string> strs { get; set; }
        //Expression embodied functions => Methods using lambda operator
        //Function Declaration => expression
        public int Compute(int n1, int n2) => n1 + n2 * 100;    //Shortcut of writing a function

        public void DoSomething() => Console.WriteLine("Did Something");

        //Lambda functions not applicable in CLASS for multi-line logic
        public void AddItem(string str)
        {
            List<string> lst = new List<string>();
            lst.Add(str);
        }

    }
}
