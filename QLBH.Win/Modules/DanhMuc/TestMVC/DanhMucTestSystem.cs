using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Data;

namespace QLBanHang.TestMVC
{
    [TestClass]
   public class DanhMucTestSystem
    {
        
        public DanhMucTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 3;
        }
       [TestMethod]
       public void TestTrungTam()
       {
           DSTrungTamView.Instance.ShowDialog();
       }
        [TestMethod]
        public void TestKho()
        {
            DSKhoView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestPhongBan()
        {
            DSPhongBanView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestChucVu()
        {
            DSChucVuView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestNhanVien()
        {
            DSNhanVienView.Instance.ShowDialog();

        }
        [TestMethod]
        public void TestDmLoaiKhachHang()
        {
            DSLoaiKhachHangView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestDonViTinh()
        {
            DSDonViTinhView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestDoiTuong()
        {
            DSDoiTuongView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestLoaiHangHoa()
        {
            DSLoaiSanPhamView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestCachGiaoHang()
        {
            DSCachGiaoHangView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestPhuongThucBanHang()
        {
            DSPhuongThucBanHangView.Instance.ShowDialog();

        }
        [TestMethod]
        public void TestDmCauHinhSanPham()
        {
            DSCauHinhSanPhamView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestDmOrderType()
        {
            DSOrderTypeView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestTaxCode()
        {
            DSBieuMauThueView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestHinhThucThanhToan()
        {
            DSHinhThucThanhToanView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestLoaiThuChi()
        {
            DSThoiHanThanhToanView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestLyDoTraHang()
        {
            DSLyDoTraHangView.Instance.ShowDialog();    
        }
        [TestMethod]
        public void TestDMLoaiHoaDon()
        {
            DSLoaiHoaDonView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestDMChiPhi()
        {
            DSChiPhiView.Instance.ShowDialog();
        }
        [TestMethod]
        public void TestDMNganHang()
        {
            DSNganHangView.Instance.ShowDialog();

        }
        [TestMethod]
        public void TestDMHangHoa()
        {
            DSHangHoaView.Instance.ShowDialog();

        }
        [TestMethod]
        public void TestDMMaLoi()
        {
            DSMaLoiView.Instance.ShowDialog();

        }
        [TestMethod]
        public void TestDMDuAn()
        {
            DSDuAnView.Instance.ShowDialog();

        }
        
        
       
    }
}
