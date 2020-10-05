using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmListDmTestSystem
    {
        public frmListDmTestSystem()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }
        [TestMethod]
        public void TestListDm()
        {
            frmDM_ListDM frm = new frmDM_ListDM();
            frm.ShowDialog();
        }
    }
}
