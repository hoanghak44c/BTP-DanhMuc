using QLBanHang.Modules.DanhMuc.Base;

// <Remarks>
// form frmChiTiet_DonViTinh
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 25/04/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_DonViTinh

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_DonViTinh : ChiTietDonViTinhController
    {
        #region frmChiTiet_DonViTinh
        public frmChiTiet_DonViTinh(frmDM_DonViTinh frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }
        #endregion


        #region Action

        private void InitializeComponent()
        {
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "CHI TIẾT ĐƠN VỊ TÍNH";
            // 
            // frmChiTiet_DonViTinh
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTiet_DonViTinh";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }

}