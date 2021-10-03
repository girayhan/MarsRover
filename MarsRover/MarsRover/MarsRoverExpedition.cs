namespace MarsRover
{
    using System.Collections.Generic;
    using System.Linq;
    using Model;

    public class MarsRoverExpedition
    {
        private readonly List<(Rover rover, MovementInstructions instructions)> expeditionPlanList;

        public MarsRoverExpedition(List<(Rover rover, MovementInstructions instructions)> expeditionPlanList)
        {
            this.expeditionPlanList = expeditionPlanList;
        }

        public List<Rover> Run()
        {
            foreach (var (rover, instructions) in this.expeditionPlanList)
            {
                foreach (var movement in instructions.Movements)
                {
                    switch (movement)
                    {
                        case Movement.MoveForward:
                            rover.MoveForward();
                            break;
                        case Movement.SpinLeft:
                            rover.SpinLeft();
                            break;
                        case Movement.SpinRight:
                            rover.SpinRight();
                            break;
                    }
                }
            }

            return this.expeditionPlanList.Select(ep => ep.rover).ToList();
        }
    }
}