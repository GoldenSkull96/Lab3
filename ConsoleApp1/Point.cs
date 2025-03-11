using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private int x;
        private int y;
        private int z;
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
