namespace presentacion
{
    partial class mdicontainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPropiedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propiedadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // propiedadToolStripMenuItem
            // 
            this.propiedadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPropiedadToolStripMenuItem});
            this.propiedadToolStripMenuItem.Name = "propiedadToolStripMenuItem";
            this.propiedadToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.propiedadToolStripMenuItem.Text = "Propiedad";
            // 
            // nuevaPropiedadToolStripMenuItem
            // 
            this.nuevaPropiedadToolStripMenuItem.Name = "nuevaPropiedadToolStripMenuItem";
            this.nuevaPropiedadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaPropiedadToolStripMenuItem.Text = "Nueva propiedad";
            this.nuevaPropiedadToolStripMenuItem.Click += new System.EventHandler(this.nuevaPropiedadToolStripMenuItem_Click);
            // 
            // mdicontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mdicontainer";
            this.Text = "mdicontainer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propiedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPropiedadToolStripMenuItem;
    }
}