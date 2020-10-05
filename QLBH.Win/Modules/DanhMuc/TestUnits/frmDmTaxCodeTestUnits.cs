using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmTaxCodeTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 24/05/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDmTaxCodeTestUnits

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmTaxCodeTestUnits
    {
        public frmDmTaxCodeTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMTaxCodeInfor> list = DMTaxCodeDataProvider.GetListTaxCodeInfor();
            List<DMTaxCodeInfor> listMatch = list.FindAll(delegate(DMTaxCodeInfor match)
            {
                return match.Code == "05";
            });
            foreach (var dmTaxCodeInfor in listMatch)
            {
                DMTaxCodeDataProvider.Instance.Delete(dmTaxCodeInfor);
            }
        }

        //Các hàm dưới đây test các unit case của chi tiết taxcode
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên taxcode: "taxcode1", Mã taxcode: "05", Mô tả: "Unit test ma taxcode", Sử dụng: 1
        //frmChiTietTaxCode.SetInput("taxcode1", "05", "Unit test ma taxcode", 1);
        [TestMethod]
        public void TestTaxCode01_TaxCodeIsNotEmpty()
        {
            try
            {
                frmDM_TaxCode frm = new frmDM_TaxCode();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
                frmChiTietTaxCode.SetInput("taxcode1", "", "Unit test ma taxcode", 1);
                frmChiTietTaxCode.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã không được để trống!");
            }
        }

        [TestMethod]
        public void TestTaxCode02_MaTaxCodeHasExistedOnInsert()
        {
            try
            {
                frmDM_TaxCode frm = new frmDM_TaxCode();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
                frmChiTietTaxCode.SetInput("taxcode1", "01", "Unit test ma taxcode", 1);
                frmChiTietTaxCode.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã Taxcode đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestTaxCode03_MaTaxCodeHasExistedOnUpdate()
        {
            try
            {
                TestTaxCode05_InsertSuccess();
                List<DMTaxCodeInfor> list = DMTaxCodeDataProvider.GetListTaxCodeInfor();
                DMTaxCodeInfor infor = list.Find(delegate(DMTaxCodeInfor match)
                {
                    return match.Code == "05";
                });

                frmDM_TaxCode frm = new frmDM_TaxCode();
                frm.isAdd = false;
                frm.Oid = infor.IdTaxCode;
                frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
                frmChiTietTaxCode.SetInput("taxcode1", "01", "Unit test ma taxcode", 1);
                frmChiTietTaxCode.TestSave();
                list = DMTaxCodeDataProvider.GetListTaxCodeInfor();
                List<DMTaxCodeInfor> listDuplicate = list.FindAll(delegate(DMTaxCodeInfor match)
                {
                    return match.Code == "01";
                });
                frmChiTietTaxCode.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã Taxcode đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestTaxCode04_TenTaxCodeIsNotEmpty()
        {
            try
            {
                frmDM_TaxCode frm = new frmDM_TaxCode();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
                frmChiTietTaxCode.SetInput("", "05", "Unit test ma taxcode", 1);
                frmChiTietTaxCode.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên không được để trống!");
            }
        }

        [TestMethod]
        public void TestTaxCode05_InsertSuccess()
        {
            frmDM_TaxCode frm = new frmDM_TaxCode();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
            frmChiTietTaxCode.SetInput("taxcode1", "05", "Unit test ma taxcode", 1);
            frmChiTietTaxCode.TestSave();
            List<DMTaxCodeInfor> list = DMTaxCodeDataProvider.Search(new DMTaxCodeInfor { Code = "05" });
            Assert.AreEqual(list.Count, 1);
        }

        [TestMethod]
        public void TestTaxCode06_DeleteFailure()
        {
            try
            {
                frmDM_TaxCode frm = new frmDM_TaxCode();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
                frmChiTietTaxCode.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới!");
            }
        }

        [TestMethod]
        public void TestTaxCode07_DeleteSuccess()
        {
            TestTaxCode05_InsertSuccess();
            List<DMTaxCodeInfor> list = DMTaxCodeDataProvider.GetListTaxCodeInfor();
            DMTaxCodeInfor infor = list.Find(delegate(DMTaxCodeInfor match)
            {
                return match.Code == "05";
            });

            frmDM_TaxCode frm = new frmDM_TaxCode();
            frm.isAdd = false;
            frm.Oid = infor.IdTaxCode;

            frmChiTiet_TaxCode frmChiTietTaxCode = new frmChiTiet_TaxCode(frm);
            frmChiTietTaxCode.TestDelete();
            list = DMTaxCodeDataProvider.GetListTaxCodeInfor();
            infor = list.Find(delegate(DMTaxCodeInfor match)
            {
                return match.Code == "05";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
