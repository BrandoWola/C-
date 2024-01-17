namespace appBlackJack
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.checkYes = new System.Windows.Forms.CheckBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.txtSecondN = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.White;
            this.lblIntro.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(628, 111);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(348, 37);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Register Black Jack Game";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(629, 148);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(173, 33);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(629, 181);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(173, 33);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(629, 214);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(173, 33);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            this.lblAge.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkYes
            // 
            this.checkYes.AutoSize = true;
            this.checkYes.BackColor = System.Drawing.Color.White;
            this.checkYes.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkYes.ForeColor = System.Drawing.Color.Black;
            this.checkYes.Location = new System.Drawing.Point(635, 356);
            this.checkYes.Margin = new System.Windows.Forms.Padding(2);
            this.checkYes.Name = "checkYes";
            this.checkYes.Size = new System.Drawing.Size(220, 17);
            this.checkYes.TabIndex = 5;
            this.checkYes.Text = "I am 18+, I agree to the terms and conditions.";
            this.checkYes.UseVisualStyleBackColor = false;
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(635, 408);
            this.btnCont.Margin = new System.Windows.Forms.Padding(2);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(167, 51);
            this.btnCont.TabIndex = 6;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(955, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 51);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.BackColor = System.Drawing.Color.White;
            this.grpBoxGender.Controls.Add(this.radFemale);
            this.grpBoxGender.Controls.Add(this.radMale);
            this.grpBoxGender.Location = new System.Drawing.Point(635, 249);
            this.grpBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Padding = new System.Windows.Forms.Padding(2);
            this.grpBoxGender.Size = new System.Drawing.Size(341, 77);
            this.grpBoxGender.TabIndex = 11;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(14, 49);
            this.radFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(95, 26);
            this.radFemale.TabIndex = 12;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(14, 17);
            this.radMale.Margin = new System.Windows.Forms.Padding(2);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(72, 26);
            this.radMale.TabIndex = 11;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtFirstN
            // 
            this.txtFirstN.BackColor = System.Drawing.Color.White;
            this.txtFirstN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstN.Location = new System.Drawing.Point(793, 146);
            this.txtFirstN.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstN.Multiline = true;
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(183, 33);
            this.txtFirstN.TabIndex = 12;
            // 
            // txtSecondN
            // 
            this.txtSecondN.BackColor = System.Drawing.Color.White;
            this.txtSecondN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecondN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondN.Location = new System.Drawing.Point(784, 179);
            this.txtSecondN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondN.Multiline = true;
            this.txtSecondN.Name = "txtSecondN";
            this.txtSecondN.Size = new System.Drawing.Size(192, 33);
            this.txtSecondN.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(696, 212);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(280, 35);
            this.txtAge.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::appBlackJack.Properties.Resources.BlackJackIntro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 624);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSecondN);
            this.Controls.Add(this.txtFirstN);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.checkYes);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblIntro);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.CheckBox checkYes;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.TextBox txtSecondN;
        private System.Windows.Forms.TextBox txtAge;
    }
}

