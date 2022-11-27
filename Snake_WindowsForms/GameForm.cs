
namespace Snake_WindowsForms
{
    public partial class GameForm : Form
    {
        private Board gameBoard = new Board();
        private Control gameControls = new Control();
        private Fruit fruit;

        public GameForm()
        {
            InitializeComponent();
            gameTimer.Tick += new EventHandler(_update);
            gameTimer.Interval = 300;
            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameBoard.CreateSnake(this);
            fruit = new Fruit(this, gameBoard.Width, gameBoard.Height, gameBoard.TickSize);
            gameBoard.Draw(this);
            this.KeyDown += OnKeyPress;
            //gameBoard.CreateSnake(this);
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            //gameBoard.Snake[0].Location = Control.Move(e.KeyCode.ToString(), gameBoard.Snake[0].Location, gameBoard.TickSize);
            gameControls.Move(e.KeyCode.ToString());
        }

        private void _update(object MyObject, EventArgs eventArgs)
        {
            var SnakeHead = gameBoard.Snake[0].Location;
            gameBoard.Snake[0].Location = gameControls.Update(gameBoard.TickSize, gameBoard.Snake[0].Location);

            if (SnakeHead == fruit.FruitPosition)
            {
                fruit.FruitRemove(this);
                gameBoard.CreateSnake(this);
                fruit = new Fruit(this, gameBoard.Width, gameBoard.Height, gameBoard.TickSize);

                for (int i = 0; i < gameBoard.Snake.Count; i++)
                {
                    if (fruit.FruitPosition == gameBoard.Snake[i].Location)
                    {
                        fruit.FruitRemove(this);
                        fruit = new Fruit(this, gameBoard.Width, gameBoard.Height, gameBoard.TickSize);
                    }
                }
            }
            else if (SnakeHead.X > gameBoard.Width * gameBoard.TickSize || SnakeHead.X < 0 || SnakeHead.Y > gameBoard.Height * gameBoard.TickSize || SnakeHead.Y < 0)
                throw new Exception($"Uderzy³eœ w krawêdŸ mapy! Twój wynik to: {gameBoard.Snake.Count - 2}");


            for (int i = 2; i < gameBoard.Snake.Count; i++)
            {
                if (SnakeHead == gameBoard.Snake[i].Location)
                    throw new Exception($"W¹¿ zjad³ sam siebie! Twój wynik to: {gameBoard.Snake.Count - 2}");
            }
            
            gameBoard.SnakeMovement();
        }
    }
}