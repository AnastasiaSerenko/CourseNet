using System;
using System.Collections.Generic;

namespace ThreeDimensionalShapes
{
    public class Box : Shape
    {
        public int Heigth { get; }
        public List<Shape> Shapes { get; }
        private double _freeSpace;

        public Box(int Heigth) 
        {
            if (Heigth < 0)
                throw new IncorrectValuesException("Heigth less than zero");

            this.Heigth = Heigth;
            Shapes = new List<Shape>();
            _freeSpace = Volume();
        }

        public override double Volume() 
        {
            return Math.Pow(Heigth, 3);
        }

        public override string ToString()
        {
            return $"Box\t (H = {Heigth})";
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
