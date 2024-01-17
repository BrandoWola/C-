namespace appBlackJack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.picPlayerC1 = new System.Windows.Forms.PictureBox();
            this.picPlayerC2 = new System.Windows.Forms.PictureBox();
            this.picPlayerC3 = new System.Windows.Forms.PictureBox();
            this.picPlayerC4 = new System.Windows.Forms.PictureBox();
            this.picPlayerC5 = new System.Windows.Forms.PictureBox();
            this.picDealerC1 = new System.Windows.Forms.PictureBox();
            this.picDealerC2 = new System.Windows.Forms.PictureBox();
            this.lblPlayerC = new System.Windows.Forms.Label();
            this.lblDealerC = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.imgListC = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerC2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(12, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(127, 35);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(727, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Plum;
            this.btnBegin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBegin.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBegin.Location = new System.Drawing.Point(12, 316);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(228, 64);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.PaleGreen;
            this.btnHit.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.Black;
            this.btnHit.Location = new System.Drawing.Point(573, 320);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(198, 60);
            this.btnHit.TabIndex = 10;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.BackColor = System.Drawing.Color.Red;
            this.btnStand.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.ForeColor = System.Drawing.Color.Black;
            this.btnStand.Location = new System.Drawing.Point(573, 384);
            this.btnStand.Margin = new System.Windows.Forms.Padding(2);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(198, 55);
            this.btnStand.TabIndex = 11;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = false;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Plum;
            this.btnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlayAgain.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlayAgain.Location = new System.Drawing.Point(12, 394);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(228, 45);
            this.btnPlayAgain.TabIndex = 16;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // picPlayerC1
            // 
            this.picPlayerC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayerC1.BackgroundImage")));
            this.picPlayerC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerC1.Location = new System.Drawing.Point(245, 285);
            this.picPlayerC1.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayerC1.Name = "picPlayerC1";
            this.picPlayerC1.Size = new System.Drawing.Size(101, 125);
            this.picPlayerC1.TabIndex = 17;
            this.picPlayerC1.TabStop = false;
            // 
            // picPlayerC2
            // 
            this.picPlayerC2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlayerC2.BackgroundImage")));
            this.picPlayerC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerC2.Location = new System.Drawing.Point(363, 285);
            this.picPlayerC2.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayerC2.Name = "picPlayerC2";
            this.picPlayerC2.Size = new System.Drawing.Size(101, 125);
            this.picPlayerC2.TabIndex = 18;
            this.picPlayerC2.TabStop = false;
            // 
            // picPlayerC3
            // 
            this.picPlayerC3.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerC3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerC3.Location = new System.Drawing.Point(468, 285);
            this.picPlayerC3.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayerC3.Name = "picPlayerC3";
            this.picPlayerC3.Size = new System.Drawing.Size(101, 125);
            this.picPlayerC3.TabIndex = 19;
            this.picPlayerC3.TabStop = false;
            this.picPlayerC3.Visible = false;
            // 
            // picPlayerC4
            // 
            this.picPlayerC4.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerC4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerC4.Location = new System.Drawing.Point(274, 156);
            this.picPlayerC4.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayerC4.Name = "picPlayerC4";
            this.picPlayerC4.Size = new System.Drawing.Size(101, 125);
            this.picPlayerC4.TabIndex = 20;
            this.picPlayerC4.TabStop = false;
            this.picPlayerC4.Visible = false;
            // 
            // picPlayerC5
            // 
            this.picPlayerC5.BackColor = System.Drawing.Color.Transparent;
            this.picPlayerC5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerC5.Location = new System.Drawing.Point(389, 156);
            this.picPlayerC5.Margin = new System.Windows.Forms.Padding(2);
            this.picPlayerC5.Name = "picPlayerC5";
            this.picPlayerC5.Size = new System.Drawing.Size(101, 125);
            this.picPlayerC5.TabIndex = 21;
            this.picPlayerC5.TabStop = false;
            this.picPlayerC5.Visible = false;
            // 
            // picDealerC1
            // 
            this.picDealerC1.BackgroundImage = global::appBlackJack.Properties.Resources.blue_back_of_cards;
            this.picDealerC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDealerC1.Location = new System.Drawing.Point(274, 11);
            this.picDealerC1.Margin = new System.Windows.Forms.Padding(2);
            this.picDealerC1.Name = "picDealerC1";
            this.picDealerC1.Size = new System.Drawing.Size(101, 125);
            this.picDealerC1.TabIndex = 22;
            this.picDealerC1.TabStop = false;
            // 
            // picDealerC2
            // 
            this.picDealerC2.BackgroundImage = global::appBlackJack.Properties.Resources.blue_back_of_cards;
            this.picDealerC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDealerC2.Location = new System.Drawing.Point(389, 11);
            this.picDealerC2.Margin = new System.Windows.Forms.Padding(2);
            this.picDealerC2.Name = "picDealerC2";
            this.picDealerC2.Size = new System.Drawing.Size(101, 125);
            this.picDealerC2.TabIndex = 23;
            this.picDealerC2.TabStop = false;
            // 
            // lblPlayerC
            // 
            this.lblPlayerC.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerC.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayerC.Location = new System.Drawing.Point(257, 408);
            this.lblPlayerC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerC.Name = "lblPlayerC";
            this.lblPlayerC.Size = new System.Drawing.Size(207, 31);
            this.lblPlayerC.TabIndex = 24;
            this.lblPlayerC.Text = "Player Cards";
            // 
            // lblDealerC
            // 
            this.lblDealerC.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerC.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerC.ForeColor = System.Drawing.Color.Transparent;
            this.lblDealerC.Location = new System.Drawing.Point(63, 105);
            this.lblDealerC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerC.Name = "lblDealerC";
            this.lblDealerC.Size = new System.Drawing.Size(207, 31);
            this.lblDealerC.TabIndex = 25;
            this.lblDealerC.Text = "Dealer Cards";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblDealerScore.Location = new System.Drawing.Point(494, 121);
            this.lblDealerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(277, 74);
            this.lblDealerScore.TabIndex = 26;
            this.lblDealerScore.Text = "Dealers Score:";
            this.lblDealerScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Location = new System.Drawing.Point(494, 250);
            this.lblPlayerScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(207, 31);
            this.lblPlayerScore.TabIndex = 27;
            this.lblPlayerScore.Text = "Your Score:";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(12, 250);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(229, 51);
            this.lblResult.TabIndex = 28;
            this.lblResult.Visible = false;
            // 
            // imgListC
            // 
            this.imgListC.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListC.ImageStream")));
            this.imgListC.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListC.Images.SetKeyName(0, "2c.png");
            this.imgListC.Images.SetKeyName(1, "2d.png");
            this.imgListC.Images.SetKeyName(2, "2h.png");
            this.imgListC.Images.SetKeyName(3, "2s.png");
            this.imgListC.Images.SetKeyName(4, "3c.png");
            this.imgListC.Images.SetKeyName(5, "3d.png");
            this.imgListC.Images.SetKeyName(6, "3h.png");
            this.imgListC.Images.SetKeyName(7, "3s.png");
            this.imgListC.Images.SetKeyName(8, "4c.png");
            this.imgListC.Images.SetKeyName(9, "4d.png");
            this.imgListC.Images.SetKeyName(10, "4h.png");
            this.imgListC.Images.SetKeyName(11, "4s.png");
            this.imgListC.Images.SetKeyName(12, "5c.png");
            this.imgListC.Images.SetKeyName(13, "5d.png");
            this.imgListC.Images.SetKeyName(14, "5h.png");
            this.imgListC.Images.SetKeyName(15, "5s.png");
            this.imgListC.Images.SetKeyName(16, "6c.png");
            this.imgListC.Images.SetKeyName(17, "6d.png");
            this.imgListC.Images.SetKeyName(18, "6h.png");
            this.imgListC.Images.SetKeyName(19, "6s.png");
            this.imgListC.Images.SetKeyName(20, "7c.png");
            this.imgListC.Images.SetKeyName(21, "7d.png");
            this.imgListC.Images.SetKeyName(22, "7h.png");
            this.imgListC.Images.SetKeyName(23, "7s.png");
            this.imgListC.Images.SetKeyName(24, "8c.png");
            this.imgListC.Images.SetKeyName(25, "8d.png");
            this.imgListC.Images.SetKeyName(26, "8h.png");
            this.imgListC.Images.SetKeyName(27, "8s.png");
            this.imgListC.Images.SetKeyName(28, "9c.png");
            this.imgListC.Images.SetKeyName(29, "9d.png");
            this.imgListC.Images.SetKeyName(30, "9h.png");
            this.imgListC.Images.SetKeyName(31, "9s.png");
            this.imgListC.Images.SetKeyName(32, "10c.png");
            this.imgListC.Images.SetKeyName(33, "10d.png");
            this.imgListC.Images.SetKeyName(34, "10h.png");
            this.imgListC.Images.SetKeyName(35, "10s.png");
            this.imgListC.Images.SetKeyName(36, "ac.png");
            this.imgListC.Images.SetKeyName(37, "ad.png");
            this.imgListC.Images.SetKeyName(38, "ah.png");
            this.imgListC.Images.SetKeyName(39, "as.png");
            this.imgListC.Images.SetKeyName(40, "jc.png");
            this.imgListC.Images.SetKeyName(41, "jd.png");
            this.imgListC.Images.SetKeyName(42, "jh.png");
            this.imgListC.Images.SetKeyName(43, "js.png");
            this.imgListC.Images.SetKeyName(44, "kc.png");
            this.imgListC.Images.SetKeyName(45, "kd.png");
            this.imgListC.Images.SetKeyName(46, "kh.png");
            this.imgListC.Images.SetKeyName(47, "ks.png");
            this.imgListC.Images.SetKeyName(48, "qc.png");
            this.imgListC.Images.SetKeyName(49, "qd.png");
            this.imgListC.Images.SetKeyName(50, "qh.png");
            this.imgListC.Images.SetKeyName(51, "qs.png");
            this.imgListC.Images.SetKeyName(52, "blue back of cards.png");
            this.imgListC.Images.SetKeyName(53, "red back of cards.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appBlackJack.Properties.Resources.SSTable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblDealerC);
            this.Controls.Add(this.lblPlayerC);
            this.Controls.Add(this.picDealerC2);
            this.Controls.Add(this.picDealerC1);
            this.Controls.Add(this.picPlayerC5);
            this.Controls.Add(this.picPlayerC4);
            this.Controls.Add(this.picPlayerC3);
            this.Controls.Add(this.picPlayerC2);
            this.Controls.Add(this.picPlayerC1);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBegin);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerC2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox picPlayerC1;
        private System.Windows.Forms.PictureBox picPlayerC2;
        private System.Windows.Forms.PictureBox picPlayerC3;
        private System.Windows.Forms.PictureBox picPlayerC4;
        private System.Windows.Forms.PictureBox picPlayerC5;
        private System.Windows.Forms.PictureBox picDealerC1;
        private System.Windows.Forms.PictureBox picDealerC2;
        private System.Windows.Forms.Label lblPlayerC;
        private System.Windows.Forms.Label lblDealerC;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ImageList imgListC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}