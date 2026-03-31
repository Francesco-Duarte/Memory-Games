using Memory_Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Color_Sequence_Game
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void g1_Click(object sender, EventArgs e)
        {
            FollowLeader fl1 = new FollowLeader();
            fl1.Show();
        }
        private void g2_Click(object sender, EventArgs e)
        {
            Color_Sequence cs1 = new Color_Sequence();
            cs1.Show();
        }

        private void g3_Click(object sender, EventArgs e)
        {
            PatternMatch pm1 = new PatternMatch();
            pm1.Show();
        }
    }
}
