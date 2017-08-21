using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Prop
    {
        public int Score { get; private set; }

        public Prop(int score)
        {
            this.Score = score;
        }
    }
}
