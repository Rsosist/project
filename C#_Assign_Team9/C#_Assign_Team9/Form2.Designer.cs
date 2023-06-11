namespace C__Assign_Team9
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            CurrentMoney = new Label();
            progressBar1 = new ProgressBar();
            CharacterImage1 = new PictureBox();
            CharacterImage2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            FinishLine = new Label();
            progressBar2 = new ProgressBar();
            panel1 = new Panel();
            Naration = new Label();
            label2 = new Label();
            BetToChar1 = new RadioButton();
            BetToChar2 = new RadioButton();
            BetMoney = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            Char1Name = new Label();
            Char2Name = new Label();
            HowToPlay = new Button();
            HowToPlayExplain = new Label();
            Location1 = new Label();
            Location2 = new Label();
            percentTimer = new System.Windows.Forms.Timer(components);
            testlabel1 = new Label();
            testlabel3 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharacterImage2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.MenuText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(354, 22);
            button1.Name = "button1";
            button1.Size = new Size(284, 98);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CurrentMoney
            // 
            CurrentMoney.AutoSize = true;
            CurrentMoney.BackColor = Color.Transparent;
            CurrentMoney.Location = new Point(881, 27);
            CurrentMoney.Name = "CurrentMoney";
            CurrentMoney.Size = new Size(35, 15);
            CurrentMoney.TabIndex = 1;
            CurrentMoney.Text = "5000";
            CurrentMoney.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(100, 256);
            progressBar1.Maximum = 10000;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 3);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // CharacterImage1
            // 
            CharacterImage1.AccessibleRole = AccessibleRole.None;
            CharacterImage1.BackColor = Color.Transparent;
            CharacterImage1.Image = Properties.Resources.RunningDog;
            CharacterImage1.Location = new Point(100, 209);
            CharacterImage1.Name = "CharacterImage1";
            CharacterImage1.Size = new Size(80, 40);
            CharacterImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage1.TabIndex = 4;
            CharacterImage1.TabStop = false;
            CharacterImage1.Click += CharacterImage1_Click;
            // 
            // CharacterImage2
            // 
            CharacterImage2.AccessibleRole = AccessibleRole.None;
            CharacterImage2.BackColor = Color.Transparent;
            CharacterImage2.Image = Properties.Resources.RunningDog;
            CharacterImage2.Location = new Point(100, 280);
            CharacterImage2.Name = "CharacterImage2";
            CharacterImage2.Size = new Size(80, 40);
            CharacterImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage2.TabIndex = 5;
            CharacterImage2.TabStop = false;
            CharacterImage2.Click += CharacterImage2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FinishLine
            // 
            FinishLine.BackColor = Color.Gainsboro;
            FinishLine.Location = new Point(900, 209);
            FinishLine.Name = "FinishLine";
            FinishLine.Size = new Size(10, 169);
            FinishLine.TabIndex = 7;
            FinishLine.Click += label2_Click_1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(100, 326);
            progressBar2.Maximum = 10000;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(800, 3);
            progressBar2.Step = 1;
            progressBar2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Naration);
            panel1.Location = new Point(337, 385);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 175);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Naration
            // 
            Naration.BackColor = Color.Transparent;
            Naration.Image = Properties.Resources.Wood_ui_resize__1_;
            Naration.Location = new Point(19, 11);
            Naration.Name = "Naration";
            Naration.Size = new Size(282, 156);
            Naration.TabIndex = 10;
            Naration.Text = "Nothing";
            Naration.TextAlign = ContentAlignment.MiddleCenter;
            Naration.Click += Naration_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = Properties.Resources.ezgif_com_resize;
            label2.Location = new Point(761, 22);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 10;
            label2.Text = "소지금 :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click_2;
            // 
            // BetToChar1
            // 
            BetToChar1.AutoSize = true;
            BetToChar1.Location = new Point(-2, 209);
            BetToChar1.Name = "BetToChar1";
            BetToChar1.Size = new Size(50, 19);
            BetToChar1.TabIndex = 11;
            BetToChar1.TabStop = true;
            BetToChar1.Text = "BetA";
            BetToChar1.UseVisualStyleBackColor = true;
            BetToChar1.CheckedChanged += BetToChar1_CheckedChanged_1;
            // 
            // BetToChar2
            // 
            BetToChar2.AutoSize = true;
            BetToChar2.Location = new Point(-1, 301);
            BetToChar2.Name = "BetToChar2";
            BetToChar2.Size = new Size(49, 19);
            BetToChar2.TabIndex = 12;
            BetToChar2.TabStop = true;
            BetToChar2.Text = "Bet2";
            BetToChar2.UseVisualStyleBackColor = true;
            BetToChar2.CheckedChanged += BetToChar2_CheckedChanged;
            // 
            // BetMoney
            // 
            BetMoney.Location = new Point(-1, 256);
            BetMoney.Name = "BetMoney";
            BetMoney.Size = new Size(83, 23);
            BetMoney.TabIndex = 13;
            BetMoney.TextChanged += BetMoney_TextChanged;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // Char1Name
            // 
            Char1Name.BackColor = Color.Transparent;
            Char1Name.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Char1Name.Image = Properties.Resources.DogCharR;
            Char1Name.ImageAlign = ContentAlignment.MiddleLeft;
            Char1Name.Location = new Point(-2, 404);
            Char1Name.Name = "Char1Name";
            Char1Name.Size = new Size(170, 156);
            Char1Name.TabIndex = 14;
            Char1Name.Text = "Char1Name";
            Char1Name.TextAlign = ContentAlignment.TopCenter;
            Char1Name.Click += label3_Click_2;
            // 
            // Char2Name
            // 
            Char2Name.BackColor = Color.Transparent;
            Char2Name.Font = new Font("Microsoft Sans Serif", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Char2Name.Image = Properties.Resources.DogCharL;
            Char2Name.ImageAlign = ContentAlignment.MiddleRight;
            Char2Name.Location = new Point(814, 404);
            Char2Name.Name = "Char2Name";
            Char2Name.Size = new Size(170, 156);
            Char2Name.TabIndex = 15;
            Char2Name.Text = "Char2Name";
            Char2Name.TextAlign = ContentAlignment.TopCenter;
            Char2Name.Click += label4_Click;
            // 
            // HowToPlay
            // 
            HowToPlay.BackColor = Color.Transparent;
            HowToPlay.FlatStyle = FlatStyle.Flat;
            HowToPlay.Image = Properties.Resources.QuestionMark_re;
            HowToPlay.Location = new Point(22, 12);
            HowToPlay.Name = "HowToPlay";
            HowToPlay.Size = new Size(36, 37);
            HowToPlay.TabIndex = 16;
            HowToPlay.UseVisualStyleBackColor = false;
            HowToPlay.Click += button2_Click;
            // 
            // HowToPlayExplain
            // 
            HowToPlayExplain.AutoSize = true;
            HowToPlayExplain.BackColor = Color.Transparent;
            HowToPlayExplain.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HowToPlayExplain.ForeColor = Color.FromArgb(255, 128, 0);
            HowToPlayExplain.Location = new Point(-1, 52);
            HowToPlayExplain.Name = "HowToPlayExplain";
            HowToPlayExplain.Size = new Size(103, 23);
            HowToPlayExplain.TabIndex = 17;
            HowToPlayExplain.Text = "How To Play";
            HowToPlayExplain.TextAlign = ContentAlignment.MiddleCenter;
            HowToPlayExplain.Click += HowToPlayExplain_Click;
            // 
            // Location1
            // 
            Location1.AutoSize = true;
            Location1.Location = new Point(916, 244);
            Location1.Name = "Location1";
            Location1.Size = new Size(60, 15);
            Location1.TabIndex = 18;
            Location1.Text = "Location1";
            // 
            // Location2
            // 
            Location2.AutoSize = true;
            Location2.Location = new Point(916, 314);
            Location2.Name = "Location2";
            Location2.Size = new Size(60, 15);
            Location2.TabIndex = 19;
            Location2.Text = "Location2";
            Location2.Click += Lacation2_Click;
            // 
            // percentTimer
            // 
            percentTimer.Interval = 200;
            percentTimer.Tick += percentTimer_Tick;
            // 
            // testlabel1
            // 
            testlabel1.AutoSize = true;
            testlabel1.Location = new Point(159, 451);
            testlabel1.Name = "testlabel1";
            testlabel1.Size = new Size(39, 15);
            testlabel1.TabIndex = 20;
            testlabel1.Text = "label1";
            // 
            // testlabel3
            // 
            testlabel3.AutoSize = true;
            testlabel3.Location = new Point(781, 451);
            testlabel3.Name = "testlabel3";
            testlabel3.Size = new Size(39, 15);
            testlabel3.TabIndex = 21;
            testlabel3.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 367);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 22;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(706, 374);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 23;
            label3.Text = "label3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(984, 561);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(testlabel3);
            Controls.Add(testlabel1);
            Controls.Add(Location2);
            Controls.Add(Location1);
            Controls.Add(HowToPlayExplain);
            Controls.Add(HowToPlay);
            Controls.Add(Char2Name);
            Controls.Add(Char1Name);
            Controls.Add(BetMoney);
            Controls.Add(BetToChar2);
            Controls.Add(BetToChar1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(progressBar2);
            Controls.Add(FinishLine);
            Controls.Add(CharacterImage2);
            Controls.Add(CharacterImage1);
            Controls.Add(progressBar1);
            Controls.Add(CurrentMoney);
            Controls.Add(button1);
            ForeColor = Color.Transparent;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharacterImage2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label CurrentMoney;
        private ProgressBar progressBar1;
        private PictureBox CharacterImage1;
        private PictureBox CharacterImage2;
        private System.Windows.Forms.Timer timer1;
        private Label FinishLine;
        private ProgressBar progressBar2;
        private Panel panel1;
        private Label Naration;
        private Label label2;
        private RadioButton BetToChar1;
        private RadioButton BetToChar2;
        private TextBox BetMoney;
        private System.Windows.Forms.Timer timer2;
        private Label Char1Name;
        private Label Char2Name;
        private Button HowToPlay;
        private Label HowToPlayExplain;
        private Label Location1;
        private Label Location2;
        private System.Windows.Forms.Timer percentTimer;
        private Label testlabel1;
        private Label testlabel3;
        private Label label1;
        private Label label3;
    }
}