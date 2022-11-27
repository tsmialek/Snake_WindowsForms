

using System.Text;

namespace Snake_WindowsForms
{
    internal class Control
    {
        private int _dirX = 0;
        private int _dirY = 0;

        public void Move(string keyCode)
        {
            switch (keyCode)
            {
                case "Right":
                    //position = new Point(position.X + TickkSize, position.Y);
                    //return position;
                    _dirX = 1;
                    _dirY = 0;
                    break;
                case "Left":
                    //position = new Point(position.X - TickkSize, position.Y);
                    //return position;
                    _dirX = -1;
                    _dirY = 0;
                    break;
                case "Up":
                    //position = new Point(position.X, position.Y - TickkSize);
                    //return position;
                    _dirX = 0;
                    _dirY = -1;
                    break;
                case "Down":
                    //position = new Point(position.X, position.Y + TickkSize);
                    //return position;
                    _dirX = 0;
                    _dirY = 1;
                    break;
                default:
                    //return position;
                    break;
            }
        }
        
        //gotta add movement buffer
        public Point Update(int TickSize, Point position)
        {
            position.X = position.X + _dirX * TickSize;
            position.Y = position.Y + _dirY * TickSize;
            return position;
        }

    }
}
