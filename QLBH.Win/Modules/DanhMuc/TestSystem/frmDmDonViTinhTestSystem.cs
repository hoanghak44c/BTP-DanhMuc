using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmDmDonViTinhTestSystem
    {
        public frmDmDonViTinhTestSystem()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }

        [TestMethod]
        public void TestDonViTinh()
        {
            frmDM_DonViTinh frm = new frmDM_DonViTinh();
            frm.ShowDialog();
        }
    }
}
