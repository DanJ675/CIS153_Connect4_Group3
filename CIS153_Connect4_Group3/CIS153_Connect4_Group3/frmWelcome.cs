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
            board.commitNextMoveForColumn(1, 0);
            board.commitNextMoveForColumn(2, 0);
            board.commitNextMoveForColumn(1, 0);
            board.mouseHover(2, 0);
            board.mouseLeave();
            board.mouseHover(2, 1);
            board.commitNextMoveForColumn(2, 1);
            board.mouseLeave();
            board.mouseHover(1, 4);
            board.mouseLeave();
            board.mouseHover(1, 4);
            board.commitNextMoveForColumn(1, 4);
            board.mouseLeave();

        }
    }
}
