namespace MarsRover.Test.UnitTests
{
    using Model;
    using Xunit;

    public class RoverSpinLeftTests
    {
        [Theory, InlineData(1, 2, Direction.East)]
        public void SpinRoverLeftWhenDirectionIsEast(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.SpinLeft();
            Assert.Equal(Direction.North, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.West)]
        public void SpinRoverLeftWhenDirectionIsWest(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.SpinLeft();
            Assert.Equal(Direction.South, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.North)]
        public void SpinRoverLeftWhenDirectionIsNorth(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.SpinLeft();
            Assert.Equal(Direction.West, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.South)]
        public void SpinRoverLeftWhenDirectionIsSouth(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.SpinLeft();
            Assert.Equal(Direction.East, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }
    }
}
