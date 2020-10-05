using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCTOrderType : CTOrderTypeView,ICTOrderTypeView 
    {
        public FrmCTOrderType()
        {
           
        }

        public void Initialize()
        {
            InitializeComponent();
        }

       public FrmCTOrderType(object ItemRowHanle):base(ItemRowHanle)
       {
           
       }

        

        public int IdOrderType { get; set; }
        public string Name
        {
            get { return txtTenOrderType.Text; }
            set { txtTenOrderType.Text = value; }
        }
        public string OrderType
        {
            get { return txtMaOrderType.Text; }
            set { txtMaOrderType.Text = value; }
        }

        public string GhiChu
        {
            get { return txtMoTa.Text; }
            set { txtMoTa.Text = value; }
        }

        public int SuDung
        {
            get { return Convert.ToInt32(chkSuDung.Checked); }
            set { chkSuDung.Checked = Convert.ToBoolean(value); }
        }

        public string LineType
        {
            get { return txtLine.Text; }
            set { txtLine.Text = value; }
        }

        public string LineKm
        {
            get { return txtLineKm.Text; }
            set { txtLineKm.Text = value; }
        }

        public string LineCk
        {
            get { return txtLineCk.Text; }
            set { txtLineCk.Text = value; }
        }

        public string NganhHang
        {
            get { return lueNganh.EditValue.ToString(); }
            set { lueNganh.EditValue = value; }
        }

        public object NganhHangDataSource
        {
            set { lueNganh.Properties.DataSource=value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }
    }
}