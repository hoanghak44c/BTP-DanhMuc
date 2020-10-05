using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmKhoTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmKhoTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmKhoTestUnits
    {
        public frmDmKhoTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMKhoInfo> list = DMKhoDataProvider.GetListDMKhoInfor();
            if (list != null)
            {
                List<DMKhoInfo> listMatch = list.FindAll(delegate(DMKhoInfo match)
                {
                    return match.MaKho == "KN1111";
                });
                foreach (var dmKhoInfor in listMatch)
                {
                    DMKhoDataProvider.Delete(dmKhoInfor);
                }
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết Kho
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên Kho: "Kho nhập", Mã Kho : "KN1111",Mã kho Oracle:"KN1111", địa chỉ :"abcdefgh", điện thoại :"12345678", email :"hanhbdgmail" ,fax:"123456", ghi chú :"UnitsTest Kho", sử dụng :1 
        //frmChiTietKho.SetInput("Kho nhập","KN1111","KN1111","abcdefgh","12345678","hanhbdgmail" ,"123456","UnitsTest Kho",1);
        [TestMethod]
        public void TestKho01_MaKhoIsNotEmpty()
        {
            try
            {
                frmDM_Kho frm = new frmDM_Kho();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
                frmChiTietKho.SetInput("Kho nhập", "", "KN1111", "abcdefgh", "12345678", "hanhbdgmail", "123456", "UnitsTest Kho", 1);
                frmChiTietKho.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã kho không được để trống !");
            }
        }

        [TestMethod]
        public void TestKho02_MaKhoHasExistedOnInsert()
        {
            try
            {
                frmDM_Kho frm = new frmDM_Kho();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
                frmChiTietKho.SetInput("Kho nhập", "1610040006", "KN1111", "abcdefgh", "12345678", "hanhbdgmail", "123456", "UnitsTest Kho", 1);
                frmChiTietKho.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã Kho đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestKho03_MaKhoHasExistedOnUpdate()
        {
            try
            {
                TestKho05_InsertSuccess();
                List<DMKhoInfo> list = DMKhoDataProvider.GetListDMKhoInfor();
                DMKhoInfo infor = list.Find(delegate(DMKhoInfo match)
                {
                    return match.MaKho == "KN1111";
                });

                frmDM_Kho frm = new frmDM_Kho();
                frm.isAdd = false;
                frm.Oid = infor.IdKho;
                frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
                frmChiTietKho.SetInput("Kho nhập", "1610040006", "KN1111", "abcdefgh", "12345678", "hanhbdgmail", "123456", "UnitsTest Kho", 1);
                frmChiTietKho.TestSave();
                list = DMKhoDataProvider.GetListDMKhoInfor();
                List<DMKhoInfo> listDuplicate = list.FindAll(delegate(DMKhoInfo match)
                {
                    return match.MaKho == "1610040006";
                });
                frmChiTietKho.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã Kho đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestKho04_KhoIsNotEmpty()
        {
            try
            {
                frmDM_Kho frm = new frmDM_Kho();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
                frmChiTietKho.SetInput("", "KN1111", "KN1111", "abcdefgh", "12345678", "hanhbdgmail", "123456", "UnitsTest Kho", 1);
                frmChiTietKho.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên kho không được để trống !");
            }
        }

        [TestMethod]
        public void TestKho05_InsertSuccess()
        {
            frmDM_Kho frm = new frmDM_Kho();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
            frmChiTietKho.SetInput("Kho nhập", "KN1111", "KN1111", "abcdefgh", "12345678", "hanhbdgmail", "123456", "UnitsTest Kho", 1);
            frmChiTietKho.TestSave();
            List<DMKhoGridLoadInfo> list = DMKhoDataProvider.Search(new DMKhoGridLoadInfo() { MaKho = "KN1111"});
            Assert.AreEqual(1,list.Count);
        }

        [TestMethod]
        public void TestKho06_DeleteFailure()
        {
            try
            {
                frmDM_Kho frm = new frmDM_Kho();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
                frmChiTietKho.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestKho07_DeleteSuccess()
        {
            TestKho05_InsertSuccess();
            List<DMKhoInfo> list = DMKhoDataProvider.GetListDMKhoInfor();
            DMKhoInfo infor = list.Find(delegate(DMKhoInfo match)
            {
                return match.MaKho == "KN1111";
            });

            frmDM_Kho frm = new frmDM_Kho();
            frm.isAdd = false;
            frm.Oid = infor.IdKho;
            frmChiTiet_Kho frmChiTietKho = new frmChiTiet_Kho(frm);
            frmChiTietKho.TestDelete();
            list = DMKhoDataProvider.GetListDMKhoInfor();
            infor = list.Find(delegate(DMKhoInfo match)
            {
                return match.MaKho == "KN1111";
            });
            Assert.AreEqual(infor, null);
        }
    }
}
