using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Color_Sequence_Game
{

    public partial class Color_Sequence : Form
    {

        public Color_Sequence()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Controls[0].Dock = DockStyle.Fill;
        }
        public Color[] colours = { Color.Red, Color.Lime, Color.Yellow, Color.Blue, Color.Cyan, Color.Green, Color.Purple, Color.Maroon };
        public Color[] sequence = new Color[5];
        public Random rnd = new Random();
        public int count = 0;
        Guesser player1 = null!;
        Guesser player2 = null!;

        void StartGame()
        {

            player1 = new Guesser(this, 1);
            player2 = new Guesser(this, 2);
            if (player1.Result == "No Result")
            {
                player1.SetStatusText("Player 1's turn");
                player1.ShowDialog();
                // Player 1 plays first
            }
            else player1.Close();

            if (player2.Result == "No Result")
            {
                player2.SetStatusText("Player 2's turn");
                player2.ShowDialog();   // Player 2 plays next
            }
            else player2.Close();
            ShowFinalResult();
        }




        void ShowFinalResult()
        {
            player2.Close();
            if (player1.Result == "Won" && player2.Result == "Won")
                MessageBox.Show("Both players won!");
            else if (player1.Result == "Won")
                MessageBox.Show("Only Player 1 wins!");
            else if (player2.Result == "Won")
                MessageBox.Show("Only Player 2 wins!");
            else
                MessageBox.Show("Both players lost!");
            this.Show();
        }



        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (tableLayoutPanel1.Width - panel1.Width) / 2;
            panel1.Top = (tableLayoutPanel1.Height - panel1.Height) / 2;

        }

        private async void Start_Click(object sender, EventArgs e)
        {
            Start.Size = new Size(150, 150);
            await Task.Delay(500);
            for (int i = 0; i < 5; i++)
            {
                sequence[i] = colours[rnd.Next(colours.Length)];
                Start.BackColor = sequence[i];
                Start.ForeColor = sequence[i];
                await Task.Delay(1000);
                Start.BackColor = Color.White;
                Start.ForeColor = Color.White;
                await Task.Delay(100);
            }
            Start.BackColor = Color.FromArgb(255, 128, 255);
            Start.ForeColor = Color.Lime;
            Start.BackColor = Color.Orange;
            StartGame();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
