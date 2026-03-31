namespace Color_Sequence_Game
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            g3 = new Button();
            g1 = new Button();
            g2 = new Button();
            Title = new Label();
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(g3);
            panel1.Controls.Add(g1);
            panel1.Controls.Add(g2);
            panel1.Controls.Add(Title);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(39, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 403);
            panel1.TabIndex = 0;
            // 
            // g3
            // 
            g3.Anchor = AnchorStyles.None;
            g3.BackColor = Color.FromArgb(255, 192, 128);
            g3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            g3.ForeColor = Color.DarkOliveGreen;
            g3.Location = new Point(516, 142);
            g3.Name = "g3";
            g3.Size = new Size(150, 150);
            g3.TabIndex = 17;
            g3.Text = "Matching Patterns";
            g3.UseVisualStyleBackColor = false;
            g3.Click += g3_Click;
            // 
            // g1
            // 
            g1.Anchor = AnchorStyles.None;
            g1.BackColor = Color.MediumTurquoise;
            g1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            g1.ForeColor = Color.DarkOliveGreen;
            g1.Location = new Point(81, 142);
            g1.Name = "g1";
            g1.Size = new Size(150, 150);
            g1.TabIndex = 17;
            g1.Text = "Follow the Leader";
            g1.UseVisualStyleBackColor = false;
            g1.Click += g1_Click;
            // 
            // g2
            // 
            g2.Anchor = AnchorStyles.None;
            g2.BackColor = Color.Plum;
            g2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            g2.ForeColor = Color.DarkOliveGreen;
            g2.Location = new Point(303, 142);
            g2.Name = "g2";
            g2.Size = new Size(150, 150);
            g2.TabIndex = 17;
            g2.Text = "Color Sequence";
            g2.UseVisualStyleBackColor = false;
            g2.Click += g2_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.BackColor = Color.FromArgb(192, 64, 0);
            Title.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(0, 192, 192);
            Title.Location = new Point(210, 40);
            Title.Name = "Title";
            Title.Size = new Size(330, 48);
            Title.TabIndex = 15;
            Title.Text = "Memory Games";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button g2;
        private Label Title;
        private Button g3;
        private Button g1;
    }
}