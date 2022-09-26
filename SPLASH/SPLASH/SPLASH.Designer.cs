namespace SPLASH
{
    partial class SPLASH
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
            this.barraCarga = new System.Windows.Forms.ProgressBar();
            this.timeBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraCarga
            // 
            this.barraCarga.ForeColor = System.Drawing.Color.Lime;
            this.barraCarga.Location = new System.Drawing.Point(136, 277);
            this.barraCarga.Name = "barraCarga";
            this.barraCarga.Size = new System.Drawing.Size(100, 23);
            this.barraCarga.TabIndex = 0;
            // 
            // timeBar
            // 
            this.timeBar.Interval = 50;
            this.timeBar.Tick += new System.EventHandler(this.timeBar_Tick);
            // 
            // SPLASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SPLASH.Properties.Resources.fact_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 344);
            this.Controls.Add(this.barraCarga);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SPLASH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ç";
            this.Load += new System.EventHandler(this.SPLASH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar barraCarga;
        private System.Windows.Forms.Timer timeBar;
    }
}