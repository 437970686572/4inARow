using System;

namespace _4inARow
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new(7,6);

            Console.WriteLine(board.ToString());

            Console.ReadLine();
        }

        private bool DoMove(int player)
        {
            return true;
        }

        private void Game(Board board)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                //Do a Move for each player
                for (int i = 0; i < 2; i++)
                {
                    int row;
                    row = int.Parse(Console.ReadLine());
                    DoMove(i + 1);

                    if (board.CheckForWin())
                    {
                        keepGoing = false;
                    }
                }
            }
        }
    }
}
