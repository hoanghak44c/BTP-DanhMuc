using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_DMChung
    {
        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota, int iSudung)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtMa.Text = sMa;
            txtMoTa.Text = sMota;
            chkSuDung.Checked = iSudung == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            Save();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion

    }
}
