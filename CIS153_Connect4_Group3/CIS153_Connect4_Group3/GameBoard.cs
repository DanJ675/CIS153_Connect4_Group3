using CIS153_Connect4_Group3;
using Connect4;
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
        private bool activeBoard = true;
        private CIS153_Connect4_Group3.Game g { get; set; }
//        private CIS153_Connect4_Group3.Game sG { get; set;}
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
            //squares = g.getSquare();   // you use this to return the information to update the colors of the squares.
            updateScreen(g.getSquare());
            //CIS153_Connect4_Group3.Game showGame = new CIS153_Connect4_Group3.Game(player1, player2);
            //sG = showGame;

        }
        public void setActiveBoard(bool a) { activeBoard = a; }
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
            if (squares[1, 0].getPlayerNum() == 0)
            {
                pBox01P0.Visible = true;
                pBox01P1.Visible = false;
                pBox01P2.Visible = false;
            }
            else if (squares[1, 0].getPlayerNum() == 1)
            {
                pBox01P0.Visible = false;
                pBox01P1.Visible = true;
                pBox01P2.Visible = false;
            }
            else if (squares[1, 0].getPlayerNum() == 2)
            {
                pBox01P0.Visible = false;
                pBox01P1.Visible = false;
                pBox01P2.Visible = true;
            }
            if (squares[1, 1].getPlayerNum() == 0)
            {
                pBox11P0.Visible = true;
                pBox11P1.Visible = false;
                pBox11P2.Visible = false;
            }
            else if (squares[1, 1].getPlayerNum() == 1)
            {
                pBox11P0.Visible = false;
                pBox11P1.Visible = true;
                pBox11P2.Visible = false;
            }
            else if (squares[1, 1].getPlayerNum() == 2)
            {
                pBox11P0.Visible = false;
                pBox11P1.Visible = false;
                pBox11P2.Visible = true;
            }
            if (squares[1, 2].getPlayerNum() == 0)
            {
                pBox21P0.Visible = true;
                pBox21P1.Visible = false;
                pBox21P2.Visible = false;
            }
            else if (squares[1, 2].getPlayerNum() == 1)
            {
                pBox21P0.Visible = false;
                pBox21P1.Visible = true;
                pBox21P2.Visible = false;
            }
            else if (squares[1, 2].getPlayerNum() == 2)
            {
                pBox21P0.Visible = false;
                pBox21P1.Visible = false;
                pBox21P2.Visible = true;
            }
            if (squares[1, 3].getPlayerNum() == 0)
            {
                pBox31P0.Visible = true;
                pBox31P1.Visible = false;
                pBox31P2.Visible = false;
            }
            else if (squares[1, 3].getPlayerNum() == 1)
            {
                pBox31P0.Visible = false;
                pBox31P1.Visible = true;
                pBox31P2.Visible = false;
            }
            else if (squares[1, 3].getPlayerNum() == 2)
            {
                pBox31P0.Visible = false;
                pBox31P1.Visible = false;
                pBox31P2.Visible = true;
            }
            if (squares[1, 4].getPlayerNum() == 0)
            {
                pBox41P0.Visible = true;
                pBox41P1.Visible = false;
                pBox41P2.Visible = false;
            }
            else if (squares[1, 4].getPlayerNum() == 1)
            {
                pBox41P0.Visible = false;
                pBox41P1.Visible = true;
                pBox41P2.Visible = false;
            }
            else if (squares[1, 4].getPlayerNum() == 2)
            {
                pBox41P0.Visible = false;
                pBox41P1.Visible = false;
                pBox41P2.Visible = true;
            }
            if (squares[1, 5].getPlayerNum() == 0)
            {
                pBox51P0.Visible = true;
                pBox51P1.Visible = false;
                pBox51P2.Visible = false;
            }
            else if (squares[1, 5].getPlayerNum() == 1)
            {
                pBox51P0.Visible = false;
                pBox51P1.Visible = true;
                pBox51P2.Visible = false;
            }
            else if (squares[1, 5].getPlayerNum() == 2)
            {
                pBox51P0.Visible = false;
                pBox51P1.Visible = false;
                pBox51P2.Visible = true;
            }
            if (squares[2, 0].getPlayerNum() == 0)
            {
                pBox02P0.Visible = true;
                pBox02P1.Visible = false;
                pBox02P2.Visible = false;
            }
            else if (squares[2, 0].getPlayerNum() == 1)
            {
                pBox02P0.Visible = false;
                pBox02P1.Visible = true;
                pBox02P2.Visible = false;
            }
            else if (squares[2, 0].getPlayerNum() == 2)
            {
                pBox02P0.Visible = false;
                pBox02P1.Visible = false;
                pBox02P2.Visible = true;
            }
            if (squares[2, 1].getPlayerNum() == 0)
            {
                pBox12P0.Visible = true;
                pBox12P1.Visible = false;
                pBox12P2.Visible = false;
            }
            else if (squares[2, 1].getPlayerNum() == 1)
            {
                pBox12P0.Visible = false;
                pBox12P1.Visible = true;
                pBox12P2.Visible = false;
            }
            else if (squares[2, 1].getPlayerNum() == 2)
            {
                pBox12P0.Visible = false;
                pBox12P1.Visible = false;
                pBox12P2.Visible = true;
            }
            if (squares[2, 2].getPlayerNum() == 0)
            {
                pBox22P0.Visible = true;
                pBox22P1.Visible = false;
                pBox22P2.Visible = false;
            }
            else if (squares[2, 2].getPlayerNum() == 1)
            {
                pBox22P0.Visible = false;
                pBox22P1.Visible = true;
                pBox22P2.Visible = false;
            }
            else if (squares[2, 2].getPlayerNum() == 2)
            {
                pBox22P0.Visible = false;
                pBox22P1.Visible = false;
                pBox22P2.Visible = true;
            }
            if (squares[2, 3].getPlayerNum() == 0)
            {
                pBox32P0.Visible = true;
                pBox32P1.Visible = false;
                pBox32P2.Visible = false;
            }
            else if (squares[2, 3].getPlayerNum() == 1)
            {
                pBox32P0.Visible = false;
                pBox32P1.Visible = true;
                pBox32P2.Visible = false;
            }
            else if (squares[2, 3].getPlayerNum() == 2)
            {
                pBox32P0.Visible = false;
                pBox32P1.Visible = false;
                pBox32P2.Visible = true;
            }
            if (squares[2, 4].getPlayerNum() == 0)
            {
                pBox42P0.Visible = true;
                pBox42P1.Visible = false;
                pBox42P2.Visible = false;
            }
            else if (squares[2, 4].getPlayerNum() == 1)
            {
                pBox42P0.Visible = false;
                pBox42P1.Visible = true;
                pBox42P2.Visible = false;
            }
            else if (squares[2, 4].getPlayerNum() == 2)
            {
                pBox42P0.Visible = false;
                pBox42P1.Visible = false;
                pBox42P2.Visible = true;
            }
            if (squares[2, 5].getPlayerNum() == 0)
            {
                pBox52P0.Visible = true;
                pBox52P1.Visible = false;
                pBox52P2.Visible = false;
            }
            else if (squares[2, 5].getPlayerNum() == 1)
            {
                pBox52P0.Visible = false;
                pBox52P1.Visible = true;
                pBox52P2.Visible = false;
            }
            else if (squares[2, 5].getPlayerNum() == 2)
            {
                pBox52P0.Visible = false;
                pBox52P1.Visible = false;
                pBox52P2.Visible = true;
            }
            if (squares[3, 0].getPlayerNum() == 0)
            {
                pBox03P0.Visible = true;
                pBox03P1.Visible = false;
                pBox03P2.Visible = false;
            }
            else if (squares[3, 0].getPlayerNum() == 1)
            {
                pBox03P0.Visible = false;
                pBox03P1.Visible = true;
                pBox03P2.Visible = false;
            }
            else if (squares[3, 0].getPlayerNum() == 2)
            {
                pBox03P0.Visible = false;
                pBox03P1.Visible = false;
                pBox03P2.Visible = true;
            }
            if (squares[3, 1].getPlayerNum() == 0)
            {
                pBox13P0.Visible = true;
                pBox13P1.Visible = false;
                pBox13P2.Visible = false;
            }
            else if (squares[3, 1].getPlayerNum() == 1)
            {
                pBox13P0.Visible = false;
                pBox13P1.Visible = true;
                pBox13P2.Visible = false;
            }
            else if (squares[3, 1].getPlayerNum() == 2)
            {
                pBox13P0.Visible = false;
                pBox13P1.Visible = false;
                pBox13P2.Visible = true;
            }
            if (squares[3, 2].getPlayerNum() == 0)
            {
                pBox23P0.Visible = true;
                pBox23P1.Visible = false;
                pBox23P2.Visible = false;
            }
            else if (squares[3, 2].getPlayerNum() == 1)
            {
                pBox23P0.Visible = false;
                pBox23P1.Visible = true;
                pBox23P2.Visible = false;
            }
            else if (squares[3, 2].getPlayerNum() == 2)
            {
                pBox23P0.Visible = false;
                pBox23P1.Visible = false;
                pBox23P2.Visible = true;
            }
            if (squares[3, 3].getPlayerNum() == 0)
            {
                pBox33P0.Visible = true;
                pBox33P1.Visible = false;
                pBox33P2.Visible = false;
            }
            else if (squares[3, 3].getPlayerNum() == 1)
            {
                pBox33P0.Visible = false;
                pBox33P1.Visible = true;
                pBox33P2.Visible = false;
            }
            else if (squares[3, 3].getPlayerNum() == 2)
            {
                pBox33P0.Visible = false;
                pBox33P1.Visible = false;
                pBox33P2.Visible = true;
            }
            if (squares[3, 4].getPlayerNum() == 0)
            {
                pBox43P0.Visible = true;
                pBox43P1.Visible = false;
                pBox43P2.Visible = false;
            }
            else if (squares[3, 4].getPlayerNum() == 1)
            {
                pBox43P0.Visible = false;
                pBox43P1.Visible = true;
                pBox43P2.Visible = false;
            }
            else if (squares[3, 4].getPlayerNum() == 2)
            {
                pBox43P0.Visible = false;
                pBox43P1.Visible = false;
                pBox43P2.Visible = true;
            }
            if (squares[3, 5].getPlayerNum() == 0)
            {
                pBox53P0.Visible = true;
                pBox53P1.Visible = false;
                pBox53P2.Visible = false;
            }
            else if (squares[3, 5].getPlayerNum() == 1)
            {
                pBox53P0.Visible = false;
                pBox53P1.Visible = true;
                pBox53P2.Visible = false;
            }
            else if (squares[3, 5].getPlayerNum() == 2)
            {
                pBox53P0.Visible = false;
                pBox53P1.Visible = false;
                pBox53P2.Visible = true;
            }
            if (squares[4, 0].getPlayerNum() == 0)
            {
                pBox04P0.Visible = true;
                pBox04P1.Visible = false;
                pBox04P2.Visible = false;
            }
            else if (squares[4, 0].getPlayerNum() == 1)
            {
                pBox04P0.Visible = false;
                pBox04P1.Visible = true;
                pBox04P2.Visible = false;
            }
            else if (squares[4, 0].getPlayerNum() == 2)
            {
                pBox04P0.Visible = false;
                pBox04P1.Visible = false;
                pBox04P2.Visible = true;
            }
            if (squares[4, 1].getPlayerNum() == 0)
            {
                pBox14P0.Visible = true;
                pBox14P1.Visible = false;
                pBox14P2.Visible = false;
            }
            else if (squares[4, 1].getPlayerNum() == 1)
            {
                pBox14P0.Visible = false;
                pBox14P1.Visible = true;
                pBox14P2.Visible = false;
            }
            else if (squares[4, 1].getPlayerNum() == 2)
            {
                pBox14P0.Visible = false;
                pBox14P1.Visible = false;
                pBox14P2.Visible = true;
            }
            if (squares[4, 2].getPlayerNum() == 0)
            {
                pBox24P0.Visible = true;
                pBox24P1.Visible = false;
                pBox24P2.Visible = false;
            }
            else if (squares[4, 2].getPlayerNum() == 1)
            {
                pBox24P0.Visible = false;
                pBox24P1.Visible = true;
                pBox24P2.Visible = false;
            }
            else if (squares[4, 2].getPlayerNum() == 2)
            {
                pBox24P0.Visible = false;
                pBox24P1.Visible = false;
                pBox24P2.Visible = true;
            }
            if (squares[4, 3].getPlayerNum() == 0)
            {
                pBox34P0.Visible = true;
                pBox34P1.Visible = false;
                pBox34P2.Visible = false;
            }
            else if (squares[4, 3].getPlayerNum() == 1)
            {
                pBox34P0.Visible = false;
                pBox34P1.Visible = true;
                pBox34P2.Visible = false;
            }
            else if (squares[4, 3].getPlayerNum() == 2)
            {
                pBox34P0.Visible = false;
                pBox34P1.Visible = false;
                pBox34P2.Visible = true;
            }
            if (squares[4, 4].getPlayerNum() == 0)
            {
                pBox44P0.Visible = true;
                pBox44P1.Visible = false;
                pBox44P2.Visible = false;
            }
            else if (squares[4, 4].getPlayerNum() == 1)
            {
                pBox44P0.Visible = false;
                pBox44P1.Visible = true;
                pBox44P2.Visible = false;
            }
            else if (squares[4, 4].getPlayerNum() == 2)
            {
                pBox44P0.Visible = false;
                pBox44P1.Visible = false;
                pBox44P2.Visible = true;
            }
            if (squares[4, 5].getPlayerNum() == 0)
            {
                pBox54P0.Visible = true;
                pBox54P1.Visible = false;
                pBox54P2.Visible = false;
            }
            else if (squares[4, 5].getPlayerNum() == 1)
            {
                pBox54P0.Visible = false;
                pBox54P1.Visible = true;
                pBox54P2.Visible = false;
            }
            else if (squares[4, 5].getPlayerNum() == 2)
            {
                pBox54P0.Visible = false;
                pBox54P1.Visible = false;
                pBox54P2.Visible = true;
            }
            if (squares[5, 0].getPlayerNum() == 0)
            {
                pBox05P0.Visible = true;
                pBox05P1.Visible = false;
                pBox05P2.Visible = false;
            }
            else if (squares[5, 0].getPlayerNum() == 1)
            {
                pBox05P0.Visible = false;
                pBox05P1.Visible = true;
                pBox05P2.Visible = false;
            }
            else if (squares[5, 0].getPlayerNum() == 2)
            {
                pBox05P0.Visible = false;
                pBox05P1.Visible = false;
                pBox05P2.Visible = true;
            }
            if (squares[5, 1].getPlayerNum() == 0)
            {
                pBox15P0.Visible = true;
                pBox15P1.Visible = false;
                pBox15P2.Visible = false;
            }
            else if (squares[5, 1].getPlayerNum() == 1)
            {
                pBox15P0.Visible = false;
                pBox15P1.Visible = true;
                pBox15P2.Visible = false;
            }
            else if (squares[5, 1].getPlayerNum() == 2)
            {
                pBox15P0.Visible = false;
                pBox15P1.Visible = false;
                pBox15P2.Visible = true;
            }
            if (squares[5, 2].getPlayerNum() == 0)
            {
                pBox25P0.Visible = true;
                pBox25P1.Visible = false;
                pBox25P2.Visible = false;
            }
            else if (squares[5, 2].getPlayerNum() == 1)
            {
                pBox25P0.Visible = false;
                pBox25P1.Visible = true;
                pBox25P2.Visible = false;
            }
            else if (squares[5, 2].getPlayerNum() == 2)
            {
                pBox25P0.Visible = false;
                pBox25P1.Visible = false;
                pBox25P2.Visible = true;
            }
            if (squares[5, 3].getPlayerNum() == 0)
            {
                pBox35P0.Visible = true;
                pBox35P1.Visible = false;
                pBox35P2.Visible = false;
            }
            else if (squares[5, 3].getPlayerNum() == 1)
            {
                pBox35P0.Visible = false;
                pBox35P1.Visible = true;
                pBox35P2.Visible = false;
            }
            else if (squares[5, 3].getPlayerNum() == 2)
            {
                pBox35P0.Visible = false;
                pBox35P1.Visible = false;
                pBox35P2.Visible = true;
            }
            if (squares[5, 4].getPlayerNum() == 0)
            {
                pBox45P0.Visible = true;
                pBox45P1.Visible = false;
                pBox45P2.Visible = false;
            }
            else if (squares[5, 4].getPlayerNum() == 1)
            {
                pBox45P0.Visible = false;
                pBox45P1.Visible = true;
                pBox45P2.Visible = false;
            }
            else if (squares[5, 4].getPlayerNum() == 2)
            {
                pBox45P0.Visible = false;
                pBox45P1.Visible = false;
                pBox45P2.Visible = true;
            }
            if (squares[5, 5].getPlayerNum() == 0)
            {
                pBox55P0.Visible = true;
                pBox55P1.Visible = false;
                pBox55P2.Visible = false;
            }
            else if (squares[5, 5].getPlayerNum() == 1)
            {
                pBox55P0.Visible = false;
                pBox55P1.Visible = true;
                pBox55P2.Visible = false;
            }
            else if (squares[5, 5].getPlayerNum() == 2)
            {
                pBox55P0.Visible = false;
                pBox55P1.Visible = false;
                pBox55P2.Visible = true;
            }
            if (squares[6, 0].getPlayerNum() == 0)
            {
                pBox06P0.Visible = true;
                pBox06P1.Visible = false;
                pBox06P2.Visible = false;
            }
            else if (squares[6, 0].getPlayerNum() == 1)
            {
                pBox06P0.Visible = false;
                pBox06P1.Visible = true;
                pBox06P2.Visible = false;
            }
            else if (squares[6, 0].getPlayerNum() == 2)
            {
                pBox06P0.Visible = false;
                pBox06P1.Visible = false;
                pBox06P2.Visible = true;
            }
            if (squares[6, 1].getPlayerNum() == 0)
            {
                pBox16P0.Visible = true;
                pBox16P1.Visible = false;
                pBox16P2.Visible = false;
            }
            else if (squares[6, 1].getPlayerNum() == 1)
            {
                pBox16P0.Visible = false;
                pBox16P1.Visible = true;
                pBox16P2.Visible = false;
            }
            else if (squares[6, 1].getPlayerNum() == 2)
            {
                pBox16P0.Visible = false;
                pBox16P1.Visible = false;
                pBox16P2.Visible = true;
            }
            if (squares[6, 2].getPlayerNum() == 0)
            {
                pBox26P0.Visible = true;
                pBox26P1.Visible = false;
                pBox26P2.Visible = false;
            }
            else if (squares[6, 2].getPlayerNum() == 1)
            {
                pBox26P0.Visible = false;
                pBox26P1.Visible = true;
                pBox26P2.Visible = false;
            }
            else if (squares[6, 2].getPlayerNum() == 2)
            {
                pBox26P0.Visible = false;
                pBox26P1.Visible = false;
                pBox26P2.Visible = true;
            }
            if (squares[6, 3].getPlayerNum() == 0)
            {
                pBox36P0.Visible = true;
                pBox36P1.Visible = false;
                pBox36P2.Visible = false;
            }
            else if (squares[6, 3].getPlayerNum() == 1)
            {
                pBox36P0.Visible = false;
                pBox36P1.Visible = true;
                pBox36P2.Visible = false;
            }
            else if (squares[6, 3].getPlayerNum() == 2)
            {
                pBox36P0.Visible = false;
                pBox36P1.Visible = false;
                pBox36P2.Visible = true;
            }
            if (squares[6, 4].getPlayerNum() == 0)
            {
                pBox46P0.Visible = true;
                pBox46P1.Visible = false;
                pBox46P2.Visible = false;
            }
            else if (squares[6, 4].getPlayerNum() == 1)
            {
                pBox46P0.Visible = false;
                pBox46P1.Visible = true;
                pBox46P2.Visible = false;
            }
            else if (squares[6, 4].getPlayerNum() == 2)
            {
                pBox46P0.Visible = false;
                pBox46P1.Visible = false;
                pBox46P2.Visible = true;
            }
            if (squares[6, 5].getPlayerNum() == 0)
            {
                pBox56P0.Visible = true;
                pBox56P1.Visible = false;
                pBox56P2.Visible = false;
            }
            else if (squares[6, 5].getPlayerNum() == 1)
            {
                pBox56P0.Visible = false;
                pBox56P1.Visible = true;
                pBox56P2.Visible = false;
            }
            else if (squares[6, 5].getPlayerNum() == 2)
            {
                pBox56P0.Visible = false;
                pBox56P1.Visible = false;
                pBox56P2.Visible = true;
            }
        }
        private void setPlayer1()
        {

        }
        private void switchPlayers()
        {
            if (g.getActivePlayerNum() == 1)
            {
                g.setActivePlayerNum(2);
                pBoxPlayer1.Visible = false;
                pBoxPlayer2.Visible = true;
            }
            else
            {
                g.setActivePlayerNum(1);
                pBoxPlayer1.Visible = true;
                pBoxPlayer2.Visible = false;
            }

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
            if(g.getPlayerNum(5,0) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 0);
                updateScreen(g.getSquare());
                switchPlayers();
                if(player2Name== "Computer")
                {
                    updateScreen(g.nextComputerMove());
                }
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col1_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 1) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 1);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col1_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 1);
            updateScreen(g.getShowSquare());
        }

        private void col1_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col2_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 2) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 2);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col2_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 2);
            updateScreen(g.getShowSquare());
        }

        private void col2_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col3_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 3) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 3);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col3_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 3);
            updateScreen(g.getShowSquare());
        }

        private void col3_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col4_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 4) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 4);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col4_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 4);
            updateScreen(g.getShowSquare());
        }

        private void col4_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col5_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 5) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 5);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col5_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 5);
            updateScreen(g.getShowSquare());
        }

        private void col5_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }
        private void col6_MouseClick(object sender, MouseEventArgs e)
        {
            if (g.getPlayerNum(5, 2) == 0 && activeBoard)
            {
                g.onClick(g.getActivePlayerNum(), 6);
                updateScreen(g.getSquare());
                switchPlayers();
            }
            if (g.checkWinner() > 0 && activeBoard)
            {
                this.Hide();
                Result result = new Result();
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addWinVsAi();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                else
                {
                    player1.addWin();
                    player2.addLoss();
                    result.setPlayerName(player1Name);
                }
                if (g.getActivePlayerNum() == 2 && player2Name == "Computer")
                {
                    player1.addLossVsAi();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                else
                {
                    player1.addLoss();
                    player2.addWin();
                    result.setPlayerName(player2Name);
                }
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
            if (g.checkDraw() && activeBoard)
            {
                switchPlayers();
                if (g.getActivePlayerNum() == 1 && player2Name == "Computer")
                {
                    player1.addTieVsAi();
                    player2.addTies();
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
                if (g.getActivePlayerNum() == 2)
                {
                    player2.addTies();
                }
                this.Hide();
                Result result = new Result();
                result.setPlayerName(player1Name);
                result.FormClosed += (s, args) => this.Close();
                result.Show();
            }
        }

        private void col6_MouseHover(object sender, EventArgs e)
        {
            g.onHover(g.getActivePlayerNum(), 6);
            updateScreen(g.getShowSquare());
        }

        private void col6_MouseLeave(object sender, EventArgs e)
        {
            updateScreen(g.getSquare());
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
