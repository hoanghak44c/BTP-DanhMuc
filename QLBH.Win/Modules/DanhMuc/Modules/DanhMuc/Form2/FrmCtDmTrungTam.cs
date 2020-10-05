using System;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCtDmTrungTam :CTTrungTamView,ICTTrungTamView
    {
        public FrmCtDmTrungTam()
        {
            
        }

        public FrmCtDmTrungTam(object ItemRowHanle) : base(ItemRowHanle)
        {}

        public void Initialize()
        {
            InitializeComponent();
        }



        public int IdTrungTam { get; set; }

        public string MaTrungTam
        {
            get
            {
                if(string.IsNullOrEmpty(txtMaTT.Text))
                    throw new Exception("Không được để trống mã trung tâm!");
                return txtMaTT.Text;

            }
            set { txtMaTT.Text = value; }
        }

        public string TenTrungTam
        {
            get
            {
                if(string.IsNullOrEmpty(txtTenTT.Text))
                    throw new Exception("Không được bỏ trống Tên Trung Tâm!");
                return txtTenTT.Text;

            }
            set { txtTenTT.Text = value; }
        }

        public string DiaChi
        {
            get
            {
                if(string.IsNullOrEmpty(txtDiaChi.Text))
                    
                    throw new Exception("Không được bỏ trống Địa Chỉ");
                return txtDiaChi.Text;

            }
            set { txtDiaChi.Text = value; }
        }

        public string DienThoai
        {
            get
            {
                if (string.IsNullOrEmpty(txtDienThoai.Text))
                    Convert.ToInt32(txtDienThoai.Text);
                txtDienThoai.SelectAll();
                    throw new Exception("Không được để trống Điện Thoại !");
                return txtDienThoai.Text;

            }
            set { txtDienThoai.Text=value ;  }
        }

        public string Fax
        {
            get
            {
                if (string.IsNullOrEmpty(txtFax.Text))
                    Convert.ToInt32(txtFax.Text);
                txtFax.SelectAll();
                throw  new Exception("Bạn chỉ được phép nhập số !");
                
            }
            set { txtFax.Text = value; }
        }

        public string Email
        {
            get
            {
                if(string.IsNullOrEmpty(txtEmail.Text))
                    throw new Exception("Không được để trống Email !");
                return txtEmail.Text;

            }
            set { txtEmail.Text = value; }
        }

        public string GhiChu
        {
            get
            {
                return memoGhiChu.Text;
            }
            set { memoGhiChu.Text = value; }
        }

        public int SuDung
        {
            get
            {
                try
                {
                    return Convert.ToInt32(chkSuDung.Properties.DisplayValueChecked);

                }
                    
                    catch(Exception ex)
                    {
                        throw  new Exception(ex.Message);
                    }
            }
            set { chkSuDung.Checked = Convert.ToBoolean(value); }
        }

        public int IdBangGia { get; set; }
        public int Price_List_Id { get; set; }

        public string ViTri
        {
            get
            {
               
                    if(string.IsNullOrEmpty(txtViTri.Text))
                        throw  new Exception("Không được bỏ trống vị trí !");
                return txtViTri.Text;


            }
            set { txtViTri.Text = value; }
        }

        public string Duong
        {
            get
            {
                if (string.IsNullOrEmpty(txtDuong.Text))
                    throw new Exception("Không được để trống đường!"); 
                return txtDuong.Text;
            }
            set { txtDuong.Text = value; }
        }

        public string Tinh
        {
            get
            {
                if(string.IsNullOrEmpty(txtTinh.Text))
                    throw new Exception("Không được để trống tên tỉnh !");
                return txtTinh.Text;
            }
            set { txtTinh.Text = value; }
        }

        public string QuocGia
        {
            get { return txtQuocGia.Text; }
            set { txtQuocGia.Text = value; }
        }

        public string ChannelCode
        {
            get
            {
                if(string.IsNullOrEmpty(txtQuocGia.Text))
                    throw  new Exception("không được để trống tên quốc gia!");
                return txtChanelCode.Text;
            }
            set { txtChanelCode.Text = value; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           txtMaTT.Text = "";
           txtTenTT.Text = "";
           txtDiaChi.Text = "";
           txtDienThoai.Text = "";
           txtEmail.Text = "";
           txtTinh .Text= "";
           txtViTri.Text = "";
           txtQuocGia.Text = "";
           txtFax.Text = "";
           txtDuong.Text = "";
           txtChanelCode.Text = "";
           memoGhiChu.Text = "";
        }
    }
}