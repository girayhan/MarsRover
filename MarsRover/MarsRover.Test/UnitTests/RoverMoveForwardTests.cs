namespace MarsRover.Test.UnitTests
{
    using Model;
    using Xunit;

    public class RoverMoveForwardTests
    {
        [Theory, InlineData(1, 2, Direction.East)]
        public void MoveRoverForwardWhenDirectionIsEast(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.MoveForward();
            Assert.Equal(Direction.East, rover.Direction);
            Assert.Equal((uint)2, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.West)]
        public void MoveRoverForwardWhenDirectionIsWest(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.MoveForward();
            Assert.Equal(Direction.West, rover.Direction);
            Assert.Equal((uint)0, rover.Coordinate.X);
            Assert.Equal((uint)2, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.North)]
        public void MoveRoverForwardWhenDirectionIsNorth(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.MoveForward();
            Assert.Equal(Direction.North, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)3, rover.Coordinate.Y);
        }

        [Theory, InlineData(1, 2, Direction.South)]
        public void MoveRoverForwardWhenDirectionIsSouth(uint x, uint y, Direction direction)
        {
            var rover = new Rover(new Coordinate(x, y), direction);
            rover.MoveForward();
            Assert.Equal(Direction.South, rover.Direction);
            Assert.Equal((uint)1, rover.Coordinate.X);
            Assert.Equal((uint)1, rover.Coordinate.Y);
        }
    }
}