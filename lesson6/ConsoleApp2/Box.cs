using System;
using System.Collections.Generic;

namespace ThreeDimensionalShapes
{
    class Box : Shape
    {
        public int H { get; }
        public List<Shape> Shapes { get; }
        private double _freeSpace;

        public Box(int H) 
        {
            this.H = H;
            Shapes = new List<Shape>();
            _freeSpace = Volume();
        }

        public override double Volume() 
        {
            return Math.Pow(H, 3);
        }

        public override string ToString()
        {
            return $"Box\t (H = {H})";
        }

        public bool Add(Shape shape) 
        {
            _freeSpace -= shape.Volume();
            if (_freeSpace >= 0)
            {
                Shapes.Add(shape);
                return true;
            }
            else
                return false;    
        }
    }
}
