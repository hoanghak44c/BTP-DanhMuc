using System;
using System.Threading;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

//Note:@HanhBD frmDM_LoaiThuChi

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_LoaiThuChi_OLD : DevExpress.XtraEditors.XtraForm
    {
        private int idThuChi=0;
        public frmDM_LoaiThuChi_OLD()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmLoaiThuChi);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>= 0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else
            {
                ucActions1.LoadEditor(null);
            }
            //ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].IsNewRow ? null : dgvList.Rows[e.RowIndex]);
        }

        private DMLoaiThuChiInfor getinfor()
        {
            DMLoaiThuChiInfor dmLoaiThuChiInfor = new DMLoaiThuChiInfor();
            dmLoaiThuChiInfor.Ten = txtTen.Text;
            dmLoaiThuChiInfor.KyHieu = txtMa.Text;
            dmLoaiThuChiInfor.GhiChu = txtMoTa.Text;
            dmLoaiThuChiInfor.Type = cboType.SelectedIndex;
            dmLoaiThuChiInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmLoaiThuChiInfor.IdThuChi = Convert.ToInt32(getValue("clIdThuChi"));
            return dmLoaiThuChiInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMLoaiThuChiDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMLoaiThuChiInfo khaibao = new DMLoaiThuChiInfo();
            //khaibao.IdThuChi = Convert.ToInt32(getValue("clIdThuChi"));
            DMLoaiThuChiDataProvider.Delete(new DMLoaiThuChiInfor{IdThuChi = Convert.ToInt32(getValue("clIdThuChi"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMa.Enabled = false;
            txtMoTa.Enabled = false;
            txtTen.Enabled = false;
            cboType.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMa.Enabled = true;
            txtMoTa.Enabled = true;
            cboType.Enabled = true;
            chkSuDung.Enabled = true;
            txtTen.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMa.Text = Convert.ToString(getValue("clKyHieu"));
                txtMoTa.Text = Convert.ToString(getValue("clGhiChu"));
                txtTen.Text = Convert.ToString(getValue("clTen"));
                cboType.SelectedIndex = Convert.ToInt32(getValue("clType"));
                chkSuDung.Checked = Convert.ToInt32(getValue("clSuDung")) == 1;
                return;
            }
            txtMa.Text = String.Empty;
            txtMoTa.Text = String.Empty;
            txtTen.Text = String.Empty;
            chkSuDung.Checked = false;
            cboType.SelectedIndex = -1;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMLoaiThuChiDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idThuChi = getEditId(obj);
                    if (txtTen.Text == String.Empty)
                    {
                        throw new Exception("Tên Danh mục Không Được Để Trống!");
                    }
                    if (DMLoaiThuChiDataProvider.KiemTra(new DMLoaiThuChiInfor{IdThuChi = idThuChi,Ten = txtTen.Text}))
                    {
                        //todo: @HanhBD (PENDING) check delete references
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Tên Danh mục Đã Tồn Tại!");
                    }
                   
                    break;
            }
        }

        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["clIdThuChi"].Value);
        }

        private bool Exist(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            return dmLoaiThuChiInfor.IdThuChi != idThuChi &&
                dmLoaiThuChiInfor.Ten != null && dmLoaiThuChiInfor.Ten.ToLower() == txtTen.Text.Trim().ToLower();
        }

        private void frmDM_LoaiThuChi_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                this.Dispose();
            }
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

    }
}