using System;

namespace ThreeDimensionalShapes
{
    class Program
    {
        static Shape RandShape() 
        {
            Random random = new Random();
            int h = random.Next(1, 10),
                s = random.Next(1, 10),
                r = random.Next(1, 10), 
                numberShape = random.Next(0, 4);

            switch (numberShape) 
            {
                case 0:
                    return new Box(h);

                case 1:
                    return new Cylinder(h, r);

                case 2:
                    return new Pyramid(h, s);

                case 3:
                default:
                    return new Ball(r); 
            }
        }

        static void Main(string[] args)
        {
            Box box = new Box(30);
            Shape shape = RandShape();

            while (box.Add(shape)) 
                shape = RandShape();

            if (box.Shapes.Count > 0) 
            {
                Console.WriteLine($"{box} consist of\n");
                foreach (Shape item in box.Shapes)
                    Console.WriteLine(item);
            }           
            else 
                Console.WriteLine("Box is empty");

            Console.ReadKey();
        }
    }
}
