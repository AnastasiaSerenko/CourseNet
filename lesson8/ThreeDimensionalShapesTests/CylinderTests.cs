using System;
using Xunit;
using ThreeDimensionalShapes;

namespace ThreeDimensionalShapesTests
{
    public class CylinderTests
    {
        [Theory] 
        [InlineData(2, 4, 100.53096491487338)] 
        [InlineData(0, 1, 0)]
        public void CylinderVolumeValueTest(int Heigth, int Radius, double expectedValue)
        {
            var shape = new Cylinder(Heigth, Radius);
            Assert.Equal(expectedValue, shape.Volume());
        }

        [Fact]
        public void CylinderVolumeExceptionTest()
        {
            var exc = Assert.Throws<IncorrectValuesException>( () => new Cylinder(-1, 2));
            Assert.Equal("Radius or heigth less than zero", exc.Message);
        }

        [Fact]
        public void CylinderToStringTest()
        {
            var shape = new Cylinder(6, 1);
            Assert.Equal("Cylinder (H = 6, R = 1)", shape.ToString());
        }
    }
}
