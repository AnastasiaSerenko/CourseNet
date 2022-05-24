using System;

namespace PolygonPerimetr
{
    class Polygon
    {
        public Point[] Points { get; }
        
        public Polygon(params Point[] points)
        {
            Points = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
               Points[i] = points[i];            
        }

        double Length(Point point1, Point point2) 
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2)
                + Math.Pow((point2.Y - point1.Y), 2));
        }

        public double Perimetr() 
        {
            double result = 0;
            if (Points.Length > 2)
                for (int i = 0; i < Points.Length; i++)
                {
                    int j = i == Points.Length - 1 ? 0 : i + 1;
                    result += Length(Points[j], Points[i]);
                }
            else 
                result = -1;

            return result;
        }
    }
}
