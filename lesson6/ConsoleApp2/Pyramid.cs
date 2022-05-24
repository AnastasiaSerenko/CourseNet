namespace ThreeDimensionalShapes
{
    class Pyramid : Shape
    {
        public int H { get; }
        public int S { get; }

        public Pyramid(int H, int S)
        {
            this.H = H;
            this.S = S;
        }

        public override double Volume()
        {
            return H * S * 0.3333;
        }

        public override string ToString()
        {
            return $"Pyramid\t (H = {H}, S = {S})";
        }
    }
}
