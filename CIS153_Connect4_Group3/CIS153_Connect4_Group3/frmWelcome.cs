﻿using Connect4;
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
    public partial class frmWelcome : Form
    {
        private List<Player> playerList = new List<Player>(new Player[] { });
        //private TextFile textFile = new TextFile("../../Resources/PlayerList.txt", ',');

        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //This code fills the playerList. This needs to be handled by reading the contents of a file in a routine

            Player computer = new Player("Computer");
            Player tim = new Player("Tim");
            Player bob = new Player("Bob");
            Player lisa = new Player("Lisa");

            playerList.Add(computer);
            playerList.Add(tim);
            playerList.Add(bob);
            playerList.Add(lisa);

            //textFile.WriteList(playerList);
            //playerList = textFile.ReadList();

            for(int i = 1; i < playerList.Count(); i++)
            {
                cmbPlayer1.Items.Add(playerList[i].getName());
            }

            for (int i = 0; i < playerList.Count(); i++)
            {
                cmbPlayer2.Items.Add(playerList[i].getName());
            }

            cmbPlayer1.SelectedIndex = 0;
            cmbPlayer2.SelectedIndex = 0;

            // Now we have a list of players for our comboBoxes


        }
        private void Start_Click(object sender, EventArgs e)
        {
            //Player player1 = new Player(cmbPlayer1.SelectedItem.ToString());
            //Player player2 = new Player(cmbPlayer2.SelectedItem.ToString());
            //Game game = new Game(player1, player2);
            this.Hide();
            GameBoard board = new GameBoard();
            board.player1Name = cmbPlayer1.SelectedItem.ToString();
            board.player2Name = cmbPlayer2.SelectedItem.ToString();
            //board.game = game;
            board.FormClosed += (s, args) => this.Close();
            board.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player(tbAdd.Text);
            playerList.Add(newPlayer);
            cmbPlayer1.Items.Add(tbAdd.Text);
            cmbPlayer2.Items.Add(tbAdd.Text);
            tbAdd.Text = "";
            
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayer1Stats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            // This list starts at the second player
            int index = cmbPlayer1.SelectedIndex + 1;
            stats.setPlayerName(playerList[index].getName());
            stats.setWins(playerList[index].getWins());
            stats.setLosses(playerList[index].getLosses());
            stats.setTies(playerList[index].getTies());
            stats.setWinsVsAi(playerList[index].getWinsVsAi());
            stats.setLossesVsAi(playerList[index].getLossesVsAi());
            stats.setTiesVsAi(playerList[index].getTiesVsAi());
            stats.FormClosed += (s, args) => this.Close();
            stats.Show();
        }

        private void btnPlayer2Stats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            int index = cmbPlayer1.SelectedIndex;
            stats.setPlayerName(playerList[index].getName());
            stats.setWins(playerList[index].getWins());
            stats.setLosses(playerList[index].getLosses());
            stats.setTies(playerList[index].getTies());
            stats.setWinsVsAi(playerList[index].getWinsVsAi());
            stats.setLossesVsAi(playerList[index].getLossesVsAi());
            stats.setTiesVsAi(playerList[index].getTiesVsAi());
            stats.FormClosed += (s, args) => this.Close();
            stats.Show();

        }
    }
}
