using System;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public enum Cell
        {
            X = 'X', O = 'O', E = ' ', draw
        }
        public Cell[,] matrix = new Cell[3, 3];
        public int numOfCells = 0;
        public Cell IsGameOver = Cell.E;
        public TicTacToeGame()
        {

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrix[i, j] = Cell.E;
        }

        public void display()
        {
            Console.WriteLine("__________");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(matrix[i, 0] + " | " + matrix[i, 1] + " | " + matrix[i, 2]);
                Console.WriteLine("__________");
            }

        }

        public bool setsAMove(int i, int j, Cell cell)
        {
            if (i > 2 || j > 2 || matrix[i, j] != Cell.E)
            {
                Console.WriteLine("You must choose number from 0-2, without repeating");
                return false;
            }

            matrix[i, j] = cell;
            if (matrix[i, 0] == cell && matrix[i, 1] == cell && matrix[i, 2] == cell)
            {
                IsGameOver = cell;
                return true;
            }
            if (matrix[0, j] == cell && matrix[1, j] == cell && matrix[2, j] == cell)
            {
                IsGameOver = cell;
                return true;
            }
            if ((i == j) && matrix[0, 0] == cell && matrix[1, 1] == cell && matrix[2, 2] == cell)
            {
                IsGameOver = cell;
                return true;
            }
            if ((i + j == 2) && matrix[2, 0] == cell && matrix[1, 1] == cell && matrix[0, 2] == cell)
            {
                IsGameOver = cell;
                return true;
            }
            numOfCells++;
            if (numOfCells == 9)
                IsGameOver = Cell.draw;
            return true;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            var ticTacToeGame = new TicTacToeGame();

            TicTacToeGame.Cell cell = TicTacToeGame.Cell.X;
            while (ticTacToeGame.IsGameOver == TicTacToeGame.Cell.E)
            {
                Console.WriteLine("\nInsert [i,j] coordinations between 0-2");
                try
                {
                    i = int.Parse(Console.ReadLine());
                    j = int.Parse(Console.ReadLine());

                    if (!ticTacToeGame.setsAMove(i, j, cell)) continue;
                    else if (cell == TicTacToeGame.Cell.X)
                        cell = TicTacToeGame.Cell.O;
                    else
                        cell = TicTacToeGame.Cell.X;
                    ticTacToeGame.display();
                }
                catch(Exception ie)
                {
                    ie.StackTrace.ToString();
                }                                 
            }
            
            if (ticTacToeGame.IsGameOver == TicTacToeGame.Cell.draw)
                Console.WriteLine("Draw");
            else
                Console.WriteLine("Congratulations " + ticTacToeGame.IsGameOver + " WON");
        }
       
    }
}
