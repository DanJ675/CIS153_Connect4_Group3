using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Game
    {
        private Player player1;
        private Player player2;
        private Board board = new Board();
        public Game(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
            Board board = new Board();
            board.getBoard();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board.getBoard();
                }
            }

        }


        public void nextComputerMove(Board board)
        {
            Square[,] square = new Square[7, 6];   //  Creates the square
            square = board.getBoard(); // Fills the square with the board information

            //check for pieces in a row
            if (threePlusTwo(square)) //sends the square with the board information to threePlusTwo
            {
                return;
            }
            else if (twoPlusTwo(square)) //sends the square with the board information to twoPlusTwo
            {
                return;
            }
            else if (onePlusTwo(square)) //sends the square with the board information to onePlueTwo
            {
                return;
            }


        }

        public int checkWinner(Square[,] square) //check for 4 in a row winner after board updates
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[r, c].getPlayerNum() == 1 &&
                        square[r, c + 1].getPlayerNum() == 1 &&
                        square[r, c + 2].getPlayerNum() == 1 &&
                        square[r, c + 3].getPlayerNum() == 1)
                    {
                        return 1; //returns player 1 won
                    }
                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r, c + 1].getPlayerNum() == 2 &&
                        square[r, c + 2].getPlayerNum() == 2 &&
                        square[r, c + 3].getPlayerNum() == 2)
                    {
                        return 2; //returns player 2 won
                    }
                }
            }

            //check for vertical winner
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 1 &&
                        square[r + 1, c].getPlayerNum() == 1 &&
                        square[r + 2, c].getPlayerNum() == 1 &&
                        square[r + 3, c].getPlayerNum() == 1)
                    {
                        return 1; //returns player 1 won
                    }
                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r + 1, c].getPlayerNum() == 2 &&
                        square[r + 2, c].getPlayerNum() == 2 &&
                        square[r + 3, c].getPlayerNum() == 2)
                    {
                        return 2; //returns player 2 won
                    }
                }
            }

            ////check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 1 &&
                        square[r + 1, c + 1].getPlayerNum() == 1 &&
                        square[r + 2, c + 2].getPlayerNum() == 1 &&
                        square[r + 3, c + 3].getPlayerNum() == 1)
                    {
                        return 1; //returns player 1 won
                    }

                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r + 1, c + 1].getPlayerNum() == 2 &&
                        square[r + 2, c + 2].getPlayerNum() == 2 &&
                        square[r + 3, c + 3].getPlayerNum() == 2)
                    {
                        return 2; //returns player 2 won
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 1 &&
                        square[r + 1, c - 1].getPlayerNum() == 1 &&
                        square[r + 2, c - 2].getPlayerNum() == 1 &&
                        square[r + 3, c - 3].getPlayerNum() == 1)
                    {
                        return 1; //returns player 1 won
                    }

                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r + 1, c - 1].getPlayerNum() == 2 &&
                        square[r + 2, c - 2].getPlayerNum() == 2 &&
                        square[r + 3, c - 3].getPlayerNum() == 2)
                    {
                        return 2; //returns player 2 won
                    }
                }
            }

            //is the board full ?
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0)
                    {
                        return 0;
                    }
                }
            }


            return 0;
        }

        public bool threePlusTwo(Square[,] square)  // we know we are player 2 becase this is for the ai
        {
            //check for horizontal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 2 &&
                        square[r, c + 2].getPlayerNum() == 2 &&
                        square[r, c + 3].getPlayerNum() == 0 &&
                        square[r, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c + 4].getPlayerNum() != 0 &&
                                    square[r - 1, c + 3].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 3].setPlayerNum(2); // make move
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 1 &&
                        square[r, c + 2].getPlayerNum() == 1 &&
                        square[r, c + 3].getPlayerNum() == 0 &&
                        square[r, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c + 4].getPlayerNum() != 0 &&
                                    square[r - 1, c + 3].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 3].setPlayerNum(2);  //make move to block
                        return true; //successful move, stop three plus two;
                    }
                }
            }

            //check for vertical
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 2 &&
                        square[r + 2, c].getPlayerNum() == 2 &&
                        square[r + 3, c].getPlayerNum() == 0 &&
                        square[r + 4, c].getPlayerNum() == 0)
                    {
                            square[r + 3, c].setPlayerNum(2); //make move
                            return true; //successful move, stop three plus two
                    }

                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 1 &&
                        square[r + 2, c].getPlayerNum() == 1 &&
                        square[r + 3, c].getPlayerNum() == 0 &&
                        square[r + 4, c].getPlayerNum() == 0)
                    {
                            square[r + 3, c].setPlayerNum(2); //block
                            return true; //successful move, stop three plus two
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 2 &&
                        square[r + 2, c + 2].getPlayerNum() == 2 &&
                        square[r + 3, c + 3].getPlayerNum() == 0 &&
                        square[r + 4, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r + 2, c + 3].getPlayerNum() != 0 &&
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 3, c + 3].setPlayerNum(2); // make move
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 1 &&
                        square[r + 2, c + 2].getPlayerNum() == 1 &&
                        square[r + 3, c + 3].getPlayerNum() == 0 &&
                        square[r + 4, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r + 2, c + 3].getPlayerNum() != 0 &&
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 3, c + 3].setPlayerNum(2); // block
                        return true; //successful move, stop three plus two;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 2 &&
                        square[r - 2, c + 2].getPlayerNum() == 2 &&
                        square[r - 3, c + 3].getPlayerNum() == 0 &&
                        square[r - 4, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 4, c + 3].getPlayerNum() != 0 &&
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 3, c + 3].setPlayerNum(2); // make move
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 1 &&
                        square[r - 2, c + 2].getPlayerNum() == 1 &&
                        square[r - 3, c + 3].getPlayerNum() == 0 &&
                        square[r - 4, c + 4].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 4, c + 3].getPlayerNum() != 0 &&
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 3, c + 3].setPlayerNum(2); // block
                        return true; //successful move, stop three plus two;
                    }
                }
            }
            return false;
        }



        public bool twoPlusTwo(Square[,] square)
        {
            //check for horizontal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 2 &&
                        square[r, c + 2].getPlayerNum() == 2 &&
                        square[r, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c + 3].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 1 &&
                        square[r, c + 2].getPlayerNum() == 1 &&
                        square[r, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c + 3].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 2].setPlayerNum(2);  //make move to block
                        return true; //successful move, stop two plus two;
                    }
                }
            }

            //check for vertical 
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 2 &&
                        square[r + 2, c].getPlayerNum() == 2 &&
                        square[r + 3, c].getPlayerNum() == 0)
                    {
                            square[r + 2, c].setPlayerNum(2); //make move
                            return true; //successful move, stop two plus two;
                    }

                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 1 &&
                        square[r + 2, c].getPlayerNum() == 1 &&
                        square[r + 3, c].getPlayerNum() == 0)
                    {
                            square[r + 2, c].setPlayerNum(2); //block
                            return true; //successful move, stop two plus two;
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 2 &&
                        square[r + 2, c + 2].getPlayerNum() == 2 &&
                        square[r + 3, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop two plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 1 &&
                        square[r + 2, c + 2].getPlayerNum() == 1 &&
                        square[r + 3, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop two plus two;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 2 &&
                        square[r - 2, c + 2].getPlayerNum() == 2 &&
                        square[r - 3, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop two plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 1 &&
                        square[r - 2, c + 2].getPlayerNum() == 1 &&
                        square[r - 3, c + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop two plus two;
                    }
                }
            }
            return false;
        }







        public bool onePlusTwo(Square[,] square)
        {
            //check for horizontal 
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 3; c++) 
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 2 &&
                        square[r, c + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r - 1, c + 2].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r, c + 1].getPlayerNum() == 1 &&
                        square[r, c + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 &&
                                    square[r - 1, c + 2].getPlayerNum() != 0 &&
                                    square[r - 1, c].getPlayerNum() != 0)))

                    {
                        square[r, c + 2].setPlayerNum(2);  //make move to block
                        return true; //successful move, stop one plus two;
                    }
                }
            }

            //check for vertical 
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 2 &&
                        square[r + 2, c].getPlayerNum() == 0)
                    {
                        square[r + 2, c].setPlayerNum(2); //make move
                        return true; //successful move, stop one plus two;
                    }

                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c].getPlayerNum() == 1 &&
                        square[r + 2, c].getPlayerNum() == 0)
                    {
                        square[r + 2, c].setPlayerNum(2); //block
                        return true; //successful move, stop one plus two;
                    }
                }
            }

            //check for upward diagonal
            for (int r = 3; r < 6; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 2 &&
                        square[r + 2, c + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r + 1, c + 1].getPlayerNum() == 1 &&
                        square[r + 2, c + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r + 1, c + 2].getPlayerNum() != 0 &&
                                    square[r, c + 1].getPlayerNum() != 0)))

                    {
                        square[r + 2, c + 2].setPlayerNum(2); // block
                        return true; //successful move, stop one plus two;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 4; c < 7; c++)
                {
                    if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 2 &&
                        square[r - 2, c + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 && 
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 2, c + 2].setPlayerNum(2); // make move
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[r, c].getPlayerNum() == 0 &&
                        square[r - 1, c + 1].getPlayerNum() == 1 &&
                        square[r - 2, c + 2].getPlayerNum() == 1 &&
                        (r == 0 || (square[r - 1, c].getPlayerNum() != 0 &&
                                    square[r - 3, c + 2].getPlayerNum() != 0 &&
                                    square[r - 2, c + 1].getPlayerNum() != 0)))

                    {
                        square[r - 2, c + 2].setPlayerNum(2); // block
                        return true; //successful move, stop one plus two;
                    }
                }
            }
            return false;
        }










    }
}
