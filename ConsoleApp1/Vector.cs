using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vector
    {
        private Point start;
        private Point end;
        private Point coordinates;
        private double length;
        public Point Start { get { return start; } }
        public Point End { get { return end; } }
        public Point Coordinates { get { return coordinates; } }
        public double Length { get { return length; } }

        public Vector(Point start, Point end)
        {
            this.start = start;
            this.end = end;
            Coordinates_();
            Length_();
        }
        private void Coordinates_()
        {
            this.coordinates = new Point(End.X - Start.X, End.Y - Start.Y, End.Z - Start.Z);
        }
        private void Length_()
        {
            this.length = Math.Sqrt(Math.Pow(Coordinates.X, 2) + Math.Pow(Coordinates.Y, 2) + Math.Pow(Coordinates.Z, 2));
        }

    }
}

