using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Data;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmLookUpSanPhamTestSystem
    {
        public frmLookUpSanPhamTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 1;
        }
        [TestMethod]
        public void TestLookUpSanPhamVirtualMode()
        {

            frmLookUp_SanPhamTestVirtualMode frm = new frmLookUp_SanPhamTestVirtualMode(DmSanPhamProvider.Instance);
            frm.ShowDialog();
            Assert.AreEqual(1, frm.SelectedItems.Count);
        }

        [TestMethod]
        public void TestLookUpSanPham_1()
        {
            frmLookUp_SanPham frm = new frmLookUp_SanPham();
            frm.ShowDialog();
            MessageBox.Show(frm.SelectedItem.Nganh);
        }
        [TestMethod]
        public void TestLookUpSanPham_CauHinh()
        {
            frmLookUp_SanPham_CauHinh frmLookUp = new frmLookUp_SanPham_CauHinh();
            frmLookUp.ShowDialog();
        }
        [TestMethod]
        public void TestLookUpSanPham()
        {
            frmLookUp_SanPham frm = new frmLookUp_SanPham(true, "%%");
            frm.ShowDialog();
            Assert.AreEqual(1, frm.SelectedItems.Count);
        }

        [TestMethod]
        public void TestLookUpLoaiSanPham()
        {
            frmLookUp_LoaiSanPham frm = new frmLookUp_LoaiSanPham();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLookUpNhaCungCap()
        {
            frmLookUp_NhaCungCap frm = new frmLookUp_NhaCungCap(false, true);
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestLookUpHangHoa()
        {
            frmLookUp_HangHoa frm = new frmLookUp_HangHoa(true, 1, 1, -1);
            frm.ShowDialog();
        }

        [TestMethod]
        public void TestLookUpTrungTam()
        {
            frmLookUp_TrungTam frm = new frmLookUp_TrungTam(false, "%a%", 184);
            frm.ShowDialog();
        }

        public Encoding GetEncode(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            return writer.Encoding;
        }

        [TestMethod]
        public void TestEncode()
        {
            string unicodeDungSan = "điện máy";
            string unicodeToHop = "điện máy";
            //Debug.WriteLine("To Hop");
            //foreach (var chr in unicodeToHop.ToCharArray())
            //{
            //    //if(char.IsLetterOrDigit(chr))
            //        Debug.Print("{0} - {1}", chr, (int)chr);
            //}
            //Debug.WriteLine("Dung San");
            //foreach (var chr in unicodeDungSan.ToCharArray())
            //{
            //    if (char.IsLetterOrDigit(chr))
            //        Debug.Print("{0} - {1}", chr, (int)chr);
            //}

            //Debug.WriteLine("Test dấu Dựng Sẵn:");
            //foreach (var chr in "êệếềểễ".ToCharArray())
            //{
            //    if (char.IsLetterOrDigit(chr))
            //        Debug.Print("{0} - {1}", chr, (int)chr);
            //}
            //Debug.WriteLine("Test dấu Tổ Hợp:");
            //foreach (var chr in "êệếềểễ".ToCharArray())
            //{
            //    Debug.Print("{0} - 0x{1:X2}", chr, (int)chr);
            //}
            //VIQR2Unicode vu = new VIQR2Unicode();
            //foreach (uint vnPreComposedChar in vu.VnPreComposedChar)
            //{
            //    Debug.Print("{0} - {1}", (char)vnPreComposedChar, vnPreComposedChar);
            //}

            //Debug.Print("{0:X2}",7929);
            //VIQR2Unicode t = new VIQR2Unicode();
            //string temp = String.Empty;
            //t.PreCompose2UCOM(unicodeDungSan, ref temp);
            //Assert.AreEqual(temp, unicodeToHop);

            //định nghĩa biến đối tượng
            //VIQR2Unicode vu = new VIQR2Unicode();
            //int cnt;
            //String str = null;
            ////thử chuyển chuỗi VIQR sang Unicode
            //cnt = vu.VIQR2PreCompose("a(a^e^o^u+o+d- a('a(`a(?a(~a(.", ref str);
            ////hiển thị chuỗi kết quả để kiểm tra
            //MessageBox.Show(str);
            //String str1 = null;
            ////thử chuyển chuỗi Unicode sang VIQR
            //cnt = vu.PreCompose2VIQR(str, ref str1);
            ////hiển thị chuỗi kết quả để kiểm tra
            //MessageBox.Show(str1); 
        }

    }
}
