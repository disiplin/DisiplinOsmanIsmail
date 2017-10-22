namespace Disiplin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriAltÖToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDisiplinListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBilgileriniAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriAltÖToolStripMenuItem,
            this.denemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriAltÖToolStripMenuItem
            // 
            this.öğrenciİşlemleriAltÖToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciDisiplinListeleToolStripMenuItem,
            this.öğrenciBilgileriniAlToolStripMenuItem});
            this.öğrenciİşlemleriAltÖToolStripMenuItem.Name = "öğrenciİşlemleriAltÖToolStripMenuItem";
            this.öğrenciİşlemleriAltÖToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.öğrenciİşlemleriAltÖToolStripMenuItem.Text = "Öğrenci İşlemleri ";
            this.öğrenciİşlemleriAltÖToolStripMenuItem.Click += new System.EventHandler(this.öğrenciİşlemleriAltÖToolStripMenuItem_Click);
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciDisiplinListeleToolStripMenuItem
            // 
            this.öğrenciDisiplinListeleToolStripMenuItem.Name = "öğrenciDisiplinListeleToolStripMenuItem";
            this.öğrenciDisiplinListeleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.öğrenciDisiplinListeleToolStripMenuItem.Text = "Öğrenci Disiplin Listele";
            // 
            // öğrenciBilgileriniAlToolStripMenuItem
            // 
            this.öğrenciBilgileriniAlToolStripMenuItem.Name = "öğrenciBilgileriniAlToolStripMenuItem";
            this.öğrenciBilgileriniAlToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.öğrenciBilgileriniAlToolStripMenuItem.Text = "Öğrenci Bilgilerini Al";
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.denemeToolStripMenuItem.Text = "Deneme ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 345);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriAltÖToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDisiplinListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciBilgileriniAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
    }
}

