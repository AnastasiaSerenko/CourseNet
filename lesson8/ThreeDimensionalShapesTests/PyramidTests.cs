using System;
using Xunit;
using ThreeDimensionalShapes;

namespace ThreeDimensionalShapesTests
{
    public class PyramidTests
    {
        [Theory] 
        [InlineData(2, 4, 2.6664)] 
        [InlineData(0, 1, 0)]
        public void PyramidVolumeValueTest(int Heigth, int Square, double expectedValue)
        {
            var shape = new Pyramid(Heigth, Square);
            Assert.Equal(expectedValue, shape.Volume());
        }

        [Fact]
        public void PyramidVolumeExceptionTest()
        {
            var exc = Assert.Throws<IncorrectValuesException>( () => new Pyramid(-1, 2));
            Assert.Equal("Heigth or square less than zero", exc.Message);
        }

        [Fact]
        public void PyramidToStringTest()
        {
            var shape = new Pyramid(6, 1);
            Assert.Equal("Pyramid\t (H = 6, S = 1)", shape.ToString());
        }
    }
}
