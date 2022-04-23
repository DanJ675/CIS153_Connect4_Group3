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
            
        }
        private void updateScreen()
        {

        }
    }
}
