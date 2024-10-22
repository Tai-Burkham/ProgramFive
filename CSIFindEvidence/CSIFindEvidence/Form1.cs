using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSIFindEvidenceGame
{
    public partial class EvidenceGameForm : Form
    {
        private EvidenceScanner evidenceScanner;

        public EvidenceGameForm()
        {
            InitializeComponent();
            ShowInstructions();
        }

        private void ShowInstructions()
        {
            MessageBox.Show("Welcome to the Evidence Finder Game!\n" +
                            "Enter the dimensions for the search grid (max 10x10).\n" +
                            "Make your guesses to find the samples. Good luck!");
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Validate and parse grid size inputs
            int rows, columns;
            if (!int.TryParse(txtRows.Text, out rows) || !int.TryParse(txtColumns.Text, out columns) ||
                rows <= 0 || columns <= 0 || rows > 10 || columns > 10)
            {
                MessageBox.Show("Please enter valid dimensions (1-10). Defaulting to 5x5.");
                rows = columns = 5;
            }

            evidenceScanner = new EvidenceScanner(rows, columns);
            txtGridDisplay.Text = evidenceScanner.DisplayGrid();
            lblFeedback.Text = "Game started! Enter your first guess.";
            lblGuesses.Text = "Number of guesses: 0";
        }

        private void btnSubmitGuess_Click(object sender, EventArgs e)
        {
            if (evidenceScanner == null || evidenceScanner.AllSamplesFound())
            {
                MessageBox.Show("Game is over. Please restart to play again.");
                return;
            }

            int guessRow, guessCol;
            if (!int.TryParse(txtGuessRow.Text, out guessRow) || !int.TryParse(txtGuessCol.Text, out guessCol) ||
                guessRow < 0 || guessCol < 0 || guessRow >= evidenceScanner.Rows || guessCol >= evidenceScanner.Columns)
            {
                MessageBox.Show("Guess out of bounds! Please try again.");
                return;
            }

            bool sampleFound = evidenceScanner.EvaluateGuess(guessRow, guessCol);
            txtGridDisplay.Text = evidenceScanner.DisplayGrid();

            lblFeedback.Text = sampleFound ? "Sample found!" : "Keep looking!";
            lblGuesses.Text = $"Number of guesses: {evidenceScanner.GuessCount}";

            if (evidenceScanner.AllSamplesFound())
            {
                lblFeedback.Text = "Success! You've found both samples.";
                btnRestart.Enabled = true;
                btnSubmitGuess.Enabled = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtGridDisplay.Clear();
            lblFeedback.Text = "Game reset! Enter grid size and start again.";
            btnSubmitGuess.Enabled = true;
            btnRestart.Enabled = false;
            txtRows.Clear();
            txtColumns.Clear();
            lblGuesses.Text = "Number of guesses: 0";
            evidenceScanner = null; // Reset the game state
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (evidenceScanner != null)
            {
                MessageBox.Show($"Sample locations were:\n{evidenceScanner.GetSampleLocations()}");
            }
            Application.Exit();
        }
    }

    public class EvidenceScanner
    {
        private string[,] grid;
        private int rows;
        private int columns;
        private int guessCounter;
        private int[] sample1;
        private int[] sample2;
        private Random random;

        public int Rows => rows;
        public int Columns => columns;
        public int GuessCount => guessCounter;

        public EvidenceScanner(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.grid = new string[rows, columns];
            this.random = new Random();
            InitializeGrid();
            PlaceSamples();
            guessCounter = 0;
        }

        private void InitializeGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    grid[i, j] = "~"; // Initialize the grid with squiggly lines
                }
            }
        }

        private void PlaceSamples()
        {
            sample1 = new int[] { random.Next(rows), random.Next(columns) };
            do
            {
                sample2 = new int[] { random.Next(rows), random.Next(columns) };
            } while (sample1[0] == sample2[0] && sample1[1] == sample2[1]); // Ensure different locations
        }

        public string DisplayGrid()
        {
            string result = "  ";
            for (int i = 0; i < columns; i++)
            {
                result += i.ToString();  // Column headers
            }
            result += "\n";

            for (int i = 0; i < rows; i++)
            {
                result += i.ToString() + " ";  // Row headers
                for (int j = 0; j < columns; j++)
                {
                    result += grid[i, j];  // Grid content
                }
                result += "\n";
            }

            return result;
        }

        public bool EvaluateGuess(int guessRow, int guessCol)
        {
            guessCounter++;

            if (guessRow == sample1[0] && guessCol == sample1[1] ||
                guessRow == sample2[0] && guessCol == sample2[1])
            {
                grid[guessRow, guessCol] = "X";  // Mark sample found
                return true;
            }
            else
            {
                // Provide directional feedback
                if (guessCounter % 2 == 0)  // Even guess: Check above/below
                {
                    grid[guessRow, guessCol] = (guessRow > sample1[0] || guessRow > sample2[0]) ? "^" : "v";
                }
                else  // Odd guess: Check left/right
                {
                    grid[guessRow, guessCol] = (guessCol < sample1[1] || guessCol < sample2[1]) ? ">" : "<";
                }

                return false;
            }
        }

        public bool AllSamplesFound()
        {
            return grid[sample1[0], sample1[1]] == "X" && grid[sample2[0], sample2[1]] == "X";
        }

        public string GetSampleLocations()
        {
            return $"Sample 1: ({sample1[0]}, {sample1[1]})\nSample 2: ({sample2[0]}, {sample2[1]})";
        }
    }
}
