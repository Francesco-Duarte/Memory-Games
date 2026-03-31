namespace Color_Sequence_Game
{
    partial class Guesser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guesser));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            b9 = new Button();
            b8 = new Button();
            b6 = new Button();
            b5 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            b7 = new Button();
            b4 = new Button();
            Submit = new Button();
            Undo = new Button();
            ch5 = new Label();
            ch4 = new Label();
            ch2 = new Label();
            ch3 = new Label();
            ch1 = new Label();
            turn = new Label();
            Yellow = new Button();
            Lime = new Button();
            Maroon = new Button();
            Green = new Button();
            Blue = new Button();
            Purple = new Button();
            Cyan = new Button();
            Red = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.5454545F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.90909F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.5454545F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.5454545F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.90909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.5454545F));
            tableLayoutPanel1.Size = new Size(1002, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(Submit);
            panel1.Controls.Add(Undo);
            panel1.Controls.Add(ch5);
            panel1.Controls.Add(ch4);
            panel1.Controls.Add(ch2);
            panel1.Controls.Add(ch3);
            panel1.Controls.Add(ch1);
            panel1.Controls.Add(turn);
            panel1.Controls.Add(Yellow);
            panel1.Controls.Add(Lime);
            panel1.Controls.Add(Maroon);
            panel1.Controls.Add(Green);
            panel1.Controls.Add(Blue);
            panel1.Controls.Add(Purple);
            panel1.Controls.Add(Cyan);
            panel1.Controls.Add(Red);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(48, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 468);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(b9, 2, 2);
            tableLayoutPanel2.Controls.Add(b8, 1, 2);
            tableLayoutPanel2.Controls.Add(b6, 2, 1);
            tableLayoutPanel2.Controls.Add(b5, 1, 1);
            tableLayoutPanel2.Controls.Add(b3, 2, 0);
            tableLayoutPanel2.Controls.Add(b2, 1, 0);
            tableLayoutPanel2.Controls.Add(b1, 0, 0);
            tableLayoutPanel2.Controls.Add(b7, 0, 2);
            tableLayoutPanel2.Controls.Add(b4, 0, 1);
            tableLayoutPanel2.Location = new Point(290, 105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(300, 283);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // b9
            // 
            b9.Dock = DockStyle.Fill;
            b9.Location = new Point(200, 188);
            b9.Margin = new Padding(0);
            b9.Name = "b9";
            b9.Size = new Size(100, 95);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b8
            // 
            b8.Dock = DockStyle.Fill;
            b8.Location = new Point(100, 188);
            b8.Margin = new Padding(0);
            b8.Name = "b8";
            b8.Size = new Size(100, 95);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b6
            // 
            b6.Dock = DockStyle.Fill;
            b6.Location = new Point(200, 94);
            b6.Margin = new Padding(0);
            b6.Name = "b6";
            b6.Size = new Size(100, 94);
            b6.TabIndex = 6;
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.Dock = DockStyle.Fill;
            b5.Location = new Point(100, 94);
            b5.Margin = new Padding(0);
            b5.Name = "b5";
            b5.Size = new Size(100, 94);
            b5.TabIndex = 5;
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b3
            // 
            b3.Dock = DockStyle.Fill;
            b3.Location = new Point(200, 0);
            b3.Margin = new Padding(0);
            b3.Name = "b3";
            b3.Size = new Size(100, 94);
            b3.TabIndex = 4;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Dock = DockStyle.Fill;
            b2.Location = new Point(100, 0);
            b2.Margin = new Padding(0);
            b2.Name = "b2";
            b2.Size = new Size(100, 94);
            b2.TabIndex = 3;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.Dock = DockStyle.Fill;
            b1.Location = new Point(0, 0);
            b1.Margin = new Padding(0);
            b1.Name = "b1";
            b1.Size = new Size(100, 94);
            b1.TabIndex = 2;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b7
            // 
            b7.Dock = DockStyle.Fill;
            b7.Location = new Point(0, 188);
            b7.Margin = new Padding(0);
            b7.Name = "b7";
            b7.Size = new Size(100, 95);
            b7.TabIndex = 1;
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b4
            // 
            b4.Dock = DockStyle.Fill;
            b4.Location = new Point(0, 94);
            b4.Margin = new Padding(0);
            b4.Name = "b4";
            b4.Size = new Size(100, 94);
            b4.TabIndex = 0;
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.None;
            Submit.BackColor = Color.FromArgb(192, 64, 0);
            Submit.FlatStyle = FlatStyle.Popup;
            Submit.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.ForeColor = Color.FromArgb(0, 192, 192);
            Submit.Location = new Point(551, 405);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 17;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Undo
            // 
            Undo.Anchor = AnchorStyles.None;
            Undo.BackColor = Color.FromArgb(192, 64, 0);
            Undo.FlatStyle = FlatStyle.Popup;
            Undo.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Undo.ForeColor = Color.FromArgb(0, 192, 192);
            Undo.Location = new Point(226, 405);
            Undo.Name = "Undo";
            Undo.Size = new Size(94, 29);
            Undo.TabIndex = 18;
            Undo.Text = "Undo";
            Undo.UseVisualStyleBackColor = false;
            Undo.Click += Undo_Click;
            // 
            // ch5
            // 
            ch5.Anchor = AnchorStyles.None;
            ch5.BackColor = SystemColors.Control;
            ch5.Location = new Point(473, 408);
            ch5.Name = "ch5";
            ch5.Size = new Size(20, 20);
            ch5.TabIndex = 12;
            // 
            // ch4
            // 
            ch4.Anchor = AnchorStyles.None;
            ch4.BackColor = SystemColors.Control;
            ch4.Location = new Point(451, 408);
            ch4.Name = "ch4";
            ch4.Size = new Size(20, 20);
            ch4.TabIndex = 13;
            // 
            // ch2
            // 
            ch2.Anchor = AnchorStyles.None;
            ch2.BackColor = SystemColors.Control;
            ch2.Location = new Point(407, 408);
            ch2.Name = "ch2";
            ch2.Size = new Size(20, 20);
            ch2.TabIndex = 14;
            // 
            // ch3
            // 
            ch3.Anchor = AnchorStyles.None;
            ch3.BackColor = SystemColors.Control;
            ch3.Location = new Point(429, 408);
            ch3.Name = "ch3";
            ch3.Size = new Size(20, 20);
            ch3.TabIndex = 15;
            // 
            // ch1
            // 
            ch1.Anchor = AnchorStyles.None;
            ch1.BackColor = SystemColors.Control;
            ch1.Location = new Point(385, 408);
            ch1.Name = "ch1";
            ch1.Size = new Size(20, 20);
            ch1.TabIndex = 16;
            // 
            // turn
            // 
            turn.Anchor = AnchorStyles.None;
            turn.BackColor = Color.FromArgb(192, 64, 0);
            turn.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            turn.ForeColor = Color.FromArgb(0, 192, 192);
            turn.Location = new Point(344, 59);
            turn.Name = "turn";
            turn.Size = new Size(179, 33);
            turn.TabIndex = 11;
            turn.Text = "Player 1's Turn";
            // 
            // Yellow
            // 
            Yellow.Anchor = AnchorStyles.None;
            Yellow.BackColor = Color.Yellow;
            Yellow.FlatAppearance.BorderColor = Color.White;
            Yellow.FlatAppearance.BorderSize = 2;
            Yellow.FlatStyle = FlatStyle.Flat;
            Yellow.Location = new Point(464, 259);
            Yellow.Name = "Yellow";
            Yellow.Size = new Size(100, 100);
            Yellow.TabIndex = 10;
            Yellow.UseVisualStyleBackColor = false;
            Yellow.Click += Yellow_Click;
            Yellow.MouseEnter += Yellow_MouseEnter;
            Yellow.MouseLeave += Yellow_MouseLeave;
            // 
            // Lime
            // 
            Lime.Anchor = AnchorStyles.None;
            Lime.BackColor = Color.Lime;
            Lime.FlatAppearance.BorderColor = Color.White;
            Lime.FlatAppearance.BorderSize = 2;
            Lime.FlatStyle = FlatStyle.Flat;
            Lime.Location = new Point(300, 259);
            Lime.Name = "Lime";
            Lime.Size = new Size(100, 100);
            Lime.TabIndex = 9;
            Lime.UseVisualStyleBackColor = false;
            Lime.Click += Lime_Click;
            Lime.MouseEnter += Lime_MouseEnter;
            Lime.MouseLeave += Lime_MouseLeave;
            // 
            // Maroon
            // 
            Maroon.Anchor = AnchorStyles.None;
            Maroon.BackColor = Color.Maroon;
            Maroon.FlatAppearance.BorderColor = Color.White;
            Maroon.FlatAppearance.BorderSize = 2;
            Maroon.FlatStyle = FlatStyle.Flat;
            Maroon.Location = new Point(622, 259);
            Maroon.Name = "Maroon";
            Maroon.Size = new Size(100, 100);
            Maroon.TabIndex = 8;
            Maroon.UseVisualStyleBackColor = false;
            Maroon.Click += Maroon_Click;
            Maroon.MouseEnter += Maroon_MouseEnter;
            Maroon.MouseLeave += Maroon_MouseLeave;
            // 
            // Green
            // 
            Green.Anchor = AnchorStyles.None;
            Green.BackColor = Color.Green;
            Green.FlatAppearance.BorderColor = Color.White;
            Green.FlatAppearance.BorderSize = 2;
            Green.FlatStyle = FlatStyle.Flat;
            Green.Location = new Point(622, 118);
            Green.Name = "Green";
            Green.Size = new Size(100, 100);
            Green.TabIndex = 8;
            Green.UseVisualStyleBackColor = false;
            Green.Click += Green_Click;
            Green.MouseEnter += Green_MouseEnter;
            Green.MouseLeave += Green_MouseLeave;
            // 
            // Blue
            // 
            Blue.Anchor = AnchorStyles.None;
            Blue.BackColor = Color.Blue;
            Blue.FlatAppearance.BorderColor = Color.White;
            Blue.FlatAppearance.BorderSize = 2;
            Blue.FlatStyle = FlatStyle.Flat;
            Blue.Location = new Point(464, 118);
            Blue.Name = "Blue";
            Blue.Size = new Size(100, 100);
            Blue.TabIndex = 8;
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += Blue_Click;
            Blue.MouseEnter += Blue_MouseEnter;
            Blue.MouseLeave += Blue_MouseLeave;
            // 
            // Purple
            // 
            Purple.Anchor = AnchorStyles.None;
            Purple.BackColor = Color.Purple;
            Purple.FlatAppearance.BorderColor = Color.White;
            Purple.FlatAppearance.BorderSize = 2;
            Purple.FlatStyle = FlatStyle.Flat;
            Purple.Location = new Point(148, 259);
            Purple.Name = "Purple";
            Purple.Size = new Size(100, 100);
            Purple.TabIndex = 7;
            Purple.UseVisualStyleBackColor = false;
            Purple.Click += Purple_Click;
            Purple.MouseEnter += Purple_MouseEnter;
            Purple.MouseLeave += Purple_MouseLeave;
            // 
            // Cyan
            // 
            Cyan.Anchor = AnchorStyles.None;
            Cyan.BackColor = Color.Cyan;
            Cyan.FlatAppearance.BorderColor = Color.White;
            Cyan.FlatAppearance.BorderSize = 2;
            Cyan.FlatStyle = FlatStyle.Flat;
            Cyan.Location = new Point(148, 118);
            Cyan.Name = "Cyan";
            Cyan.Size = new Size(100, 100);
            Cyan.TabIndex = 7;
            Cyan.UseVisualStyleBackColor = false;
            Cyan.Click += Cyan_Click;
            Cyan.MouseEnter += Cyan_MouseEnter;
            Cyan.MouseLeave += Cyan_MouseLeave;
            // 
            // Red
            // 
            Red.Anchor = AnchorStyles.None;
            Red.BackColor = Color.Red;
            Red.FlatAppearance.BorderColor = Color.White;
            Red.FlatAppearance.BorderSize = 2;
            Red.FlatStyle = FlatStyle.Flat;
            Red.Location = new Point(300, 118);
            Red.Name = "Red";
            Red.Size = new Size(100, 100);
            Red.TabIndex = 7;
            Red.UseVisualStyleBackColor = false;
            Red.Click += Red_Click;
            Red.MouseEnter += Red_MouseEnter;
            Red.MouseLeave += Red_MouseLeave;
            // 
            // Guesser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1002, 522);
            Controls.Add(tableLayoutPanel1);
            Name = "Guesser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button Submit;
        private Button Undo;
        private Label ch5;
        private Label ch4;
        private Label ch2;
        private Label ch3;
        private Label ch1;
        private Label turn;
        private Button Yellow;
        private Button Lime;
        private Button Blue;
        private Button Red;
        private Button Maroon;
        private Button Green;
        private Button Purple;
        private Button Cyan;
        private TableLayoutPanel tableLayoutPanel2;
        private Button b9;
        private Button b8;
        private Button b6;
        private Button b5;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button b7;
        private Button b4;
    }
}
