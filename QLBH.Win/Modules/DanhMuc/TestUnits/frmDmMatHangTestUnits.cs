using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;

// <Remarks>
// form frmDmMatHangTestUnits
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
//HanhBD frmDmMatHangTestUnits
namespace QLBanHang.TestUnits
{
    [TestClass]
    public class frmDmMatHangTestUnits
    {
        public frmDmMatHangTestUnits()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");

            //chuẩn bị dữ liệu để test
            List<DMSanPhamInfo> list = DmSanPhamProvider.GetListDmSanPhamInfo();
            if(list != null)
            {
                List<DMSanPhamInfo> listMatch = list.FindAll(delegate(DMSanPhamInfo match)
                {
                    return match.MaSanPham == "11111";
                });
                foreach (var dmLoaiThuChiInfo in listMatch)
                {
                    DmSanPhamProvider.Delete(dmLoaiThuChiInfo);
                }
            }
        }
        //Các hàm dưới đây test các unit case của chi tiết sản phẩm
        //Các dữ liệu đầu vào chuẩn để test như sau
        //Tên sản phẩm: "sản phẩm 1", Mã sản phẩm : "11111",Tên viết tắt: "SP1",Mã vạch:"123654",Giá nhập:"120000", Mô tả :"UnitsTest sản phẩm", Sử dụng: 1, Chiết khấu:0, Trùng mã vạch :0
        //frmChiTietMatHang.SetInput("sản phẩm 1","11111","SP1","123654",120000,"UnitsTest sản phẩm", 1);
        [TestMethod]
        public void TestMatHang01_MaSanPhamIsNotEmpty()
        {
            try
            {
                frmDM_HangHoa frm = new frmDM_HangHoa();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
                frmChiTietListDM.SetInput("sản phẩm 1", "", "SP1", "123654", 120000, "UnitsTest sản phẩm", 1,0,0);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã sản phẩm không được để trống !");
            }
        }

        [TestMethod]
        public void TestMatHang02_MaSanPhamHasExistedOnInsert()
        {
            try
            {
                frmDM_HangHoa frm = new frmDM_HangHoa();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
                frmChiTietListDM.SetInput("sản phẩm 1", "1234", "SP1", "123654", 120000, "UnitsTest sản phẩm", 1,0,0);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Mã sản phẩm đã tồn tại trong hệ thống !");
            }
        }
        [TestMethod]
        public void TestMatHang03_MaMatHangHasExistedOnUpdate()
        {
            try
            {
                TestMatHang05_InsertSuccess();
                List<DMSanPhamInfo> list = DmSanPhamProvider.GetListDmSanPhamInfo();
                DMSanPhamInfo infor = list.Find(delegate(DMSanPhamInfo match)
                {
                    return match.MaSanPham == "11111";
                });

                frmDM_HangHoa frm = new frmDM_HangHoa();
                frm.isAdd = false;
                frm.Oid = Convert.ToInt32(infor.MaSanPham);
                frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
                frmChiTietListDM.SetInput("sản phẩm 1", "1234", "SP1", "123654", 120000, "UnitsTest sản phẩm", 1,0,0);
                frmChiTietListDM.TestSave();
                list = DmSanPhamProvider.GetListDmSanPhamInfo();
                List<DMSanPhamInfo> listDuplicate = list.FindAll(delegate(DMSanPhamInfo match)
                {
                    return match.MaSanPham == "1234";
                });
                frmChiTietListDM.TestDelete();
                Assert.AreEqual(1, listDuplicate.Count);
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(AssertFailedException))
                    Assert.AreEqual(ex.Message, "Mã sản phẩm đã tồn tại trong hệ thống !");
                else
                    throw;
            }
        }


        [TestMethod]
        public void TestMatHang04_TenMatHangIsNotEmpty()
        {
            try
            {
                frmDM_HangHoa frm = new frmDM_HangHoa();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
                frmChiTietListDM.SetInput("", "11111", "SP1", "123654", 120000, "UnitsTest sản phẩm", 1,0,0);
                frmChiTietListDM.TestSave();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Tên sản phẩm không được để trống !");
            }
        }

        [TestMethod]
        public void TestMatHang05_InsertSuccess()
        {
            frmDM_HangHoa frm = new frmDM_HangHoa();
            frm.Oid = 0;
            frm.isAdd = true;
            frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
            frmChiTietListDM.SetInput("sản phẩm 1", "11111", "SP1", "123654", 120000, "UnitsTest sản phẩm", 1,0,0);
            frmChiTietListDM.TestSave();
            List<DMSanPhamInfo> list = DmSanPhamProvider.Search(new DMSanPhamInfo { MaSanPham = "11111"});
            Assert.AreEqual(1,list.Count);
        }

        [TestMethod]
        public void TestMatHang06_DeleteFailure()
        {
            try
            {
                frmDM_HangHoa frm = new frmDM_HangHoa();
                frm.Oid = 0;
                frm.isAdd = true;
                frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
                frmChiTietListDM.TestDelete();
                Assert.AreEqual("Khong chay dong nay", String.Empty);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Bạn không thể xóa khi đang thêm mới !");
            }
        }

        [TestMethod]
        public void TestMatHang07_DeleteSuccess()
        {
            TestMatHang05_InsertSuccess();
            List<DMSanPhamInfo> list = DmSanPhamProvider.GetListDmSanPhamInfo();
            DMSanPhamInfo infor = list.Find(delegate(DMSanPhamInfo match)
            {
                return match.MaSanPham == "11111";
            });

            frmDM_HangHoa frm = new frmDM_HangHoa();
            frm.isAdd = false;
            frm.Oid = infor.IdSanPham;
            frmChiTiet_MatHang frmChiTietListDM = new frmChiTiet_MatHang(frm);
            frmChiTietListDM.TestDelete();
            list = DmSanPhamProvider.GetListDmSanPhamInfo();
            infor = list.Find(delegate(DMSanPhamInfo match)
            {
                return match.MaSanPham == "11111";
            });

            Assert.AreEqual(infor, null);
        }
    }
}
