using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Console.WriteLine("b.counter: " + b.counter);

            Derived d = new Derived(5);
            Console.WriteLine("\nd.counter: " + d.counter + " d.value:" + d.value);

            Base bb = new Derived(15);
            Console.WriteLine("\nbb.counter: " + bb.counter);

            Derived dd = (Derived)bb;

            Console.WriteLine(dd.value);
        }
    }
}