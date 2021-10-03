namespace MarsRover.Model
{
    public class Coordinate
    {
        public Coordinate(uint x, uint y)
        {
            this.X = x;
            this.Y = y;
        }

        public uint X { get; set; }
        public uint Y { get; set; }
    }
}