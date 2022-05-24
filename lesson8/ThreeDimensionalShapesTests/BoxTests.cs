using System;
using Xunit;
using ThreeDimensionalShapes;

namespace ThreeDimensionalShapesTests
{
    public class BoxTests
    {
        [Theory] 
        [InlineData(2, 8.0)] 
        [InlineData(0, 0)]
        public void BoxVolumeValueTest(int Heigth, double expectedValue)
        {
            var shape = new Box(Heigth);
            Assert.Equal(expectedValue, shape.Volume());
        }

        [Fact]
        public void BoxVolumeExceptionTest()
        {
            var exc = Assert.Throws<IncorrectValuesException>( () => new Box(-1));
            Assert.Equal("Heigth less than zero", exc.Message);
        }

        [Fact]
        public void BoxToStringTest()
        {
            var shape = new Box(6);
            Assert.Equal("Box\t (H = 6)", shape.ToString());
        }

        [Theory] 
        [InlineData(2, 2, false)] 
        [InlineData(2, 1, true)]
        [InlineData(0, 0, true)]
        public void BoxAddTest(int containerHeigth, int ballRadius, bool expectedValue)
        {
            var shape = new Box(containerHeigth);
            Assert.Equal(expectedValue, shape.Add(new Ball(ballRadius)));
        }
    }
}
