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
        public Stats()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome menu = new frmWelcome();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }
    }
}
