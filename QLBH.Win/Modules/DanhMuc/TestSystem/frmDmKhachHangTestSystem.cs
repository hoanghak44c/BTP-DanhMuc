using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmDmKhachHangTestSystem
    {
        public frmDmKhachHangTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 1;// 1: golive 2: test1  3 : test 
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }

        [TestMethod]
        public void TestView2()
        {
            frmDM_KhachHang frmDmKhachHang = new frmDM_KhachHang();
            frmDmKhachHang.ShowDialog();
        }
        [TestMethod]
        public void TestKhachHangLe()
        {
            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestCauHinhSanPham()
        {
            frm_DM_CauHinhSanPham frm = new frm_DM_CauHinhSanPham();
            frm.ShowDialog();
        }
    }
}
