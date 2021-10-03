namespace MarsRover.Test.IntegrationTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Model;
    using Xunit;

    public class MarsRoverTest
    {
        [Theory, ClassData(typeof(MarsRoverTestData))]
        public void MarsRoverExpeditionTest(List<(Rover rover, MovementInstructions instructions)> expeditionPlanList)
        {
            var resultRovers = new MarsRoverExpedition(expeditionPlanList).Run();
            Assert.Equal(2, resultRovers.Count);

            Assert.Equal((uint)1, resultRovers.First().Coordinate.X);
            Assert.Equal((uint)3, resultRovers.First().Coordinate.Y);
            Assert.Equal(Direction.North, resultRovers.First().Direction);

            Assert.Equal((uint)5,         resultRovers.Last().Coordinate.X);
            Assert.Equal((uint)1,         resultRovers.Last().Coordinate.Y);
            Assert.Equal(Direction.East, resultRovers.Last().Direction);
        }
    }

    public class MarsRoverTestData : TheoryData<List<(Rover rover, MovementInstructions instructions)>>
    {
        public MarsRoverTestData()
        {
            this.Add(new List<(Rover rover, MovementInstructions instructions)>()
            {
                (new Rover(new Coordinate(1, 2), Direction.North),
                 new MovementInstructions(new List<Movement>
                 {
                     Movement.SpinLeft, Movement.MoveForward, Movement.SpinLeft, Movement.MoveForward, Movement.SpinLeft, Movement.MoveForward,
                     Movement.SpinLeft, Movement.MoveForward, Movement.MoveForward
                 })),
                (new Rover(new Coordinate(3, 3), Direction.East),
                 new MovementInstructions(new List<Movement>
                 {
                     Movement.MoveForward, Movement.MoveForward, Movement.SpinRight, Movement.MoveForward, Movement.MoveForward, Movement.SpinRight,
                     Movement.MoveForward, Movement.SpinRight, Movement.SpinRight, Movement.MoveForward
                 }))
            });
        }
    }
}