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
            btnShuffle = new Button();
            label1 = new Label();
            label2 = new Label();
            lblVersion = new Label();
            chkAnimate = new CheckBox();
            udNumPicBoxes = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)udNumPicBoxes).BeginInit();
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
            btnQuit.Location = new Point(337, 41);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 23);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnShuffle
            // 
            btnShuffle.Location = new Point(337, 12);
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
            label1.Location = new Point(418, 14);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 7;
            label1.Text = "Story Prompt Generator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 34);
            label2.Name = "label2";
            label2.Size = new Size(174, 15);
            label2.TabIndex = 8;
            label2.Text = "Copyright © 2025 Anna Vahtera";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(418, 49);
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
            chkAnimate.Location = new Point(222, 16);
            chkAnimate.Name = "chkAnimate";
            chkAnimate.Size = new Size(109, 19);
            chkAnimate.TabIndex = 10;
            chkAnimate.Text = "Use Animations";
            chkAnimate.UseVisualStyleBackColor = true;
            // 
            // udNumPicBoxes
            // 
            udNumPicBoxes.Location = new Point(222, 41);
            udNumPicBoxes.Name = "udNumPicBoxes";
            udNumPicBoxes.Size = new Size(37, 23);
            udNumPicBoxes.TabIndex = 15;
            udNumPicBoxes.Value = new decimal(new int[] { 4, 0, 0, 0 });
            udNumPicBoxes.ValueChanged += udNumPicBoxes_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 45);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 16;
            label3.Text = "# of Pictures";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 281);
            Controls.Add(label3);
            Controls.Add(udNumPicBoxes);
            Controls.Add(chkAnimate);
            Controls.Add(lblVersion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShuffle);
            Controls.Add(btnQuit);
            Controls.Add(btnRoll);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Story Prompt Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)udNumPicBoxes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private Button btnQuit;
        private Button btnShuffle;
        private Label label1;
        private Label label2;
        private Label lblVersion;
        private CheckBox chkAnimate;
        private NumericUpDown udNumPicBoxes;
        private Label label3;
    }
}
