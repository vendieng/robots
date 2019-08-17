using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotsssss
{
    public class Robot
    {
        public int X { get; private set; } 
        public int Y { get; private set; }
        private int gridSize;

        //private set so that the user can't set the position but it does set, get is called to find out what the position is

        //creating attributes for the robot - here, position

        public Robot(int x, int y, int gridSize)
        {
            this.X = x;
            this.Y = y;
            this.gridSize = gridSize;

            //inside a class, this always refers to the attributes of the class
        }

        //create method to move robot in four directionsn

        public void MoveUp()
        {
            if (Y >= 1)
                //if y is more than or equal to 1 (because the grid is upside down) it moves up
            {
                Y--;
            }
        }

        public void MoveDown()
        {

            if (Y < gridSize)
            {
                Y++;
            }
        }

        public void MoveLeft()
        {
            if (X >= 1)
            {
                X--;
            }
        }

        public void MoveRight()
        {
            if (X < gridSize)
            {
                X++;
            }
        }
    }
}
