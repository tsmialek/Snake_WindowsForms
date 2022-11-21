namespace Snake_WindowsForms
{
    internal class Border : Control
    {
        //readonly border size property
        private int _borderSize = 16;

        public int BorderSize => _borderSize;

        //border drawing method
        public void Draw(Form currentForm, int size)
        {
            if (size <= 5)
                throw new Exception("size parameter too small");

            int boxSize = 40; // size of single grid element
            for (int i = 0; i < size; i++) // top edge of the square
            {
                var tmp = new PictureBox()
                {
                    Name = $"BorderBox{i}",
                    Size = new Size(boxSize, boxSize),
                    Location = new Point(i * boxSize, 0),
                    BackColor = Color.Black
                };

                currentForm.Controls.Add(tmp);
            }

            for (int i = 0; i < size - 1; i++) // right edge
            {
                var tmp = new PictureBox()
                {
                    Name = $"BorderBox{i + size}",
                    Size = new Size(boxSize, boxSize),
                    Location = new Point((size - 1) * boxSize, (i * boxSize) + boxSize),
                    BackColor = Color.Black
                };

                currentForm.Controls.Add(tmp);
            }

            for (int i = 0; i < size - 1; i++) // bottom edge
            {
                var tmp = new PictureBox()
                {
                    Name = $"BorderBox{i + (2 * size) - 1}",
                    Size = new Size(boxSize, boxSize),
                    Location = new Point(i * boxSize, (size - 1)* boxSize),
                    BackColor = Color.Black
                };

                currentForm.Controls.Add(tmp);
            }

            for (int i = 0; i < size - 2; i++) // left edge
            {
                var tmp = new PictureBox()
                {
                    Name = $"BorderBox{i + (3 * size) - 2}",
                    Size = new Size(boxSize, boxSize),
                    Location = new Point(0, boxSize + (i * boxSize)),
                    BackColor = Color.Black
                };
                
                currentForm.Controls.Add(tmp);
            }
            _borderSize = size;
        }
    }
}
