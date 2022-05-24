using System;

namespace ThreeDimensionalShapes
{
    public class Ball : Shape
    {
        public int Radius {get; }         
        
        public Ball(int Radius)
        {
            if (Radius < 0)
                throw new IncorrectValuesException("Radius less than zero");
            this.Radius = Radius;
        }

        public override double Volume()
        {
            return (Math.Pow(Radius, 3) * Math.PI * 1.3333);
        }

        public override string ToString()
        {
            return $"Ball\t (R = {Radius})";
        }
    }
}
