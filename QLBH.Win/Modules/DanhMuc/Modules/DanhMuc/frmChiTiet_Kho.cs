using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
//Note:@CuongTT frmChiTiet_Kho 
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_Kho : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_Kho frmKho;
        List<DMTrungTamPairInfor> liTrungTam = new List<DMTrungTamPairInfor>();
        List<MaVungInfo> liMaVung = new List<MaVungInfo>();
        DMKhoInfo dm = new DMKhoInfo();
        string[] str;
        private Common Common = new Common();
        #endregion

        #region frmChiTiet_Kho
        public frmChiTiet_Kho()
        {
            InitializeComponent();
        }
        public frmChiTiet_Kho(frmDM_Kho frm)
        {
            this.frmKho = frm;
            InitializeComponent();
        }
        #endregion

        #region Action

        #region LoadTrungTamAll
        private void LoadTrungTamAll()
        {
            liTrungTam = DMTrungTamDataProvider.GetListTrungTamPairInfo();
            //cboTrungTam.DataSource = null;
            cboTrungTam.DataSource = liTrungTam;
            cboTrungTam.DisplayMember = "TenTrungTam";
            cboTrungTam.ValueMember = "IdTrungTam";
            //lstTrungTam.DataSource = null;
            lstTrungTam.DataSource = liTrungTam;
            lstTrungTam.DisplayMember = "TenTrungTam";
            lstTrungTam.ValueMember = "IdTrungTam";
        }
        #endregion

        #region LoadMaVung
        private void LoadMaVung()
        {
            liMaVung = MaVungDataProvider.GetListDMMaVungInfo();
            //cboMaVung.DataSource = null;
            cboMaVung.DataSource = liMaVung;
            cboMaVung.DisplayMember = "TenVung";
            cboMaVung.ValueMember = "MaVung";
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frmKho.isAdd)
            {
                txtTenKho.Text = String.Empty;
                txtMaKhoOracle.Text = String.Empty;
                txtMaKho.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
                //txtFax.Text = "0";
                txtEmail.Text = String.Empty;
                //txtDienThoai.Text = "0";
                txtDiaChi.Text = String.Empty;
                txtVitri.Text = String.Empty;
                txtDuong.Text = String.Empty;
                txtTinh.Text = String.Empty;
                txtQuocGia.Text = String.Empty;
                chkSuDung.Checked = false;
                chkDemo.Checked = false;
                txtMaKho.Focus();
                btnXoa.Enabled = false;
            }
            else
            {
                txtMaKho.Enabled = false;
                dm = DMKhoDataProvider.GetKhoByIdInfo(frmKho.Oid);
                btnXoa.Enabled = false;
                txtTenKho.Text = dm.TenKho;
                txtMaKhoOracle.Text = dm.MaKhoOracle;
                txtMaKho.Text = dm.MaKho;
                txtGhiChu.Text = dm.GhiChu;
                txtFax.Text = dm.Fax;
                txtEmail.Text = dm.Email;
                txtDienThoai.Text = dm.DienThoai;
                txtDiaChi.Text = dm.DiaChi;
                cboTrungTam.SelectedValue = dm.IdTrungTam;
                if(dm.MaVung != null) cboMaVung.SelectedValue = dm.MaVung;
                chkSuDung.Checked = dm.SuDung == 1;
                txtVitri.Text = dm.ViTri;
                txtDuong.Text = dm.Duong;
                txtTinh.Text = dm.Tinh;
                txtQuocGia.Text = dm.QuocGia;
                chkDemo.Checked = dm.Type == 1;

                if (dm.OtherTrungTam != null)
                {
                    for (int i = 0; i < lstTrungTam.Items.Count; i++)
                    {
                        lstTrungTam.SetItemChecked(i, dm.OtherTrungTam.Contains("," + ((DMTrungTamPairInfor)lstTrungTam.Items[i]).IdTrungTam + ","));
                    }
                }
            }
            if (frmKho.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaKho.Enabled = false;
                //txtTenKho.Enabled = false;
                //cboTrungTam.Enabled = false;
                //txtMaKhoOracle.Enabled = false;
                //txtDienThoai.Enabled = false;
                //txtFax.Enabled = false;
                //txtEmail.Enabled = false;
                //txtVitri.Enabled = false;
                //txtDuong.Enabled = false;
                //txtTinh.Enabled = false;
                //txtGhiChu.Enabled = false;
                //btnXoa.Enabled = false;
                //chkSuDung.Enabled = false;
            }

        }
        #endregion

        #region SetKhoInfo
        private DMKhoInfo SetKhoInfo()
        {
            DMKhoInfo dm = new DMKhoInfo();
            dm.DiaChi = txtDiaChi.Text.Trim();
            dm.DienThoai = txtDienThoai.Text.Trim();
            dm.Email = txtEmail.Text.Trim();
            dm.Fax = txtFax.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.IdTrungTam = Convert.ToInt32(cboTrungTam.SelectedValue);
            dm.MaKho = txtMaKho.Text.Trim();
            dm.MaKhoOracle = txtMaKhoOracle.Text.Trim();
            dm.MaVung = Convert.ToString(cboMaVung.SelectedValue);
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.TenKho = txtTenKho.Text.Trim();
            dm.Type = chkDemo.Checked ? 1 : 0;
            string str = ",";
            for (int i = 0; i < lstTrungTam.Items.Count; i++)
            {
                if (lstTrungTam.GetItemChecked(i))
                {
                    str += ((DMTrungTamPairInfor)lstTrungTam.Items[i]).IdTrungTam + ",";
                }
            }
            dm.OtherTrungTam = str;
            dm.ViTri = txtVitri.Text.Trim();
            dm.Duong = txtDuong.Text.Trim();
            dm.Tinh = txtTinh.Text.Trim();
            dm.QuocGia = txtQuocGia.Text.Trim();
            dm.IdKho = frmKho.Oid;

            return dm;
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaKho.Text))
            {
                txtMaKho.Focus();
                throw new InvalidOperationException("Mã kho không được để trống !");
            }
            if (String.IsNullOrEmpty(txtMaKhoOracle.Text))
            {
                txtMaKhoOracle.Focus();
                throw new InvalidOperationException("Mã kho Oracle không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenKho.Text))
            {
                txtTenKho.Focus();
                throw new InvalidOperationException("Tên kho không được để trống !");
            }
            //if (String.IsNullOrEmpty(txtDienThoai.Text))
            //{
            //    txtDienThoai.Focus();
            //    throw new InvalidOperationException("Điện thoại trung tâm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtFax.Text))
            //{
            //    txtFax.Focus();
            //    throw new InvalidOperationException("Fax trung tâm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtEmail.Text))
            //{
            //    txtEmail.Focus();
            //    throw new InvalidOperationException("Email không được để trống !");
            //}
            if (txtEmail.Text.Trim().Length > 0 && Common.ValidEmail(txtEmail.Text.Trim()) == false)
            {
                txtEmail.Focus();
                throw new InvalidOperationException("Email chưa đúng định dạng!");
            }

            if (frmKho.IsSync)
            {
                if (txtMaKho.Text != dm.MaKho)
                {
                    throw new InvalidOperationException("Mã kho đã bị thay đổi !");
                }
                //if (txtMaKhoOracle.Text != dm.MaKhoOracle)
                //{
                //    throw new InvalidOperationException("Mã kho Oracle  đã bị thay đổi !");
                //}
            }
            if (DMKhoDataProvider.KiemTra(new DMKhoInfo { IdKho = frmKho.Oid,MaKho = txtMaKho.Text.Trim()}))
            {
                throw new InvalidOperationException("Mã Kho đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SaveKho
        private void SaveKho()
        {
            if (Check())
            {
               try
               {
                   ConnectionUtil.Instance.BeginTransaction();
                   if (frmKho.isAdd)
                   {
                       DMKhoDataProvider.Insert(SetKhoInfo());
                       ConnectionUtil.Instance.CommitTransaction();
                   }
                   else
                   {
                       DMKhoDataProvider.Update(SetKhoInfo());
                       ConnectionUtil.Instance.CommitTransaction();
                   }
               }
                catch(Exception)
                {
                    ConnectionUtil.Instance.RollbackTransaction();
                    throw;
                }
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmKho.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmKho.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMKhoDataProvider.Delete(new DMKhoInfo { IdKho = frmKho.Oid }); 
        }
        #endregion

        #endregion

        #region Event
        private void frmChiTiet_Kho_Load(object sender, EventArgs e)
        {
            LoadTrungTamAll();
            LoadMaVung();
            LoadData();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveKho();
                if(frmKho.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                frmKho.ReLoad();
                frmKho.SetControl(false);
                this.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void gtidButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa bản ghi thành công!");
                frmKho.ReLoad();
                frmKho.SetControl(false);
                this.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        #endregion

        private void txtFax_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyValue >= 48 && e.KeyValue <= 57) || (e.KeyValue >= 96 && e.KeyValue <= 105))
            //{
            //    //do continue
            //}
            //else
            //{
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            //bool fag;

            //fag = Common.IsNumber(txtDienThoai.Text);
            //if (fag == false)
            //{
            //    MessageBox.Show("Điện thoại phải là kiểu số!");
            //    txtDienThoai.Focus();
            //}
        }

        private void txtFax_Leave(object sender, EventArgs e)
        {
            //bool fag;

            //fag = Common.IsNumber(txtFax.Text);
            //if (fag == false)
            //{
            //    MessageBox.Show("Fax phải là kiểu số!");
            //    txtFax.Focus();
            //}
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoai.Text != "")
                    Convert.ToInt32(txtDienThoai.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDienThoai.SelectAll();
            }
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFax.Text != "")
                    Convert.ToInt32(txtFax.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtFax.SelectAll();
            }
        }

        

        
    }
}