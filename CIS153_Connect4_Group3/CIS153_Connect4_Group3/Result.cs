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

namespace CIS153_Connect4_Group3
{
    public partial class Result : Form
    {
        private string playerName;
        
        public Result()
        {
            InitializeComponent();
        }
        public void setPlayerName(string s) { playerName = s; }

        private void ReturnButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome menu = new frmWelcome();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void StatButt_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameBoard board = new GameBoard();
            board.setActiveBoard(false);
            board.FormClosed += (s, args) => this.Close();
            board.Show();

        }

        private void Result_Load(object sender, EventArgs e)
        {
            lblName.Text = playerName;
        }
    }
}
