

using System.Text;

namespace Snake_WindowsForms
{
    internal class Control
    {
        public static Point Move(string keyCode, Point position, int TickkSize)
        {
            switch (keyCode)
            {
                case "Right":
                    position = new Point(position.X + TickkSize, position.Y);
                    return position;
                case "Left":
                    position = new Point(position.X - TickkSize, position.Y);
                    return position;
                case "Up":
                    position = new Point(position.X, position.Y - TickkSize);
                    return position;
                case "Down":
                    position = new Point(position.X, position.Y + TickkSize);
                    return position;
                default: 
                    return position;
            }
        }
    }
}
