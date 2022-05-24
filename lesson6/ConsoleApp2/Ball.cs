using System;

namespace ThreeDimensionalShapes
{
    class Ball : Shape
    {
        public int R {get; }         
        
        public Ball(int R)
        {
            this.R = R;
        }

        public override double Volume()
        {
            return (Math.Pow(R, 3) * Math.PI * 1.3333);
        }

        public override string ToString()
        {
            return $"Ball\t (R = {R})";
        }
    }
}
