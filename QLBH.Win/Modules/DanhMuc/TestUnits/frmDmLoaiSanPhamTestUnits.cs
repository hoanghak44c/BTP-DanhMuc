using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.HeThong;
using QLBH.Core.TestUnits;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmLoaiSanPhamTestUnits
    {
        public frmDmLoaiSanPhamTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMLoaiSanPhamInfo> list = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
            List<DMLoaiSanPhamInfo> listMatch = list.FindAll(delegate(DMLoaiSanPhamInfo match)
            {
                return match.MaLoaiSP == "13";
            });
            foreach (var dmLoaiSanPhamInfo in listMatch)
            {
                DMLoaiSanPhamDataProvider.Instance.Delete(dmLoaiSanPhamInfo);                
            }
        }
        [TestMethod]
        public void TestLoaiSP01_MaLoaiSPIsNotEmpty()
        {
            try
            {
                frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
                frmChiTiet.SetInput("Test1", "", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }
        [TestMethod]
        public void TestLoaiSP02_MaLoaiSPHasExistedOnInsert()
        {
            try
            {
                frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
                frmChiTiet.SetInput("Test1", "03", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã đã tồn tại trong hệ thống!");
            }
        }
        [TestMethod]
        public void TestCauHinh03_MaCauHinhHasExistedOnUpdate()
        {
            try
            {
                TestLoaiSP05_InsertSuccess();
                List<DMLoaiSanPhamInfo> list = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
                DMLoaiSanPhamInfo infor = list.Find(delegate(DMLoaiSanPhamInfo match)
                {
                    return match.MaLoaiSP == "13";
                });

                frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
                frm.isAdd = false;
                frm.Oid = infor.IdLoaiSP;

                frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
                frmChiTiet.SetInput("Test1", "03", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                list = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
                List<DMLoaiSanPhamInfo> listDuplicate = list.FindAll(delegate(DMLoaiSanPhamInfo match)
                {
                    return match.MaLoaiSP == "03";
                });
                frmChiTiet.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã đã tồn tại trong hệ thống!");
                else
                    throw;
            }
        }
        [TestMethod]
        public void TestLoaiSP04_TenLoaiSPIsNotEmpty()
        {
            try
            {
                frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
                frmChiTiet.SetInput("", "13", "Unit test ma du an", 1, 1);
                frmChiTiet.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }
        [TestMethod]
        public void TestLoaiSP05_InsertSuccess()
        {
            frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
            frmChiTiet.SetInput("Test1", "13", "Unit test ma du an", 1, 1);
            frmChiTiet.TestSave();
            List<DMLoaiSanPhamInfo> list = DMLoaiSanPhamDataProvider.Search(new DMLoaiSanPhamInfo { MaLoaiSP = "13" });
            Assert.AreEqual(list.Count, 1);
        }
        [TestMethod]
        public void TestLoaiSP06_DeleteFailure()
        {
            try
            {
                frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiSanPham frmChiTietDuAn = new frmChiTiet_LoaiSanPham(frm);
                frmChiTietDuAn.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }
        [TestMethod]
        public void TestDuAn07_DeleteSuccess()
        {
            TestLoaiSP05_InsertSuccess();
            List<DMLoaiSanPhamInfo> list = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
            DMLoaiSanPhamInfo infor = list.Find(delegate(DMLoaiSanPhamInfo match)
            {
                return match.MaLoaiSP == "13";
            });

            frmDM_LoaiSanPham frm = new frmDM_LoaiSanPham();
            frm.isAdd = false;
            frm.Oid = infor.IdLoaiSP;

            frmChiTiet_LoaiSanPham frmChiTiet = new frmChiTiet_LoaiSanPham(frm);
            frmChiTiet.TestDelete();
            list = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
            infor = list.Find(delegate(DMLoaiSanPhamInfo match)
            {
                return match.MaLoaiSP == "13";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
