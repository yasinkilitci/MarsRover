using System;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Plateau plateauOne = new Plateau(new Position(5, 5));
            Rover firstRover = new Rover(plateauOne, new Position(1, 2), Directions.N);
            firstRover.Process("LMLMLMLMM");


            Plateau plateauTwo = new Plateau(new Position(5, 5));
            Rover secondRover = new Rover(plateauTwo, new Position(3, 3), Directions.E);
            secondRover.Process("MMRMMRMRRM");

            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());
        }
    }
}
