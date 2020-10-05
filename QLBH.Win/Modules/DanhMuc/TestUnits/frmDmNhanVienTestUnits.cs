using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmNhanVienTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmNhanVienTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmNhanVienTestUnits
    {
        public frmDmNhanVienTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMNhanVienInfo> list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
            if (list != null)
            {
                List<DMNhanVienInfo> listMatch = list.FindAll(delegate(DMNhanVienInfo match)
                {
                    return match.MaNhanVien == "TA111";
                });
                foreach (var dmNhanVienInfor in listMatch)
                {
                    DmNhanVienDataProvider.Delete(dmNhanVienInfor);
                }
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết NhanVien
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên Nhân Viên: "Bùi Đức Hạnh", Mã nhân viên : "TA111",ngày sinh:"04/02/1988", địa chỉ :"abcdef", điện thoại :"12345678", email :"hanhbd@gmail.com" , ghi chú :"UnitsTest Nhan Vien", sử dụng :1,IdPhong ban : 42, Id Chức vụ :1
        //frmChiTietNhanVien.SetInput("Bùi Đức Hạnh","TA111","04/02/1988","abcdef","12345678","hanhbd@gmail.com","UnitsTest Nhan Vien",1,42,1);
        [TestMethod]
        public void TestNhanVien01_MaNhanVienIsNotEmpty()
        {
            try
            {
                frmDM_NhanVien frm = new frmDM_NhanVien();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
                frmChiTietNhanVien.SetInput("Bùi Đức Hạnh", "", "04/02/1988", "abcdef", "12345678", "hanhbd@gmail.com", "UnitsTest Nhan Vien", 1,42,1);
                frmChiTietNhanVien.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã nhân viên không được để trống !");
            }
        }

        [TestMethod]
        public void TestNhanVien02_MaNhanVienHasExistedOnInsert()
        {
            try
            {
                frmDM_NhanVien frm = new frmDM_NhanVien();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
                frmChiTietNhanVien.SetInput("Bùi Đức Hạnh", "TA004", "04/02/1988", "abcdef", "12345678", "hanhbd@gmail.com", "UnitsTest Nhan Vien", 1, 42, 1);
                frmChiTietNhanVien.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã nhân viên đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestNhanVien03_MaNhanVienHasExistedOnUpdate()
        {
            try
            {
                TestNhanVien05_InsertSuccess();
                List<DMNhanVienInfo> list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
                DMNhanVienInfo infor = list.Find(delegate(DMNhanVienInfo match)
                {
                    return match.MaNhanVien == "TA111";
                });

                frmDM_NhanVien frm = new frmDM_NhanVien();
                frm.isAdd = false;
                frm.Oid = infor.IdNhanVien;
                frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
                frmChiTietNhanVien.SetInput("Bùi Đức Hạnh", "TA004", "04/02/1988", "abcdef", "12345678", "hanhbd@gmail.com", "UnitsTest Nhan Vien", 1, 42, 1);
                frmChiTietNhanVien.TestSave();
                list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
                List<DMNhanVienInfo> listDuplicate = list.FindAll(delegate(DMNhanVienInfo match)
                {
                    return match.MaNhanVien == "TA004";
                });
                frmChiTietNhanVien.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã nhân viên đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestNhanVien04_NhanVienIsNotEmpty()
        {
            try
            {
                frmDM_NhanVien frm = new frmDM_NhanVien();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
                frmChiTietNhanVien.SetInput("", "TA111", "04/02/1988", "abcdef", "12345678", "hanhbd@gmail.com", "UnitsTest Nhan Vien", 1,42,1);
                frmChiTietNhanVien.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên nhân viên không được để trống !");
            }
        }

        [TestMethod]
        public void TestNhanVien05_InsertSuccess()
        {
            frmDM_NhanVien frm = new frmDM_NhanVien();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
            frmChiTietNhanVien.SetInput("Bùi Đức Hạnh", "TA111", "04/02/1988", "abcdef", "12345678", "hanhbd@gmail.com", "UnitsTest Nhan Vien", 1,42,1);
            frmChiTietNhanVien.TestSave();
            List<DMNhanVienInfo> list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
            //todo : HanhBD xem lại store search
            //List<DMNhanVienInfo> listMatch = list.FindAll(delegate(DMNhanVienInfo match)
            //{
            //    return match.MaNhanVien == "TA111";
            //});
            //List<DmNhanVienGridInfo> listMatch = DmNhanVienDataProvider.Search(new DmNhanVienGridInfo() { MaNhanVien = "111" });

            //Assert.AreEqual(1, listMatch.Count);
        }

        [TestMethod]
        public void TestNhanVien06_DeleteFailure()
        {
            try
            {
                frmDM_NhanVien frm = new frmDM_NhanVien();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
                frmChiTietNhanVien.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới !");
            }
        }

        [TestMethod]
        public void TestNhanVien07_DeleteSuccess()
        {
            TestNhanVien05_InsertSuccess();
            List<DMNhanVienInfo> list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
            DMNhanVienInfo infor = list.Find(delegate(DMNhanVienInfo match)
            {
                return match.MaNhanVien == "TA111";
            });

            frmDM_NhanVien frm = new frmDM_NhanVien();
            frm.isAdd = false;
            frm.Oid = infor.IdNhanVien;
            frmChiTiet_NhanVien frmChiTietNhanVien = new frmChiTiet_NhanVien(frm);
            frmChiTietNhanVien.TestDelete();
            list = DmNhanVienDataProvider.GetListDmNhanVienInfor();
            infor = list.Find(delegate(DMNhanVienInfo match)
            {
                return match.MaNhanVien == "TA111";
            });
            Assert.AreEqual(infor, null);
        }
    }
}
