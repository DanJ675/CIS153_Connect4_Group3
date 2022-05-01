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
        private Square[,] square = new Square[7, 6];
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
            Console.WriteLine("Entered AI");

            if (square[3, 0].getPlayerNum() == 0)
            {
                square[3, 0].setPlayerNum(2);
                return board.getBoard();
            }

            //check for pieces in a row
            if (threePlusTwo(board.getBoard())) //sends the square with the board information to threePlusTwo
            {
                Console.WriteLine("3 + 2");
                return board.getBoard();
            }
            else if (twoPlusTwo(board.getBoard())) //sends the square with the board information to twoPlusTwo
            {
                Console.WriteLine("2 + 2");
                return board.getBoard();
            }
            else if (onePlusTwo(board.getBoard())) //sends the square with the board information to onePlueTwo
            {
                Console.WriteLine("1 + 2");
                return board.getBoard();
            }
            else

            return board.getBoard();
        }
        public bool checkDraw() //check for 4 in a row winner after board updates
        {
            if (square[6, 5].getPlayerNum() != 0 &&
                square[5, 5].getPlayerNum() != 0 &&
                square[4, 5].getPlayerNum() != 0 &&
                square[3, 5].getPlayerNum() != 0 &&
                square[2, 5].getPlayerNum() != 0 &&
                square[1, 5].getPlayerNum() != 0 &&
                square[0, 5].getPlayerNum() != 0)
            {
                return true;
            }
            else
                return false;
        }

        public int checkWinner() //check for 4 in a row winner after board updates
        {
            //Horizontal
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r].getPlayerNum() == 1 &&
                        square[c + 2, r].getPlayerNum() == 1 &&
                        square[c + 3, r].getPlayerNum() == 1)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        Console.WriteLine("Horiz player winner");
                        return 1;
                    }
                    else if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r].getPlayerNum() == 2 &&
                        square[c + 2, r].getPlayerNum() == 2 &&
                        square[c + 3, r].getPlayerNum() == 2)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addLossVsAi();
                        }
                        else
                        {
                            player1.addLoss();
                        }
                        Console.WriteLine("Horiz comp winner");
                        return 2;
                    }
                }
            }

            //check for vertical winner
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (square[c, r].getPlayerNum() == 1 &&
                        square[c, r + 1].getPlayerNum() == 1 &&
                        square[c, r + 2].getPlayerNum() == 1 &&
                        square[c, r + 3].getPlayerNum() == 1)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        Console.WriteLine("vert player winner");
                        return 1;
                    }
                    else if (square[c, r].getPlayerNum() == 2 &&
                        square[c, r + 1].getPlayerNum() == 2 &&
                        square[c, r + 2].getPlayerNum() == 2 &&
                        square[c, r + 3].getPlayerNum() == 2)
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
                        Console.WriteLine("Vert comp winner");
                        return 2;

                    }
                }
            }

            ////check for upward diagonal
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r + 1].getPlayerNum() == 1 &&
                        square[c + 2, r + 2].getPlayerNum() == 1 &&
                        square[c + 3, r + 3].getPlayerNum() == 1)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                            player2.addLoss();
                        }
                        else
                        {
                            player1.addWin();
                            player2.addLoss();
                        }
                        Console.WriteLine("Up diag player winner");
                        return 1;
                    }

                    else if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r + 1].getPlayerNum() == 2 &&
                        square[c + 2, r + 2].getPlayerNum() == 2 &&
                        square[c + 3, r + 3].getPlayerNum() == 2)
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
                        Console.WriteLine("Up diag comp winner");
                        return 2;
                    }
                }
            }

            //check for downward diagonal
            for (int r = 5; r > 2; r--)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r - 1].getPlayerNum() == 1 &&
                        square[c + 2, r - 2].getPlayerNum() == 1 &&
                        square[c + 3, r - 3].getPlayerNum() == 1)
                    {
                        if (player2.getName() == "Computer")
                        {
                            player1.addWinVsAi();
                        }
                        else
                        {
                            player1.addWin();
                        }
                        Console.WriteLine("down diag player winner");
                        return 1;
                    }

                    else if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r - 1].getPlayerNum() == 2 &&
                        square[c + 2, r - 2].getPlayerNum() == 2 &&
                        square[c + 3, r - 3].getPlayerNum() == 2)
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
                        Console.WriteLine("Down diag comp winner");
                        return 2;
                    }
                }
            }
            return 0;
        }

        public bool threePlusTwo(Square[,] square) //ai - take the win if you can or block player 1's win
        {
            //check for horizontal

            for (int c = 0; c < 3; c++)
            {
                for (int r = 0; r < 6; r++)
                {
                    //if there's a spot in front of the row of 3
                    if (square[c, r].getPlayerNum() == 0 &&
                        square[c + 1, r].getPlayerNum() == 2 &&
                        square[c + 2, r].getPlayerNum() == 2 &&
                        square[c + 3, r].getPlayerNum() == 2 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2); // make move
                        Console.WriteLine("3+2 horiz Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }
                    //if there's a spot behind the row of 3
                    else if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r].getPlayerNum() == 2 &&
                        square[c + 2, r].getPlayerNum() == 2 &&
                        square[c + 3, r].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 3, r - 1].getPlayerNum() != 0)))

                    {
                        square[c + 3, r].setPlayerNum(2); // make move
                        Console.WriteLine("3+2 horiz Square: " + c+3 + ", " + r + " is player: " + square[c+3, r].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }

                    //block if there's a spot in front of the row of 3
                    else if (square[c, r].getPlayerNum() == 0 &&
                        square[c + 1, r].getPlayerNum() == 1 &&
                        square[c + 2, r].getPlayerNum() == 1 &&
                        square[c + 3, r].getPlayerNum() == 1 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0)))
                    {
                        square[c, r].setPlayerNum(2);  //make move to block
                        Console.WriteLine("3+2 horiz block Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }

                    //block if there's a spot behind the row of 3
                    else if (square[c, r].getPlayerNum() == 1 &&
                            square[c + 1, r].getPlayerNum() == 1 &&
                            square[c + 2, r].getPlayerNum() == 1 &&
                            square[c + 3, r].getPlayerNum() == 0 &&
                            (r == 0 || (square[c + 3, r - 1].getPlayerNum() != 0)))
                    {
                        square[c + 3, r].setPlayerNum(2);  //make move to block
                        Console.WriteLine("3+2 horiz block Square: " + c + 3 + ", " + r + " is player: " + square[c + 3, r].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }

                }
            }

            //check for vertical
            for (int c = 0; c < 7; c++)
            {
                for (int r = 0; r < 3; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c, r + 1].getPlayerNum() == 2 &&
                        square[c, r + 2].getPlayerNum() == 2 &&
                        square[c, r + 3].getPlayerNum() == 0)
                    {
                        square[c, r + 3].setPlayerNum(2); //make move
                        Console.WriteLine("3+2 vert Square: " + c + ", " + (r + 3) + " is player: " + square[c, r + 3].getPlayerNum());
                        return true; //successful move, stop three plus two
                    }

                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c, r + 1].getPlayerNum() == 1 &&
                        square[c, r + 2].getPlayerNum() == 1 &&
                        square[c, r + 3].getPlayerNum() == 0)
                    {
                        square[c, r + 3].setPlayerNum(2); //block
                        Console.WriteLine("3+2 vert block Square: " + c + ", " + (r + 3) + " is player: " + square[c, r + 3].getPlayerNum());
                        return true; //successful move, stop three plus two
                    }
                }
            }

            //check for upward diagonal
            for (int c = 0; c < 3; c++)
            {
                for (int r = 0; r < 2; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r + 1].getPlayerNum() == 2 &&
                        square[c + 2, r + 2].getPlayerNum() == 2 &&
                        square[c + 3, r + 3].getPlayerNum() == 0 &&
                        (square[c + 3, r + 2].getPlayerNum() != 0))

                    {
                        square[c + 3, r + 3].setPlayerNum(2); // make move
                        Console.WriteLine("3+2 up Square: " + (c + 3) + ", " + (r + 3) + " is player: " + square[c + 3, r + 3].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 1 &&
                         square[c + 1, r + 1].getPlayerNum() == 1 &&
                         square[c + 2, r + 2].getPlayerNum() == 1 &&
                         square[c + 3, r + 3].getPlayerNum() == 0 &&
                         (square[c + 3, r + 2].getPlayerNum() != 0))

                    {
                        square[c + 3, r + 3].setPlayerNum(2); // block
                        Console.WriteLine("3+2 up block Square: " + (c + 3) + ", " + (r + 3) + " is player: " + square[c + 3, r + 3].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }
                }
            }

            //    //check for downward diagonal
            for (int c = 0; c < 3; c++)
            {
                for (int r = 4; r < 6; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r - 1].getPlayerNum() == 2 &&
                        square[c + 2, r - 2].getPlayerNum() == 2 &&
                        square[c + 3, r - 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 3, r - 4].getPlayerNum() != 0)))

                    {
                        square[c + 3, r - 3].setPlayerNum(2); // make move
                        Console.WriteLine("3+2 down block Square: " + (c + 3) + ", " + (r - 3) + " is player: " + square[c + 3, r - 3].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r - 1].getPlayerNum() == 1 &&
                        square[c + 2, r - 2].getPlayerNum() == 1 &&
                        square[c + 3, r - 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 3, r - 4].getPlayerNum() != 0)))

                    {
                        square[c + 3, r - 3].setPlayerNum(2); // block
                        Console.WriteLine("3+2 down block Square: " + (c + 3) + ", " + (r - 4) + " is player: " + square[c + 3, r - 3].getPlayerNum());
                        return true; //successful move, stop three plus two;
                    }
                }
            }
            return false;
        }



        public bool twoPlusTwo(Square[,] square)
        {


            //Horizontal
            for (int c = 0; c < 3; c++)
            {
                for (int r = 0; r < 6; r++)
                {
                    if (square[c, r].getPlayerNum() == 0 &&
                        square[c + 1, r].getPlayerNum() == 2 &&
                        square[c + 2, r].getPlayerNum() == 2 &&
                        square[c + 3, r].getPlayerNum() == 0 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0 &&
                                    square[c + 3, r - 1].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2); // make move
                        Console.WriteLine("2+2 Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 0 &&
                        square[c + 1, r].getPlayerNum() == 1 &&
                        square[c + 2, r].getPlayerNum() == 1 &&
                        square[c + 3, r].getPlayerNum() == 0 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0 &&
                                    square[c + 3, r - 1].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2);  //make move to block
                        Console.WriteLine("2+2 block Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                }
            }

            //check for vertical
            for (int c = 0; c < 7; c++)
            {
                for (int r = 0; r < 4; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c, r + 1].getPlayerNum() == 2 &&
                        square[c, r + 2].getPlayerNum() == 0)
                    {
                        square[c, r + 2].setPlayerNum(2); //make move
                        Console.WriteLine("2+2 Square: " + c + ", " + (r + 2) + " is player: " + square[c, r + 2].getPlayerNum());
                        return true; //successful move, stop two plus two
                    }

                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c, r + 1].getPlayerNum() == 1 &&
                        square[c, r + 2].getPlayerNum() == 0)
                    {
                        square[c, r + 2].setPlayerNum(2); //block
                        Console.WriteLine("2+2 block Square: " + c + ", " + (r + 2) + " is player: " + square[c, r + 2].getPlayerNum());
                        return true; //successful move, stop two plus two
                    }
                }
            }

            //check for upward diagonal
            for (int c = 0; c < 5; c++)
            {
                for (int r = 0; r < 3; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r + 1].getPlayerNum() == 2 &&
                        square[c + 2, r + 2].getPlayerNum() == 0 &&
                        square[c + 3, r + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 2, r + 1].getPlayerNum() != 0)))

                    {
                        square[c + 2, r + 1].setPlayerNum(2); // make move
                        Console.WriteLine("2+2 Square: " + (c + 2) + ", " + (r + 1) + " is player: " + square[c + 2, r + 1].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r + 1].getPlayerNum() == 1 &&
                        square[c + 2, r + 2].getPlayerNum() == 0 &&
                        square[c + 3, r + 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 2, r + 1].getPlayerNum() != 0)))

                    {
                        square[c + 2, r + 1].setPlayerNum(2); // block
                        Console.WriteLine("2+2 block Square: " + (c + 2) + ", " + (r + 1) + " is player: " + square[c + 2, r + 1].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                }
            }

            //check for downward diagonal
            for (int c = 0; c < 4; c++)
            {
                for (int r = 3; r < 6; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r - 1].getPlayerNum() == 2 &&
                        square[c + 2, r - 2].getPlayerNum() == 0 &&
                        square[c + 3, r - 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 2, r - 3].getPlayerNum() != 0)))

                    {
                        square[c + 1, r - 2].setPlayerNum(2); // make move
                        Console.WriteLine("2+2 Square: " + (c + 1) + ", " + (r - 2) + " is player: " + square[c + 1, r - 2].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c + 1, r - 1].getPlayerNum() == 1 &&
                        square[c + 2, r - 2].getPlayerNum() == 0 &&
                        square[c + 3, r - 3].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 2, r - 3].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2); // block
                        Console.WriteLine("2+2 block Square: " + (c + 2) + ", " + (r - 2) + " is player: " + square[c + 1, r - 2].getPlayerNum());
                        return true; //successful move, stop two plus two;
                    }
                }
            }







            return false;
        }

    public bool onePlusTwo(Square[,] square)
        {
            Console.WriteLine("Entered 1+2");


            //Horizontal
            for (int c = 0; c < 5; c++)
            {
                for (int r = 0; r < 6; r++)
                {
                    if (square[c + 1, r].getPlayerNum() == 2 &&
                        square[c, r].getPlayerNum() == 0 &&
                        square[c + 2, r].getPlayerNum() == 0 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0 &&
                                    square[c + 2, r - 1].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2); // make move
                        Console.WriteLine("1+2 Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[c + 1, r].getPlayerNum() == 1 &&
                        square[c, r].getPlayerNum() == 0 &&
                        square[c + 2, r].getPlayerNum() == 0 &&
                        (r == 0 || (square[c, r - 1].getPlayerNum() != 0 &&
                                    square[c + 2, r - 1].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2);  //make move to block
                        Console.WriteLine("1+2 block Square: " + c + ", " + r + " is player: " + square[c, r].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                }
            }

            //check for vertical
            for (int c = 0; c < 7; c++)
            {
                for (int r = 0; r < 5; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c, r + 1].getPlayerNum() == 0)
                    {
                        square[c, r + 1].setPlayerNum(2); //make move
                        Console.WriteLine("1+2 Square: " + c + ", " + (r + 1) + " is player: " + square[c, r + 1].getPlayerNum());
                        return true; //successful move, stop one plus two
                    }

                    else if (square[c, r].getPlayerNum() == 1 &&
                        square[c, r + 1].getPlayerNum() == 0)
                    {
                        square[c, r + 1].setPlayerNum(2); //block
                        Console.WriteLine("1+2 block Square: " + c + ", " + (r + 1) + " is player: " + square[c, r + 1].getPlayerNum());
                        return true; //successful move, stop one plus two
                    }
                }
            }

            //check for upward diagonal
            for (int c = 0; c < 5; c++)
            {
                for (int r = 0; r < 4; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r + 1].getPlayerNum() == 0 &&
                        square[c + 2, r + 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[c, r + 1].getPlayerNum() != 0)))

                    {
                        square[c + 1, r + 1].setPlayerNum(2); // make move
                        Console.WriteLine("1+2 Square: " + (c + 1) + ", " + (r + 1) + " is player: " + square[c + 1, r + 1].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 1 &&
                         square[c + 1, r + 1].getPlayerNum() == 0 &&
                         square[c + 2, r + 2].getPlayerNum() == 0 &&
                         (r == 0 || (square[c, r + 1].getPlayerNum() != 0)))

                    {
                        square[c + 1, r + 1].setPlayerNum(2); // block
                        Console.WriteLine("1+2 block Square: " + (c + 1) + ", " + (r + 1) + " is player: " + square[c + 1, r + 1].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                }
            }

            //check for downward diagonal
            for (int c = 2; c < 4; c++)
            {
                for (int r = 2; r < 6; r++)
                {
                    if (square[c, r].getPlayerNum() == 2 &&
                        square[c + 1, r - 1].getPlayerNum() == 0 &&
                        square[c + 2, r - 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 1, r - 2].getPlayerNum() != 0)))

                    {
                        square[c + 1, r - 2].setPlayerNum(2); // make move
                        Console.WriteLine("1+2 Square: " + (c + 1) + ", " + (r - 2) + " is player: " + square[c + 1, r - 2].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                    else if (square[c, r].getPlayerNum() == 0 &&
                        square[c + 1, r - 1].getPlayerNum() == 1 &&
                        square[c + 2, r - 2].getPlayerNum() == 0 &&
                        (r == 0 || (square[c + 1, r - 2].getPlayerNum() != 0)))

                    {
                        square[c, r].setPlayerNum(2); // block
                        Console.WriteLine("1+2 block Square: " + (c + 1) + ", " + (r - 2) + " is player: " + square[c + 1, r - 2].getPlayerNum());
                        return true; //successful move, stop one plus two;
                    }
                }
            }








            return false;

        }
    }
}
