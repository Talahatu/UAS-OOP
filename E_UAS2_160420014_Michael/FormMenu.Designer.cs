
namespace E_UAS2_160420014_Michael
{
    partial class FormMenu
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
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanDanAmbilUangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.simpanToolStripMenuItem,
            this.displayDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpananToolStripMenuItem});
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.addDataToolStripMenuItem.Text = "Add Data";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // simpanToolStripMenuItem
            // 
            this.simpanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpanDanAmbilUangToolStripMenuItem});
            this.simpanToolStripMenuItem.Name = "simpanToolStripMenuItem";
            this.simpanToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.simpanToolStripMenuItem.Text = "Pendanaan Pribadi";
            // 
            // simpananToolStripMenuItem
            // 
            this.simpananToolStripMenuItem.Name = "simpananToolStripMenuItem";
            this.simpananToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.simpananToolStripMenuItem.Text = "Simpanan dan Simpanan Rencana";
            this.simpananToolStripMenuItem.Click += new System.EventHandler(this.simpananToolStripMenuItem_Click);
            // 
            // simpanDanAmbilUangToolStripMenuItem
            // 
            this.simpanDanAmbilUangToolStripMenuItem.Name = "simpanDanAmbilUangToolStripMenuItem";
            this.simpanDanAmbilUangToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.simpanDanAmbilUangToolStripMenuItem.Text = "Simpan dan Ambil Dana";
            this.simpanDanAmbilUangToolStripMenuItem.Click += new System.EventHandler(this.simpanDanAmbilUangToolStripMenuItem_Click);
            // 
            // displayDataToolStripMenuItem
            // 
            this.displayDataToolStripMenuItem.Name = "displayDataToolStripMenuItem";
            this.displayDataToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.displayDataToolStripMenuItem.Text = "Display Data";
            this.displayDataToolStripMenuItem.Click += new System.EventHandler(this.displayDataToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanDanAmbilUangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDataToolStripMenuItem;
    }
}

