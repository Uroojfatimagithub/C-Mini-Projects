using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int x , int y)
        {
            this.X = x;
            this.Y =y;                       //here we are repeating in setting the values of x and y its just two variables 
            //but sometimes when there is too much data ita not a good idea to repeat the same conceptin two places so what we can do is to make this move method call the other move method this way we can set x and y in only one place let
        }
        public void Move(int x ,int y)
        {
            this.X = x;
            this.Y = y;
        } 
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X,newLocation.Y);
            //this.X = newLocation.X;
           //this.Y = newLocation.Y;
        }
    }
}
