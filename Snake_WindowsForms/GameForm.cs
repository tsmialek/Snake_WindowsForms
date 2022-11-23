
namespace Snake_WindowsForms
{
    public partial class GameForm : Form
    {
        private Board gameBoard = new Board();
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameBoard.Draw(this);
            this.KeyDown += new KeyEventHandler(OnKeyPress);
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {

            //drop the whole switch to Board class
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    gameBoard.Snake[0].Location = new Point(gameBoard.Snake[0].Location.X + gameBoard.TickSize, gameBoard.Snake[0].Location.Y);
                    break;
                case "Left":
                    gameBoard.Snake[0].Location = new Point(gameBoard.Snake[0].Location.X - gameBoard.TickSize, gameBoard.Snake[0].Location.Y);
                    break;
                case "Up":
                    gameBoard.Snake[0].Location = new Point(gameBoard.Snake[0].Location.X, gameBoard.Snake[0].Location.Y - gameBoard.TickSize);
                    break;
                case "Down":
                    gameBoard.Snake[0].Location = new Point(gameBoard.Snake[0].Location.X, gameBoard.Snake[0].Location.Y + gameBoard.TickSize);
                    break;
            }
        }
    }
}