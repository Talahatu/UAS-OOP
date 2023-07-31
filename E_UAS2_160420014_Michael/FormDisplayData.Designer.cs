
namespace E_UAS2_160420014_Michael
{
    partial class FormDisplayData
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpanan = new System.Windows.Forms.RadioButton();
            this.radioButtonSimpananRencana = new System.Windows.Forms.RadioButton();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display : ";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(107, 13);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(51, 24);
            this.radioButtonAll.TabIndex = 1;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonSimpanan
            // 
            this.radioButtonSimpanan.AutoSize = true;
            this.radioButtonSimpanan.Location = new System.Drawing.Point(230, 13);
            this.radioButtonSimpanan.Name = "radioButtonSimpanan";
            this.radioButtonSimpanan.Size = new System.Drawing.Size(106, 24);
            this.radioButtonSimpanan.TabIndex = 2;
            this.radioButtonSimpanan.TabStop = true;
            this.radioButtonSimpanan.Text = "Simpanan";
            this.radioButtonSimpanan.UseVisualStyleBackColor = true;
            this.radioButtonSimpanan.CheckedChanged += new System.EventHandler(this.radioButtonSimpanan_CheckedChanged);
            // 
            // radioButtonSimpananRencana
            // 
            this.radioButtonSimpananRencana.AutoSize = true;
            this.radioButtonSimpananRencana.Location = new System.Drawing.Point(405, 13);
            this.radioButtonSimpananRencana.Name = "radioButtonSimpananRencana";
            this.radioButtonSimpananRencana.Size = new System.Drawing.Size(175, 24);
            this.radioButtonSimpananRencana.TabIndex = 3;
            this.radioButtonSimpananRencana.TabStop = true;
            this.radioButtonSimpananRencana.Text = "Simpanan Rencana";
            this.radioButtonSimpananRencana.UseVisualStyleBackColor = true;
            this.radioButtonSimpananRencana.CheckedChanged += new System.EventHandler(this.radioButtonSimpananRencana_CheckedChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 20;
            this.listBoxInfo.Location = new System.Drawing.Point(32, 57);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(739, 364);
            this.listBoxInfo.TabIndex = 4;
            // 
            // FormDisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.radioButtonSimpananRencana);
            this.Controls.Add(this.radioButtonSimpanan);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.label1);
            this.Name = "FormDisplayData";
            this.Text = "FormDisplayData";
            this.Load += new System.EventHandler(this.FormDisplayData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonSimpanan;
        private System.Windows.Forms.RadioButton radioButtonSimpananRencana;
        private System.Windows.Forms.ListBox listBoxInfo;
    }
}