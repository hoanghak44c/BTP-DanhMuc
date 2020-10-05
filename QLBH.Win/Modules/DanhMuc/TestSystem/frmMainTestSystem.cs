using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules;
using QLBanHang.Modules.HeThong;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmMainTestSystem
    {
        public frmMainTestSystem()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("tuanna", "tuanna");
        }

        [TestMethod]
        public void TestView()
        {
            //frmMain frmMain = new frmMain();
            //frmMain.ShowDialog();
        }
    }
}
