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
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            Board board = new Board();
            board.onClick(1, 0);
            board.onClick(2, 0);
            board.onClick(1, 0);
            board.mouseHover(2, 0);
            board.mouseLeave();
            board.mouseHover(2, 1);
            board.onClick(2, 1);
            board.mouseLeave();
            board.mouseHover(1, 4);
            board.mouseLeave();
            board.mouseHover(1, 4);
            board.onClick(1, 4);
            board.mouseLeave();

        }

        private void StatButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            stats.FormClosed += (s, args) => this.Close();
            stats.Show();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameBoard board = new GameBoard();
            board.FormClosed += (s, args) => this.Close();
            board.Show();
        }
    }
}
