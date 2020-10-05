using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmKhachHangTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmKhachHangTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmKhachHangTestUnits
    {
        public frmDmKhachHangTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfo();
            if (list != null)
            {
                List<DMDoiTuongInfo> listMatch = list.FindAll(delegate(DMDoiTuongInfo match)
                {
                    return match.MaDoiTuong == "11021986";
                });
                foreach (var dmKhoInfor in listMatch)
                {
                    DmDoiTuongProvider.Delete(dmKhoInfor);
                }
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết đối Tượng
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên đối Tượng: "Nguyễn bá hải", Mã đối tượng : "11021986",Mã số thuế:"11021986" ,Người liên lạc :"lê cường" ,ngày sinh :"11/12/2011",OrderType :"123321" ,Điện thoại:"0436987411" ,Email:"hainb" ,Fax :"112233" ,Ghi chú :"Units Test Khách Hàng" ,Sử dụng:1
        //frmChiTietDoiTuong.SetInput("Nguyễn bá hải","11021986","11021986","11/12/2011","lê cường","123321","0436987411","hainb","112233","Units Test Khách Hàng",1);
        [TestMethod]
        public void TestDoiTuong01_TenDoiTuongIsNotEmpty()
        {
            try
            {
                frmDM_KhachHang frm = new frmDM_KhachHang();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
                frmChiTietKhachHang.SetInput("Nguyễn bá hải", "", "11021986", Convert.ToDateTime("11/12/2011"), "lê cường", "123321", "0436987411", "hainb", "112233", "Units Test Khách Hàng", 1);
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
                frmDM_KhachHang frm = new frmDM_KhachHang();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
                frmChiTietKhachHang.SetInput("Nguyễn bá hải", "22222222", "11021986", Convert.ToDateTime("11/12/2011"), "lê cường", "123321", "0436987411", "hainb", "112233", "Units Test Khách Hàng", 1);
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
                List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfo();
                DMDoiTuongInfo infor = list.Find(delegate(DMDoiTuongInfo match)
                {
                    return match.MaDoiTuong == "11021986";
                });

                frmDM_KhachHang frm = new frmDM_KhachHang();
                frm.isAdd = false;
                frm.Oid = infor.IdDoiTuong;
                frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
                frmChiTietKhachHang.SetInput("Nguyễn bá hải", "22222222", "11021986", Convert.ToDateTime("11/12/2011"), "lê cường", "123321", "0436987411", "hainb", "112233", "Units Test Khách Hàng", 1);
                frmChiTietKhachHang.TestSave();
                list = DmDoiTuongProvider.GetListDmDoiTuongInfo();
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
                frmDM_KhachHang frm = new frmDM_KhachHang();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
                frmChiTietKhachHang.SetInput("", "11021986", "11021986",Convert.ToDateTime("11/12/2011"), "lê cường", "123321", "0436987411", "hainb", "112233", "Units Test Khách Hàng", 1);
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
            frmDM_KhachHang frm = new frmDM_KhachHang();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
            frmChiTietKhachHang.SetInput("Nguyễn bá hải", "11021986", "11021986",Convert.ToDateTime("11/12/2011"), "lê cường", "123321", "0436987411", "hainb", "112233", "Units Test Khách Hàng", 1);
            frmChiTietKhachHang.TestSave();
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.Search(new DMDoiTuongInfo() { MaDoiTuong = "11021986" });
            Assert.AreEqual(1,list.Count);
        }

        [TestMethod]
        public void TestKhachHang06_DeleteFailure()
        {
            try
            {
                frmDM_KhachHang frm = new frmDM_KhachHang();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
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
            List<DMDoiTuongInfo> list = DmDoiTuongProvider.GetListDmDoiTuongInfo();
            DMDoiTuongInfo infor = list.Find(delegate(DMDoiTuongInfo match)
            {
                return match.MaDoiTuong == "11021986";
            });

            frmDM_KhachHang frm = new frmDM_KhachHang();
            frm.isAdd = false;
            frm.Oid = infor.IdDoiTuong;
            frmChiTiet_KhachHang frmChiTietKhachHang = new frmChiTiet_KhachHang(frm);
            frmChiTietKhachHang.TestDelete();
            list = DmDoiTuongProvider.GetListDmDoiTuongInfo();
            infor = list.Find(delegate(DMDoiTuongInfo match)
            {
                return match.MaDoiTuong == "11021986";
            });
            Assert.AreEqual(infor, null);
        }

        [TestMethod]
        public void TestSys()
        {
            frmDM_KhachHang frm = new frmDM_KhachHang();
            frm.ShowDialog();
        }
    }
}
