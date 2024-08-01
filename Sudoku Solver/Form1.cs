namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        Board board = new Board();
        int selectedNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            board.Draw(graphics);
        }

        private void Update(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            board.Solve();
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            selectedNumber = int.Parse(((Button)sender).Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (e.X >= board.Cells[i, j].ColOffset * Cell.length && e.X <= board.Cells[i, j].ColOffset * Cell.length + Cell.length)
                    {
                        if (e.Y >= board.Cells[i, j].RowOffset * Cell.length && e.Y <= board.Cells[i, j].RowOffset * Cell.length + Cell.length)
                        {
                            board.Cells[i, j].Value = selectedNumber;
                        }
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedNumber = 0;
        }
    }
}
