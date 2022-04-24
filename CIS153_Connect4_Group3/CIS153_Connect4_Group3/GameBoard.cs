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
        private CIS153_Connect4_Group3.Game game { get; set; }
        private CIS153_Connect4_Group3.Game showGame { get; set;}
        private CIS153_Connect4_Group3.Player player1;
        private CIS153_Connect4_Group3.Player player2;
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            CIS153_Connect4_Group3.Square[,] squares;
            player1 = new CIS153_Connect4_Group3.Player(player1Name);
            player2 = new CIS153_Connect4_Group3.Player(player2Name);
            CIS153_Connect4_Group3.Game game = new CIS153_Connect4_Group3.Game(player1, player2);
            
            squares = game.getSquare();   // you use this to return the information to update the colors of the squares.
            updateScreen(squares);
            CIS153_Connect4_Group3.Game showGame = new CIS153_Connect4_Group3.Game(player1, player2);

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
            if (squares[1, 0].getPlayerNum() == 0)
            {
                pBox10P0.Visible = true;
                pBox10P1.Visible = false;
                pBox10P2.Visible = false;
            }
            else if (squares[1, 0].getPlayerNum() == 1)
            {
                pBox10P0.Visible = false;
                pBox10P1.Visible = true;
                pBox10P2.Visible = false;
            }
            else if (squares[1, 0].getPlayerNum() == 2)
            {
                pBox10P0.Visible = false;
                pBox10P1.Visible = false;
                pBox10P2.Visible = true;
            }
            if (squares[2, 0].getPlayerNum() == 0)
            {
                pBox20P0.Visible = true;
                pBox20P1.Visible = false;
                pBox20P2.Visible = false;
            }
            else if (squares[2, 0].getPlayerNum() == 1)
            {
                pBox20P0.Visible = false;
                pBox20P1.Visible = true;
                pBox20P2.Visible = false;
            }
            else if (squares[2, 0].getPlayerNum() == 2)
            {
                pBox20P0.Visible = false;
                pBox20P1.Visible = false;
                pBox20P2.Visible = true;
            }
            if (squares[3, 0].getPlayerNum() == 0)
            {
                pBox30P0.Visible = true;
                pBox30P1.Visible = false;
                pBox30P2.Visible = false;
            }
            else if (squares[3, 0].getPlayerNum() == 1)
            {
                pBox30P0.Visible = false;
                pBox30P1.Visible = true;
                pBox30P2.Visible = false;
            }
            else if (squares[3, 0].getPlayerNum() == 2)
            {
                pBox30P0.Visible = false;
                pBox30P1.Visible = false;
                pBox30P2.Visible = true;
            }
            if (squares[4, 0].getPlayerNum() == 0)
            {
                pBox40P0.Visible = true;
                pBox40P1.Visible = false;
                pBox40P2.Visible = false;
            }
            else if (squares[4, 0].getPlayerNum() == 1)
            {
                pBox40P0.Visible = false;
                pBox40P1.Visible = true;
                pBox40P2.Visible = false;
            }
            else if (squares[4, 0].getPlayerNum() == 2)
            {
                pBox40P0.Visible = false;
                pBox40P1.Visible = false;
                pBox40P2.Visible = true;
            }
            if (squares[5, 0].getPlayerNum() == 0)
            {
                pBox50P0.Visible = true;
                pBox50P1.Visible = false;
                pBox50P2.Visible = false;
            }
            else if (squares[5, 0].getPlayerNum() == 1)
            {
                pBox50P0.Visible = false;
                pBox50P1.Visible = true;
                pBox50P2.Visible = false;
            }
            else if (squares[5, 0].getPlayerNum() == 2)
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
            
            this.showGame.onClick(0);
        }

        private void col0_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }

        private void col0_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(0);
        }

        private void col1_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(1);
        }

        private void col1_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(1);
        }

        private void col1_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
        private void col2_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(2);
        }

        private void col2_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(2);
        }

        private void col2_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
        private void col3_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(3);
        }

        private void col3_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(3);
        }

        private void col3_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
        private void col4_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(4);
        }

        private void col4_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(4);
        }

        private void col4_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
        private void col5_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(5);
        }

        private void col5_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(5);
        }

        private void col5_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
        private void col6_MouseClick(object sender, MouseEventArgs e)
        {
            this.game.onClick(6);
        }

        private void col6_MouseHover(object sender, EventArgs e)
        {
            this.showGame.onClick(6);
        }

        private void col6_MouseLeave(object sender, EventArgs e)
        {
            this.showGame = this.game;
        }
    }
}
