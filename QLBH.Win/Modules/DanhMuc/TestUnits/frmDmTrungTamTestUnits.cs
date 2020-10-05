using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;
using QLBH.Core.TestUnits;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmTrungTamTestUnits
    {
        private readonly TestController testController;

        public frmDmTrungTamTestUnits()
        {
            //testController = new TestController(new frmDM_TrungTam());
            //isGenDataPerTestMethod = false;
            ConnectionUtil.Instance.IsUAT = 3;// 
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "khong biet dau");
        }

        [TestMethod]
        public void TestTrungTam()
        {
            frmDM_TrungTam frm = new frmDM_TrungTam();
            frm.ShowDialog();
        }
        //[TestMethod]
        //public void TestLoaiSP()
        //{
        //    frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
        //    frm.ShowDialog();
        //}
        //[TestMethod]
        //public void TestCauHinhLoaiSP()
        //{
        //    frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void Testthanhtoan()
        //{
        //    frmDM_ThanhToan frm = new frmDM_ThanhToan();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void Testhoadon()
        //{
        //    frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestOrderType()
        //{
        //    frmDM_OrderType frm = new frmDM_OrderType();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestItem()
        //{
        //    frmDM_LoaiItem frm = new frmDM_LoaiItem();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public  void TestLoaiThuChi()
        //{
        //    frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestDuAn()
        //{
        //    frmDM_DuAn frm = new frmDM_DuAn();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public  void TestDOnViTinh()
        //{
        //    frmDM_DonViTinh frm = new frmDM_DonViTinh();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestListDM()
        //{
        //    frmDM_ListDM frm = new frmDM_ListDM();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestMaLoi()
        //{
        //    frmDM_MaLoi frm = new frmDM_MaLoi();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestTaxtcode()
        //{
        //    frmDM_TaxCode frm = new frmDM_TaxCode();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestTenTe()
        //{
        //    frmDM_TienTe frm = new frmDM_TienTe();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestChucVu()
        //{
        //    frmDM_ChucVu frm = new frmDM_ChucVu();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestChucNang()
        //{
        //    frmDM_ChucNang frm = new frmDM_ChucNang();
        //    frm.ShowDialog();
        //}

        //[TestMethod]
        //public void TestPhongBan()
        //{
        //    frmDM_PhongBan frm = new frmDM_PhongBan();
        //    frm.ShowDialog();
        //}

        [TestMethod]
        public void TestKhachHang()
        {
            frmDM_KhachHang frm = new frmDM_KhachHang();
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestMatHang()
        {
            frmDM_HangHoa frm = new frmDM_HangHoa();
            frm.ShowDialog();
        }

        //[TestMethod]
        //public void TestKho()
        //{
        //    frmDM_Kho frm = new frmDM_Kho();
        //    frm.ShowDialog();
        //}

        [TestMethod]
        public void TestKhachHangLe()
        {
            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.ShowDialog();
        }
        //[TestMethod]
        //public void TestThe()
        //{
        //    frmDM_The frm = new frmDM_The();
        //    frm.ShowDialog();
        //}
        [TestMethod]
        public void TestDMLoaiDT()
        {
            frmDM_LoaiDoiTuong frm = new frmDM_LoaiDoiTuong();
            frm.ShowDialog();
        }
    }

}
