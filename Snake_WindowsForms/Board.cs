
namespace Snake_WindowsForms
{
    internal class Board : Form
    {
        public int TickSize { get; } = 40;
        public int Width { get; set; } = 15;
        public int Height { get; set; } = 15;

        public List<PictureBox> Snake = new List<PictureBox>(); 
        
        //drawing the board
        public void Draw(Form currentForm)
        {
            //vertical lines genereation
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

            //horizontal lines generation
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

        //creating the head of the snake
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

            //adding another snake head on top of the existing one bc of Movement algorithm malfunction. Temporary solution
            if(Snake.Count <= 1)
                CreateSnake(currentForm);

            currentForm.Controls.Add(snakePart);
        }

        //setting up the rest of the snake's movement
        public void SnakeMovement()
        {
            try
            {
                for (int i = Snake.Count - 1; i >= 1; i--)
                {
                    Snake[i].Location = Snake[i - 1].Location;
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("SnakeMovement function failed. Something went wron in setting picture box location");
            }
            catch(Exception)
            {
                MessageBox.Show("SnakeMovement Function failed. Don't know what's the case");
            }
        }

    }
}
