using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;

// <Remarks>
// form frmDmDuAnTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 22/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmDuAnTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmDuAnTestUnits
    {
        public frmDmDuAnTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMDuAnInfor> list = DMDuAnDataProvider.Instance.GetListDuAnInfo();
            List<DMDuAnInfor> listMatch = list.FindAll(delegate(DMDuAnInfor match)
            {
                return match.MaDuAn == "13";
            });
            foreach (var dmDuAnInfor in listMatch)
            {
                DMDuAnDataProvider.Instance.Delete(dmDuAnInfor);
            }
        }

        [TestMethod]
        public void TestDuAn99_SystemTest()
        {
            //frmDM_DuAn frm = new frmDM_DuAn();
            //frm.ShowDialog();
        }

        //Các hàm dưới đây test các unit case của chi tiết dự án
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên dự án: "Test1", Mã dự án: "13", Mô tả: "Unit test ma du an", Sử dụng: 1
        //frmChiTietDuAn.SetInput("Test1", "13", "Unit test ma du an", 1);

        [TestMethod]
        public void TestDuAn01_MaDuAnIsNotEmpty()
        {
            try
            {
                frmDM_DuAn frm = new frmDM_DuAn();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
                frmChiTietDuAn.SetInput("Test1", "", "Unit test ma du an", 1);
                frmChiTietDuAn.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }

        [TestMethod]
        public void TestDuAn02_MaDuAnHasExistedOnInsert()
        {
            try
            {
                frmDM_DuAn frm = new frmDM_DuAn();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
                frmChiTietDuAn.SetInput("Test1", "03", "Unit test ma du an", 1);
                frmChiTietDuAn.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã đã tồn tại trong hệ thống!");
            }
        }

        [TestMethod]
        public void TestDuAn03_MaDuAnHasExistedOnUpdate()
        {
            try
            {
                TestDuAn05_InsertSuccess();
                List<DMDuAnInfor> list = DMDuAnDataProvider.Instance.GetListDuAnInfo();
                DMDuAnInfor infor = list.Find(delegate(DMDuAnInfor match)
                {
                    return match.MaDuAn == "13";
                });

                frmDM_DuAn frm = new frmDM_DuAn();
                frm.isAdd = false;
                frm.Oid = infor.IdDuAn;
                frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
                frmChiTietDuAn.SetInput("Test1", "03", "Unit test ma du an", 1);
                frmChiTietDuAn.TestSave();
                list = DMDuAnDataProvider.Instance.GetListDuAnInfo();
                List<DMDuAnInfor> listDuplicate = list.FindAll(delegate(DMDuAnInfor match)
                {
                    return match.MaDuAn == "03";
                });
                frmChiTietDuAn.TestDelete();
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
        public void TestDuAn04_TenDuAnIsNotEmpty()
        {
            try
            {
                frmDM_DuAn frm = new frmDM_DuAn();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
                frmChiTietDuAn.SetInput("", "13", "Unit test ma du an", 1);
                frmChiTietDuAn.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }

        [TestMethod]
        public void TestDuAn05_InsertSuccess()
        {
            frmDM_DuAn frm = new frmDM_DuAn();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
            frmChiTietDuAn.SetInput("Test1", "13", "Unit test ma du an", 1);
            frmChiTietDuAn.TestSave();
            //List<DMDuAnInfor> list = DMDuAnDataProvider.Instance.Search(new DMDuAnInfor { MaDuAn = "13" });
            //Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(true, DMDuAnDataProvider.Instance.IsExisted(new DMDuAnInfor(){MaDuAn = "13"}));
        }

        [TestMethod]
        public void TestDuAn06_DeleteFailure()
        {
            try
            {
                frmDM_DuAn frm = new frmDM_DuAn();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
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
            TestDuAn05_InsertSuccess();
            List<DMDuAnInfor> list = DMDuAnDataProvider.Instance.GetListDuAnInfo();
            DMDuAnInfor infor = list.Find(delegate(DMDuAnInfor match)
            {
                return match.MaDuAn == "13";
            });

            frmDM_DuAn frm = new frmDM_DuAn();
            frm.isAdd = false;
            frm.Oid = infor.IdDuAn;

            frmChiTiet_DuAn frmChiTietDuAn = new frmChiTiet_DuAn(frm);
            frmChiTietDuAn.TestDelete();
            list = DMDuAnDataProvider.Instance.GetListDuAnInfo();
            infor = list.Find(delegate(DMDuAnInfor match)
            {
                return match.MaDuAn == "13";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
