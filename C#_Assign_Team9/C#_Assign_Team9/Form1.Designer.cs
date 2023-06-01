namespace C__Assign_Team9
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            startButton = new Button();
            label2 = new Label();
            CharacterImage1 = new PictureBox();
            pictureBox1 = new PictureBox();
            NameInput1 = new TextBox();
            NameChangeButton1 = new Button();
            NameInput2 = new TextBox();
            NameChangeButton2 = new Button();
            VS_Mark = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VS_Mark).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.ForeColor = SystemColors.ControlText;
            startButton.Image = (Image)resources.GetObject("startButton.Image");
            startButton.Location = new Point(345, 457);
            startButton.Name = "startButton";
            startButton.Size = new Size(284, 92);
            startButton.TabIndex = 0;
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(362, 69);
            label2.Name = "label2";
            label2.Size = new Size(267, 131);
            label2.TabIndex = 4;
            label2.Text = "Racing\r\nGame";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CharacterImage1
            // 
            CharacterImage1.AccessibleRole = AccessibleRole.None;
            CharacterImage1.BackColor = Color.Transparent;
            CharacterImage1.Image = Properties.Resources.RunningMan;
            CharacterImage1.Location = new Point(2, 276);
            CharacterImage1.Name = "CharacterImage1";
            CharacterImage1.Size = new Size(303, 283);
            CharacterImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            CharacterImage1.TabIndex = 5;
            CharacterImage1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.RunningMan_R;
            pictureBox1.Location = new Point(681, 276);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // NameInput1
            // 
            NameInput1.Location = new Point(225, 245);
            NameInput1.Multiline = true;
            NameInput1.Name = "NameInput1";
            NameInput1.Size = new Size(80, 25);
            NameInput1.TabIndex = 7;
            NameInput1.Text = "A";
            NameInput1.TextAlign = HorizontalAlignment.Center;
            NameInput1.TextChanged += NameInput1_TextChanged;
            // 
            // NameChangeButton1
            // 
            NameChangeButton1.Location = new Point(225, 216);
            NameChangeButton1.Name = "NameChangeButton1";
            NameChangeButton1.Size = new Size(80, 25);
            NameChangeButton1.TabIndex = 8;
            NameChangeButton1.Text = "이름변경!";
            NameChangeButton1.UseVisualStyleBackColor = true;
            NameChangeButton1.Click += NameChangeButton1_Click;
            // 
            // NameInput2
            // 
            NameInput2.Location = new Point(681, 245);
            NameInput2.Multiline = true;
            NameInput2.Name = "NameInput2";
            NameInput2.Size = new Size(80, 25);
            NameInput2.TabIndex = 9;
            NameInput2.Text = "B";
            NameInput2.TextAlign = HorizontalAlignment.Center;
            // 
            // NameChangeButton2
            // 
            NameChangeButton2.Location = new Point(681, 214);
            NameChangeButton2.Name = "NameChangeButton2";
            NameChangeButton2.Size = new Size(80, 25);
            NameChangeButton2.TabIndex = 10;
            NameChangeButton2.Text = "이름변경!";
            NameChangeButton2.UseVisualStyleBackColor = true;
            NameChangeButton2.Click += NameChangeButton2_Click;
            // 
            // VS_Mark
            // 
            VS_Mark.BackColor = Color.Transparent;
            VS_Mark.Image = (Image)resources.GetObject("VS_Mark.Image");
            VS_Mark.Location = new Point(404, 245);
            VS_Mark.Name = "VS_Mark";
            VS_Mark.Size = new Size(184, 190);
            VS_Mark.SizeMode = PictureBoxSizeMode.StretchImage;
            VS_Mark.TabIndex = 11;
            VS_Mark.TabStop = false;
            VS_Mark.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(984, 561);
            Controls.Add(VS_Mark);
            Controls.Add(NameChangeButton2);
            Controls.Add(NameInput2);
            Controls.Add(NameChangeButton1);
            Controls.Add(NameInput1);
            Controls.Add(pictureBox1);
            Controls.Add(CharacterImage1);
            Controls.Add(label2);
            Controls.Add(startButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CharacterImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VS_Mark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label2;
        private PictureBox CharacterImage1;
        private PictureBox pictureBox1;
        private TextBox NameInput1;
        private Button NameChangeButton1;
        private TextBox NameInput2;
        private Button NameChangeButton2;
        private PictureBox VS_Mark;
    }
}