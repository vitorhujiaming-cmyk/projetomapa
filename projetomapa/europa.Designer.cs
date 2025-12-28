namespace projetomapa
{
    partial class europa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(europa));
            this.portugal = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.portugal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // portugal
            // 
            this.portugal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portugal.BackColor = System.Drawing.Color.Transparent;
            this.portugal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portugal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portugal.Image = ((System.Drawing.Image)(resources.GetObject("portugal.Image")));
            this.portugal.Location = new System.Drawing.Point(77, 639);
            this.portugal.Name = "portugal";
            this.portugal.Size = new System.Drawing.Size(109, 147);
            this.portugal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.portugal.TabIndex = 0;
            this.portugal.TabStop = false;
            this.portugal.Click += new System.EventHandler(this.portugal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2000, 1006);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // europa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2000, 1006);
            this.Controls.Add(this.portugal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "europa";
            this.Text = "europa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.europa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portugal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox portugal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}