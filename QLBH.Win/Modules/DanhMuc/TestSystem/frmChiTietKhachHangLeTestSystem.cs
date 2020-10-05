using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmChiTietKhachHangLeTestSystem
    {
        public frmChiTietKhachHangLeTestSystem()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }

        [TestMethod]
        public void TestView()
        {
            frmChiTiet_KhachHangLe frmChiTietKhachHangLe = new frmChiTiet_KhachHangLe();
            frmChiTietKhachHangLe.ShowDialog();
        }

        [TestMethod]
        public void TestView2()
        {
            frmDM_KhachHangLe frmDmKhachHangLe = new frmDM_KhachHangLe();
            frmDmKhachHangLe.ShowDialog();
        }
        [TestMethod]
        public void TestNV()
        {
            frmDM_NhanVien frm=new frmDM_NhanVien();
            frm.ShowDialog();
        }
    }
}
