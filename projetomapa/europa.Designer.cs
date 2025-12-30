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
            this.espanha = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.portugal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // portugal
            // 
            this.portugal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portugal.BackColor = System.Drawing.Color.Transparent;
            this.portugal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.portugal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portugal.Image = ((System.Drawing.Image)(resources.GetObject("portugal.Image")));
            this.portugal.Location = new System.Drawing.Point(202, 714);
            this.portugal.Margin = new System.Windows.Forms.Padding(12);
            this.portugal.Name = "portugal";
            this.portugal.Size = new System.Drawing.Size(30, 40);
            this.portugal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portugal.TabIndex = 0;
            this.portugal.TabStop = false;
            this.portugal.Click += new System.EventHandler(this.portugal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1444, 941);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // espanha
            // 
            this.espanha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.espanha.BackColor = System.Drawing.Color.Transparent;
            this.espanha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.espanha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.espanha.Image = ((System.Drawing.Image)(resources.GetObject("espanha.Image")));
            this.espanha.Location = new System.Drawing.Point(299, 727);
            this.espanha.Margin = new System.Windows.Forms.Padding(12);
            this.espanha.Name = "espanha";
            this.espanha.Size = new System.Drawing.Size(30, 40);
            this.espanha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.espanha.TabIndex = 2;
            this.espanha.TabStop = false;
            this.espanha.Click += new System.EventHandler(this.espanha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // europa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 941);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.espanha);
            this.Controls.Add(this.portugal);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "europa";
            this.Text = "europa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.europa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portugal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espanha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox portugal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox espanha;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}