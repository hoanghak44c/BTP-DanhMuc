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
    public class frmDmTrungTamTestSystem
    {
        public frmDmTrungTamTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 1;// 1: golive 2: test1  3 : test 
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "khong biet dau");
        }

        [TestMethod]
        public void TestTrungTam()
        {
            frmDM_TrungTam frm = new frmDM_TrungTam();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestThanhToan()
        {
            frmDM_HinhThucThanhToan frm = new frmDM_HinhThucThanhToan();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestOrderType()
        {
            frmDM_OrderType frm = new frmDM_OrderType();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestHangHoa()
        {
            frmDM_HangHoa frm = new frmDM_HangHoa();
            frm.ShowDialog();
        }
        [TestMethod]
        public void  TestKhachHangLe()
        {
            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestKhachHang()
        {
            frmDM_KhachHang frm = new frmDM_KhachHang();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestHoaDon()
        {
            frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestThuChi()
        {
            frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestTaxCode()
        {
            frmDM_TaxCode frm = new frmDM_TaxCode();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestNhanVien()
        {
            frmDM_NhanVien frm = new frmDM_NhanVien();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestChiPhi()
        {
            frmDM_ChiPhi frm = new frmDM_ChiPhi();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestKho()
        {
            frmDM_Kho frm = new frmDM_Kho();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestPhuongThucBH()
        {
            frmDM_PhuongThucBanHang frm = new frmDM_PhuongThucBanHang();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestListDM()
        {
            frmDM_ListDM frm = new frmDM_ListDM();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLyDoGiaoDich()
        {
            frmDM_LyDoGiaoDich frm = new frmDM_LyDoGiaoDich();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLyDoTraHang()
        {
            frmDM_LyDoTraHang frm = new frmDM_LyDoTraHang();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestCachGiaoHang()
        {
            frmDM_CachGiaoHang frm = new frmDM_CachGiaoHang();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestDonViTinh()
        {
            frmDM_DonViTinh frm = new frmDM_DonViTinh();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestBangKeThue()
        {
            frmDM_BangKeThue frm = new frmDM_BangKeThue();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLoaiDoiTuong()
        {
            frmDM_LoaiDoiTuong frm = new frmDM_LoaiDoiTuong();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLoaiSP()
        {
            frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLoaiHD()
        {
            frmDM_LoaiHoaDon frm = new frmDM_LoaiHoaDon();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestPhongBan()
        {
            frmDM_PhongBan frm = new frmDM_PhongBan();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestCauHinhLoaiSP()
        {
            frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestMaLoi()
        {
            frmDM_MaLoi frm = new frmDM_MaLoi();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestNganHang()
        {
            frmDM_NganHang frm = new frmDM_NganHang();
            frm.ShowDialog();
        }

    }
}
