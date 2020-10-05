namespace QLBanHang.Modules.DanhMuc
{
    partial class frmChiTietSegmentChild_DMChung
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
            this.txtMaCha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.txtMaCha);
            this.groupBoxList.Controls.Add(this.label1);
            this.groupBoxList.Controls.SetChildIndex(this.label1, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMaCha, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblTen, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtTen, 0);
            // 
            // txtMa
            // 
            this.txtMa.Size = new System.Drawing.Size(203, 21);
            // 
            // txtMaCha
            // 
            this.txtMaCha.Location = new System.Drawing.Point(321, 22);
            this.txtMaCha.Name = "txtMaCha";
            this.txtMaCha.Size = new System.Drawing.Size(210, 21);
            this.txtMaCha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã cha";
            // 
            // frmChiTietSegmentChild_DMChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 223);
            this.Name = "frmChiTietSegmentChild_DMChung";
            this.Text = "frmChiTietSegmentChild_DMChung";
            this.Load += new System.EventHandler(this.frmChiTietSegmentChild_DMChung_Load);
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox txtMaCha;
        private System.Windows.Forms.Label label1;
    }
}