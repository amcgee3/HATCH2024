namespace HATCH_2024
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.populateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(866, 510);
            this.textBox1.TabIndex = 0;
            // 
            // closeBTN
            // 
            this.closeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBTN.BackgroundImage")));
            this.closeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBTN.Location = new System.Drawing.Point(541, 529);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(215, 56);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // populateBTN
            // 
            this.populateBTN.Location = new System.Drawing.Point(206, 529);
            this.populateBTN.Name = "populateBTN";
            this.populateBTN.Size = new System.Drawing.Size(215, 56);
            this.populateBTN.TabIndex = 2;
            this.populateBTN.Text = "Populate";
            this.populateBTN.UseVisualStyleBackColor = true;
            this.populateBTN.Click += new System.EventHandler(this.populateBTN_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(891, 589);
            this.Controls.Add(this.populateBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.textBox1);
            this.Name = "Report";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button populateBTN;
    }
}