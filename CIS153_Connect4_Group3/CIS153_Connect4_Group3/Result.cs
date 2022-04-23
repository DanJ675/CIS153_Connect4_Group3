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
        public Result()
        {
            InitializeComponent();
        }

        private void ReturnButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome menu = new frmWelcome();
            menu.FormClosed += (s, args) => this.Close();
            menu.Show();
        }

        private void StatButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stats stats = new Stats();
            stats.FormClosed += (s, args) => this.Close();
            stats.Show();
        }

        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
