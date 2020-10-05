using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmOrderTypeTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 26/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmOrderTypeTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmOrderTypeTestUnits
    {
        public frmDmOrderTypeTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMOrderTypeInfor> list = DMOrderTypeProvider.GetListOrderTypeInfor();
            List<DMOrderTypeInfor> listMatch = list.FindAll(delegate(DMOrderTypeInfor match)
            {
                return match.OrderType == "004001NuocNgoai";
            });
            foreach (var dmOrderTypeInfor in listMatch)
            {
                DMOrderTypeProvider.Delete(dmOrderTypeInfor);
            }
        }

        //Các hàm dưới đây test các unit case của chi tiết OrderType
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên OrderType: "Bán ngoài nước", Mã OrderType: "004001NuocNgoai", Mô tả: "Unit test OrderType ", Sử dụng: 1, Line:"004001NN"
        //frmChiTietOrderType.SetInput("Bán ngoài nước", "004001NuocNgoai", "Unit test OrderType", 1,"004001NN");
        [TestMethod]
        public void TestOrderType01_OrderTypeIsNotEmpty()
        {
            try
            {
                frmDM_OrderType frm = new frmDM_OrderType();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
                frmChiTietOrderType.SetInput("Bán ngoài nước", "", "Unit test OrderType", 1, "004001NN");
                frmChiTietOrderType.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã OrderType không được để trống !");
            }
        }

        [TestMethod]
        public void TestOrderType02_MaOrderTypeHasExistedOnInsert()
        {
            try
            {
                frmDM_OrderType frm = new frmDM_OrderType();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
                frmChiTietOrderType.SetInput("Bán ngoài nước", "123", "Unit test OrderType", 1, "004001NN");
                frmChiTietOrderType.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã OrderType đã tồn tại trong hệ thống!");
            }
        }
        [TestMethod]
        public void TestOrderType03_MaOrderTypeHasExistedOnUpdate()
        {
            try
            {
                TestOrderType05_InsertSuccess();
                List<DMOrderTypeInfor> list = DMOrderTypeProvider.GetListOrderTypeInfor();
                DMOrderTypeInfor infor = list.Find(delegate(DMOrderTypeInfor match)
                {
                    return match.OrderType == "004001NuocNgoai";
                });

                frmDM_OrderType frm = new frmDM_OrderType();
                frm.isAdd = false;
                frm.Oid = infor.IdOrderType;
                frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
                frmChiTietOrderType.SetInput("Bán ngoài nước", "123", "Unit test OrderType", 1, "004001NN");
                frmChiTietOrderType.TestSave();
                list = DMOrderTypeProvider.GetListOrderTypeInfor();
                List<DMOrderTypeInfor> listDuplicate = list.FindAll(delegate(DMOrderTypeInfor match)
                {
                    return match.OrderType == "123";
                });
                frmChiTietOrderType.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã OrderType đã tồn tại trong hệ thống!");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestOrderType04_TenOrderTypeIsNotEmpty()
        {
            try
            {
                frmDM_OrderType frm = new frmDM_OrderType();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
                frmChiTietOrderType.SetInput("", "004001NuocNgoai", "Unit test OrderType", 1, "004001NN");
                frmChiTietOrderType.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên OrderType không được để trống !");
            }
        }

        [TestMethod]
        public void TestOrderType05_InsertSuccess()
        {
            frmDM_OrderType frm = new frmDM_OrderType();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
            frmChiTietOrderType.SetInput("Bán ngoài nước", "004001NuocNgoai", "Unit test OrderType", 1, "004001NN");
            frmChiTietOrderType.TestSave();
            List<DMOrderTypeInfor> list = DMOrderTypeProvider.Search(new DMOrderTypeInfor { OrderType = "004001NuocNgoai" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestOrderType06_DeleteFailure()
        {
            try
            {
                frmDM_OrderType frm = new frmDM_OrderType();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
                frmChiTietOrderType.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestOrderType07_DeleteSuccess()
        {
            TestOrderType05_InsertSuccess();
            List<DMOrderTypeInfor> list = DMOrderTypeProvider.GetListOrderTypeInfor();
            DMOrderTypeInfor infor = list.Find(delegate(DMOrderTypeInfor match)
            {
                return match.OrderType == "004001NuocNgoai";
            });

            frmDM_OrderType frm = new frmDM_OrderType();
            frm.isAdd = false;
            frm.Oid = infor.IdOrderType;

            frmChiTiet_OrderType frmChiTietOrderType = new frmChiTiet_OrderType(frm);
            frmChiTietOrderType.TestDelete();
            list = DMOrderTypeProvider.GetListOrderTypeInfor();
            infor = list.Find(delegate(DMOrderTypeInfor match)
            {
                return match.OrderType == "004001NuocNgoai";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
