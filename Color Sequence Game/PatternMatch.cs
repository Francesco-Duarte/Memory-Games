using Color_Sequence_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Memory_Games
{
    public partial class PatternMatch : Form
    {
        Random rnd = new Random();
        List<int> pattern = new List<int>();
        List<Label> labels  ;
        Guess player1 = null!;
        Guess player2 = null!;

        public PatternMatch()
        {
            InitializeComponent();
            labels = new List<Label>()
            {
                p1,p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15,p16
            };
            tableLayoutPanel2.Visible = false;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            pattern = pattern_gen();
            ShowPattern();
        }

        private List<int> pattern_gen()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < 17; i++)
                numbers.Add(i);
            numbers = numbers.OrderBy(x => rnd.Next()).ToList();
            return numbers.Take(rnd.Next(6,10)).ToList();
        }
        

        async void ShowPattern()
        {
            foreach (int index in pattern)
            {
                Label lab = labels[index -1 ];
                lab.BackColor = Color.Blue;   
            }
            await Task.Delay(5000);
            foreach(var lab in labels)
            {
                lab.BackColor= Color.White;
            }
            StartGame();
        }

        void StartGame()
        {
            player1 = new Guess(pattern, 1);
            player2 = new Guess(pattern, 2);
            if (player1.Result == "No Result")
            {
                player1.SetStatusText("Player 1's turn");
                player1.ShowDialog();
             }
            else player1.Close();

            if (player2.Result == "No Result")
            {
                player2.SetStatusText("Player 2's turn");
                player2.ShowDialog();
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
           
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
