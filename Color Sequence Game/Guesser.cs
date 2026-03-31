using System.Windows.Forms;

namespace Color_Sequence_Game
{
    public partial class Guesser : Form
    {
        Color_Sequence s1;
        int P_no;
        public Color[] answer = new Color[5];
        public int count;
        public String Result = "No Result";
        List<int> pattern;
        List<Button> buttons;
        List<int> index = new List<int>(5);


        public Guesser(List<int> pattern, int P_no)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.pattern = pattern;
            this.P_no = P_no;
            buttons = new List<Button>() {
                b1,b2,b3,
                b4,b5,b6,
                b7,b8,b9
            };
            Hide_all();
            tableLayoutPanel2.Visible = true;
        }
        public Guesser(Color_Sequence s1, int P_no)
        {
            InitializeComponent();
            tableLayoutPanel2.Visible = false;
            this.s1 = s1;
            this.P_no = P_no;
        }
        
        void CheckGuess(List<int> index)
        {
            bool equal = false;
            if (count == 5)
            {
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

            count = 0;
        }

        public void SetStatusText(string text)
        {
            turn.Text = text;
        }
        void check_Answer(Color[] sequence)
        {
            bool equal = false;
            if (count == 5)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (sequence[i] == answer[i])
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

            count = 0;
        }
        void addCount(int count)
        {
            switch (count)
            {
                case 0:
                    ch1.BackColor = Color.White;
                    ch2.BackColor = Color.White;
                    ch3.BackColor = Color.White;
                    ch4.BackColor = Color.White;
                    ch5.BackColor = Color.White;
                    break;
                case 1:
                    ch1.BackColor = Color.Black;
                    ch2.BackColor = Color.White;
                    ch3.BackColor = Color.White;
                    ch4.BackColor = Color.White;
                    ch5.BackColor = Color.White; break;
                case 2:
                    ch2.BackColor = Color.Black;
                    ch3.BackColor = Color.White;
                    ch4.BackColor = Color.White;
                    ch5.BackColor = Color.White; break;
                case 3:
                    ch3.BackColor = Color.Black;
                    ch4.BackColor = Color.White;
                    ch5.BackColor = Color.White; break;
                case 4:
                    ch4.BackColor = Color.Black;
                    ch5.BackColor = Color.White; break;
                case 5:
                    ch5.BackColor = Color.Black; break;
            }
        }
        private void Red_Click(object sender, EventArgs e)
        {
            answer[count] = (Red.BackColor);
            count++;
            addCount(count);
        }
        private void Blue_Click(object sender, EventArgs e)
        {
            answer[count] = (Blue.BackColor);
            count++;
            addCount(count);
        }
        private void Lime_Click(object sender, EventArgs e)
        {
            answer[count] = (Lime.BackColor);
            count++;
            addCount(count);
        }
        private void Yellow_Click(object sender, EventArgs e)
        {
            answer[count] = (Yellow.BackColor);
            count++;
            addCount(count);
        }
        private void Cyan_Click(object sender, EventArgs e)
        {
            answer[count] = (Cyan.BackColor);
            count++;
            addCount(count);
        }
        private void Purple_Click(object sender, EventArgs e)
        {
            answer[count] = (Purple.BackColor);
            count++;
            addCount(count);
        }
        private void Green_Click(object sender, EventArgs e)
        {
            answer[count] = (Green.BackColor);
            count++;
            addCount(count);
        }
        private void Maroon_Click(object sender, EventArgs e)
        {
            answer[count] = (Maroon.BackColor);
            count++;
            addCount(count);
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            if (Red.Visible == true)
            {
                check_Answer(s1.sequence);
            }
            if (tableLayoutPanel2.Visible == true)
            {
                CheckGuess(index);
            }
            this.Close();
        }
        private void Undo_Click(object sender, EventArgs e)
        {
            count--;
            addCount(count);
            if(index.Count > 0)
            index.RemoveAt(index.Count - 1);
        }
        private void ME(Button x)
        {
            x.FlatAppearance.BorderColor = Color.Black;
        }
        private void ML(Button x)
        {
            x.FlatAppearance.BorderColor = Color.White;
        }
        private void Red_MouseEnter(object sender, EventArgs e)
        {
            ME(Red);
        }
        private void Red_MouseLeave(object sender, EventArgs e)
        {
            ML(Red);
        }
        private void Blue_MouseEnter(object sender, EventArgs e)
        {
            ME(Blue);
        }
        private void Blue_MouseLeave(object sender, EventArgs e)
        {
            ML(Blue);
        }
        private void Lime_MouseEnter(object sender, EventArgs e)
        {
            ME(Lime);
        }
        private void Lime_MouseLeave(object sender, EventArgs e)
        {
            ML(Lime);
        }
        private void Yellow_MouseEnter(object sender, EventArgs e)
        {
            ME(Yellow);
        }
        private void Yellow_MouseLeave(object sender, EventArgs e)
        {
            ML(Yellow);
        }
        private void Hide_all()
        {
            Yellow.Visible = false; Maroon.Visible = false;
            Red.Visible = false; Blue.Visible = false; Green.Visible = false; Purple.Visible = false;
            Cyan.Visible = false; Lime.Visible = false;
        }
        async private void addButton(Button b)
        {
            index.Add(buttons.IndexOf(b) + 1);
            count++;
            addCount(count);
            b.BackColor = Color.Yellow;
            await Task.Delay(300);
            b.BackColor = Color.White;
        }
        async private void b1_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b1);
            }
        }
        async private void b2_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b2);
            }
        }

        async private void b3_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b3);
            }
        }

        async private void b4_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b4);
            }
        }

        async private void b5_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b5);
            }
        }

        async private void b6_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b6);
            }
        }

        async private void b7_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b7);
            }
        }

        async private void b8_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b8);
            }
        }

        async private void b9_Click(object sender, EventArgs e)
        {
            if (index.Count <= 5)
            {
                addButton(b9);
            }
        }
        private void Green_MouseEnter(object sender, EventArgs e)
        {
            ME(Green);
        }

        private void Green_MouseLeave(object sender, EventArgs e)
        {
            ML(Green);
        }

        private void Maroon_MouseEnter(object sender, EventArgs e)
        {
            ME(Maroon);
        }

        private void Maroon_MouseLeave(object sender, EventArgs e)
        {
            ML(Maroon);
        }

        private void Cyan_MouseEnter(object sender, EventArgs e)
        {
            ME(Cyan);
        }

        private void Cyan_MouseLeave(object sender, EventArgs e)
        {
            ML(Cyan);
        }

        private void Purple_MouseEnter(object sender, EventArgs e)
        {
            ME(Purple);
        }

        private void Purple_MouseLeave(object sender, EventArgs e)
        {
            ML(Purple);
        }

    }
}