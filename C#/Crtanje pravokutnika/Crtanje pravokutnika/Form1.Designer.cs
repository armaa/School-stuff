﻿namespace Crtanje_pravokutnika
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
            this.crtanjePravokutnika = new Crtanje_pravokutnika.CrtanjePravokutnika();
            this.SuspendLayout();
            // 
            // crtanjePravokutnika
            // 
            this.crtanjePravokutnika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crtanjePravokutnika.Location = new System.Drawing.Point(12, 12);
            this.crtanjePravokutnika.Name = "crtanjePravokutnika";
            this.crtanjePravokutnika.Size = new System.Drawing.Size(760, 538);
            this.crtanjePravokutnika.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.crtanjePravokutnika);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crtač pravokutnika";
            this.ResumeLayout(false);

        }

        #endregion

        private CrtanjePravokutnika crtanjePravokutnika;

    }
}
