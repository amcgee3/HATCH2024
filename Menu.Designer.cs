namespace HATCH_2024
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.newBTN = new System.Windows.Forms.Button();
            this.searchBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // newBTN
            // 
            this.newBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newBTN.BackgroundImage")));
            this.newBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newBTN.Location = new System.Drawing.Point(664, 145);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(215, 56);
            this.newBTN.TabIndex = 0;
            this.newBTN.UseVisualStyleBackColor = true;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBTN.BackgroundImage")));
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBTN.Location = new System.Drawing.Point(664, 237);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(215, 56);
            this.searchBTN.TabIndex = 1;
            this.searchBTN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(664, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 56);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBTN.BackgroundImage")));
            this.closeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBTN.Location = new System.Drawing.Point(355, 466);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(215, 56);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(891, 589);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.newBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeBTN;
    }
}