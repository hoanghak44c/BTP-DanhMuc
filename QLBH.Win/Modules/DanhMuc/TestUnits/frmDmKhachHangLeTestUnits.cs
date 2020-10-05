using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmKhachHangLeTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmKhachHangLeTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmKhachHangLeTestUnits
    {
        public frmDmKhachHangLeTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
            if (list != null)
            {
                List<DMDoiTuongInfo> listMatch = list.FindAll(delegate(DMDoiTuongInfo match)
                {
                    return match.MaDoiTuong == "15121988";
                });
                foreach (var dmKhoInfor in listMatch)
                {
                    DmDoiTuongProvider.Delete(dmKhoInfor);
                }
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết khách hàng lẻ
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên khách hàng: "Nguyễn văn dũng", Mã khách hàng : "15121988",Mã Riêng :"123123",Mã số thuế:"15121988",Ngày sinh :"08/10/1988",Người liên lạc :"lê việt cường" ,OrderType :"123321" ,Địa chỉ:"107/1/14 Lĩnh Nam",Điện thoại:"0436987411" ,Email:"dungnv" ,Fax :"112233",Số CMND:"135308601",Ghi chú :"Units Test Khách Hàng lẻ" ,Sử dụng:1
        //frmChiTietDoiTuong.SetInput("Nguyễn văn dũng","15121988","123123","15121988","18/10/1988","lê việt cường","123321","107/1/14 Lĩnh Nam","0436987411","dungnv","112233","135308601","Units Test Khách Hàng Lẻ",1);
        [TestMethod]
        public void TestDoiTuong01_TenDoiTuongIsNotEmpty()
        {
            try
            {
                frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
                frmChiTietKhachHang.SetInput("Nguyễn văn dũng", "", "123123", "15121988", Convert.ToDateTime("18/10/1988"), "lê việt cường", "123321", "107/1/14 Lĩnh Nam", "0436987411", "dungnv", "112233", "135308601", "Units Test Khách Hàng Lẻ", 1);
                frmChiTietKhachHang.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã khách hàng không được để trống !");
            }
        }

        [TestMethod]
        public void TestKhachHang02_MaKhachHangHasExistedOnInsert()
        {
            try
            {
                frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
                frmChiTietKhachHang.SetInput("Nguyễn văn dũng", "22222222", "123123", "15121988", Convert.ToDateTime("18/10/1988"), "lê việt cường", "123321", "107/1/14 Lĩnh Nam", "0436987411", "dungnv", "112233", "135308601", "Units Test Khách Hàng Lẻ", 1);
                frmChiTietKhachHang.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã khách hàng đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestKhachHang03_MaKhachHangHasExistedOnUpdate()
        {
            try
            {
                TestKhachHang05_InsertSuccess();
                List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
                DMDoiTuongInfo infor = list.Find(delegate(DMDoiTuongInfo match)
                {
                    return match.MaDoiTuong == "15121988";
                });

                frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
                frm.isAdd = false;
                frm.Oid = infor.IdDoiTuong;
                frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
                frmChiTietKhachHang.SetInput("Nguyễn văn dũng", "22222222", "123123", "15121988", Convert.ToDateTime("18/10/1988"), "lê việt cường", "123321", "107/1/14 Lĩnh Nam", "0436987411", "dungnv", "112233", "135308601", "Units Test Khách Hàng Lẻ", 1);
                frmChiTietKhachHang.TestSave();
                list = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
                List<DMDoiTuongInfo> listDuplicate = list.FindAll(delegate(DMDoiTuongInfo match)
                {
                    return match.MaDoiTuong == "22222222";
                });
                frmChiTietKhachHang.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã khách hàng đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestKhachHang04_KhachHangIsNotEmpty()
        {
            try
            {
                frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
                frmChiTietKhachHang.SetInput("", "15121988", "123123", "15121988", Convert.ToDateTime("18/10/1988"), "lê việt cường", "123321", "107/1/14 Lĩnh Nam", "0436987411", "dungnv", "112233", "135308601", "Units Test Khách Hàng Lẻ", 1);
                frmChiTietKhachHang.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên khách hàng không được để trống !");
            }
        }

        [TestMethod]
        public void TestKhachHang05_InsertSuccess()
        {
            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
            frmChiTietKhachHang.SetInput("Nguyễn văn dũng", "15121988", "123123", "15121988", Convert.ToDateTime("18/10/1988"), "lê việt cường", "123321", "107/1/14 Lĩnh Nam", "0436987411", "dungnv", "112233", "135308601", "Units Test Khách Hàng Lẻ", 1);
            frmChiTietKhachHang.TestSave();
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.SearchRieng(new DMDoiTuongInfo() { MaRieng = "123123" });
            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void TestKhachHang06_DeleteFailure()
        {
            try
            {
                frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
                frmChiTietKhachHang.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestKhachHang07_DeleteSuccess()
        {
            TestKhachHang05_InsertSuccess();
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
            DMDoiTuongInfo infor = list.Find(delegate(DMDoiTuongInfo match)
            {
                return match.MaDoiTuong == "15121988";
            });

            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.isAdd = false;
            frm.Oid = infor.IdDoiTuong;
            frmChiTiet_KhachHangLe frmChiTietKhachHang = new frmChiTiet_KhachHangLe(frm);
            frmChiTietKhachHang.TestDelete();
            list = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
            infor = list.Find(delegate(DMDoiTuongInfo match)
            {
                return match.MaDoiTuong == "15121988";
            });
            Assert.AreEqual(infor, null);
        }

        [TestMethod]
        public void TestSys()
        {
            frmDM_KhachHangLe frm = new frmDM_KhachHangLe();
            frm.ShowDialog();
        }
    }
}
