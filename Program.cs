using System;
using MarsRover;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {


            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");


            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");

            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}