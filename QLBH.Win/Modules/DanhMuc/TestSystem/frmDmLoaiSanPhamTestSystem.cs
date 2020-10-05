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
    public class frmDmLoaiSanPhamTestSystem
    {
        public frmDmLoaiSanPhamTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 3;// 1: golive 2: test1  3 : test
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }

        [TestMethod]
        public void TestLoaiSP()
        {
            frmDM_LoaiSanPham frmDmKhachHang = new frmDM_LoaiSanPham();
            frmDmKhachHang.ShowDialog();
        }
        [TestMethod]
        public void TestDM_CauHinh()
        {
            frmDMCauHinh_LoaiSanPham frmDmKhachHang = new frmDMCauHinh_LoaiSanPham();
            frmDmKhachHang.ShowDialog();
        }
    }
}
