using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Views
{
    public partial class FrmCtKho : CTKhoView,ICTKhoView 
    {
        public FrmCtKho()
        {
            
        }
        public FrmCtKho(object  ItemRowHanle):base(ItemRowHanle)
        {
            
        }
        public void Initialize()
        {
            InitializeComponent();
        
        }

        public int IdKho { get; set; }

       
        public int IdTrungTam 
        {
            get
            {
                try
                {
                    return Convert.ToInt32(lueTrungTam.EditValue);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
               
            }
            set { chkListTrungTam.SelectedItem = value; }
             
        }
        public object TrungTamDataSource
        {
            get { return lueTrungTam.EditValue; }
            set { lueTrungTam.Properties.DataSource = value; }
        }

        public object checkTrungTam
        {
            //get { return chkListTrungTam.DataSource; }
            get { return chkListTrungTam.SelectedItem; }
            set { chkListTrungTam.DataSource = value; }

        }
        public object listcheckothertrungtam
        {
            get { return chkListTrungTam.DataSource; }
            set { chkListTrungTam.DataSource = value; }
        }
        

        public int OtherTrungTamCount
        {
            get { return chkListTrungTam.CheckedItems.Count; }
            
        }

        public object CheckedOtherTrungTam(int index)
        {

           return  chkListTrungTam.CheckedItems[index];

        }
        public void othertrungtamcheck(int index)
        {
            chkListTrungTam.SetItemChecked(index,true);
        }


        public string OtherTrungTam
        {
            get; set;
        }
        public string MaKho
        {
            get
            {
                if(string.IsNullOrEmpty(txtMaKho.Text))
                    throw new Exception("Không được để trống mã kho !");
                return txtMaKho.Text;
            }
            set { txtMaKho.Text = value; }
        }

        public string TenKho
        {
            get
            {
                if(string.IsNullOrEmpty(txtTenKho.Text))
                    throw new Exception("Không được để trống tên kho !");
                return txtTenKho.Text;
            }
            set { txtTenKho.Text=value; }
        }

        public string DiaChi
        {
            get
            {
                if(string.IsNullOrEmpty(txtDiaChi.Text))
                    throw new Exception("Không được để trống địa chỉ !");
                return txtDiaChi.Text;
            }
            set { txtDiaChi.Text=value; }
        }

        public string DienThoai
        {
            get
            {
                if (string.IsNullOrEmpty(txtDienThoai.Text))  
                  throw new Exception("Không được để trống điện thoại ");
                return txtDienThoai.Text;

            }
            set { txtDienThoai.Text=value; }
        }

        public string Fax
        {
            get
            {
                if (string.IsNullOrEmpty(txtFax.Text))
                    throw new Exception("Không được để trống Fax!");
                return txtFax.Text;
            }
            set { txtFax.Text=value; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text=value; }
        }

        public string GhiChu
        {
            get { return memoGhiChu.Text; }
            set { memoGhiChu.Text = value; }
        }

        public int SuDung
        {
            get
            {
                try
                {
                    return Convert.ToInt32(chkSuDung.Checked);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception(ex.Message);
                }
                
            }
            set { chkSuDung.Checked=Convert.ToBoolean(value); }
        }

        public string MaKhoOracle
        {
            get { return txtMaOracle.Text; }
            set { txtMaOracle.Text = value; }
        }

        public string ViTri
        {
            get { return txtViTri.Text; }
            set { txtViTri.Text = value; }
        }

        public string Duong
        {
            get { return txtDuong.Text; }
            set { txtDuong.Text=value; }
        }

        public string Tinh
        {
            get { return txtTinh.Text; }
            set { txtTinh.Text=value; }
        }

        public string QuocGia
        {
            get { return txtQuocGia.Text; }
            set { txtQuocGia.Text=value; }
        }

        public int Type
        { get
        {
            try
            {
                return Convert.ToInt32(chkDemo.Checked);
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
           
        }
          set { chkDemo.Checked = Convert.ToBoolean(value); } 
        }
        public string MaVung
        {
            get { return lueMaVung.Text; }
            set { lueMaVung.Text = value; }
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
         Controller.Save();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            memoGhiChu.Text = "";
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            lueTrungTam.Text = "";
            lueMaVung.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtDuong.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtMaOracle.Text = "";
            txtQuocGia.Text = "";
            txtTinh.Text = "";
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void frmChiTietKho_Load(object sender, EventArgs e)
        {

            
            
        }

       
            
       
    }
}