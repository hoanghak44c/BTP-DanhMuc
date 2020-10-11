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
// form frmDmChucVuTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 23/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmChucVuTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmChucVuTestUnits
    {
        public frmDmChucVuTestUnits()
        {
            ConnectionUtil.Instance.IsUAT = 1;
            //frmLogin frmLogin = new frmLogin();
            //frmLogin.TestLogin("quantri", "khong biet dau");

            ////chuẩn bị dữ liệu để test
            //List<DMChucVuInfor> list = DMChucVuDataProvider.GetListChucVuInfor();
            //List<DMChucVuInfor> listMatch = list.FindAll(delegate(DMChucVuInfor match)
            //{
            //    return match.MaChucVu == "20";
            //});
            //foreach (var dmChucVuInfor in listMatch)
            //{
            //    DMChucVuDataProvider.Instance.Delete(dmChucVuInfor);
            //}
        }
        //Các hàm dưới đây test các unit case của chi tiết chức vụ
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên chức vụ: "Chuc Vu 1", Mã chức vụ: "20", Mô tả: "Unit Test ma chuc vu", Sử dụng: 1
        //frmChiTietChucVu.SetInput("Chuc Nang 1", "20", "Unit Test ma chuc vu", 1);

        [TestMethod]
        public void TestChucVu01_MaChucVuIsNotEmpty()
        {
            try
            {
                frmDM_ChucVu frm = new frmDM_ChucVu();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ChucVu frmChiTietChucNang = new frmChiTiet_ChucVu(frm);
                frmChiTietChucNang.SetInput("Chuc Vu 1", "", "Unit Test ma chuc vu", 1);
                frmChiTietChucNang.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }

        [TestMethod]
        public void TestChucVu02_MaChucVuHasExistedOnInsert()
        {
            try
            {
                frmDM_ChucVu frm = new frmDM_ChucVu();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
                frmChiTietChucVu.SetInput("Chuc Vu 1", "10", "Unit Test ma chuc vu", 1);
                frmChiTietChucVu.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã chức vụ đã tồn tại trong hệ thống!");
            }
        }

        [TestMethod]
        public void TestChucVu03_MaChucVuHasExistedOnUpdate()
        {
            try
            {
                TestChucVu05_InsertSuccess();
                List<DMChucVuInfor> list = DMChucVuDataProvider.GetListChucVuInfor();
                DMChucVuInfor infor = list.Find(delegate(DMChucVuInfor match)
                {
                    return match.MaChucVu == "20";
                });

                frmDM_ChucVu frm = new frmDM_ChucVu();
                frm.isAdd = false;
                frm.Oid = infor.IdChucVu;
                frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
                frmChiTietChucVu.SetInput("Chuc Vu 1", "10", "Unit Test ma chuc vu", 1);
                frmChiTietChucVu.TestSave();
                list = DMChucVuDataProvider.GetListChucVuInfor();
                List<DMChucVuInfor> listDuplicate = list.FindAll(delegate(DMChucVuInfor match)
                {
                    return match.MaChucVu == "10";
                });
                frmChiTietChucVu.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã chức vụ đã tồn tại trong hệ thống!");
                else
                    throw;
            }
        }

        [TestMethod]
        public void TestChucVu04_TenChucVuIsNotEmpty()
        {
            try
            {
                frmDM_ChucVu frm = new frmDM_ChucVu();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
                frmChiTietChucVu.SetInput("", "20", "Unit Test ma chuc vu", 1);
                frmChiTietChucVu.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }

        [TestMethod]
        public void TestChucVu05_InsertSuccess()
        {
            frmDM_ChucVu frm = new frmDM_ChucVu();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
            frmChiTietChucVu.SetInput("Chuc Vu 1", "20", "Unit Test ma chuc vu", 1);
            frmChiTietChucVu.TestSave();
            List<DMChucVuInfor> list = DMChucVuDataProvider.Search(new DMChucVuInfor { MaChucVu = "20" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestChucVu06_DeleteFailure()
        {
            try
            {
                frmDM_ChucVu frm = new frmDM_ChucVu();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
                frmChiTietChucVu.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestChucVu07_DeleteSuccess()
        {
            TestChucVu05_InsertSuccess();
            List<DMChucVuInfor> list = DMChucVuDataProvider.GetListChucVuInfor();
            DMChucVuInfor infor = list.Find(delegate(DMChucVuInfor match)
            {
                return match.MaChucVu == "20";
            });

            frmDM_ChucVu frm = new frmDM_ChucVu();
            frm.isAdd = false;
            frm.Oid = infor.IdChucVu;

            frmChiTiet_ChucVu frmChiTietChucVu = new frmChiTiet_ChucVu(frm);
            frmChiTietChucVu.TestDelete();
            list = DMChucVuDataProvider.GetListChucVuInfor();
            infor = list.Find(delegate(DMChucVuInfor match)
            {
                return match.MaChucVu == "20";
            });

            Assert.AreEqual(infor, null);
        }

        [TestMethod]
        public void TestDmNganHangProvider()
        {
            //DMNganHangDataProvider.Instance.GetListNganhTonKho(1);
        }
    }
}
