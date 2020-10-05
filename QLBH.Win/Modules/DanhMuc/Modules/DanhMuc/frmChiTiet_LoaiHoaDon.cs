using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_LoaiHoaDon : ChiTietLoaiHoaDonController
    {
        #region frmChiTiet_LoaiHoaDon
        public frmChiTiet_LoaiHoaDon(frmDM_LoaiHoaDon frm)
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
            this.lblTieuDe.Text = "CHI TIẾT  LOẠI HÓA ĐƠN";
            // 
            // frmChiTiet_LoaiHoaDon
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Name = "frmChiTiet_LoaiHoaDon";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
