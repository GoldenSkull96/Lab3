using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vector
    {
        private int[] start;
        private int[] end;
        private int[] coordinates;
        private double length;
        public int[] Start { get { return start; } }
        public int[] End { get { return end; } }
        public int[] Coordinates { get { return coordinates; } }
        public double Length { get { return length; } }

        public Vector(int[] start, int[] end)
        {
            this.start = start;
            this.end = end;
            Coordinates_();
        }
        private void Coordinates_()
        {
            int[] coordinates = new int[3];
            coordinates[0] = end[0] - start[0];
            coordinates[1] = end[1] - start[1];
            coordinates[2] = end[2] - start[2];
            this.coordinates = coordinates;
        }
        public void Length_()
        {
            this.length = Math.Sqrt(Math.Pow(coordinates[0], 2) + Math.Pow(coordinates[1], 2) + Math.Pow(coordinates[2], 2));
            Console.Write(length);
        }
    }
}

