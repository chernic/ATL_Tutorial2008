using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharptestATLTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            ATLTutorial2008Lib.HelloWorld hw = new ATLTutorial2008Lib.HelloWorld();
            System.Diagnostics.Debug.WriteLine("===>" + hw.SayHello("abc"));
            Console.ReadKey();
        }
    }
}
