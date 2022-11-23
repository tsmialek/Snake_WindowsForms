
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
        }

        private void OnKeyPress(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode.ToString())
            {
                case "Right":

                    break;
                case "Left":

                    break;
                case "Up":

                    break;
                case "Down":

                    break;
            }
        }
    }
}