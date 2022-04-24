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
            //for(int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        board.getBoard();
            //    }
            //}
        }
        public void setActivePlayerNum(int i) { activePlayerNum = i; }
        public int getActivePlayerNum() { return activePlayerNum; }
        public Square[,] onClick(int playerNum, int col) 
        {
            
            square = board.getShowBoard();
            square = board.onClick(playerNum, col);
            return square;
        }
        public Square[,] getSquare()
        {
            return square;
        }
        public void nextComputerMove(Square[,] square)
        {
            //square = board.getBoard(); // Fills the square with the board information

            //check for pieces in a row
            if(threePlusTwo(square)) //sends the square with the board information to the threePlusTwoMoveAttempt
            {
                return;
            }
            //else if (threePlusTwo(square, 1)) //blocker if player 1 has 3 in a row
            //{
            //    checkWinner(square, player);
            //}
            //else if (twoPlusTwo(square, player))
            //{
            //    checkWinner(square, player);
            //}
            //else if (twoPlusTwo(square, 1))
            //{
            //    checkWinner(square, player);
            //}
            //else if (onePlusTwo(square, player))
            //{
            //    checkWinner(square, player);
            //}


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
            //for (int r = 3; r < 6; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == player &&
            //            square[r + 1, c + 1].getPlayerNum() == player &&
            //            square[r + 2, c + 2].getPlayerNum() == player &&
            //            square[r + 3, c + 3].getPlayerNum() == player)
            //        {
            //            winner = player;
            //        }
            //    }
            //}

            ////check for downward diagonal
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 4; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == player &&
            //            square[r + 1, c - 1].getPlayerNum() == player &&
            //            square[r + 2, c - 2].getPlayerNum() == player &&
            //            square[r + 3, c - 3].getPlayerNum() == player)
            //        {
            //            winner = player;
            //        }
            //    }
            //}

            //is the board full ?
            //for (int r = 0; r < 6; r++)
            //{
            //    for (int c = 0; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == 0)
            //        {
            //            return 0;
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
            //ai checking for three in a row. 1st time through is for the ai to win, second time through is to block the human player
            //bool moveMade = false;
            //check for horizontal 3
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 3; c++) //this search is 5 long, but dont do the negative thing. you just search shorter
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

            ////////////////// This is the end of the code. Hopefully this is enough for you to update the rest.
            /// I will be on Saturday too.

            ////check for vertical 3
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 0; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == player &&
            //            square[r + 1, c].getPlayerNum() == player &&
            //            square[r + 2, c].getPlayerNum() == player)
            //        {
            //            if (square[r + 3, c].getPlayerNum() == 0)
            //            {
            //                //if the square above is empty
            //                square[r + 3, c].setPlayerNum(computer);
            //                moveMade = true;
            //            }
            //        }
            //    }
            //}

            ////check for upward diagonal
            //for (int r = 3; r < 6; r++)
            //{
            //    for (int c = 0; c < 3; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == player &&
            //            square[r + 1, c + 1].getPlayerNum() == player &&
            //            square[r + 2, c + 2].getPlayerNum() == player)
            //        {
            //            if(square[r + 3, c + 3].getPlayerNum() == 0)
            //            {
            //                square[r + 3, c + 3].setPlayerNum(computer);
            //                moveMade = true;
            //            }
            //            if(square[r - 1,c - 1].getPlayerNum() == 0)
            //            {
            //                square[r - 1, c - 1].setPlayerNum(computer);
            //                moveMade = true;
            //            }
            //        }
            //    }
            //}

            ////check for downward diagonal
            //for (int r = 0; r < 3; r++)
            //{
            //    for (int c = 4; c < 7; c++)
            //    {
            //        if (square[r, c].getPlayerNum() == player &&
            //            square[r + 1, c - 1].getPlayerNum() == player &&
            //            square[r + 2, c - 2].getPlayerNum() == player)
            //        {
            //            if (square[r + 3, c - 3].getPlayerNum() == 0)
            //            {
            //                square[r + 3, c - 3].setPlayerNum(computer);
            //                moveMade = true;
            //            }
            //            if (square[r - 1, c + 1].getPlayerNum() == 0)
            //            {
            //                square[r - 1, c + 1].setPlayerNum(computer);
            //                moveMade = true;
            //            }
            //        }
            //    }
            //}

            //return moveMade;
            return false;
        }



        //public bool twoPlusTwo(Square[,] square, int player)
        //{
        //    //checks for 2 in a row. First time through is for the ai to place a piece to continue, second time through is to block the human
        //    bool moveMade = false;
        //    //check for horizontal 2
        //    for (int r = 0; r < 6; r++)
        //    {
        //        for (int c = 0; c < 4; c++)
        //        {
        //            if (square[r, c].getPlayerNum() == player &&
        //                square[r, c + 1].getPlayerNum() == player)
        //            {
        //                if (square[r - 1, c + 2].getPlayerNum() != 0 && square[r, c + 2].getPlayerNum() == 0 && square[r , c + 3].getPlayerNum() == 0)
        //                {
        //                    //if the square after the 2 found has a piece under it
        //                    square[r, c + 2].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                if (square[r - 1, c - 1].getPlayerNum() != 0 && square[r, c + 2].getPlayerNum() == 0 && square[r, c - 1].getPlayerNum() == 0)
        //                {
        //                    //if the square before the 2 found has a piece under it
        //                    square[r, c + 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //            }
        //        }
        //    }

        //    //check for vertical 2
        //    for (int r = 0; r < 3; r++)
        //    {
        //        for (int c = 0; c < 7; c++)
        //        {
        //            if (square[r, c].getPlayerNum() == player &&
        //                square[r + 1, c].getPlayerNum() == player)
        //            {
        //                if (square[r + 2, c].getPlayerNum() == 0 && square[r + 3, c].getPlayerNum() == 0)
        //                {
        //                    //if the square above is empty
        //                    square[r + 2, c].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //            }
        //        }
        //    }

        //    //check for upward diagonal
        //    for (int r = 3; r < 6; r++)
        //    {
        //        for (int c = 0; c < 3; c++)
        //        {
        //            if (square[r, c].getPlayerNum() == player &&
        //                square[r + 1, c + 1].getPlayerNum() == player)
        //            {
        //                if (square[r + 2, c + 2].getPlayerNum() == 0 && square[r + 3, c + 3].getPlayerNum() == 0 && square[r + 1, c + 2].getPlayerNum() != 0)
        //                {
        //                    square[r + 2, c + 2].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                if (square[r - 1, c - 1].getPlayerNum() == 0 && square[r - 2, c - 1].getPlayerNum() != 0 && square[r + 2, c + 2].getPlayerNum() == 0)
        //                {
        //                    square[r - 1, c - 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //            }
        //        }
        //    }

        //    //check for downward diagonal
        //    for (int r = 0; r < 3; r++)
        //    {
        //        for (int c = 4; c < 7; c++)
        //        {
        //            if (square[r, c].getPlayerNum() == player &&
        //                square[r + 1, c - 1].getPlayerNum() == player)
        //            {
        //                if (square[r + 2, c - 2].getPlayerNum() == 0 && square[r + 3, c - 3].getPlayerNum() == 0 && square[r + 2, c - 3].getPlayerNum() != 0)
        //                {
        //                    square[r + 2, c - 2].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                if (square[r - 1, c + 1].getPlayerNum() == 0 && square[r + 2, c - 2].getPlayerNum() == 0 && square[r - 2, c + 1].getPlayerNum() != 0)
        //                {
        //                    square[r - 1, c + 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //            }
        //        }
        //    }

        //    return moveMade;

        //}



        //public bool onePlusTwo(Square[,] square, int player)
        //{
        //    //checks for 1 plus 2 empty in a row, ai will place a piece next to the previous
        //    bool moveMade = false;
        //    //check for horizontal
        //    for (int r = 0; r < 6; r++)
        //    {
        //        for (int c = 0; c < 4; c++)
        //        {
        //            if (square[r, c].getPlayerNum() == player)
        //            {
        //                if (square[r + 1, c].getPlayerNum() == 0)
        //                {
        //                    //vertical
        //                    square[r + 1, c].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                else if (square[r, c + 1].getPlayerNum() == 0 && square[r, c + 2].getPlayerNum() == 0 && square[r - 1, c + 1].getPlayerNum() != 0)
        //                {
        //                    square[r, c + 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                else if (square[r + 1, c + 1].getPlayerNum() == 0 && square[r + 2, c + 2].getPlayerNum() == 0 && square[r + 1, c].getPlayerNum() != 0)
        //                {
        //                    square[r + 1, c + 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //                else if (square[r + 1, c - 1].getPlayerNum() == 0 && square[r + 2, c - 2].getPlayerNum() == 0 && square[r + 1, c -2].getPlayerNum() != 0)
        //                {
        //                    square[r + 1, c - 1].setPlayerNum(computer);
        //                    moveMade = true;
        //                }
        //            }
        //        }
        //    }




        //    return moveMade;
        //}










    }
}
