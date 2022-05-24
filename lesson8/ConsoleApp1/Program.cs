using System;

namespace PolygonPerimetr
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4];
            points[0] = new (2, 1, 'A');
            points[1] = new (5, 4, 'B'); 
            points[2] = new (7, 4, 'C');
            points[3] = new (7, 1, 'D');

            Polygon shape = new Polygon(points);  
  
           Console.WriteLine($"For figure with point{(shape.Points.Length > 1 ? "s" : "")}");
           foreach (var point in shape.Points)
            Console.WriteLine($"{point}");

           if (shape.Perimetr() > 0)          
                Console.WriteLine($"perimetr = {shape.Perimetr()}");
           else
                Console.WriteLine("perimetr not define");

            Console.ReadKey();
        }
    }
}
