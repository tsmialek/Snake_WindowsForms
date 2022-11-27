namespace Snake_WindowsForms
{
    internal class Fruit
    {
        private Point _fruitPosition;
        public Point FruitPosition { get { return _fruitPosition; } }
        private PictureBox _fruit;

        //Initializing the "fruit" picture box
        public Fruit(Form currentForm, int width, int height, int TickSize)
        {
            _fruit = new PictureBox()
            {
                Location = GenerateFruitPosition(width, height, TickSize),
                BackColor = Color.Yellow,
                Size = new Size(39, 39),
                Name = "fruit"
            };

            currentForm.Controls.Add(_fruit);
        }

        //removing existing fruit from the board
        public void FruitRemove(Form currentForm)
        {
            currentForm.Controls.Remove(_fruit);
        }
        
        //generating random fruit position
        private Point GenerateFruitPosition(int width, int height, int tickSize)
        {
            var tmp1 = new Random();
            var tmp2 = new Random();
            _fruitPosition = new Point(tmp1.Next(0, width - 1) * tickSize + 1, tmp2.Next(0, height - 1) * tickSize + 1);

            return _fruitPosition;
        }
    }
}
