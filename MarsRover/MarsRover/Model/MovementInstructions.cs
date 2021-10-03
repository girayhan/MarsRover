namespace MarsRover.Model
{
    using System.Collections.Generic;

    public class MovementInstructions
    {
        public MovementInstructions(List<Movement> movements)
        {
            this.Movements = movements;
        }

        public List<Movement> Movements { get; set; }
    }
}