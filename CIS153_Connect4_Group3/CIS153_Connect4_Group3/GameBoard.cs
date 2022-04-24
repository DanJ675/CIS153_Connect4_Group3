using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class GameBoard : Form
    {
        public string player1Name { get; set; }
        public string player2Name { get; set; }
        private CIS153_Connect4_Group3.Game g { get; set; }
        private CIS153_Connect4_Group3.Game sG { get; set;}
        private CIS153_Connect4_Group3.Player player1;
        private CIS153_Connect4_Group3.Player player2;
        public GameBoard()
        {
            InitializeComponent();
            CIS153_Connect4_Group3.Square[,] squares;
            player1 = new CIS153_Connect4_Group3.Player(player1Name);
            player2 = new CIS153_Connect4_Group3.Player(player2Name);
            CIS153_Connect4_Group3.Game game = new CIS153_Connect4_Group3.Game(player1, player2);
            g = game;
            squares = g.getSquare();   // you use this to return the information to update the colors of the squares.
            updateScreen(squares);
            CIS153_Connect4_Group3.Game showGame = new CIS153_Connect4_Group3.Game(player1, player2);
            sG = showGame;

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

            //showGame.getSquare();   // you use this to return the information to update the colors of the squares.

            //if (game.checkWinner() > 0)
            //{
            //    if(player2.getName() == "Computer")
            //    {
            //        if(game.checkWinner() == 1)
            //        {
            //            player1.addWinVsAi();
            //        }
            //        else
            //        {
            //            player1.addLossVsAi();
            //        }
            //    }
            //}

            //if(game.checkDraw())
            //{
            //    if (player2.getName() == "Computer")
            //    {
            //        if (game.checkDraw() == true)
            //        {
            //            player1.addTieVsAi();
            //            player2.addTies();
            //        }
            //    }
            //    else
            //    {
            //        player1.addTies();
            //        player2.addTies();
            //    }
            //}
        }
        private void updateScreen(CIS153_Connect4_Group3.Square[,] squares)
        {
            if(squares[0,0].getPlayerNum() == 0)
            {
                pBox00P0.Visible = true;
                pBox00P1.Visible = false;
                pBox00P2.Visible = false;
            }
            else if (squares[0, 0].getPlayerNum() == 1)
            { 
                pBox00P0.Visible = false;
                pBox00P1.Visible = true;
                pBox00P2.Visible = false;
            }
            else if (squares[0, 0].getPlayerNum() == 2)
            {
                pBox00P0.Visible = false;
                pBox00P1.Visible = false;
                pBox00P2.Visible = true;
            }
            if (squares[0, 1].getPlayerNum() == 0)
            {
                pBox10P0.Visible = true;
                pBox10P1.Visible = false;
                pBox10P2.Visible = false;
            }
            else if (squares[0, 1].getPlayerNum() == 1)
            {
                pBox10P0.Visible = false;
                pBox10P1.Visible = true;
                pBox10P2.Visible = false;
            }
            else if (squares[0,1].getPlayerNum() == 2)
            {
                pBox10P0.Visible = false;
                pBox10P1.Visible = false;
                pBox10P2.Visible = true;
            }
            if (squares[0 , 2].getPlayerNum() == 0)
            {
                pBox20P0.Visible = true;
                pBox20P1.Visible = false;
                pBox20P2.Visible = false;
            }
            else if (squares[0, 2].getPlayerNum() == 1)
            {
                pBox20P0.Visible = false;
                pBox20P1.Visible = true;
                pBox20P2.Visible = false;
            }
            else if (squares[0 , 2].getPlayerNum() == 2)
            {
                pBox20P0.Visible = false;
                pBox20P1.Visible = false;
                pBox20P2.Visible = true;
            }
            if (squares[0, 3].getPlayerNum() == 0)
            {
                pBox30P0.Visible = true;
                pBox30P1.Visible = false;
                pBox30P2.Visible = false;
            }
            else if (squares[0, 3].getPlayerNum() == 1)
            {
                pBox30P0.Visible = false;
                pBox30P1.Visible = true;
                pBox30P2.Visible = false;
            }
            else if (squares[0, 3].getPlayerNum() == 2)
            {
                pBox30P0.Visible = false;
                pBox30P1.Visible = false;
                pBox30P2.Visible = true;
            }
            if (squares[0, 4].getPlayerNum() == 0)
            {
                pBox40P0.Visible = true;
                pBox40P1.Visible = false;
                pBox40P2.Visible = false;
            }
            else if (squares[0, 4].getPlayerNum() == 1)
            {
                pBox40P0.Visible = false;
                pBox40P1.Visible = true;
                pBox40P2.Visible = false;
            }
            else if (squares[0, 4].getPlayerNum() == 2)
            {
                pBox40P0.Visible = false;
                pBox40P1.Visible = false;
                pBox40P2.Visible = true;
            }
            if (squares[0, 5].getPlayerNum() == 0)
            {
                pBox50P0.Visible = true;
                pBox50P1.Visible = false;
                pBox50P2.Visible = false;
            }
            else if (squares[0, 5].getPlayerNum() == 1)
            {
                pBox50P0.Visible = false;
                pBox50P1.Visible = true;
                pBox50P2.Visible = false;
            }
            else if (squares[0, 5].getPlayerNum() == 2)
            {
                pBox50P0.Visible = false;
                pBox50P1.Visible = false;
                pBox50P2.Visible = true;
            }
        }
        private void setPlayer1()
        {

        }
        
        private void col0_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 0);
            updateScreen(g.getShowSquare());
        }

        private void col0_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }

        private void col0_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 0);
            updateScreen(g.getSquare());
            if(g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col1_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 1);
            updateScreen(g.getSquare());
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col1_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 1);
            updateScreen(sG.getSquare());
        }

        private void col1_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col2_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 2);
            updateScreen(g.getSquare());
        }

        private void col2_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 2);
            updateScreen(sG.getSquare());
        }

        private void col2_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col3_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 3);
            updateScreen(g.getSquare());
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col3_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 3);
            updateScreen(sG.getSquare());
        }

        private void col3_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col4_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 4);
            updateScreen(g.getSquare());
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col4_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 4);
            updateScreen(sG.getSquare());
        }

        private void col4_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col5_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 5);
            updateScreen(g.getSquare());
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col5_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 5);
            updateScreen(sG.getSquare());
        }

        private void col5_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col6_MouseClick(object sender, MouseEventArgs e)
        {
            g.onClick(g.getActivePlayerNum(), 6);
            updateScreen(g.getSquare());
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
            }
            else
            {
                g.setActivePlayerNum(1);
            }
        }

        private void col6_MouseHover(object sender, EventArgs e)
        {
            sG.onClick(sG.getActivePlayerNum(), 6);
            updateScreen(sG.getSquare());
        }

        private void col6_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
    }
}
