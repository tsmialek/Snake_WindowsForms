

namespace Snake_WindowsForms
{
    internal class Board
    {
        public int TickSize { get; } = 40;
        public int Width { get; set; } = 14;
        public int Height { get; set; } = 14;

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

            CreateSnake();
            foreach (var part in Snake)
            {
                currentForm.Controls.Add(part);
            }
        }

        public void CreateSnake()
        {
            Snake.Add(new PictureBox()
            {
                Image = Image.FromFile(@"G:\Visual_Studio\repos\Snake_WindowsForms\Snake_WindowsForms\Graphics\head_right.png")
            });
        }
    }
}
