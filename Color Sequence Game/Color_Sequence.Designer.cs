namespace Color_Sequence_Game
{
    partial class Color_Sequence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color_Sequence));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            Back = new Button();
            Start = new Button();
            Title = new Label();
            Instruction = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(807, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Plum;
            panel1.Controls.Add(Back);
            panel1.Controls.Add(Start);
            panel1.Controls.Add(Title);
            panel1.Controls.Add(Instruction);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(39, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 413);
            panel1.TabIndex = 0;
            // 
            // Back
            // 
            Back.BackColor = Color.RoyalBlue;
            Back.Font = new Font("Lucida Console", 9F);
            Back.ForeColor = Color.FromArgb(128, 255, 128);
            Back.Location = new Point(7, 7);
            Back.Name = "Back";
            Back.Size = new Size(64, 39);
            Back.TabIndex = 18;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.None;
            Start.BackColor = Color.FromArgb(255, 128, 0);
            Start.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Start.ForeColor = Color.Lime;
            Start.Location = new Point(286, 220);
            Start.Name = "Start";
            Start.Size = new Size(150, 150);
            Start.TabIndex = 17;
            Start.Text = "Let's Play";
            Start.UseVisualStyleBackColor = false;
            Start.Click += Start_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.BackColor = Color.FromArgb(192, 64, 0);
            Title.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(0, 192, 192);
            Title.Location = new Point(197, 42);
            Title.Name = "Title";
            Title.Size = new Size(330, 48);
            Title.TabIndex = 15;
            Title.Text = "Colour Sequence";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Instruction
            // 
            Instruction.Anchor = AnchorStyles.None;
            Instruction.BackColor = Color.RoyalBlue;
            Instruction.Font = new Font("Lucida Console", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Instruction.ForeColor = Color.FromArgb(128, 255, 128);
            Instruction.Location = new Point(144, 135);
            Instruction.Name = "Instruction";
            Instruction.Size = new Size(439, 39);
            Instruction.TabIndex = 16;
            Instruction.Text = "Memorize the sequence of colours";
            Instruction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Color_Sequence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(807, 461);
            Controls.Add(tableLayoutPanel1);
            Name = "Color_Sequence";
            Text = "Color Sequence";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button Start;
        private Label Title;
        private Label Instruction;
        private Button Back;
    }
}