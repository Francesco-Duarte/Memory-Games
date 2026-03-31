using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory_Games
{
    public partial class Guess : Form
    {
        List<int> pattern = new List<int>();
        int P_no;
        List<Button> buttons;
        int count = 0;
        List<int> index = new List<int>();
        public String Result = "No Result";
        public Guess(List<int> pattern, int P_no)
        {
            InitializeComponent();
            this.pattern = pattern;
            this.P_no = P_no;
            buttons = new List<Button>() {
                A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16
            };
        }
        void CheckGuess(List<int> index)
        {
            bool equal = false;
            if (index.Count == pattern.Count)
            {
                index.Sort();
                pattern.Sort();
                for (int i = 0; i < pattern.Count; i++)
                {
                    if (index[i] == pattern[i])
                    {
                        equal = true;
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    Result = "Won";
                }
                else
                {
                    Result = "Lost";
                }
            }
            else
            {
                Result = "Lost";
            }
        }
        public void SetStatusText(string text)
        {
            turn.Text = text;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            CheckGuess(index);
            this.Close();
        }

        void AddButton(Button b)
        {
            int btnIndex = buttons.IndexOf(b)+1;
            if (index.Contains(btnIndex))
            {
                index.Remove(btnIndex);
                b.BackColor = Color.White; 
            }
            else
            {
                if (index.Count < pattern.Count)
                {
                    index.Add(btnIndex);
                    b.BackColor = Color.Blue;
                }
            }
        }
        private void A1_Click(object sender, EventArgs e)
        {
            AddButton(A1);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            AddButton(A2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            AddButton(A3);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            AddButton(A4);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            AddButton(A5);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            AddButton(A6);
        }

        private void A7_Click(object sender, EventArgs e)
        {
            AddButton(A7);
        }

        private void A8_Click(object sender, EventArgs e)
        {
            AddButton(A8);
        }

        private void A9_Click(object sender, EventArgs e)
        {
            AddButton(A9);
        }

        private void A10_Click(object sender, EventArgs e)
        {
            AddButton(A10);
        }

        private void A11_Click(object sender, EventArgs e)
        {
            AddButton(A11);
        }

        private void A12_Click(object sender, EventArgs e)
        {
            AddButton(A12);
        }

        private void A13_Click(object sender, EventArgs e)
        {
            AddButton(A13);
        }

        private void A14_Click(object sender, EventArgs e)
        {
            AddButton(A14);
        }

        private void A15_Click(object sender, EventArgs e)
        {
            AddButton(A15);
        }

        private void A16_Click(object sender, EventArgs e)
        {
            AddButton(A16);
        }
    }
}
