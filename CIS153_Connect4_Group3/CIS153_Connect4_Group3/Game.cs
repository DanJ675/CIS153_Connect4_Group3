using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Game
    {
        private int activePlayerNum;
        private Player player1;
        private Player player2;
        private Square[,] square = new Square[7,6];
        private Board board = new Board();
        public Game(Player p1, Player p2)
        {
            activePlayerNum = 1;
            player1 = p1;
            player2 = p2;
            square = board.getBoard();

        }
        public void setActivePlayerNum(int i) { activePlayerNum = i; }
        public int getActivePlayerNum() { return activePlayerNum; }
        public int getPlayerNum(int row, int col)
        {
            Square[,] square = new Square[7, 6];
            square = board.getBoard();
            return square[col, row].getPlayerNum(); 
        }
        public Square[,] onClick(int playerNum, int col) 
        {
            //board.onClick
            //square = board.getBoard();
            //square = board.onClick(playerNum, col);-
            return board.onClick(playerNum, col); ;
        }
        public Square[,] onHover(int playerNum, int col)
        {

            //square = board.getShowBoard();
            //square = board.mouseHover(playerNum, col);
            return board.mouseHover(playerNum, col);
        }
        public Square[,] getSquare()
        {
            return board.getBoard();
        }
        public Square[,] getShowSquare()
        {
            return board.getShowBoard();
        }
        public Square[,] nextComputerMove()
        {
            //square = board.getBoard(); // Fills the square with the board information

            //check for pieces in a row
            //tree
            if (threePlusTwo(board.getBoard())) //sends the square with the board information to threePlusTwo
            {
                return board.getBoard();
            }
            else if (twoPlusTwo(board.getBoard())) //sends the square with the board information to twoPlusTwo
            {
                return board.getBoard();
            }
            else if (onePlusTwo(board.getBoard())) //sends the square with the board information to onePlueTwo
            {
                return board.getBoard();
            }

            return board.getBoard();
        }
        public bool checkDraw() //check for 4 in a row winner after board updates
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if(square[r,c].getPlayerNum() == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int checkWinner() //check for 4 in a row winner after board updates
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
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        return 1;
                    }
                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r, c + 1].getPlayerNum() == 2 &&
                        square[r, c + 2].getPlayerNum() == 2 &&
                        square[r, c + 3].getPlayerNum() == 2)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addLossVsAi();
                        }
                        else
                        {
                            player1.addLoss();
                        }
                        return 2;
                    }
                }
            }

            //check for vertical winner
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (square[r, c].getPlayerNum() == 1 &&
                        square[r + 1, c].getPlayerNum() == 1 &&
                        square[r + 2, c].getPlayerNum() == 1 &&
                        square[r + 3, c].getPlayerNum() == 1)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        return 1;
                    }
                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r + 1, c].getPlayerNum() == 2 &&
                        square[r + 2, c].getPlayerNum() == 2 &&
                        square[r + 3, c].getPlayerNum() == 2)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addLossVsAi();
                            player2.addWin();
                        }
                        else
                        {
                            player1.addLoss();
                            player2.addWin();
                        }
                        return 2;

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
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        return 1;
                    }

                    if (square[r, c].getPlayerNum() == 2 &&
                        square[r + 1, c + 1].getPlayerNum() == 2 &&
                        square[r + 2, c + 2].getPlayerNum() == 2 &&
                        square[r + 3, c + 3].getPlayerNum() == 2)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addLossVsAi();
                            player2.addWin();
                        }
                        else
                        {
                            player1.addLoss();
                            player2.addWin();
                        }
                        return 2;
                    }
                }
            }

            //check for downward diagonal
            //for (int r = 0; r < 7; r++)
            //{
            //    for (int c = 4; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == 1 &&
            //            square[r + 1, c - 1].getPlayerNum() == 1 &&
            //            square[r + 2, c - 2].getPlayerNum() == 1 &&
            //            square[r + 3, c - 3].getPlayerNum() == 1)
            //        {
            //            if (player2.getName() == "Computer")
            //            {
            //                player1.addWinVsAi();
            //            }
            //            else
            //            {
            //                player1.addWin();
            //            }
            //            return 1;
            //        }

            //        if (square[r, c].getPlayerNum() == 2 &&
            //            square[r + 1, c - 1].getPlayerNum() == 2 &&
            //            square[r + 2, c - 2].getPlayerNum() == 2 &&
            //            square[r + 3, c - 3].getPlayerNum() == 2)
            //        {
            //            if (player2.getName() == "Computer")
            //            {
            //                player1.addLossVsAi();
            //                player2.addWin();
            //            }
            //            else
            //            {
            //                player1.addLoss();
            //                player2.addWin();
            //            }
            //            return 2;
            //        }
            //    }
            //}
            return 0;
        }
        private void isBoardFull()
        {

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
                        (r == 0 || (square[r-1, c + 4].getPlayerNum() != 0 &&
                                    square[r-1, c + 3].getPlayerNum() != 0 &&
                                    square[r-1, c].getPlayerNum() != 0)))
                        
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
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 2 &&
            //            square[r + 2, c].getPlayerNum() == 2 &&
            //            square[r + 3, c].getPlayerNum() == 0 &&
            //            square[r + 4, c].getPlayerNum() == 0)
            //        {
            //            square[r + 3, c].setPlayerNum(2); //make move
            //            return true; //successful move, stop three plus two
            //        }

            //        else if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 1 &&
            //            square[r + 2, c].getPlayerNum() == 1 &&
            //            square[r + 3, c].getPlayerNum() == 0 &&
            //            square[r + 4, c].getPlayerNum() == 0)
            //        {
            //            square[r + 3, c].setPlayerNum(2); //block
            //            return true; //successful move, stop three plus two
            //        }
            //    }
            //}

            //check for upward diagonal
            for (int r = 0; r < 2; r++)
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
            for (int r = 5; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
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
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 2 &&
            //            square[r + 2, c].getPlayerNum() == 2 &&
            //            square[r + 3, c].getPlayerNum() == 0)
            //        {
            //            square[r + 2, c].setPlayerNum(2); //make move
            //            return true; //successful move, stop two plus two;
            //        }

            //        else if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 1 &&
            //            square[r + 2, c].getPlayerNum() == 1 &&
            //            square[r + 3, c].getPlayerNum() == 0)
            //        {
            //            square[r + 2, c].setPlayerNum(2); //block
            //            return true; //successful move, stop two plus two;
            //        }
            //    }
            //}

            //check for upward diagonal
            for (int r = 0; r < 3; r++)
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
            for (int r = 5; r < 3; r--)
            {
                for (int c = 0; c < 4; c++)
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
                for (int c = 0; c < 4; c++)
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
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 2 &&
            //            square[r + 2, c].getPlayerNum() == 0)
            //        {
            //            square[r + 2, c].setPlayerNum(2); //make move
            //            return true; //successful move, stop one plus two;
            //        }

            //        else if (square[r, c].getPlayerNum() == 0 &&
            //            square[r + 1, c].getPlayerNum() == 1 &&
            //            square[r + 2, c].getPlayerNum() == 0)
            //        {
            //            square[r + 2, c].setPlayerNum(2); //block
            //            return true; //successful move, stop one plus two;
            //        }
            //    }
            //}

            //check for upward diagonal
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
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
            for (int r = 5; r < 3; r--)
            {
                for (int c = 0; c < 4; c++)
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
