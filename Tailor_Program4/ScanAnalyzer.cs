// ScanAnalyzer Class
// Tailor Burkham
using System;

public class ScanAnalyzer
{
    private char[,] grid;
    private int sample1Row;
    private int sample1Col;
    private int sample2Row;
    private int sample2Col;
    private int guessCount;
    private int rows;
    private int cols;

    public ScanAnalyzer(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        grid = new char[rows, cols];
        Random rand = new Random();

        // Randomly generate two different sample locations
        sample1Row = rand.Next(rows);
        sample1Col = rand.Next(cols);
        do
        {
            sample2Row = rand.Next(rows);
            sample2Col = rand.Next(cols);
        } while (sample1Row == sample2Row && sample1Col == sample2Col);

        // Initialize the grid with squiggly lines
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                grid[r, c] = '~';
            }
        }

        guessCount = 0;
    }

    public char[,] DisplayGrid()
    {
        return grid;
    }

    public bool EvaluateGuess(int guessRow, int guessCol)
    {
        // Validate the guess
        if (guessRow < 0 || guessRow >= rows || guessCol < 0 || guessCol >= cols)
        {
            Console.WriteLine("Guess out of bounds. Try again.");
            return false;
        }

        guessCount++;
        char symbol = ' ';

        // Check if the guess matches the first sample
        if (guessRow == sample1Row && guessCol == sample1Col)
        {
            symbol = 'X'; // Found the first sample
            grid[guessRow, guessCol] = symbol;
            return true; // Return true indicating first sample found
        }

        // Check if the guess matches the second sample
        if (guessRow == sample2Row && guessCol == sample2Col)
        {
            symbol = 'X'; // Found the second sample
            grid[guessRow, guessCol] = symbol;
            return true; // Return true indicating second sample found
        }

        // Determine direction hints based on guess count
        if (guessCount % 2 == 1) // Odd guesses - check left/right (columns)
        {
            if (guessCol < sample1Col)
            {
                symbol = '>'; // Right hint
            }
            else if (guessCol > sample1Col)
            {
                symbol = '<'; // Left hint
            }
        }
        else // Even guesses - check top/bottom (rows)
        {
            if (guessRow < sample1Row)
            {
                symbol = 'V'; // Down hint
            }
            else if (guessRow > sample1Row)
            {
                symbol = '^'; // Up hint
            }
        }

        grid[guessRow, guessCol] = symbol; // Place hint in the grid
        return false; // Wrong guess
    }

    public int GetGuessCount()
    {
        return guessCount;
    }
}
