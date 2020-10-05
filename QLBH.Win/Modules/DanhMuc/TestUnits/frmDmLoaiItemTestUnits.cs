using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmLoaiItemTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 24/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmLoaiItemTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmLoaiItemTestUnits
    {
        public frmDmLoaiItemTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMLoaiItemInfor> list = DMLoaiItemDataProvider.GetListItemInfor();
            List<DMLoaiItemInfor> listMatch = list.FindAll(delegate(DMLoaiItemInfor match)
            {
                return match.MaLoaiItem == "5";
            });
            foreach (var dmLoaiItemInfor in listMatch)
            {
                DMLoaiItemDataProvider.Delete(dmLoaiItemInfor);                
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết loaiItem
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên loai Item: "loai item 3", Mã Loai Item: "5", Mô tả: "Unit test ma loai item ", Sử dụng: 1
        //frmChiTietLoaiItem.SetInput("loai item 3", "5", "Unit test ma loai item", 1);
        [TestMethod]
        public void TestLoaiItem01_LoaiItemIsNotEmpty()
        {
            try
            {
                frmDM_LoaiItem frm = new frmDM_LoaiItem();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
                frmChiTietLoaiItem.SetInput("LoaiItem1", "", "Unit test ma LoaiItem", 1);
                frmChiTietLoaiItem.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã loại Item không được để trống !");
            }
        }

        [TestMethod]
        public void TestLoaiItem02_MaLoaiItemHasExistedOnInsert()
        {
            try
            {
                frmDM_LoaiItem frm = new frmDM_LoaiItem();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
                frmChiTietLoaiItem.SetInput("LoaiItem1", "01", "Unit test ma LoaiItem", 1);
                frmChiTietLoaiItem.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã loại Item đã có trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestLoaiItem03_MaLoaiItemHasExistedOnUpdate()
        {
            try
            {
                TestLoaiItem05_InsertSuccess();
                List<DMLoaiItemInfor> list = DMLoaiItemDataProvider.GetListItemInfor();
                DMLoaiItemInfor infor = list.Find(delegate(DMLoaiItemInfor match)
                {
                    return match.MaLoaiItem == "5";
                });

                frmDM_LoaiItem frm = new frmDM_LoaiItem();
                frm.isAdd = false;
                frm.Oid = infor.IdLoaiItem;
                frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
                frmChiTietLoaiItem.SetInput("LoaiItem1", "1", "Unit test ma LoaiItem", 1);
                frmChiTietLoaiItem.TestSave();
                list = DMLoaiItemDataProvider.GetListItemInfor();
                List<DMLoaiItemInfor> listDuplicate = list.FindAll(delegate(DMLoaiItemInfor match)
                {
                    return match.MaLoaiItem == "1";
                });
                frmChiTietLoaiItem.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã loại Item đã có trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestLoaiItem04_TenLoaiItemIsNotEmpty()
        {
            try
            {
                frmDM_LoaiItem frm = new frmDM_LoaiItem();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
                frmChiTietLoaiItem.SetInput("", "5", "Unit test ma LoaiItem", 1);
                frmChiTietLoaiItem.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên loại Item không được để trống !");
            }
        }

        [TestMethod]
        public void TestLoaiItem05_InsertSuccess()
        {
            frmDM_LoaiItem frm = new frmDM_LoaiItem();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
            frmChiTietLoaiItem.SetInput("LoaiItem1", "5", "Unit test ma LoaiItem", 1);
            frmChiTietLoaiItem.TestSave();
            List<DMLoaiItemInfor> list = DMLoaiItemDataProvider.Search(new DMLoaiItemInfor { MaLoaiItem = "5" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestLoaiItem06_DeleteFailure()
        {
            try
            {
                frmDM_LoaiItem frm = new frmDM_LoaiItem();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
                frmChiTietLoaiItem.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới !");
            }
        }

        [TestMethod]
        public void TestLoaiItem07_DeleteSuccess()
        {
            TestLoaiItem05_InsertSuccess();
            List<DMLoaiItemInfor> list = DMLoaiItemDataProvider.GetListItemInfor();
            DMLoaiItemInfor infor = list.Find(delegate(DMLoaiItemInfor match)
            {
                return match.MaLoaiItem == "5";
            });

            frmDM_LoaiItem frm = new frmDM_LoaiItem();
            frm.isAdd = false;
            frm.Oid = infor.IdLoaiItem;

            frmChiTiet_LoaiItem frmChiTietLoaiItem = new frmChiTiet_LoaiItem(frm);
            frmChiTietLoaiItem.TestDelete();
            list = DMLoaiItemDataProvider.GetListItemInfor();
            infor = list.Find(delegate(DMLoaiItemInfor match)
            {
                return match.MaLoaiItem == "5";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
