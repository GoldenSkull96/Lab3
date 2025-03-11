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
        private Point coordinate;
        private double length;
        public Point Start { get { return start; } }
        public Point End { get { return end; } }
        public Point Coordinate { get { return coordinate; } }
        public double Length { get { return length; } }

        public Vector(Point start, Point end)
        {
            this.start = start;
            this.end = end;
            Coordinates_();
            Length_();
        }
        private Vector(Point coordinate)
        {
            this.coordinate = coordinate;
        }
        private void Coordinates_()
        {
            this.coordinate = new Point(End.x - Start.x, End.y - Start.y, End.z - Start.z);
        }
        private void Length_()
        {
            this.length = Math.Sqrt(Math.Pow(Coordinate.x, 2) + Math.Pow(Coordinate.y, 2) + Math.Pow(Coordinate.z, 2));
        }
        public Vector Sum(Vector vector)
        {
            return new Vector(new Point(coordinate.x + vector.Coordinate.x, coordinate.y + vector.Coordinate.y, coordinate.z + vector.Coordinate.z));
        }
        public Vector Minus(Vector vector)
        {
            return new Vector(new Point(coordinate.x - vector.Coordinate.x, coordinate.y - vector.Coordinate.y, coordinate.z - vector.Coordinate.z));
        }
        public int Mult(Vector vector)
        {
            return coordinate.y * vector.Coordinate.y + coordinate.y * vector.Coordinate.y + coordinate.z * vector.Coordinate.z; 
        }
        public double Cos(Vector vector)
        {
            return Mult(vector)/length * vector.Length;
        }
    }
}

