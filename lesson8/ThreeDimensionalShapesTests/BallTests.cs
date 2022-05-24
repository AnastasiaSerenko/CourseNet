using System;
using Xunit;
using ThreeDimensionalShapes;

namespace ThreeDimensionalShapesTests
{
    public class BallTests
    {         
        [Theory] 
        [InlineData(2, 33.509483880250166)] 
        [InlineData(0, 0)]
        public void BallVolumeValueTest(int Radius, double expectedValue)
        {
            var shape = new Ball(Radius);
            Assert.Equal(expectedValue, shape.Volume());
        }

        [Fact]
        public void BallVolumeExceptionTest()
        {
            var exc = Assert.Throws<IncorrectValuesException>( () => new Ball(-1));
            Assert.Equal("Radius less than zero", exc.Message);
        }        
        
        [Fact]
        public void BallToStringTest()
        {
            var shape = new Ball(6);
            Assert.Equal("Ball\t (R = 6)", shape.ToString());
        }
    }
}
