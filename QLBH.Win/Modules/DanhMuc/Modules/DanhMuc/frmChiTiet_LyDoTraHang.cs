using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_LyDoTraHang: ChiTietLyDoTraHangController
    {
        #region frmChiTiet_LyDoTraHang
        public frmChiTiet_LyDoTraHang(frmDM_LyDoTraHang frm)
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
            this.lblTieuDe.Text = "CHI TIẾT LÝ DO TRẢ HÀNG";
            // 
            // frmChiTiet_LyDoTraHang
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Name = "frmChiTiet_LyDoTraHang";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
