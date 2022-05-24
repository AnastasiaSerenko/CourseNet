namespace PolygonPerimetr
{
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public char Name { get; }
  
        public Point(int X, int Y, char Name) {
            this.X = X;
            this.Y = Y;
            this.Name = Name;
        }

        public override string ToString()
        {
            return $"{Name}({X}, {Y})";
        }
    }
}
