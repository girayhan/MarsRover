namespace MarsRover
{
    using System;
    using System.Collections.Generic;
    using Extensions;
    using Model;

    class Program
    {
        static void Main(string[] args)
        {
            string[] plateauInput = Console.ReadLine()?.Split(' ');

            var expeditionPlanList = new List<(Rover rover, MovementInstructions instructions)>();
            while (true)
            {
                var roverInput = Console.ReadLine();
                if(string.IsNullOrEmpty(roverInput))
                    break;

                var rover = roverInput.ToRover();

                var instructionsInput = Console.ReadLine();
                if(string.IsNullOrEmpty(instructionsInput))
                    break;

                var instructions = instructionsInput.ToMovementInstructions();

                expeditionPlanList.Add((rover, instructions));
            }

            var resultRovers = new MarsRoverExpedition(expeditionPlanList).Run();
            var resultRoverOutputs = resultRovers.ToRoverOutput();

            foreach (var resultRoverOutput in resultRoverOutputs)
            {
                Console.WriteLine(resultRoverOutput);
            }
        }
    }
}
