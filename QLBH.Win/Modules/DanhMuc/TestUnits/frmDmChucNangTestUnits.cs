using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmChucNangTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 23/05/2012
// Ngày sửa cuối:
// </remarks>
//todo :@HanhBD frmDmChucNangTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmChucNangTestUnits
    {
        //public frmDmChucNangTestUnits()
        //{
        //    frmLogin frmLogin = new frmLogin();
        //    frmLogin.TestLogin("quantri", "quantri");

        //    //chuẩn bị dữ liệu để test
        //    List<DMChucNangInfor> list = DMChucNangDataProvider.Instance.GetChucNangInfor();
        //    List<DMChucNangInfor> listMatch = list.FindAll(delegate(DMChucNangInfor match)
        //    {
        //        return match.MaChucNang == "39";
        //    });
        //    foreach (var dmChucNangInfor in listMatch)
        //    {
        //        DMChucNangDataProvider.Instance.Delete(dmChucNangInfor);                
        //    }
        //}
        //Các hàm dưới đây test các unit case của chi tiết chức năng
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên chức năng: "Chuc Nang 1", Mã chức năng: "39", Mô tả: "Unit Test ma chuc nang", Sử dụng: 1
        //frmChiTietChucNang.SetInput("Chuc Nang 1", "39", "Unit Test ma chuc nang", 1);

        //[TestMethod]
        //public void TestChucNang01_MaChucNangIsNotEmpty()
        //{
        //    try
        //    {
        //        frmDM_ChucNang frm = new frmDM_ChucNang();
        //        frm.Oid = 0;
        //        frm.isAdd = true;
        //        frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //        frmChiTietChucNang.SetInput("Chuc Nang 1", "", "Unit Test ma chuc nang", 1);
        //        frmChiTietChucNang.TestSave();
        //        Assert.AreEqual("Khong chay dong nay", String.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual(ex.Message, "Mã không được để trống!");
        //    }
        //}

        //[TestMethod]
        //public void TestChucNang02_MaChucNangHasExistedOnInsert()
        //{
        //    try
        //    {
        //        frmDM_ChucNang frm = new frmDM_ChucNang();
        //        frm.Oid = 0;
        //        frm.isAdd = true;
        //        frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //        frmChiTietChucNang.SetInput("Chuc Nang 1", "15", "Unit Test ma chuc nang", 1);
        //        frmChiTietChucNang.TestSave();
        //        Assert.AreEqual("Khong chay dong nay", String.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual(ex.Message, "Mã chức năng đã tồn tại trong hệ thống !");
        //    }
        //}

        //[TestMethod]
        //public void TestChucNang03_MaChucNangHasExistedOnUpdate()
        //{
        //    try
        //    {
        //        TestChucNang05_InsertSuccess();
        //        List<DMChucNangInfor> list = DMChucNangDataProvider.Instance.GetChucNangInfor();
        //        DMChucNangInfor infor = list.Find(delegate(DMChucNangInfor match)
        //        {
        //            return match.MaChucNang == "39";
        //        });

        //        frmDM_ChucNang frm = new frmDM_ChucNang();
        //        frm.isAdd = false;
        //        frm.Oid = infor.IdChucNang;
        //        frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //        frmChiTietChucNang.SetInput("Chuc Nang 1", "15", "Unit Test ma chuc nang", 1);
        //        frmChiTietChucNang.TestSave();
        //        list = DMChucNangDataProvider.Instance.GetChucNangInfor();
        //        List<DMChucNangInfor> listDuplicate = list.FindAll(delegate(DMChucNangInfor match)
        //        {
        //            return match.MaChucNang == "15";
        //        });
        //        frmChiTietChucNang.TestDelete();
        //        Assert.AreEqual(1, listDuplicate.Count);
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.GetType() != typeof(AssertFailedException))
        //            Assert.AreEqual(ex.Message, "Mã chức năng đã tồn tại trong hệ thống !");
        //        else
        //            throw;
        //    }
        //}

        //[TestMethod]
        //public void TestChucNang04_TenChucNangIsNotEmpty()
        //{
        //    try
        //    {
        //        frmDM_ChucNang frm = new frmDM_ChucNang();
        //        frm.Oid = 0;
        //        frm.isAdd = true;
        //        frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //        frmChiTietChucNang.SetInput("", "39", "Unit Test ma chuc nang", 1);
        //        frmChiTietChucNang.TestSave();
        //        Assert.AreEqual("Khong chay dong nay", String.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual(ex.Message, "Tên không được để trống!");
        //    }
        //}

        //[TestMethod]
        //public void TestChucNang05_InsertSuccess()
        //{
        //    frmDM_ChucNang frm = new frmDM_ChucNang();
        //    frm.Oid = 0;
        //    frm.isAdd = true;
        //    frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //    frmChiTietChucNang.SetInput("Chuc Nang 1", "39", "Unit Test ma chuc nang", 1);
        //    frmChiTietChucNang.TestSave();
        //    List<DMChucNangInfor> list = DMChucNangDataProvider.Instance.Search(new DMChucNangInfor { MaChucNang = "39" });
        //    Assert.AreEqual(list.Count, 1);
        //}

        //[TestMethod]
        //public void TestChucNang06_DeleteFailure()
        //{
        //    try
        //    {
        //        frmDM_ChucNang frm = new frmDM_ChucNang();
        //        frm.Oid = 0;
        //        frm.isAdd = true;
        //        frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //        frmChiTietChucNang.TestDelete();
        //        Assert.AreEqual("Khong chay dong nay", String.Empty);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
        //    }
        //}

        //[TestMethod]
        //public void TestChucNang07_DeleteSuccess()
        //{
        //    TestChucNang05_InsertSuccess();
        //    List<DMChucNangInfor> list = DMChucNangDataProvider.Instance.GetChucNangInfor();
        //    DMChucNangInfor infor = list.Find(delegate(DMChucNangInfor match)
        //    {
        //        return match.MaChucNang == "39";
        //    });

        //    frmDM_ChucNang frm = new frmDM_ChucNang();
        //    frm.isAdd = false;
        //    frm.Oid = infor.IdChucNang;

        //    frmChiTiet_ChucNang frmChiTietChucNang = new frmChiTiet_ChucNang(frm);
        //    frmChiTietChucNang.TestDelete();
        //    list = DMChucNangDataProvider.Instance.GetChucNangInfor();
        //    infor = list.Find(delegate(DMChucNangInfor match)
        //    {
        //        return match.MaChucNang == "39";
        //    });

        //    Assert.AreEqual(infor, null);
        //}
    }


}
