namespace UAS_OOP_1204044
{
    partial class Home
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
            this.InputMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MahasiswaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaksiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputMenuItem,
            this.ViewMenuItem,
            this.UpdateMenuItem,
            this.TransaksiMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InputMenuItem
            // 
            this.InputMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MahasiswaMenuItem,
            this.ProdiMenuItem});
            this.InputMenuItem.Name = "InputMenuItem";
            this.InputMenuItem.Size = new System.Drawing.Size(47, 20);
            this.InputMenuItem.Text = "&Input";
            // 
            // MahasiswaMenuItem
            // 
            this.MahasiswaMenuItem.Name = "MahasiswaMenuItem";
            this.MahasiswaMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MahasiswaMenuItem.Text = "Mahasiswa";
            this.MahasiswaMenuItem.Click += new System.EventHandler(this.MahasiswaMenuItem_Click);
            // 
            // ProdiMenuItem
            // 
            this.ProdiMenuItem.Name = "ProdiMenuItem";
            this.ProdiMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ProdiMenuItem.Text = "Prodi";
            this.ProdiMenuItem.Click += new System.EventHandler(this.ProdiMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewMenuItem.Text = "&View";
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(57, 20);
            this.UpdateMenuItem.Text = "&Update";
            // 
            // TransaksiMenuItem
            // 
            this.TransaksiMenuItem.Name = "TransaksiMenuItem";
            this.TransaksiMenuItem.Size = new System.Drawing.Size(66, 20);
            this.TransaksiMenuItem.Text = "&Transaksi";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 330);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InputMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MahasiswaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransaksiMenuItem;
    }
}

