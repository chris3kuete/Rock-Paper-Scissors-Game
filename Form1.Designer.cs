namespace Rock_Paper_Scissors
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
            RockpictureBox = new PictureBox();
            ScissorpictureBox = new PictureBox();
            PaperpictureBox = new PictureBox();
            playBtn = new Button();
            button2 = new Button();
            userChoicelbl = new Label();
            label1 = new Label();
            compChoicelbl = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)RockpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ScissorpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaperpictureBox).BeginInit();
            SuspendLayout();
            // 
            // RockpictureBox
            // 
            RockpictureBox.Image = Properties.Resources.rock;
            RockpictureBox.Location = new Point(173, 120);
            RockpictureBox.Name = "RockpictureBox";
            RockpictureBox.Size = new Size(192, 231);
            RockpictureBox.TabIndex = 0;
            RockpictureBox.TabStop = false;
            RockpictureBox.Click += pictureBox1_Click;
            // 
            // ScissorpictureBox
            // 
            ScissorpictureBox.Image = Properties.Resources.scissors;
            ScissorpictureBox.Location = new Point(420, 120);
            ScissorpictureBox.Name = "ScissorpictureBox";
            ScissorpictureBox.Size = new Size(211, 231);
            ScissorpictureBox.TabIndex = 1;
            ScissorpictureBox.TabStop = false;
            ScissorpictureBox.Click += pictureBox2_Click;
            // 
            // PaperpictureBox
            // 
            PaperpictureBox.Image = Properties.Resources.paper;
            PaperpictureBox.Location = new Point(686, 120);
            PaperpictureBox.Name = "PaperpictureBox";
            PaperpictureBox.Size = new Size(249, 187);
            PaperpictureBox.TabIndex = 2;
            PaperpictureBox.TabStop = false;
            PaperpictureBox.Click += pictureBox3_Click;
            // 
            // playBtn
            // 
            playBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playBtn.Location = new Point(337, 719);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(337, 81);
            playBtn.TabIndex = 3;
            playBtn.Text = "Play";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += playBtn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(789, 603);
            button2.Name = "button2";
            button2.Size = new Size(119, 49);
            button2.TabIndex = 4;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userChoicelbl
            // 
            userChoicelbl.BorderStyle = BorderStyle.FixedSingle;
            userChoicelbl.Location = new Point(337, 436);
            userChoicelbl.Name = "userChoicelbl";
            userChoicelbl.Size = new Size(337, 52);
            userChoicelbl.TabIndex = 5;
            userChoicelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 57);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 6;
            label1.Text = "Click on any Picture to choose";
            // 
            // compChoicelbl
            // 
            compChoicelbl.BorderStyle = BorderStyle.FixedSingle;
            compChoicelbl.Location = new Point(337, 558);
            compChoicelbl.Name = "compChoicelbl";
            compChoicelbl.Size = new Size(337, 57);
            compChoicelbl.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(407, 393);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 8;
            label2.Text = "User Choice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(385, 515);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 9;
            label3.Text = "Computer Choice";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 845);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(compChoicelbl);
            Controls.Add(label1);
            Controls.Add(userChoicelbl);
            Controls.Add(button2);
            Controls.Add(playBtn);
            Controls.Add(PaperpictureBox);
            Controls.Add(ScissorpictureBox);
            Controls.Add(RockpictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)RockpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ScissorpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaperpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox RockpictureBox;
        private PictureBox ScissorpictureBox;
        private PictureBox PaperpictureBox;
        private Button playBtn;
        private Button button2;
        private Label userChoicelbl;
        private Label label1;
        private Label compChoicelbl;
        private Label label2;
        private Label label3;
    }
}
