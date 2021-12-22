namespace PolimorfizmExampleForm
{
    partial class FormAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silindirProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küpProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dikdörtgenProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silindirProfilToolStripMenuItem,
            this.küpProfilToolStripMenuItem,
            this.dikdörtgenProfilToolStripMenuItem});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // silindirProfilToolStripMenuItem
            // 
            this.silindirProfilToolStripMenuItem.Name = "silindirProfilToolStripMenuItem";
            this.silindirProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silindirProfilToolStripMenuItem.Text = "Silindir Profil";
            this.silindirProfilToolStripMenuItem.Click += new System.EventHandler(this.silindirProfilToolStripMenuItem_Click);
            // 
            // küpProfilToolStripMenuItem
            // 
            this.küpProfilToolStripMenuItem.Name = "küpProfilToolStripMenuItem";
            this.küpProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.küpProfilToolStripMenuItem.Text = "Küp Profil";
            // 
            // dikdörtgenProfilToolStripMenuItem
            // 
            this.dikdörtgenProfilToolStripMenuItem.Name = "dikdörtgenProfilToolStripMenuItem";
            this.dikdörtgenProfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dikdörtgenProfilToolStripMenuItem.Text = "Dikdörtgen Profil";
            this.dikdörtgenProfilToolStripMenuItem.Click += new System.EventHandler(this.dikdörtgenProfilToolStripMenuItem_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAna";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem silindirProfilToolStripMenuItem;
        private ToolStripMenuItem küpProfilToolStripMenuItem;
        private ToolStripMenuItem dikdörtgenProfilToolStripMenuItem;
    }
}