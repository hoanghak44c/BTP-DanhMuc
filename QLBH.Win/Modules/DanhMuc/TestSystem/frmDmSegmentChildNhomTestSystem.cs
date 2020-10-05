using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;

namespace QLBanHang.TestSystem
{
    [TestClass]
    public class frmDmSegmentChildNhomTestSystem
    {
        public frmDmSegmentChildNhomTestSystem()
        {
            ConnectionUtil.Instance.IsUAT = 3;// 1: golive 2: test1  3 : test 
            frmLogin frmLogin = new frmLogin();
            frmLogin.TestLogin("quantri", "quantri");
        }

        [TestMethod]
        public void Show()
        {
            frmDM_SegmentChildNhom frm = new frmDM_SegmentChildNhom();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLinhVuc()
        {
            frmDm_SegmentLinhVuc frm = new frmDm_SegmentLinhVuc();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestHang()
        {
            frmDm_SegmentHang frm = new frmDm_SegmentHang();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestLoai()
        {
            frmDM_SegmentChildLoai frm = new frmDM_SegmentChildLoai();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestNhom()
        {
            frmDM_SegmentChildNhom frm = new frmDM_SegmentChildNhom();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestNganh()
        {
            frmDM_SegmentChildNganh frm = new frmDM_SegmentChildNganh();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestChung()
        {
            frmDM_SegmentChildChung frm = new frmDM_SegmentChildChung();
            frm.ShowDialog();
        }
        [TestMethod]
        public void TestModel()
        {
            frmDM_SegmentChildModel frm = new frmDM_SegmentChildModel();
            frm.ShowDialog();
        }
    }
}
