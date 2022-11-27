namespace Snake_WindowsForms
{
    internal class Fruit
    {
        private Point _fruitPosition = new Point();
        public Fruit(Form currentForm, int width, int height, int TickSize)
        {
            var fruit = new PictureBox()
            {
                Location = FruitPosition(width, height, TickSize),
                BackColor = Color.Yellow,
                Size = new Size(39, 39)
            };

            currentForm.Controls.Add(fruit);
        }
        
        private Point FruitPosition(int width, int height, int TickSize)
        {
            var tmp1 = new Random();
            var tmp2 = new Random();
            _fruitPosition = new Point(tmp1.Next(0, width - 1) * TickSize + 1, tmp2.Next(0, height - 1) * TickSize + 1);

            return _fruitPosition;
        }
    }
}
