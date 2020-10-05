using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmMaLoiTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 26/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmMaLoiTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmMaLoiTestUnits
    {
        public frmDmMaLoiTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMMaLoiInfor> list = DMMaLoiDataProvider.GetListMaLoiInfor();
            List<DMMaLoiInfor> listMatch = list.FindAll(delegate(DMMaLoiInfor match)
            {
                return match.MaLoi == "001";
            });
            foreach (DMMaLoiInfor dmMaLoiInfor in listMatch)
            {
                DMMaLoiDataProvider.Delete(dmMaLoiInfor);
            }            
        }
        //Các hàm dưới đây test các unit case của chi tiết MaLoi
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên MaLoi: "Ma Loi 1", Mã MaLoi: "001", Mô tả: "Unit test MaLoi ", Sử dụng: 1
        //frmChiTietMaLoi.SetInput("Ma Loi 1", "001", "Unit test MaLoi", 1);
        [TestMethod]
        public void TestMaLoi01_MaLoiIsNotEmpty()
        {
            try
            {
                frmDM_MaLoi frm = new frmDM_MaLoi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
                frmChiTietMaLoi.SetInput("Ma Loi 1", "", "Unit test MaLoi", 1);
                frmChiTietMaLoi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã Lỗi không được để trống !");
            }
        }

        [TestMethod]
        public void TestMaLoi02_MaMaLoiHasExistedOnInsert()
        {
            try
            {
                frmDM_MaLoi frm = new frmDM_MaLoi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
                frmChiTietMaLoi.SetInput("Ma Loi 1", "sdfsdf", "Unit test MaLoi", 1);
                frmChiTietMaLoi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã Lỗi đã tồn tại trong hệ thống!");
            }
        }
        [TestMethod]
        public void TestMaLoi03_MaMaLoiHasExistedOnUpdate()
        {
            try
            {
                TestMaLoi05_InsertSuccess();
                List<DMMaLoiInfor> list = DMMaLoiDataProvider.GetListMaLoiInfor();
                DMMaLoiInfor infor = list.Find(delegate(DMMaLoiInfor match)
                {
                    return match.MaLoi == "001";
                });

                frmDM_MaLoi frm = new frmDM_MaLoi();
                frm.isAdd = false;
                frm.Oid = infor.IdMaLoi;
                frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
                frmChiTietMaLoi.SetInput("Ma Loi 1", "sdfsdf", "Unit test MaLoi", 1);
                frmChiTietMaLoi.TestSave();
                list = DMMaLoiDataProvider.GetListMaLoiInfor();
                List<DMMaLoiInfor> listDuplicate = list.FindAll(delegate(DMMaLoiInfor match)
                {
                    return match.MaLoi == "sdfsdf";
                });
                frmChiTietMaLoi.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã Lỗi đã tồn tại trong hệ thống!");
                else
                    throw;
            }
        }

        [TestMethod]
        public void TestMaLoi04_TenMaLoiIsNotEmpty()
        {
            try
            {
                frmDM_MaLoi frm = new frmDM_MaLoi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
                frmChiTietMaLoi.SetInput("", "001", "Unit test MaLoi", 1);
                frmChiTietMaLoi.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên Lỗi không được để trống !");
            }
        }

        [TestMethod]
        public void TestMaLoi05_InsertSuccess()
        {
            frmDM_MaLoi frm = new frmDM_MaLoi();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
            frmChiTietMaLoi.SetInput("Ma Loi 1", "001", "Unit test MaLoi", 1);
            frmChiTietMaLoi.TestSave();
            List<DMMaLoiPairInfor> list = DMMaLoiDataProvider.Search(new DMMaLoiPairInfor { MaLoi = "001" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestMaLoi06_DeleteFailure()
        {
            try
            {
                frmDM_MaLoi frm = new frmDM_MaLoi();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
                frmChiTietMaLoi.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestMaLoi07_DeleteSuccess()
        {
            TestMaLoi05_InsertSuccess();
            List<DMMaLoiInfor> list = DMMaLoiDataProvider.GetListMaLoiInfor();
            DMMaLoiInfor infor = list.Find(delegate(DMMaLoiInfor match)
            {
                return match.MaLoi == "001";
            });

            frmDM_MaLoi frm = new frmDM_MaLoi();
            frm.isAdd = false;
            frm.Oid = infor.IdMaLoi;

            frmChiTiet_MaLoi frmChiTietMaLoi = new frmChiTiet_MaLoi(frm);
            frmChiTietMaLoi.TestDelete();
            list = DMMaLoiDataProvider.GetListMaLoiInfor();
            infor = list.Find(delegate(DMMaLoiInfor match)
            {
                return match.MaLoi == "001";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
