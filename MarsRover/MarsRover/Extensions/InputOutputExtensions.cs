namespace MarsRover.Extensions
{
    using System;
    using System.Collections.Generic;
    using Exceptions;
    using Model;

    public static class InputOutputExtensions
    {
        public static Rover ToRover(this string roverInput)
        {
            var splitRoverInput = roverInput.Split(' ');

            var coordinate = ToCoordinate(splitRoverInput[0], splitRoverInput[1]);
            var direction = splitRoverInput[2].ToDirection();

            return new Rover(coordinate, direction);
        }

        public static MovementInstructions ToMovementInstructions(this string movementInstructionsInput)
        {
            var movementInstructions = new List<Movement>();
            foreach (var movementInput in movementInstructionsInput)
            {
                movementInstructions.Add(movementInput.ToMovement());
            }

            return new MovementInstructions(movementInstructions);
        }

        public static List<string> ToRoverOutput(this List<Rover> rovers)
        {
            var outputList = new List<string>();

            foreach (var rover in rovers)
            {
                outputList.Add($"{rover.Coordinate.X} {rover.Coordinate.Y} {rover.Direction.ToDirectionOutput()}");
            }

            return outputList;
        }

        public static Movement ToMovement(this char movementInput)
        {
            switch (movementInput)
            {
                case 'L': return Movement.SpinLeft;
                case 'R': return Movement.SpinRight;
                case 'M': return Movement.MoveForward;
                default:  throw new InvalidInputException();
            }
        }

        public static Direction ToDirection(this string directionInput)
        {
            switch (directionInput)
            {
                case "N": return Direction.North;
                case "S": return Direction.South;
                case "E": return Direction.East;
                case "W": return Direction.West;
                default: throw new InvalidInputException();
            }
        }

        public static char ToDirectionOutput(this Direction direction)
        {
            
            
            
            switch (direction)
            {
                case Direction.North: return 'N';
                case Direction.South: return 'S';
                case Direction.East: return 'E';
                case Direction.West: return 'W';
                default:  throw new InvalidInputException();
            }
        }

        public static Coordinate ToCoordinate(string firstInput, string secondInput)
        {
            try
            {
                var x = Convert.ToUInt32(firstInput);
                var y = Convert.ToUInt32(secondInput);

                return new Coordinate(x, y);
            }
            catch (FormatException)
            {
                throw new InvalidInputException();
            }
        }
    }
}
