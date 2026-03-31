using Color_Sequence_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Windows.Forms;

namespace Memory_Games
{
    public partial class FollowLeader : Form
    {
        public FollowLeader()
        {
            InitializeComponent();
            tableLayoutPanel2.Visible = false;
            buttons = new List<Button>()
            {
                b1, b2, b3,
                b4, b5, b6,
                b7, b8, b9
            };
        }
        public Random random = new Random();
        List<int> pattern = new List<int>();
        List<Button> buttons;
        Guesser player1 = null!;
        Guesser player2 = null!;

        private void Start_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            pattern_gen();
            ShowPattern();
            
        }

        private void pattern_gen()
        {
            pattern.Clear();
            for (int i = 0; i < 5; i++)
            {
                pattern.Add(random.Next(1, 10));
            }
        }

        async void ShowPattern()
        {
            foreach (int index in pattern)
            {
                Button btn = buttons[index - 1];

                btn.BackColor = Color.Yellow;   // light up
                await Task.Delay(500);

                btn.BackColor = Color.White; // reset
                await Task.Delay(200);
            }
            StartGame();
        }

        void StartGame()
        {
            player1 = new Guesser(pattern, 1);
            player2 = new Guesser(pattern, 2);
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
            tableLayoutPanel2.Visible = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
