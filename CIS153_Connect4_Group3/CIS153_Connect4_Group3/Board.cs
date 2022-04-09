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
        private Square[,] showBoard = new Square[7, 6];
        private Square[,] board = new Square[7, 6];
        public Board()
        {
            Square square = new Square();
            square.setPlayerNum(0);
            Square showSquare = new Square();
            showSquare.setPlayerNum(0);
            //initialize board to all empty
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    board[column, row] = square;
                    showBoard[column, row] = showSquare;
                }
            }
        }
        public Square[,] getBoard()
        {
            return board;
        }
        public Square[,] getShowBoard()
        {
            return showBoard;
        }
        public Square[,] mouseHover(int playerNum, int column)
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
                            showBoard[c, row] = square;
                        }
                        else
                        {
                            Square square = new Square();
                            square.setPlayerNum(board[c, row].getPlayerNum());
                            showBoard[c, row] = square;
                        }

                    }
                    else
                    {
                        Square square = new Square();
                        square.setPlayerNum(board[c, row].getPlayerNum());
                        showBoard[c, row] = square;
                    }
                }
            }
            return showBoard;
        }

        public void mouseLeave()
        {
            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 6; row++)
                {
                    showBoard[column, row] = board[column, row];
                }
            }
        }
        public Square[,] onClick(int playerNum, int column)
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
                            showBoard[c, row] = square;
                        }
                        else
                        {
                            Square square = new Square();
                            square.setPlayerNum(board[c, row].getPlayerNum());
                            board[c, row] = square;
                            showBoard[c, row] = square;
                        }

                    }
                    else
                    {
                        Square square = new Square();
                        square.setPlayerNum(board[c, row].getPlayerNum());
                        board[c, row] = square;
                        showBoard[c, row] = square;
                    }
                }

            }
            return board;
        }
    }
}
