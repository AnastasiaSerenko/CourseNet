using System;

namespace ThreeDimensionalShapes
{
    class Cylinder : Shape
    {
        public int H { get; }
        public int R { get; }

        public Cylinder (int H, int R)
        {
            this.H = H;
            this.R = R;
        } 

        public override double Volume()
        {
            return Math.Pow(R, 2) * H * Math.PI;
        }

        public override string ToString()
        {
            return $"Cylinder (H = {H}, R = {R})";
        }
    }
}
