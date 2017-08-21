using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Ball
    {
        private float size;
        private float radius;
        private Color color;
        private int ThrowCount;

        public Ball()
        {

        }

        public void Pop()
        {
            size = 0;
        }
    }
}
