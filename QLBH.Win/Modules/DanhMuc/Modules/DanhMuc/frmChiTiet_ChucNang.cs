using QLBanHang.Modules.DanhMuc.Base;

// <Remarks>
// form frmChiTiet_ChucNang
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 03/05/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_ChucNang

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_ChucNang : ChiTietChucNangController
    {
        #region Declare
        private int idChucNang;
        #endregion
        

        #region frmChiTiet_ChucNang
        public frmChiTiet_ChucNang(int idChucNang)
        {
            InitializeComponent();
            this.idChucNang = idChucNang;
        }

        public frmChiTiet_ChucNang(frmDM_ChucNang frm)
        {
            InitializeComponent();
            this.frmList = frm;
        }
        #endregion

        private void InitializeComponent()
        {
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "CHI TIẾT CHỨC NĂNG";
            // 
            // frmChiTiet_ChucNang
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmChiTiet_ChucNang";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}