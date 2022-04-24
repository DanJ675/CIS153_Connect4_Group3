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
    public partial class Stats : Form
    {
        private string playerName;
        private int wins;
        private int losses;
        private int ties;
        private int winsVsAi;
        private int lossesVsAi;
        private int tiesVsAi;
        public Stats()
        {
            InitializeComponent();
        }
        public void setPlayerName(string p) { playerName = p; }
        public void setWins(int w) { wins = w; }
        public void setLosses(int l) { losses = l; }
        public void setTies(int t) { ties = t; }
        public void setWinsVsAi(int w) { winsVsAi = w; }
        public void setLossesVsAi(int l) { lossesVsAi = l; }
        public void setTiesVsAi(int t) { tiesVsAi = t; }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome menu = new frmWelcome();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            lblPlayerName.Text = playerName;
            lblWins.Text = wins.ToString();
            lblLosses.Text = losses.ToString();
            lblTies.Text = ties.ToString();
            lblWinsVsAi.Text = winsVsAi.ToString();
            lblLossesVsAi.Text = lossesVsAi.ToString();
            lblTiesVsAi.Text = tiesVsAi.ToString();

        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
