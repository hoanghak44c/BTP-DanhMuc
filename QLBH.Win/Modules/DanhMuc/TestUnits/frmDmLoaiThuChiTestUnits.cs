using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmLoaiThuChiTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 26/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmLoaiThuChiTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmLoaiThuChiTestUnits
    {
        public frmDmLoaiThuChiTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMLoaiThuChiInfor> list = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            List<DMLoaiThuChiInfor> listMatch = list.FindAll(delegate(DMLoaiThuChiInfor match)
            {
                return match.KyHieu == "1111D";
            });
            foreach (DMLoaiThuChiInfor dmLoaiThuChiInfor in listMatch)
            {
                DMLoaiThuChiDataProvider.Delete(dmLoaiThuChiInfor);
            }  
        }
        //Các hàm dưới đây test các unit case của chi tiết LoaiThuChi
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên Loại Thu Chi: "Trả Chậm 1111 ngày", Mã LoaiThuChi: "1111D", Mô tả: "Unit test LoaiThuChi ",Type :0, Sử dụng: 1
        //frmChiTietLoaiThuChi.SetInput("Trả Chậm 1111 ngày", "1111D", "Unit test LoaiThuChi",0, 1);
        [TestMethod]
        public void TestLoaiThuChi01_LoaiThuChiIsNotEmpty()
        {
            try
            {
                frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
                frmChiTietLoaiThuChi.SetInput("Trả Chậm 1111 ngày", "", "Unit test LoaiThuChi", 0, 1);
                frmChiTietLoaiThuChi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Ký hiệu không được để trống !");
            }
        }

        [TestMethod]
        public void TestLoaiThuChi02_MaLoaiThuChiHasExistedOnInsert()
        {
            try
            {
                frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
                frmChiTietLoaiThuChi.SetInput("Trả Chậm 1111 ngày", "111D", "Unit test LoaiThuChi", 0, 1);
                frmChiTietLoaiThuChi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Ký hiệu đã tồn tại trong hệ thống!");
            }
        }
        [TestMethod]
        public void TestLoaiThuChi03_MaLoaiThuChiHasExistedOnUpdate()
        {
            try
            {
                TestLoaiThuChi05_InsertSuccess();
                List<DMLoaiThuChiInfor> list = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
                DMLoaiThuChiInfor infor = list.Find(delegate(DMLoaiThuChiInfor match)
                {
                    return match.KyHieu == "1111D";
                });

                frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
                frm.isAdd = false;
                frm.Oid = infor.IdThuChi;
                frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
                frmChiTietLoaiThuChi.SetInput("Trả Chậm 1111 ngày", "111D", "Unit test LoaiThuChi", 0, 1);
                frmChiTietLoaiThuChi.TestSave();
                list = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
                List<DMLoaiThuChiInfor> listDuplicate = list.FindAll(delegate(DMLoaiThuChiInfor match)
                {
                    return match.KyHieu == "111D";
                });
                frmChiTietLoaiThuChi.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Ký hiệu đã tồn tại trong hệ thống!");
                else
                    throw;
            }
        }

        [TestMethod]
        public void TestLoaiThuChi04_TenLoaiThuChiIsNotEmpty()
        {
            try
            {
                frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
                frmChiTietLoaiThuChi.SetInput("", "1111D", "Unit test LoaiThuChi", 0, 1);
                frmChiTietLoaiThuChi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống !");
            }
        }

        [TestMethod]
        public void TestLoaiThuChi05_InsertSuccess()
        {
            frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
            frmChiTietLoaiThuChi.SetInput("Trả Chậm 1111 ngày", "1111D", "Unit test LoaiThuChi", 0, 1);
            frmChiTietLoaiThuChi.TestSave();
            List<DMLoaiThuChiInfor> list = DMLoaiThuChiDataProvider.Search(new DMLoaiThuChiInfor { KyHieu = "1111D" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestLoaiThuChi06_DeleteFailure()
        {
            try
            {
                frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
                frmChiTietLoaiThuChi.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestLoaiThuChi07_DeleteSuccess()
        {
            TestLoaiThuChi05_InsertSuccess();
            List<DMLoaiThuChiInfor> list = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            DMLoaiThuChiInfor infor = list.Find(delegate(DMLoaiThuChiInfor match)
            {
                return match.KyHieu == "1111D";
            });

            frmDM_LoaiThuChi frm = new frmDM_LoaiThuChi();
            frm.isAdd = false;
            frm.Oid = infor.IdThuChi;

            frmChiTiet_LoaiThuChi frmChiTietLoaiThuChi = new frmChiTiet_LoaiThuChi(frm);
            frmChiTietLoaiThuChi.TestDelete();
            list = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            infor = list.Find(delegate(DMLoaiThuChiInfor match)
            {
                return match.KyHieu == "1111D";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
