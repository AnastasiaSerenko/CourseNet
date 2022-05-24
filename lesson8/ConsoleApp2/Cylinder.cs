using System;

namespace ThreeDimensionalShapes
{
    public class Cylinder : Shape
    {
        public int Heigth { get; }
        public int Radius { get; }

        public Cylinder (int Heigth, int Radius)
        {
            if (Radius < 0 || Heigth < 0)
                throw new IncorrectValuesException("Radius or heigth less than zero");

            this.Heigth = Heigth;
            this.Radius = Radius;
        } 

        public override double Volume()
        {
            return Math.Pow(Radius, 2) * Heigth * Math.PI;
        }

        public override string ToString()
        {
            return $"Cylinder (H = {Heigth}, R = {Radius})";
        }
    }
}
