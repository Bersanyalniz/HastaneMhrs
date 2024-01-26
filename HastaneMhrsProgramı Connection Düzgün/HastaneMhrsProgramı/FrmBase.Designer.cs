
namespace HastaneMhrsProgramı
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mevcutRandevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorEkleToolStripMenuItem,
            this.kayıtToolStripMenuItem,
            this.mevcutRandevularToolStripMenuItem,
            this.pToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // doktorEkleToolStripMenuItem
            // 
            this.doktorEkleToolStripMenuItem.Name = "doktorEkleToolStripMenuItem";
            this.doktorEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.doktorEkleToolStripMenuItem.Text = "Doktor Ekle";
            this.doktorEkleToolStripMenuItem.Click += new System.EventHandler(this.doktorEkleToolStripMenuItem_Click);
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.kayıtToolStripMenuItem.Text = "Randevu Oluştur";
            this.kayıtToolStripMenuItem.Click += new System.EventHandler(this.kayıtToolStripMenuItem_Click);
            // 
            // mevcutRandevularToolStripMenuItem
            // 
            this.mevcutRandevularToolStripMenuItem.Name = "mevcutRandevularToolStripMenuItem";
            this.mevcutRandevularToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.mevcutRandevularToolStripMenuItem.Text = "Mevcut Randevular";
            this.mevcutRandevularToolStripMenuItem.Click += new System.EventHandler(this.mevcutRandevularToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.pToolStripMenuItem.Text = "Poliklinik Ekle";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 243);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBase";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mevcutRandevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

