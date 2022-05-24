namespace ThreeDimensionalShapes
{
    public class Pyramid : Shape
    {
        public int Heigth { get; }
        public int Square { get; }

        public Pyramid(int Heigth, int Square)
        {
            if (Heigth < 0 || Square < 0)
                throw new IncorrectValuesException("Heigth or square less than zero");

            this.Heigth = Heigth;
            this.Square = Square;
        }

        public override double Volume()
        {
            return Heigth * Square * 0.3333;
        }

        public override string ToString()
        {
            return $"Pyramid\t (H = {Heigth}, S = {Square})";
        }
    }
}
