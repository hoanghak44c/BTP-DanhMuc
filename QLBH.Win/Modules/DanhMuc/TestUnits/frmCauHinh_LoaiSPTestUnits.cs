using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmCauHinh_LoaiSPTestUnits
    {
        public frmCauHinh_LoaiSPTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<CauHinh_LoaiSanPhamInfo> list = CauHinh_LoaiSanPhamDataProvider.GetCauHinhLoaiSPInfor();
            List<CauHinh_LoaiSanPhamInfo> listMatch = list.FindAll(delegate(CauHinh_LoaiSanPhamInfo match)
            {
                return match.MaCauHinh == "13";
            });
            foreach (var cauHinhLoaiSanPhamInfo in listMatch)
            {
                CauHinh_LoaiSanPhamDataProvider.Delete(cauHinhLoaiSanPhamInfo);                
            }
        }

        [TestMethod]
        public void TestCauHinh01_MaCauHinhIsNotEmpty()
        {
            try
            {
                frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
                //frmChiTiet.SetInput("Test1", "", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã cấu hình không được để trống !");
            }
        }
        [TestMethod]
        public void TestCauHinh02_MaCauHinhHasExistedOnInsert()
        {
            try
            {
                frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
                //frmChiTiet.SetInput("Test1", "03", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã cấu hình đã tồn tại trong hệ thống.Xin hãy kiểm tra lại !");
            }
        }
        [TestMethod]
        public void TestCauHinh03_MaCauHinhHasExistedOnUpdate()
        {
            try
            {
                TestCauHinh05_InsertSuccess();
                List<CauHinh_LoaiSanPhamInfo> list = CauHinh_LoaiSanPhamDataProvider.GetCauHinhLoaiSPInfor();
                CauHinh_LoaiSanPhamInfo infor = list.Find(delegate(CauHinh_LoaiSanPhamInfo match)
                {
                    return match.MaCauHinh == "13";
                });

                frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
                frm.isAdd = false;
                frm.Oid = infor.IdCauHinh;

                frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
                //frmChiTiet.SetInput("Test1", "03", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                list = CauHinh_LoaiSanPhamDataProvider.GetCauHinhLoaiSPInfor();
                List<CauHinh_LoaiSanPhamInfo> listDuplicate = list.FindAll(delegate(CauHinh_LoaiSanPhamInfo match)
                {
                    return match.MaCauHinh == "03";
                });
                frmChiTiet.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã cấu hình đã tồn tại trong hệ thống.Xin hãy kiểm tra lại !");
                else
                    throw;
            }
        }
        [TestMethod]
        public void TestCauHinh04_TenCauHinhIsNotEmpty()
        {
            try
            {
                frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
                //frmChiTiet.SetInput("", "13", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên cấu hình không được để trống !");
            }
        }
        [TestMethod]
        public void TestCauHinh05_InsertSuccess()
        {
            frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
            //frmChiTiet.SetInput("Test1", "13", "Unit test ma du an", 1, 1);
            frmChiTiet.TestSave();
            List<CauHinh_LoaiSanPhamInfo> list = CauHinh_LoaiSanPhamDataProvider.Search(new CauHinh_LoaiSanPhamInfo { MaCauHinh = "13" });
            Assert.AreEqual(list.Count, 1);
        }
        [TestMethod]
        public void TestCauHinh06_DeleteFailure()
        {
            try
            {
                frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_CauHinhLoaiSP frmChiTietDuAn = new frmChiTiet_CauHinhLoaiSP(frm);
                frmChiTietDuAn.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }
        [TestMethod]
        public void TestCauHinh07_DeleteSuccess()
        {
            TestCauHinh05_InsertSuccess();
            List<CauHinh_LoaiSanPhamInfo> list = CauHinh_LoaiSanPhamDataProvider.GetCauHinhLoaiSPInfor();
            CauHinh_LoaiSanPhamInfo infor = list.Find(delegate(CauHinh_LoaiSanPhamInfo match)
            {
                return match.MaCauHinh == "13";
            });

            frmDMCauHinh_LoaiSanPham frm = new frmDMCauHinh_LoaiSanPham();
            frm.isAdd = false;
            frm.Oid = infor.IdCauHinh;

            frmChiTiet_CauHinhLoaiSP frmChiTiet = new frmChiTiet_CauHinhLoaiSP(frm);
            frmChiTiet.TestDelete();
            list = CauHinh_LoaiSanPhamDataProvider.GetCauHinhLoaiSPInfor();
            infor = list.Find(delegate(CauHinh_LoaiSanPhamInfo match)
            {
                return match.MaCauHinh == "13";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
