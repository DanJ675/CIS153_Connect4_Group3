using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Game
    {

        private int maxValue = 1000;


        public void nextComputerMove()
        {
            //playerNum = 0 -- regardless if I start or not
            //max score 1000, each depth +10, 0, -10
            //My first turn, place a piece randomly
            //My second turn, try to place a piece near the first 
            //third turn, find if I have 2 in a row. If I do, try to place a third in the same row. If I can't, try to block human
            //find if I have 3 pieces in row and try to win. If I can't win then block human or find a new empty space.
            //repeat above until I win. Death to human! (or the game is over)
        }

        private void scoreMoves()
        {
            //int score = 0;
            //score horizontal positions
            //score vertical positions
            //score positive diagonals
            //score negative diagonals

            //return score;
        }

        public static bool checkWinner(Square[,] square, int player)
        {
            bool winner = false;

            //check for horizontal winner
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r,c].getPlayerNum() == player &&
                        square[r,c + 1].getPlayerNum() == player &&
                        square [r,c + 2].getPlayerNum() == player&&
                        square [r,c + 3].getPlayerNum() == player)
                    {
                        winner = true;
                    }
                }
            }

            //check for vertical winner
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c].getPlayerNum() == player &&
                        square[r + 2, c].getPlayerNum() == player &&
                        square[r + 3, c].getPlayerNum() == player)
                    {
                        winner = true;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c + 1].getPlayerNum() == player &&
                        square[r + 2, c + 2].getPlayerNum() == player &&
                        square[r + 3, c + 3].getPlayerNum() == player)
                    {
                        winner = true;
                    }
                }
            }

            //check for upward diagonal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c - 1].getPlayerNum() == player &&
                        square[r + 2, c - 2].getPlayerNum() == player &&
                        square[r + 3, c - 3].getPlayerNum() == player)
                    {
                        winner = true;
                    }
                }
            }


            return winner;
        }



    }
}
