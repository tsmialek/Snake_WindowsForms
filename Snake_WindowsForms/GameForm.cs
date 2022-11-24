
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
            gameBoard.Snake[0].Location = Control.Move(e.KeyCode.ToString(), gameBoard.Snake[0].Location, gameBoard.TickSize);
        }
    }
}