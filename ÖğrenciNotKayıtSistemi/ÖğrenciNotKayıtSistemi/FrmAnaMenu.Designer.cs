
namespace ÖğrenciNotKayıtSistemi
{
    partial class FrmAnaMenu
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
            this.sEÇENEKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sEÇENEKLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sEÇENEKLERToolStripMenuItem
            // 
            this.sEÇENEKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşleriToolStripMenuItem,
            this.öğretmenİşleriToolStripMenuItem,
            this.öğrenciGirişToolStripMenuItem,
            this.öğretmenGirişToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.sEÇENEKLERToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.sEÇENEKLERToolStripMenuItem.Name = "sEÇENEKLERToolStripMenuItem";
            this.sEÇENEKLERToolStripMenuItem.Size = new System.Drawing.Size(190, 41);
            this.sEÇENEKLERToolStripMenuItem.Text = "SEÇENEKLER";
            // 
            // öğrenciİşleriToolStripMenuItem
            // 
            this.öğrenciİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem,
            this.öğrenciListesiToolStripMenuItem});
            this.öğrenciİşleriToolStripMenuItem.Name = "öğrenciİşleriToolStripMenuItem";
            this.öğrenciİşleriToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.öğrenciİşleriToolStripMenuItem.Text = "Öğrenci İşleri";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(325, 42);
            this.öğrenciKayıtToolStripMenuItem.Text = "Öğrenci Güncelle";
            this.öğrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKayıtToolStripMenuItem_Click);
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            this.öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            this.öğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(325, 42);
            this.öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            this.öğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.öğrenciListesiToolStripMenuItem_Click);
            // 
            // öğretmenİşleriToolStripMenuItem
            // 
            this.öğretmenİşleriToolStripMenuItem.Name = "öğretmenİşleriToolStripMenuItem";
            this.öğretmenİşleriToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.öğretmenİşleriToolStripMenuItem.Text = "Öğretmen İşleri";
            // 
            // öğrenciGirişToolStripMenuItem
            // 
            this.öğrenciGirişToolStripMenuItem.Name = "öğrenciGirişToolStripMenuItem";
            this.öğrenciGirişToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.öğrenciGirişToolStripMenuItem.Text = "Öğrenci Giriş";
            // 
            // öğretmenGirişToolStripMenuItem
            // 
            this.öğretmenGirişToolStripMenuItem.Name = "öğretmenGirişToolStripMenuItem";
            this.öğretmenGirişToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.öğretmenGirişToolStripMenuItem.Text = "Öğretmen Giriş";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(308, 42);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaMenu";
            this.Text = "ANA MENU";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sEÇENEKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}