namespace Snake_WindowsForms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var gameBoard = new Board();
            gameBoard.Initialize(this);
        }
    }
}