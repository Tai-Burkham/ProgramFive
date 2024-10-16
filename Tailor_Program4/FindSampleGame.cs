// FindSampleGame Class
// Tailor Burkham

using System;
using System.Windows.Forms;

namespace Program4
{
    public class FindSampleGame
    {
        private char[,] grid; // The grid for the game
        private int firstSampleRow; // Row of the first sample
        private int firstSampleCol; // Column of the first sample
        private int secondSampleRow; // Row of the second sample
        private int secondSampleCol; // Column of the second sample
        private int guessCounter; // Count of guesses made
        private bool firstSampleFound; // Status of the first sample
        private bool secondSampleFound; // Status of the second sample

        public FindSampleGame()
        {
            StartGame();
        }

        public void StartGame()
        {
            guessCounter = 0;
            firstSampleFound = false;
            secondSampleFound = false;

            Random random = new Random();

            // Initialize the grid size
            int rows = 5;
            int cols = 10;
            grid = new char[rows, cols];

            // Fill the grid with squiggly lines
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = '~'; // Set initial grid state
                }
            }

            // Randomly place the first sample
            do
            {
                firstSampleRow = random.Next(rows);
                firstSampleCol = random.Next(cols);
            } while (grid[firstSampleRow, firstSampleCol] == 'X');

            // Randomly place the second sample
            do
            {
                secondSampleRow = random.Next(rows);
                secondSampleCol = random.Next(cols);
            } while (grid[secondSampleRow, secondSampleCol] == 'X' ||
                     (secondSampleRow == firstSampleRow && secondSampleCol == firstSampleCol));
        }

        public bool ProcessGuess(int row, int col)
        {
            // Validate the guess
            if (row < 0 || row >= grid.GetLength(0) || col < 0 || col >= grid.GetLength(1))
            {
                MessageBox.Show("Guess out of bounds. Try again.");
                return false;
            }

            guessCounter++;

            // Check if the guess matches either sample
            if (row == firstSampleRow && col == firstSampleCol)
            {
                grid[row, col] = 'X'; // Mark the first sample as found
                firstSampleFound = true; // Update status to true
                return true; // Indicate a sample was found
            }
            else if (row == secondSampleRow && col == secondSampleCol)
            {
                grid[row, col] = 'X'; // Mark the second sample as found
                secondSampleFound = true; // Update status to true
                return true; // Indicate a sample was found
            }

            // Provide hints based on the nearest sample
            char hint;
            if (guessCounter % 2 == 1) // Odd guesses: check left/right (columns)
            {
                // Calculate distance to both samples
                int distanceToFirstSample = Math.Abs(col - firstSampleCol);
                int distanceToSecondSample = Math.Abs(col - secondSampleCol);

                if (distanceToFirstSample < distanceToSecondSample)
                {
                    // Hint based on the first sample
                    hint = (col < firstSampleCol) ? '>' : '<'; // Move right or left
                }
                else
                {
                    // Hint based on the second sample
                    hint = (col < secondSampleCol) ? '>' : '<'; // Move right or left
                }
            }
            else // Even guesses: check up/down (rows)
            {
                // Calculate distance to both samples
                int distanceToFirstSample = Math.Abs(row - firstSampleRow);
                int distanceToSecondSample = Math.Abs(row - secondSampleRow);

                if (distanceToFirstSample < distanceToSecondSample)
                {
                    // Hint based on the first sample
                    hint = (row < firstSampleRow) ? 'V' : '^'; // Move down or up
                }
                else
                {
                    // Hint based on the second sample
                    hint = (row < secondSampleRow) ? 'V' : '^'; // Move down or up
                }
            }

            // Update the grid with the hint
            grid[row, col] = hint; // Place hint in the grid
            return false; // Indicate no sample was found
        }

        public char[,] GetGrid()
        {
            return grid;
        }

        public int GetGuessCount()
        {
            return guessCounter;
        }

        public bool SamplesFound()
        {
            return firstSampleFound && secondSampleFound;
        }
    }
}

