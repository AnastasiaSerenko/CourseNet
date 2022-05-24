using Xunit;
using PolygonPerimetr;

namespace PolygonPerimetrTests
{
    public class PointTests
    {
        [Fact]
        public void PointToStringTest()
        {
            var point = new Point(1, 2, 'A');

            Assert.Equal("A(1, 2)", point.ToString());
        }
    }
}
