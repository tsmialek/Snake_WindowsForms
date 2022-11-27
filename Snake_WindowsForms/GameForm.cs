
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
            gameTimer.Interval = 500;
            gameTimer.Start();
            fruit = new Fruit(this, gameBoard.Width, gameBoard.Height, gameBoard.TickSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameBoard.Draw(this);
            this.KeyDown += new KeyEventHandler(OnKeyPress);
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            //gameBoard.Snake[0].Location = Control.Move(e.KeyCode.ToString(), gameBoard.Snake[0].Location, gameBoard.TickSize);
            gameControls.Move(e.KeyCode.ToString());
        }

        private void _update(object MyObject, EventArgs eventArgs)
        {
            gameBoard.Snake[0].Location = gameControls.Update(gameBoard.TickSize, gameBoard.Snake[0].Location);
        }
    }
}