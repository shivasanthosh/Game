namespace GameApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Box = new System.Windows.Forms.PictureBox();
            this.Left = new System.Windows.Forms.Timer(this.components);
            this.Right = new System.Windows.Forms.Timer(this.components);
            this.Up = new System.Windows.Forms.Timer(this.components);
            this.Down = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.en1 = new System.Windows.Forms.PictureBox();
            this.en2 = new System.Windows.Forms.PictureBox();
            this.en3 = new System.Windows.Forms.PictureBox();
            this.en4 = new System.Windows.Forms.PictureBox();
            this.Entimer1 = new System.Windows.Forms.Timer(this.components);
            this.etimer2 = new System.Windows.Forms.Timer(this.components);
            this.etimer3 = new System.Windows.Forms.Timer(this.components);
            this.etimer4 = new System.Windows.Forms.Timer(this.components);
            this.End = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.timePlayed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en4)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Box.Image = ((System.Drawing.Image)(resources.GetObject("Box.Image")));
            this.Box.Location = new System.Drawing.Point(228, 340);
            this.Box.MinimumSize = new System.Drawing.Size(50, 50);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(50, 73);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UP);
            // 
            // Left
            // 
            this.Left.Interval = 10;
            this.Left.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Right
            // 
            this.Right.Interval = 10;
            this.Right.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // Up
            // 
            this.Up.Interval = 10;
            this.Up.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // Down
            // 
            this.Down.Interval = 10;
            this.Down.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(79, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 119);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(79, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 89);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(79, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 122);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(79, 343);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 98);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(332, 343);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 97);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Location = new System.Drawing.Point(332, 215);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 119);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(332, 97);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 108);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox8.Location = new System.Drawing.Point(332, -15);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 109);
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox9.Location = new System.Drawing.Point(212, 340);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 99);
            this.pictureBox9.TabIndex = 12;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox10.Location = new System.Drawing.Point(212, 211);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(10, 122);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox11.Location = new System.Drawing.Point(212, 97);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 105);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox12.Location = new System.Drawing.Point(212, 2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(10, 89);
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 10;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // en1
            // 
            this.en1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.en1.Image = ((System.Drawing.Image)(resources.GetObject("en1.Image")));
            this.en1.Location = new System.Drawing.Point(12, 97);
            this.en1.Name = "en1";
            this.en1.Size = new System.Drawing.Size(48, 60);
            this.en1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.en1.TabIndex = 13;
            this.en1.TabStop = false;
            // 
            // en2
            // 
            this.en2.Image = ((System.Drawing.Image)(resources.GetObject("en2.Image")));
            this.en2.Location = new System.Drawing.Point(127, 25);
            this.en2.Name = "en2";
            this.en2.Size = new System.Drawing.Size(56, 55);
            this.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.en2.TabIndex = 14;
            this.en2.TabStop = false;
            // 
            // en3
            // 
            this.en3.Image = ((System.Drawing.Image)(resources.GetObject("en3.Image")));
            this.en3.Location = new System.Drawing.Point(274, 97);
            this.en3.Name = "en3";
            this.en3.Size = new System.Drawing.Size(52, 67);
            this.en3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.en3.TabIndex = 15;
            this.en3.TabStop = false;
            this.en3.Click += new System.EventHandler(this.en3_Click);
            // 
            // en4
            // 
            this.en4.Image = ((System.Drawing.Image)(resources.GetObject("en4.Image")));
            this.en4.Location = new System.Drawing.Point(374, 226);
            this.en4.Name = "en4";
            this.en4.Size = new System.Drawing.Size(58, 69);
            this.en4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.en4.TabIndex = 16;
            this.en4.TabStop = false;
            this.en4.Click += new System.EventHandler(this.en4_Click);
            // 
            // Entimer1
            // 
            this.Entimer1.Enabled = true;
            this.Entimer1.Interval = 10;
            this.Entimer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // etimer2
            // 
            this.etimer2.Enabled = true;
            this.etimer2.Interval = 10;
            this.etimer2.Tick += new System.EventHandler(this.etimer2_Tick);
            // 
            // etimer3
            // 
            this.etimer3.Enabled = true;
            this.etimer3.Interval = 10;
            this.etimer3.Tick += new System.EventHandler(this.etimer3_Tick);
            // 
            // etimer4
            // 
            this.etimer4.Enabled = true;
            this.etimer4.Interval = 10;
            this.etimer4.Tick += new System.EventHandler(this.etimer4_Tick);
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.BackColor = System.Drawing.Color.Transparent;
            this.End.Enabled = false;
            this.End.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(66, 107);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(323, 55);
            this.End.TabIndex = 17;
            this.End.Text = "GAME OVER";
            this.End.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(348, 2);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(68, 13);
            this.Score.TabIndex = 18;
            this.Score.Text = "SCORE : 0";
            // 
            // restart
            // 
            this.restart.Enabled = false;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.Color.Red;
            this.restart.Location = new System.Drawing.Point(147, 242);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(141, 53);
            this.restart.TabIndex = 20;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timePlayed
            // 
            this.timePlayed.AutoSize = true;
            this.timePlayed.Location = new System.Drawing.Point(9, 2);
            this.timePlayed.Name = "timePlayed";
            this.timePlayed.Size = new System.Drawing.Size(0, 13);
            this.timePlayed.TabIndex = 21;
            this.timePlayed.Click += new System.EventHandler(this.timePlayed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(444, 422);
            this.Controls.Add(this.timePlayed);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.End);
            this.Controls.Add(this.en4);
            this.Controls.Add(this.en3);
            this.Controls.Add(this.en2);
            this.Controls.Add(this.en1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Box);
            this.MaximumSize = new System.Drawing.Size(460, 460);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DownMovement);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lr);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Timer Left;
        private System.Windows.Forms.Timer Right;
        private System.Windows.Forms.Timer Up;
        private System.Windows.Forms.Timer Down;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.PictureBox en1;
        private System.Windows.Forms.PictureBox en2;
        private System.Windows.Forms.PictureBox en3;
        private System.Windows.Forms.PictureBox en4;
        private System.Windows.Forms.Timer Entimer1;
        private System.Windows.Forms.Timer etimer2;
        private System.Windows.Forms.Timer etimer3;
        private System.Windows.Forms.Timer etimer4;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label timePlayed;
    }
}

