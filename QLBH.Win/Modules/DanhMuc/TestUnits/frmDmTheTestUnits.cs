using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmTheTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmTheTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmTheTestUnits
    {
        public frmDmTheTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMLoaiTheKhachHangInfo> list = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfor();
           if(list != null)
           {
               List<DMLoaiTheKhachHangInfo> listMatch = list.FindAll(delegate(DMLoaiTheKhachHangInfo match)
               {
                   return match.MaThe == "1111";
               });
               foreach (var dmTheInfor in listMatch)
               {
                   DmLoaitheKhachHangProvider.Delete(dmTheInfor);
               }
           }
        }
        //Các hàm dưới đây test các unit case của chi tiết The
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên The: "Thẻ số 1 ", Mã thẻ : "1111",Tích Lũy Từ:100 , Tích Lũy đến :150 , Giá trị mua lần đầu :555000 , Bảo lưu điểm :55 , Tính năng khác :2 , Hiệu lực :3 
        //frmChiTietThe.SetInput("Thẻ số 1 ","1111",100,150,555000,55,2,3);
        [TestMethod]
        public void TestThe01_TenTheIsNotEmpty()
        {
            try
            {
                frmDM_The frm = new frmDM_The();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
                frmChiTietThe.SetInput("Thẻ số 1 ", "", 100, 150, 555000, 55, 2, 3);
                frmChiTietThe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã thẻ không được để trống !");
            }
        }

        [TestMethod]
        public void TestThe02_MaTheHasExistedOnInsert()
        {
            try
            {
                frmDM_The frm = new frmDM_The();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
                frmChiTietThe.SetInput("Thẻ số 1 ", "12345", 100, 150, 555000, 55, 2, 3);
                frmChiTietThe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã thẻ đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestThe03_MaTheHasExistedOnUpdate()
        {
            try
            {
                TestThe05_InsertSuccess();
                List<DMLoaiTheKhachHangInfo> list = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfor();
                DMLoaiTheKhachHangInfo infor = list.Find(delegate(DMLoaiTheKhachHangInfo match)
                {
                    return match.MaThe == "1111";
                });

                frmDM_The frm = new frmDM_The();
                frm.isAdd = false;
                frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
                frmChiTietThe.SetInput("Thẻ số 1 ", "12345", 100, 150, 555000, 55, 2, 3);
                frmChiTietThe.TestSave();
                list = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfor();
                List<DMLoaiTheKhachHangInfo> listDuplicate = list.FindAll(delegate(DMLoaiTheKhachHangInfo match)
                {
                    return match.MaThe == "12345";
                });
                frmChiTietThe.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã thẻ đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestThe04_TheIsNotEmpty()
        {
            try
            {
                frmDM_The frm = new frmDM_The();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
                frmChiTietThe.SetInput("", "1111", 100, 150, 555000, 55, 2, 3);
                frmChiTietThe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên thẻ không được để trống !");
            }
        }

        [TestMethod]
        public void TestThe05_InsertSuccess()
        {
            frmDM_The frm = new frmDM_The();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
            frmChiTietThe.SetInput("Thẻ số 1", "1111", 100, 150, 555000, 55, 2, 3);
            frmChiTietThe.TestSave();
            List<DMLoaiTheKhachHangInfo> list = DmLoaitheKhachHangProvider.Search(new DMLoaiTheKhachHangInfo { TenThe = "Thẻ số 1", MaThe = "1111" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestThe06_DeleteFailure()
        {
            try
            {
                frmDM_The frm = new frmDM_The();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
                frmChiTietThe.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestThe07_DeleteSuccess()
        {
            TestThe05_InsertSuccess();
            List<DMLoaiTheKhachHangInfo> list = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfor();
            DMLoaiTheKhachHangInfo infor = list.Find(delegate(DMLoaiTheKhachHangInfo match)
            {
                return match.MaThe == "1111";
            });

            frmDM_The frm = new frmDM_The();
            frm.isAdd = false;
            frm.Oid = infor.IdLoaiThe;
            frmChiTiet_The frmChiTietThe = new frmChiTiet_The(frm);
            frmChiTietThe.TestDelete();
            list = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfor();
            infor = list.Find(delegate(DMLoaiTheKhachHangInfo match)
            {
                return match.MaThe == "1111";
            });
            Assert.AreEqual(infor, null);
        }
    }
}
