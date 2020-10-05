using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmQuyenHoaDonTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 25/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmQuyenHoaDonTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmQuyenHoaDonTestUnits
    {
        public frmDmQuyenHoaDonTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMQuyenHoaDonInfor> list = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
            List<DMQuyenHoaDonInfor> listMatch = list.FindAll(delegate(DMQuyenHoaDonInfor match)
            {
                return match.KyHieuHoaDon == "HD1" && match.KyTuDauSerie =="GH";
            });
            foreach (var dmQuyenHoaDonInfor in listMatch)
            {
                DMQuyenHoaDonDataProvider.Delete(dmQuyenHoaDonInfor);
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết QuyenHoaDon
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Ký hiệu hóa đơn: "HD1", Ký tự đầu serie: "GH", Số lượng: "20", Sử dụng: "5"
        //frmChiTietQuyenHoaDon.SetInput("HD1", "GH", 20, 5);
        [TestMethod]
        public void TestQuyenHoaDon01_KyHieuIsNotEmpty()
        {
            try
            {
                frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
                frmChiTietQuyenHoaDon.SetInput("", "GH", 20,5);
                frmChiTietQuyenHoaDon.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Ký hiệu không được để trống !");
            }
        }

        [TestMethod]
        public void TestQuyenHoaDon02_KyHieuHasExistedOnInsert()
        {
            try
            {
                frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
                frmChiTietQuyenHoaDon.SetInput("HD1", "TG/fh", 20, 5);
                frmChiTietQuyenHoaDon.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Ký hiệu đã có trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestQuyenHoaDon03_KyHieuHasExistedOnUpdate()
        {
            try
            {
                TestQuyenHoaDon05_InsertSuccess();
                List<DMQuyenHoaDonInfor> list = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
                DMQuyenHoaDonInfor infor = list.Find(delegate(DMQuyenHoaDonInfor match)
                {
                    return match.KyHieuHoaDon == "HD1"&& match.KyTuDauSerie == "GH";
                });

                frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
                frm.isAdd = false;
                //frm.Oid = Convert.ToInt32(infor.KyHieuHoaDon);
                frm.kytudau = infor.KyTuDauSerie;
                frm.kyhieuhoadon = infor.KyHieuHoaDon;
                frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
                frmChiTietQuyenHoaDon.SetInput("HD1", "Tg/fh", 20, 5);
                frmChiTietQuyenHoaDon.TestSave();
                list = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
                List<DMQuyenHoaDonInfor> listDuplicate = list.FindAll(delegate(DMQuyenHoaDonInfor match)
                {
                    return match.KyHieuHoaDon == "HD1" && match.KyTuDauSerie == "TG/fh";
                });
                frmChiTietQuyenHoaDon.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Ký hiệu đã có trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestQuyenHoaDon04_QuyenHoaDonIsNotEmpty()
        {
            try
            {
                frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
                frmChiTietQuyenHoaDon.SetInput("HD1", "", 20, 5);
                frmChiTietQuyenHoaDon.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Ký tự đầu không được để trống !");
            }
        }

        [TestMethod]
        public void TestQuyenHoaDon05_InsertSuccess()
        {
            frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
            frmChiTietQuyenHoaDon.SetInput("HD1", "GH", 20, 5);
            frmChiTietQuyenHoaDon.TestSave();
            List<DMQuyenHoaDonInfor> list = DMQuyenHoaDonDataProvider.Search(new DMQuyenHoaDonInfor { KyHieuHoaDon = "HD1",KyTuDauSerie = "GH"});
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestQuyenHoaDon06_DeleteFailure()
        {
            try
            {
                frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
                frmChiTietQuyenHoaDon.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới !");
            }
        }

        [TestMethod]
        public void TestQuyenHoaDon07_DeleteSuccess()
        {
            TestQuyenHoaDon05_InsertSuccess();
            List<DMQuyenHoaDonInfor> list = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
            DMQuyenHoaDonInfor infor = list.Find(delegate(DMQuyenHoaDonInfor match)
            {
                return match.KyHieuHoaDon == "HD1" && match.KyTuDauSerie == "GH";
            });

            frmDM_QuyenHoaDon frm = new frmDM_QuyenHoaDon();
            frm.isAdd = false;
            frm.kytudau = infor.KyTuDauSerie;
            frm.kyhieuhoadon = infor.KyHieuHoaDon;
            frmChiTiet_QuyenHoaDon frmChiTietQuyenHoaDon = new frmChiTiet_QuyenHoaDon(frm);
            frmChiTietQuyenHoaDon.TestDelete();
            list = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
            infor = list.Find(delegate(DMQuyenHoaDonInfor match)
            {
                return match.KyHieuHoaDon == "HD1" && match.KyTuDauSerie == "GH";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
