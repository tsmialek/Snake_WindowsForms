
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
            //game timer setup 
            gameTimer.Tick += new EventHandler(_update);
            gameTimer.Interval = 300;
            gameTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initializing all needed components on form load
            gameBoard.CreateSnake(this);
            fruit = new Fruit(this, gameBoard.Width, gameBoard.Height, gameBoard.TickSize);
            gameBoard.Draw(this);
            this.KeyDown += OnKeyPress;
        }

        //changing head directions on arrow press
        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            gameControls.Move(e.KeyCode.ToString());
        }

        //updating the board on timer tick
        private void _update(object MyObject, EventArgs eventArgs)
        {
            var SnakeHead = gameBoard.Snake[0].Location;
            gameBoard.Snake[0].Location = gameControls.Update(gameBoard.TickSize, gameBoard.Snake[0].Location);

            //checking if snake ate the fruit
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

            //snake and the map borders collision detection
            else if (SnakeHead.X > (gameBoard.Width - 1) * gameBoard.TickSize || SnakeHead.X < 0 || SnakeHead.Y > (gameBoard.Height - 1) * gameBoard.TickSize || SnakeHead.Y < 0)
            {
                gameTimer.Stop();
                this.Controls.Clear();
                throw new Exception($"Uderzy³eœ w krawêdŸ mapy! Twój wynik to: {gameBoard.Snake.Count - 2}");
            }

            //snake and his body collision detection
            for (int i = 2; i < gameBoard.Snake.Count; i++)
            {
                if (SnakeHead == gameBoard.Snake[i].Location)
                {
                    gameTimer.Stop();
                    this.Controls.Clear();
                    throw new Exception($"W¹¿ zjad³ sam siebie! Twój wynik to: {gameBoard.Snake.Count - 2}");
                }
            }
            
            gameBoard.SnakeMovement();
        }
    }
}