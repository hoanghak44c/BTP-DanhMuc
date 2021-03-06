using System;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_TaxCode : ChiTietTaxCodeController
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTri;
    
        public frmChiTiet_TaxCode(frmDM_TaxCode frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }

        protected override void SetFormInfo()
        {
            base.SetFormInfo();
            txtGiaTri.Text = dm.GiaTri.ToString();
        }
        protected override DMTaxCodeInfor GetFormInfo()
        {
            DMTaxCodeInfor dmTaxCodeInfor = base.GetFormInfo();
            dmTaxCodeInfor.GiaTri = Convert.ToInt32(txtGiaTri.Text);
            return dmTaxCodeInfor;
        }
        private void InitializeComponent()
        {
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "CHI TIẾT TAX CODE";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.txtGiaTri);
            this.groupBoxList.Controls.Add(this.label1);
            this.groupBoxList.Controls.SetChildIndex(this.label1, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtGiaTri, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblTen, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblMoTa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblSuDung, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtTen, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMoTa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.chkSuDung, 0);
            // 
            // chkSuDung
            // 
            this.chkSuDung.TabIndex = 4;
            // 
            // txtMoTa
            // 
            this.txtMoTa.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.TabIndex = 2;
            // 
            // lblSuDung
            // 
            this.lblSuDung.TabIndex = 9;
            // 
            // lblMoTa
            // 
            this.lblMoTa.TabIndex = 8;
            // 
            // lblTen
            // 
            this.lblTen.TabIndex = 7;
            // 
            // lblMa
            // 
            this.lblMa.TabIndex = 5;
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(514, 25);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(219, 22);
            this.txtGiaTri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá trị";
            // 
            // frmChiTiet_TaxCode
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmChiTiet_TaxCode";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}