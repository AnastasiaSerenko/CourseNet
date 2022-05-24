using System;

namespace ThreeDimensionalShapes
{
    class Program
    {
        static Shape RandShape(int maxNumber) 
        {
            Random random = new();

            switch (random.Next(0, 4)) 
            {
                case 0:
                    return new Box(random.Next(1, maxNumber));

                case 1:
                    return new Cylinder(random.Next(1, maxNumber), random.Next(1, maxNumber));

                case 2:
                    return new Pyramid(random.Next(1, maxNumber), random.Next(1, maxNumber));

                case 3:
                default:
                    return new Ball(random.Next(1, maxNumber)); 
            }
        }

        static void Main(string[] args)
        {
            Box box = new(10);
            Shape shape = RandShape(10);

            while (box.Add(shape)) 
                shape = RandShape(10);

            if (box.Shapes.Count > 0) 
            {
                Console.WriteLine($"{box} consist of\n");
                foreach (Shape item in box.Shapes)
                    Console.WriteLine(item);
            }           
            else 
                Console.WriteLine($"{box} is empty");

            Console.ReadKey();
        }
    }
}
