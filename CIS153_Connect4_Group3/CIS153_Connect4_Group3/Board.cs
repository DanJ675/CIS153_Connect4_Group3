//CIS_153_Final Project Connect 4 Group 3 
//Daniel Johnson
//Board Class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_Connect4_Group3
{
    class Board
    {
        Square[,] board = new Square[7, 6]; 
        public Board()
        {
            Square square = new Square();
            square.setPlayerNum(0);
            //initialize board to all empty
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    board[column, row] = square;
                }
            }

        }
        public Square[,] showNextMoveForColumn(int playerNum, int column)
        {
            Square[,] outBoard = new Square[7, 6];
            bool addedPiece = false;
            //fill from bottom up
            for(int c = 0; c < 7; c++)
            {
                for (int row = 0; row < 6; row++)
                {
                    if(c == column)
                    {
                        if (board[c, row].getPlayerNum() == 0 && !addedPiece)
                        {
                            Square square = new Square();
                            addedPiece = true;
                            square.setPlayerNum(playerNum);
                            outBoard[c, row] = square;
                        }
                        else
                        {
                            Square square = new Square();
                            square.setPlayerNum(board[c, row].getPlayerNum());
                            outBoard[c, row] = square;
                        }

                    }
                    else
                    {
                        Square square = new Square();
                        square.setPlayerNum(board[c, row].getPlayerNum());
                        outBoard[c, row] = square;
                    }
                }

            }

            return outBoard;
        }
        public void commitNextMoveForColumn(int playerNum, int column)
        {
            bool addedPiece = false;
            //fill from bottom up
            for (int c = 0; c < 7; c++)
            {
                for (int row = 0; row < 6; row++)
                {
                    if (c == column)
                    {
                        if (board[c, row].getPlayerNum() == 0 && !addedPiece)
                        {
                            Square square = new Square();
                            addedPiece = true;
                            square.setPlayerNum(playerNum);
                            board[c, row] = square;
                        }
                        else
                        {
                            Square square = new Square();
                            square.setPlayerNum(board[c, row].getPlayerNum());
                            board[c, row] = square;
                        }

                    }
                    else
                    {
                        Square square = new Square();
                        square.setPlayerNum(board[c, row].getPlayerNum());
                        board[c, row] = square;
                    }
                }

            }
        }
        public Square[,] getBoard()
        {
            return board;
        }
    }
}
