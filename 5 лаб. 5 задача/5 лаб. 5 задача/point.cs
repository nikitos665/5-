using System;
using System.Collections.Generic;
using System.Text;

namespace _5_лаб._5_задача
{
    internal class point
    {
        public int x;
        public int y;
        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Deconstruct (out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }
    }
}
