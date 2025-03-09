namespace Story_Prompt_Generator
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
            btnRoll = new Button();
            btnQuit = new Button();
            picOne = new PictureBox();
            picTwo = new PictureBox();
            picThree = new PictureBox();
            picFour = new PictureBox();
            btnShuffle = new Button();
            label1 = new Label();
            label2 = new Label();
            lblVersion = new Label();
            chkAnimate = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)picOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFour).BeginInit();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.BackgroundImage = Properties.Resources.btnRandomize_up;
            btnRoll.BackgroundImageLayout = ImageLayout.Center;
            btnRoll.FlatStyle = FlatStyle.Flat;
            btnRoll.Location = new Point(12, 12);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(200, 54);
            btnRoll.TabIndex = 0;
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            btnRoll.MouseDown += btnRoll_MouseDown;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(751, 43);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // picOne
            // 
            picOne.BackColor = SystemColors.Window;
            picOne.BackgroundImage = Properties.Resources._019;
            picOne.BorderStyle = BorderStyle.FixedSingle;
            picOne.Location = new Point(12, 72);
            picOne.Name = "picOne";
            picOne.Size = new Size(200, 200);
            picOne.TabIndex = 2;
            picOne.TabStop = false;
            // 
            // picTwo
            // 
            picTwo.BackColor = SystemColors.Window;
            picTwo.BackgroundImage = Properties.Resources._009;
            picTwo.BorderStyle = BorderStyle.FixedSingle;
            picTwo.Location = new Point(218, 72);
            picTwo.Name = "picTwo";
            picTwo.Size = new Size(200, 200);
            picTwo.TabIndex = 3;
            picTwo.TabStop = false;
            // 
            // picThree
            // 
            picThree.BackColor = SystemColors.Window;
            picThree.BackgroundImage = Properties.Resources._003;
            picThree.BorderStyle = BorderStyle.FixedSingle;
            picThree.Location = new Point(424, 72);
            picThree.Name = "picThree";
            picThree.Size = new Size(200, 200);
            picThree.TabIndex = 4;
            picThree.TabStop = false;
            // 
            // picFour
            // 
            picFour.BackColor = SystemColors.Window;
            picFour.BackgroundImage = Properties.Resources._002;
            picFour.BorderStyle = BorderStyle.FixedSingle;
            picFour.Location = new Point(630, 72);
            picFour.Name = "picFour";
            picFour.Size = new Size(200, 200);
            picFour.TabIndex = 5;
            picFour.TabStop = false;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(751, 14);
            btnShuffle.Name = "btnShuffle";
            btnShuffle.Size = new Size(75, 23);
            btnShuffle.TabIndex = 6;
            btnShuffle.Text = "Shuffle";
            btnShuffle.UseVisualStyleBackColor = true;
            btnShuffle.Click += btnShuffle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 12);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 7;
            label1.Text = "Story Prompt Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 32);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 8;
            label2.Text = "Copyright © 2025 Anna Vahtera";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(228, 47);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(45, 13);
            lblVersion.TabIndex = 9;
            lblVersion.Text = "Version";
            // 
            // chkAnimate
            // 
            chkAnimate.AutoSize = true;
            chkAnimate.Checked = true;
            chkAnimate.CheckState = CheckState.Checked;
            chkAnimate.Location = new Point(636, 18);
            chkAnimate.Name = "chkAnimate";
            chkAnimate.Size = new Size(109, 19);
            chkAnimate.TabIndex = 10;
            chkAnimate.Text = "Use Animations";
            chkAnimate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 280);
            Controls.Add(chkAnimate);
            Controls.Add(lblVersion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShuffle);
            Controls.Add(picFour);
            Controls.Add(picThree);
            Controls.Add(picTwo);
            Controls.Add(picOne);
            Controls.Add(btnQuit);
            Controls.Add(btnRoll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Story Prompt Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Button btnQuit;
        private PictureBox picOne;
        private PictureBox picTwo;
        private PictureBox picThree;
        private PictureBox picFour;
        private Button btnShuffle;
        private Label label1;
        private Label label2;
        private Label lblVersion;
        private CheckBox chkAnimate;
    }
}
