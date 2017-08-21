using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Derived : Base
    {
        public int value;

        public Derived(int value)
        {
            this.value = value;
            counter = 100;
        }
    }
}