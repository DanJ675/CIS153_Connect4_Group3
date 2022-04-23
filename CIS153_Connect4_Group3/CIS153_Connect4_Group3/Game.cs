using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Game
    {
        private Board board = new Board();
        private int player;
        private int computer = 2;






        public void nextComputerMove(Square[,] square, int player)
        {
            //if the middle square is open, take it, or take the one above for the first move
            if (square[0, 3].getPlayerNum() == 0)
            {
                square[0, 3].setPlayerNum(computer);
            }
            else if (square[1,3].getPlayerNum() == 0)
            {
                square[1, 3].setPlayerNum(computer);
            }

            //check for pieces in a row
            if(threePlusTwo(square, player)) //places winning piece
            {
                checkWinner(square, player);
            }
            else if (threePlusTwo(square, 1)) //blocker if player 1 has 3 in a row
            {
                checkWinner(square, player);
            }
            else if (twoPlusTwo(square, player))
            {
                checkWinner(square, player);
            }
            else if (twoPlusTwo(square, 1))
            {
                checkWinner(square, player);
            }
            else if (onePlusTwo(square, player))
            {
                checkWinner(square, player);
            }


        }

        public static int checkWinner(Square[,] square, int player) //check for 4 in a row winner after board updates
        {
            int winner = 0;

            //check for horizontal winner
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r, c + 1].getPlayerNum() == player &&
                        square[r, c + 2].getPlayerNum() == player &&
                        square[r, c + 3].getPlayerNum() == player)
                    {
                        winner = player;
                    }
                }
            }

            //check for vertical winner
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c].getPlayerNum() == player &&
                        square[r + 2, c].getPlayerNum() == player &&
                        square[r + 3, c].getPlayerNum() == player)
                    {
                        winner = player;
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c + 1].getPlayerNum() == player &&
                        square[r + 2, c + 2].getPlayerNum() == player &&
                        square[r + 3, c + 3].getPlayerNum() == player)
                    {
                        winner = player;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c - 1].getPlayerNum() == player &&
                        square[r + 2, c - 2].getPlayerNum() == player &&
                        square[r + 3, c - 3].getPlayerNum() == player)
                    {
                        winner = player;
                    }
                }
            }

            //is the board full?
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0)
                    {
                        winner = 0;
                    }
                }
            }


            return winner;
        }

        public bool threePlusTwo(Square[,] square, int player)
        {
            //ai checking for three in a row. 1st time through is for the ai to win, second time through is to block the human player
            bool moveMade = false;
            //check for horizontal 3
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r, c + 1].getPlayerNum() == player &&
                        square[r, c + 2].getPlayerNum() == player)
                    {
                        if (square[r-1,c+3].getPlayerNum() == 0)
                        {
                            //if the square after the 3 found has a piece under it
                            square[r - 1, c + 3].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if (square[r - 1, c - 1].getPlayerNum() == 0)
                        {
                            //if the square before the 3 found has a piece under it
                            square[r - 1, c - 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for vertical 3
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c].getPlayerNum() == player &&
                        square[r + 2, c].getPlayerNum() == player)
                    {
                        if (square[r + 3, c].getPlayerNum() == 0)
                        {
                            //if the square above is empty
                            square[r + 3, c].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c + 1].getPlayerNum() == player &&
                        square[r + 2, c + 2].getPlayerNum() == player)
                    {
                        if(square[r + 3, c + 3].getPlayerNum() == 0)
                        {
                            square[r + 3, c + 3].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if(square[r - 1,c - 1].getPlayerNum() == 0)
                        {
                            square[r - 1, c - 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c - 1].getPlayerNum() == player &&
                        square[r + 2, c - 2].getPlayerNum() == player)
                    {
                        if (square[r + 3, c - 3].getPlayerNum() == 0)
                        {
                            square[r + 3, c - 3].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if (square[r - 1, c + 1].getPlayerNum() == 0)
                        {
                            square[r - 1, c + 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            return moveMade;

        }



        public bool twoPlusTwo(Square[,] square, int player)
        {
            //checks for 2 in a row. First time through is for the ai to place a piece to continue, second time through is to block the human
            bool moveMade = false;
            //check for horizontal 2
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r, c + 1].getPlayerNum() == player)
                    {
                        if (square[r - 1, c + 2].getPlayerNum() != 0 && square[r, c + 2].getPlayerNum() == 0 && square[r , c + 3].getPlayerNum() == 0)
                        {
                            //if the square after the 2 found has a piece under it
                            square[r, c + 2].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if (square[r - 1, c - 1].getPlayerNum() != 0 && square[r, c + 2].getPlayerNum() == 0 && square[r, c - 1].getPlayerNum() == 0)
                        {
                            //if the square before the 2 found has a piece under it
                            square[r, c + 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for vertical 2
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c].getPlayerNum() == player)
                    {
                        if (square[r + 2, c].getPlayerNum() == 0 && square[r + 3, c].getPlayerNum() == 0)
                        {
                            //if the square above is empty
                            square[r + 2, c].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c + 1].getPlayerNum() == player)
                    {
                        if (square[r + 2, c + 2].getPlayerNum() == 0 && square[r + 3, c + 3].getPlayerNum() == 0 && square[r + 1, c + 2].getPlayerNum() != 0)
                        {
                            square[r + 2, c + 2].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if (square[r - 1, c - 1].getPlayerNum() == 0 && square[r - 2, c - 1].getPlayerNum() != 0 && square[r + 2, c + 2].getPlayerNum() == 0)
                        {
                            square[r - 1, c - 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == player &&
                        square[r + 1, c - 1].getPlayerNum() == player)
                    {
                        if (square[r + 2, c - 2].getPlayerNum() == 0 && square[r + 3, c - 3].getPlayerNum() == 0 && square[r + 2, c - 3].getPlayerNum() != 0)
                        {
                            square[r + 2, c - 2].setPlayerNum(computer);
                            moveMade = true;
                        }
                        if (square[r - 1, c + 1].getPlayerNum() == 0 && square[r + 2, c - 2].getPlayerNum() == 0 && square[r - 2, c + 1].getPlayerNum() != 0)
                        {
                            square[r - 1, c + 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }

            return moveMade;

        }



        public bool onePlusTwo(Square[,] square, int player)
        {
            //checks for 1 plus 2 empty in a row, ai will place a piece next to the previous
            bool moveMade = false;
            //check for horizontal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[r, c].getPlayerNum() == player)
                    {
                        if (square[r + 1, c].getPlayerNum() == 0)
                        {
                            //vertical
                            square[r + 1, c].setPlayerNum(computer);
                            moveMade = true;
                        }
                        else if (square[r, c + 1].getPlayerNum() == 0 && square[r, c + 2].getPlayerNum() == 0 && square[r - 1, c + 1].getPlayerNum() != 0)
                        {
                            square[r, c + 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                        else if (square[r + 1, c + 1].getPlayerNum() == 0 && square[r + 2, c + 2].getPlayerNum() == 0 && square[r + 1, c].getPlayerNum() != 0)
                        {
                            square[r + 1, c + 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                        else if (square[r + 1, c - 1].getPlayerNum() == 0 && square[r + 2, c - 2].getPlayerNum() == 0 && square[r + 1, c -2].getPlayerNum() != 0)
                        {
                            square[r + 1, c - 1].setPlayerNum(computer);
                            moveMade = true;
                        }
                    }
                }
            }




            return moveMade;
        }










    }
}
