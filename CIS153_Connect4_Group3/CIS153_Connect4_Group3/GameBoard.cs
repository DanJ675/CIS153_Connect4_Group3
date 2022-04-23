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
        public GameBoard()
        {
            InitializeComponent();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            CIS153_Connect4_Group3.Player player1 = new CIS153_Connect4_Group3.Player(player1Name);
            CIS153_Connect4_Group3.Player player2 = new CIS153_Connect4_Group3.Player(player2Name);

            CIS153_Connect4_Group3.Game game = new CIS153_Connect4_Group3.Game(player1, player2);
            if (game.checkWinner() > 0)
            {
                if(player2.getName() == "Computer")
                {
                    if(game.checkWinner() == 1)
                    {
                        player1.addWinVsAi();
                    }
                    else
                    {
                        player1.addLossVsAi();
                    }
                }
            }
            
            if(game.checkDraw())
            {
                if (player2.getName() == "Computer")
                {
                    if (game.checkDraw() == true)
                    {
                        player1.addTieVsAi();
                        player2.addTies();
                    }
                }
                else
                {
                    player1.addTies();
                    player2.addTies();
                }
            }
        }
        private void updateScreen()
        {

        }
    }
}
