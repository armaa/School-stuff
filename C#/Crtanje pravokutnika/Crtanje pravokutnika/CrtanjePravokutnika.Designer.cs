namespace Crtanje_pravokutnika
{
    partial class CrtanjePravokutnika
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCrtanje = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlCrtanje
            // 
            this.pnlCrtanje.BackColor = System.Drawing.Color.LightGray;
            this.pnlCrtanje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCrtanje.Location = new System.Drawing.Point(0, 0);
            this.pnlCrtanje.Name = "pnlCrtanje";
            this.pnlCrtanje.Size = new System.Drawing.Size(315, 219);
            this.pnlCrtanje.TabIndex = 0;
            this.pnlCrtanje.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCrtanje_Paint);
            this.pnlCrtanje.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlCrtanje_MouseDown);
            this.pnlCrtanje.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCrtanje_MouseMove);
            this.pnlCrtanje.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlCrtanje_MouseUp);
            // 
            // CrtanjePravokutnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCrtanje);
            this.Name = "CrtanjePravokutnika";
            this.Size = new System.Drawing.Size(315, 219);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrtanje;
    }
}
