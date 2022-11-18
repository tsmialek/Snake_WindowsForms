namespace Snake_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var Board = new Board();
            Board.Draw(this);
        }
    }
}