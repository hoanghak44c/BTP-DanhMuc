using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmTrungTamTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 25/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmTrungTamTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmTrungTamTestUnit
    {
        public frmDmTrungTamTestUnit()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMTrungTamInfor> list = DMTrungTamDataProvider.GetListTrungTamInfo();
            List<DMTrungTamInfor> listMatch = list.FindAll(delegate(DMTrungTamInfor match)
            {
                return match.MaTrungTam == "111";
            });
            foreach (var dmTrungTamInfor in listMatch)
            {
                DMTrungTamDataProvider.Delete(dmTrungTamInfor);
            }
        }

        //Các hàm dưới đây test các unit case của chi tiết trung tâm
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên trung tâm: "TrungTam1", Mã trung tâm: "111",Địa chỉ:"Thai Thinh 2",Điện thoại:"043840856",Fax:"045621543",Email:"hanhbd@gmail", Mô tả: "Unit test ma trung tam ", Sử dụng: 1
        //frmChiTietTrungTam.SetInput("TrungTam1", "111","Thai Thinh 2","043840856","045621543","hanhbuiduck5a@gmail.com", "Unit test ma trung tam ", 1);

        [TestMethod]
        public void TestTrungTam01_MaTrungTamIsNotEmpty()
        {
            try
            {
                frmDM_TrungTam frm = new frmDM_TrungTam();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
                frmChiTietTrungTam.SetInput("TrungTam1", "", "Thai Thinh 2", "043840856", "045621543", "hanhbd@gmail", "Unit test ma TrungTam", 1);
                frmChiTietTrungTam.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã trung tâm không được để trống !");
            }
        }
        [TestMethod]
        public void TestTrungTam02_MaTrungTamHasExistedOnInsert()
        {
            try
            {
                frmDM_TrungTam frm = new frmDM_TrungTam();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
                frmChiTietTrungTam.SetInput("TrungTam1", "2222", "Thai Thinh 2", "043840856", "045621543", "hanhbd@gmail", "Unit test ma TrungTam", 1);
                frmChiTietTrungTam.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã trung tâm đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestTrungTam03_MaTrungTamHasExistedOnUpdate()
        {
            try
            {
                TestTrungTam05_InsertSuccess();
                List<DMTrungTamInfor> list = DMTrungTamDataProvider.GetListTrungTamInfo();
                DMTrungTamInfor infor = list.Find(delegate(DMTrungTamInfor match)
                {
                    return match.MaTrungTam == "111";
                });

                frmDM_TrungTam frm = new frmDM_TrungTam();
                frm.isAdd = false;
                frm.Oid = infor.IdTrungTam;
                frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
                frmChiTietTrungTam.SetInput("TrungTam1", "2222", "Thai Thinh 2", "043840856", "045621543", "hanhbd@gmail", "Unit test ma TrungTam", 1);
                frmChiTietTrungTam.TestSave();
                list = DMTrungTamDataProvider.GetListTrungTamInfo();
                List<DMTrungTamInfor> listDuplicate = list.FindAll(delegate(DMTrungTamInfor match)
                {
                    return match.MaTrungTam == "2222";
                });
                frmChiTietTrungTam.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã trung tâm đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestTrungTam04_TenTrungTamIsNotEmpty()
        {
            try
            {
                frmDM_TrungTam frm = new frmDM_TrungTam();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
                frmChiTietTrungTam.SetInput("", "111", "Thai Thinh 2", "043840856", "045621543", "hanhbd@gmail", "Unit test ma TrungTam", 1);
                frmChiTietTrungTam.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên trung tâm không được để trống !");
            }
        }

        [TestMethod]
        public void TestTrungTam05_InsertSuccess()
        {
            frmDM_TrungTam frm = new frmDM_TrungTam();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
            frmChiTietTrungTam.SetInput("TrungTam1", "111", "Thai Thinh 2", "043840856", "045621543", "hanhbd@gmail", "Unit test ma TrungTam", 1);
            frmChiTietTrungTam.TestSave();
            List<DMTrungTamInfor> list = DMTrungTamDataProvider.Search(new DMTrungTamInfor { MaTrungTam = "111" });
            //List<DMTrungTamInfor> list = DMTrungTamDataProvider.Search(t = "111"});
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestTrungTam06_DeleteFailure()
        {
            try
            {
                frmDM_TrungTam frm = new frmDM_TrungTam();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
                frmChiTietTrungTam.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestTrungTam07_DeleteSuccess()
        {
            TestTrungTam05_InsertSuccess();
            List<DMTrungTamInfor> list = DMTrungTamDataProvider.GetListTrungTamInfo();
            DMTrungTamInfor infor = list.Find(delegate(DMTrungTamInfor match)
            {
                return match.MaTrungTam == "111";
            });

            frmDM_TrungTam frm = new frmDM_TrungTam();
            frm.isAdd = false;
            frm.Oid = infor.IdTrungTam;
            frmChiTiet_TrungTam frmChiTietTrungTam = new frmChiTiet_TrungTam(frm);
            frmChiTietTrungTam.TestDelete();
            list = DMTrungTamDataProvider.GetListTrungTamInfo();
            infor = list.Find(delegate(DMTrungTamInfor match)
            {
                return match.MaTrungTam == "111";
            });

            Assert.AreEqual(null, infor);
        }
    }
}
