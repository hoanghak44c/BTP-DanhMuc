using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmPhongBanTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 24/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmPhongBanTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmPhongBanTestUnits
    {
        public frmDmPhongBanTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMPhongBanInfor> list = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
            List<DMPhongBanInfor> listMatch = list.FindAll(delegate(DMPhongBanInfor match)
            {
                return match.MaPhongBan == "PB1";
            });
            foreach (var dmPhongBanInfor in listMatch)
            {
                DMPhongBanDataProvider.Instance.Delete(dmPhongBanInfor);                
            }
        }

        //Các hàm dưới đây test các unit case của chi tiết phòng ban
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên phòng ban: "Phong Ban 1", Mã phòng ban: "PB1", Mô tả: "Unit test ma phong ban", Sử dụng: 1
        //frmChiTietPhongBan.SetInput("Phong Ban 1", "PB1", "Unit test ma phong ban", 1);

        [TestMethod]
        public void TestPhongBan01_MaPhongBanIsNotEmpty()
        {
            try
            {
                frmDM_PhongBan frm = new frmDM_PhongBan();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
                frmChiTietPhongBan.SetInput("Phong Ban 1", "", "Unit test ma phong ban", 1);
                frmChiTietPhongBan.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }

        [TestMethod]
        public void TestPhongBan02_MaPhongBanHasExistedOnInsert()
        {
            try
            {
                frmDM_PhongBan frm = new frmDM_PhongBan();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
                frmChiTietPhongBan.SetInput("Phong Ban 1", "BGD", "Unit test ma phong ban", 1);
                frmChiTietPhongBan.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã đã tồn tại trong hệ thống!");
            }
        }
        [TestMethod]
        public void TestPhongBan03_MaPhongBanHasExistedOnUpdate()
        {
            try
            {
                TestPhongBan05_InsertSuccess();
                List<DMPhongBanInfor> list = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
                DMPhongBanInfor infor = list.Find(delegate(DMPhongBanInfor match)
                {
                    return match.MaPhongBan == "PB1";
                });

                frmDM_PhongBan frm = new frmDM_PhongBan();
                frm.isAdd = false;
                frm.Oid = infor.IdPhongBan;
                frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
                frmChiTietPhongBan.SetInput("Phong Ban 1", "BGD", "Unit test ma phong ban", 1);
                frmChiTietPhongBan.TestSave();
                list = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
                List<DMPhongBanInfor> listDuplicate = list.FindAll(delegate(DMPhongBanInfor match)
                {
                    return match.MaPhongBan == "BGD";
                });
                frmChiTietPhongBan.TestDelete();
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
        public void TestPhongBan04_TenPhongBanIsNotEmpty()
        {
            try
            {
                frmDM_PhongBan frm = new frmDM_PhongBan();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
                frmChiTietPhongBan.SetInput("", "PB1", "Unit test ma phong ban", 1);
                frmChiTietPhongBan.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }

        [TestMethod]
        public void TestPhongBan05_InsertSuccess()
        {
            frmDM_PhongBan frm = new frmDM_PhongBan();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
            frmChiTietPhongBan.SetInput("Phong Ban 1", "PB1", "Unit test ma phong ban", 1);
            frmChiTietPhongBan.TestSave();
            List<DMPhongBanInfor> list = DMPhongBanDataProvider.Instance.Search(new DMPhongBanInfor { MaPhongBan = "PB1" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestPhongBan06_DeleteFailure()
        {
            try
            {
                frmDM_PhongBan frm = new frmDM_PhongBan();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
                frmChiTietPhongBan.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestPhongBan07_DeleteSuccess()
        {
            TestPhongBan05_InsertSuccess();
            List<DMPhongBanInfor> list = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
            DMPhongBanInfor infor = list.Find(delegate(DMPhongBanInfor match)
            {
                return match.MaPhongBan == "PB1";
            });

            frmDM_PhongBan frm = new frmDM_PhongBan();
            frm.isAdd = false;
            frm.Oid = infor.IdPhongBan;

            frmChiTiet_PhongBan frmChiTietPhongBan = new frmChiTiet_PhongBan(frm);
            frmChiTietPhongBan.TestDelete();
            list = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
            infor = list.Find(delegate(DMPhongBanInfor match)
            {
                return match.MaPhongBan == "PB1";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
