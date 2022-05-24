using Xunit;
using PolygonPerimetr;

namespace PolygonPerimetrTests
{
    public class PolygonTests
    {
        [Fact]
        public void PerimetrTests()
        {            
            Point[] points = new Point[4];
            points[0] = new(2, 1, 'A');
            points[1] = new(5, 4, 'B');
            points[2] = new(7, 4, 'C');
            points[3] = new(7, 1, 'D');

            var shape = new Polygon(points);

            Assert.Equal(14.242640687119284, shape.Perimetr());
        }
    }
}
