
using System;

namespace Lab_4
{
    internal class Circle
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}
