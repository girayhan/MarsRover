namespace MarsRover.Model
{
    public class Rover
    {
        public Rover(Coordinate coordinate, Direction direction)
        {
            this.Coordinate = coordinate;
            this.Direction = direction;
        }

        public Coordinate Coordinate { get; set; }
        public Direction Direction { get; set; }

        public void MoveForward()
        {
            switch (this.Direction)
            {
                case Direction.East: 
                    this.Coordinate.X++;
                    break;
                case Direction.West:
                    this.Coordinate.X--;
                    break;
                case Direction.North:
                    this.Coordinate.Y++;
                    break;
                case Direction.South:
                    this.Coordinate.Y--;
                    break;
            }
        }

        public void SpinLeft()
        {
            switch (this.Direction)
            {
                case Direction.East:
                    this.Direction = Direction.North;
                    break;
                case Direction.West:
                    this.Direction = Direction.South;
                    break;
                case Direction.North:
                    this.Direction = Direction.West;
                    break;
                case Direction.South:
                    this.Direction = Direction.East;
                    break;
            }
        }

        public void SpinRight()
        {
            switch (this.Direction)
            {
                case Direction.East:
                    this.Direction = Direction.South;
                    break;
                case Direction.West:
                    this.Direction = Direction.North;
                    break;
                case Direction.North:
                    this.Direction = Direction.East;
                    break;
                case Direction.South:
                    this.Direction = Direction.West;
                    break;
            }
        }
    }
}