// Program 4
// Tailor Burkham

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program4
{
    public partial class Program4 : Form
    {
        private FindSampleGame game;

        public Program4()
        {
            InitializeComponent();
            game = new FindSampleGame();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            // Retrieve user input for row and column
            if (int.TryParse(txtRows.Text, out int row) && int.TryParse(txtCols.Text, out int col))
            {
                if (row < 0 || row >= 5 || col < 0 || col >= 10) // Ensure row and col are within valid range
                {
                    MessageBox.Show("Please enter valid row (0-4) and column (0-9) numbers.");
                    return;
                }

                if (!game.ProcessGuess(row, col))
                {
                    UpdateGrid(); // Update the grid if the guess is incorrect
                }
                else
                {
                    // Check if both samples have been found
                    if (game.SamplesFound())
                    {
                        MessageBox.Show("Congratulations! You've found both samples! Press Restart to play again.");
                        // Optionally, disable the guess button or implement additional logic here
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid row and column numbers.");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            game.StartGame();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            // Clear Grid
            txtGrid.Clear();

            char[,] currentGrid = game.GetGrid();

            // Column headers
            string header = "  ";
            for (int col = 0; col < currentGrid.GetLength(1); col++)
            {
                header += col % 10; // Adds column numbers
            }
            txtGrid.AppendText(header + Environment.NewLine);

            // Grid display
            for (int r = 0; r < currentGrid.GetLength(0); r++)
            {
                // Add row index
                txtGrid.AppendText(r.ToString() + " ");
                for (int c = 0; c < currentGrid.GetLength(1); c++)
                {
                    txtGrid.AppendText(currentGrid[r, c].ToString());
                }
                txtGrid.AppendText(Environment.NewLine);
            }

            // Guess Count
            lblGuessCount.Text = $"Guesses: {game.GetGuessCount()}";
        }

        // Event handler for TextBox change (can be used for additional form control logic)
        private void InstructionsTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCols_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void contInstructions_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


