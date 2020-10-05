using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmDonViTinhTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 23/05/2012
// Ngày sửa cuối:
// </remarks>
//todo :@HanhBD frmDmDonViTinhTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmDonViTinhTestUnits
    {
        public frmDmDonViTinhTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMDonViTinhInfor> list = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
            List<DMDonViTinhInfor> listMatch = list.FindAll(delegate(DMDonViTinhInfor match)
            {
                return match.KyHieu == "DV1";
            });
            foreach (var dmDonViTinhInfor in listMatch)
            {
                DmDonViTinhProvider.Instance.Delete(dmDonViTinhInfor);                
            }
        }

        //Các hàm dưới đây test các unit case của chi tiết đơn vị tính
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên đơn vị tính: "Don Vi 1", Ký Hiệu: "DV1", Mô tả: "Unit Test ky hieu", Sử dụng: 1
        //frmChiTietDonViTinh.SetInput("Don Vi 1", "DV1", "Unit Test ky hieu", 1);

        [TestMethod]
        public void TestDonViTinh01_MaDonViTinhIsNotEmpty()
        {
            try
            {
                frmDM_DonViTinh frm = new frmDM_DonViTinh();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
                frmChiTietDonViTinh.SetInput("Don Vi 1", "", "Unit Test ky hieu", 1);
                frmChiTietDonViTinh.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }

        [TestMethod]
        public void TestDonViTinh02_MaDonViTinhHasExistedOnInsert()
        {
            try
            {
                frmDM_DonViTinh frm = new frmDM_DonViTinh();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DonViTinh frmChiTietChucNang = new frmChiTiet_DonViTinh(frm);
                frmChiTietChucNang.SetInput("Don Vi 1", "CHI", "Unit Test ky hieu", 1);
                frmChiTietChucNang.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã đơn vị tính đã có trong hệ thống!");
            }
        }

        [TestMethod]
        public void TestDonViTinh03_MaDonViTinhHasExistedOnUpdate()
        {
            try
            {
                TestDonViTinh05_InsertSuccess();
                List<DMDonViTinhInfor> list = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
                DMDonViTinhInfor infor = list.Find(delegate(DMDonViTinhInfor match)
                {
                    return match.KyHieu == "DV1";
                });

                frmDM_DonViTinh frm = new frmDM_DonViTinh();
                frm.isAdd = false;
                frm.Oid = infor.IdDonViTinh;
                frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
                frmChiTietDonViTinh.SetInput("Don Vi 1", "CHI", "Unit Test ky hieu", 1);
                frmChiTietDonViTinh.TestSave();
                list = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
                List<DMDonViTinhInfor> listDuplicate = list.FindAll(delegate(DMDonViTinhInfor match)
                {
                    return match.KyHieu == "CHI";
                });
                frmChiTietDonViTinh.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã đơn vị tính đã có trong hệ thống!");
                else
                    throw;
            }
        }

        [TestMethod]
        public void TestDonViTinh04_TenDonViTinhIsNotEmpty()
        {
            try
            {
                frmDM_DonViTinh frm = new frmDM_DonViTinh();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
                frmChiTietDonViTinh.SetInput("", "DV1", "Unit Test ky hieu", 1);
                frmChiTietDonViTinh.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }

        [TestMethod]
        public void TestDonViTinh05_InsertSuccess()
        {
            frmDM_DonViTinh frm = new frmDM_DonViTinh();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
            frmChiTietDonViTinh.SetInput("Don Vi 1", "DV1", "Unit Test ky hieu", 1);
            frmChiTietDonViTinh.TestSave();
            List<DMDonViTinhInfor> list = DmDonViTinhProvider.Instance.Search(new DMDonViTinhInfor { KyHieu = "DV1" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestDonViTinh06_DeleteFailure()
        {
            try
            {
                frmDM_DonViTinh frm = new frmDM_DonViTinh();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
                frmChiTietDonViTinh.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestDonViTinh07_DeleteSuccess()
        {
            TestDonViTinh05_InsertSuccess();
            List<DMDonViTinhInfor> list = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
            DMDonViTinhInfor infor = list.Find(delegate(DMDonViTinhInfor match)
            {
                return match.KyHieu == "DV1";
            });

            frmDM_DonViTinh frm = new frmDM_DonViTinh();
            frm.isAdd = false;
            frm.Oid = infor.IdDonViTinh;

            frmChiTiet_DonViTinh frmChiTietDonViTinh = new frmChiTiet_DonViTinh(frm);
            frmChiTietDonViTinh.TestDelete();
            list = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
            infor = list.Find(delegate(DMDonViTinhInfor match)
            {
                return match.KyHieu == "DV1";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
