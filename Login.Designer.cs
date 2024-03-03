namespace HATCH_2024
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logoPCT = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPCT
            // 
            this.logoPCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPCT.Enabled = false;
            this.logoPCT.Image = ((System.Drawing.Image)(resources.GetObject("logoPCT.Image")));
            this.logoPCT.Location = new System.Drawing.Point(260, 32);
            this.logoPCT.Name = "logoPCT";
            this.logoPCT.Size = new System.Drawing.Size(377, 260);
            this.logoPCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPCT.TabIndex = 1;
            this.logoPCT.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(374, 330);
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(326, 34);
            this.userTXT.TabIndex = 0;
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(374, 381);
            this.passTXT.Name = "passTXT";
            this.passTXT.PasswordChar = '*';
            this.passTXT.Size = new System.Drawing.Size(326, 34);
            this.passTXT.TabIndex = 1;
            // 
            // submitBTN
            // 
            this.submitBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitBTN.BackgroundImage")));
            this.submitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBTN.Location = new System.Drawing.Point(168, 485);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(200, 48);
            this.submitBTN.TabIndex = 2;
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(500, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 48);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(891, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.passTXT);
            this.Controls.Add(this.userTXT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoPCT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoPCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logoPCT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button button1;
    }
}

