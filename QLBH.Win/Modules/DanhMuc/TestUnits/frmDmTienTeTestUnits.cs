using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmTienTeTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 22/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmTienTeTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmTienTeTestUnits
    {
        public frmDmTienTeTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMTienTeInfor> list = DMTienTeDataProvider.GetListTienTeInfor();
            List<DMTienTeInfor> listMatch = list.FindAll(delegate(DMTienTeInfor match)
            {
                return match.KyHieu == "SGP";
            });
            foreach (var dmTienTeInfor in listMatch)
            {
                DMTienTeDataProvider.Delete(dmTienTeInfor);
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết tiền tệ
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên tiền tệ: "Singapo", Mã tiền tệ: "SGP", Mô tả: "Unit test ma tien te ", Sử dụng: 1, Tỷ giá :"20"
        //frmChiTietTienTe.SetInput("Singapo", "SGP", "Unit test ma tien te", 1,20);
        [TestMethod]
        public void TestTienTe01_TienTeIsNotEmpty()
        {
            try
            {
                frmDM_TienTe frm = new frmDM_TienTe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
                frmChiTietTienTe.SetInput("Singapo", "", "Unit test ma tien te", 1, 20);
                frmChiTietTienTe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã tiền tệ không được để trống !");
            }
        }

        [TestMethod]
        public void TestTienTe02_KyHieuHasExistedOnInsert()
        {
            try
            {
                frmDM_TienTe frm = new frmDM_TienTe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
                frmChiTietTienTe.SetInput("Singapo", "VND", "Unit test ma tien te", 1, 20);
                frmChiTietTienTe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã tiền tệ đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestTienTe03_KyHieuHasExistedOnUpdate()
        {
            try
            {
                TestTienTe05_InsertSuccess();
                List<DMTienTeInfor> list = DMTienTeDataProvider.GetListTienTeInfor();
                DMTienTeInfor infor = list.Find(delegate(DMTienTeInfor match)
                {
                    return match.KyHieu == "SGP";
                });

                frmDM_TienTe frm = new frmDM_TienTe();
                frm.isAdd = false;
                frm.Oid = infor.IdTienTe;
                frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
                frmChiTietTienTe.SetInput("Singapo", "VND", "Unit test ma tien te", 1, 20);
                frmChiTietTienTe.TestSave();
                list = DMTienTeDataProvider.GetListTienTeInfor();
                List<DMTienTeInfor> listDuplicate = list.FindAll(delegate(DMTienTeInfor match)
                {
                    return match.KyHieu == "VND";
                });
                frmChiTietTienTe.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã tiền tệ đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestTienTe04_TenTienTeIsNotEmpty()
        {
            try
            {
                frmDM_TienTe frm = new frmDM_TienTe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
                frmChiTietTienTe.SetInput("", "SGP", "Unit test ma tien te", 1, 20);
                frmChiTietTienTe.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên tiền tệ không được để trống !");
            }
        }

        [TestMethod]
        public void TestTienTe05_InsertSuccess()
        {
            frmDM_TienTe frm = new frmDM_TienTe();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
            frmChiTietTienTe.SetInput("Singapo", "SGP", "Unit test ma tien te", 1, 20);
            frmChiTietTienTe.TestSave();
            List<DMTienTeInfor> list = DMTienTeDataProvider.Search(new DMTienTeInfor { KyHieu = "SGP" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestTienTe06_DeleteFailure()
        {
            try
            {
                frmDM_TienTe frm = new frmDM_TienTe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
                frmChiTietTienTe.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestTienTe07_DeleteSuccess()
        {
            TestTienTe05_InsertSuccess();
            List<DMTienTeInfor> list = DMTienTeDataProvider.GetListTienTeInfor();
            DMTienTeInfor infor = list.Find(delegate(DMTienTeInfor match)
            {
                return match.KyHieu == "SGP";
            });

            frmDM_TienTe frm = new frmDM_TienTe();
            frm.isAdd = false;
            frm.Oid = infor.IdTienTe;

            frmChiTiet_TienTe frmChiTietTienTe = new frmChiTiet_TienTe(frm);
            frmChiTietTienTe.TestDelete();
            list = DMTienTeDataProvider.GetListTienTeInfor();
            infor = list.Find(delegate(DMTienTeInfor match)
            {
                return match.KyHieu == "SGP";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
