using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmListDMTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmListDMTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmListDMTestUnits
    {
        public frmDmListDMTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMListInfor> list = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
            List<DMListInfor> listMatch = list.FindAll(delegate(DMListInfor match)
               {
                   return match.TblName == "tbl_dm_1";
               });
            foreach (var dmListDMInfor in listMatch)
            {
                KhaiBaoDMDataProvider.Delete(dmListDMInfor);
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết ListDM
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên ListDM: "Danh mục 1", Tên bảng : "tbl_dm_1",Sử dụng: 1
        //frmChiTietListDM.SetInput("Danh mục 1", "tbl_dm_1",1);
        [TestMethod]
        public void TestListDM01_TblNameIsNotEmpty()
        {
            try
            {
                frmDM_ListDM frm = new frmDM_ListDM();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.SetInput("Danh mục 1", "", 1);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên bảng không được để trống !");
            }
        }

        [TestMethod]
        public void TestListDM02_TblNameHasExistedOnInsert()
        {
            try
            {
                frmDM_ListDM frm = new frmDM_ListDM();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.SetInput("Danh mục 1", "fgh", 1);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên bảng đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestListDM03_MaListDMHasExistedOnUpdate()
        {
            try
            {
                TestListDM05_InsertSuccess();
                List<DMListInfor> list = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
                DMListInfor infor = list.Find(delegate(DMListInfor match)
                {
                    return match.TblName == "tbl_dm_1";
                });

                frmDM_ListDM frm = new frmDM_ListDM();
                frm.isAdd = true;
                frm.TblName = infor.TblName;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.SetInput("Danh mục 1", "fgh", 1);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Tên bảng đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestListDM04_ListDMIsNotEmpty()
        {
            try
            {
                frmDM_ListDM frm = new frmDM_ListDM();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.SetInput("", "tbl_dm_1", 1);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên danh mục không được để trống !");
            }
        }

        [TestMethod]
        public void TestListDM05_InsertSuccess()
        {
            frmDM_ListDM frm = new frmDM_ListDM();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
            frmChiTietListDM.SetInput("Danh mục 1", "tbl_dm_1", 1);
            frmChiTietListDM.TestSave();
            List<DMListInfor> list = KhaiBaoDMDataProvider.Search(new DMListInfor { TblName = "tbl_dm_1", Name = "Danh mục 1" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestListDM06_DeleteFailure()
        {
            try
            {
                frmDM_ListDM frm = new frmDM_ListDM();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới !");
            }
        }

        [TestMethod]
        public void TestListDM07_DeleteSuccess()
        {
            TestListDM05_InsertSuccess();
            List<DMListInfor> list = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
            DMListInfor infor = list.Find(delegate(DMListInfor match)
            {
                return match.TblName == "tbl_dm_1";
            });

            frmDM_ListDM frm = new frmDM_ListDM();
            frm.isAdd = false;
            frm.TblName = infor.TblName;
            frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
            frmChiTietListDM.TestDelete();
            list = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
            infor = list.Find(delegate(DMListInfor match)
            {
                return match.TblName == "tbl_dm_1";
            });

            Assert.AreEqual(infor, null);
        }
        [TestMethod]
        public void TestListDM08_TenBangHasExistedOnUpdate()
        {
            try
            {
                TestListDM05_InsertSuccess();
                List<DMListInfor> list = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
                DMListInfor infor = list.Find(delegate(DMListInfor match)
                {
                    return match.TblName == "tbl_dm_1";
                });

                frmDM_ListDM frm = new frmDM_ListDM();
                frm.isAdd = false;
                frm.TblName = infor.TblName;
                frmChiTiet_ListDM frmChiTietListDM = new frmChiTiet_ListDM(frm);
                frmChiTietListDM.SetInput("Danh mục 1", "ghi", 1);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Tên bảng cần cập nhật đã bị thay đổi !");
                else
                    throw;
            }
        }
    }
}
