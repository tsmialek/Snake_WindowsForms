
namespace Snake_WindowsForms
{
    internal class Control
    {
        private int _dirX = 0;
        private int _dirY = 0;

        public int DirX{ get { return _dirX; } }
        public int DirY{ get { return _dirY; } }

        //changing the directions on key press
        public void Move(string keyCode)
        {
            switch (keyCode)
            {
                case "Right":
                    _dirX = 1;
                    _dirY = 0;
                    break;
                case "Left":
                    _dirX = -1;
                    _dirY = 0;
                    break;
                case "Up":
                    _dirX = 0;
                    _dirY = -1;
                    break;
                case "Down":
                    _dirX = 0;
                    _dirY = 1;
                    break;
            }
        }
        
        //changing the actual snake head position based on the directions from Move()
        public Point Update(int TickSize, Point position)
        {
            position.X = position.X + _dirX * TickSize;
            position.Y = position.Y + _dirY * TickSize;
            return position;
        }

    }
}
