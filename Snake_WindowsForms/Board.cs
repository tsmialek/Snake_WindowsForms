
namespace Snake_WindowsForms
{
    internal class Board
    {
        public int TickSize { get; } = 40;
        public int Width { get; set; } = 15;
        public int Height { get; set; } = 15;

        public List<PictureBox> Snake = new List<PictureBox>(); 
        
        public void Draw(Form currentForm)
        {
            for (int i = 0; i <= Height; i++)
            {
                var vertical = new PictureBox()
                {
                    Size = new Size(Width * TickSize, 1),
                    BackColor = Color.Black,
                    Location = new Point(0,  TickSize * i)
                };

                vertical.BringToFront();
                currentForm.Controls.Add(vertical);
            }

            for (int i = 0; i <= Width; i++)
            {
                var horizontal = new PictureBox()
                {
                    Size = new Size(1,  Height * TickSize),
                    BackColor = Color.Black,
                    Location = new Point(TickSize * i, 0)
                };

                horizontal.BringToFront();
                currentForm.Controls.Add(horizontal);
            }


        }

        public void CreateSnake(Form currentForm)
        {
            PictureBox snakePart;
            snakePart = new PictureBox()
            {
                Size = new Size(39, 39),
                BackColor = Color.RoyalBlue,
                Location = new Point(1, 1)
            };

            Snake.Add(snakePart);

            if(Snake.Count <= 1)
                CreateSnake(currentForm);

            currentForm.Controls.Add(snakePart);
        }

        public void SnakeMovement()
        {
            //Snake[1].Location = new Point(Snake[0].Location.X - (dirX * TickSize), Snake[0].Location.Y - (dirY * TickSize));
            
            for (int i = Snake.Count - 1; i >= 1; i--)
            {
                Snake[i].Location = Snake[i - 1].Location;
            }
        }

    }
}
