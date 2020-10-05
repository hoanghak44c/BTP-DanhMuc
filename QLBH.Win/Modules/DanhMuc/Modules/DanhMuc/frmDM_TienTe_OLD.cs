using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;

//Note:@HanhBD frmDM_TienTe
// <Remarks>
// form ListDM
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 22/02/2012
// Ngày sửa cuối :26/03/2012
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_TienTe_OLD : DevExpress.XtraEditors.XtraForm
    {
        private int idTienTe = 0;
        public frmDM_TienTe_OLD()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmTienTe);
        }

        private DMTienTeInfor getinfor()
        {
            DMTienTeInfor dmTienTeInfo = new DMTienTeInfor();
            dmTienTeInfo.KyHieu = txtMa.Text;
            dmTienTeInfo.TenTienTe = txtTen.Text;
            dmTienTeInfo.TyGia = Convert.ToInt32(txtTyGia.Text);
            dmTienTeInfo.GhiChu = txtMoTa.Text;
            dmTienTeInfo.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmTienTeInfo.IdTienTe = Convert.ToInt32(getValue("IdTienTe"));
            return dmTienTeInfo;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMTienTeDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMTienTeDataProvider.GetListTienTeInfor();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMTienTeInfo khaibao = new DMTienTeInfo();
            //khaibao.IdTienTe = Convert.ToInt32(getValue("IdTienTe"));
            DMTienTeDataProvider.Delete(new DMTienTeInfor{IdTienTe = Convert.ToInt32(getValue("IdTienTe"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMTienTeDataProvider.GetListTienTeInfor();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMa.Enabled = false;
            txtMoTa.Enabled = false;
            txtTen.Enabled = false;
            txtTyGia.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtTen.Enabled = true;
            txtMoTa.Enabled = true;
            txtTyGia.Enabled = true;
            txtMa.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMa.Text = Convert.ToString(getValue("clKyHieu"));
                txtMoTa.Text = Convert.ToString(getValue("clGhiChu"));
                txtTen.Text = Convert.ToString(getValue("clTenTienTe"));
                txtTyGia.Text = Convert.ToString(getValue("clTyGia"));
                chkSuDung.Checked = Convert.ToInt32(getValue("clSuDung")) == 1;
                return;
            }
            txtMa.Text = String.Empty;
            txtMoTa.Text = String.Empty;
            txtTen.Text = String.Empty;
            chkSuDung.Checked = false;
            txtTyGia.Text = String.Empty;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMTienTeDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMTienTeDataProvider.GetListTienTeInfor();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idTienTe = getEditId(obj);
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã tiền tệ Không Được Để Trống!");
                    }
                    if (DMTienTeDataProvider.KiemTra(new DMTienTeInfor{IdTienTe = idTienTe, TenTienTe = txtTen.Text}))
                    {
                        //todo: @HanhBD (PENDING) check delete references
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã tiền tệ Đã Tồn Tại!");
                    }
                    break;
            }     
        }

        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["IdTienTe"].Value);
        }

        private bool Exist(DMTienTeInfor dmTienTeInfo)
        {
            return dmTienTeInfo.IdTienTe != idTienTe &&
                dmTienTeInfo.KyHieu.ToLower() == txtMa.Text.Trim().ToLower();
        }

        private void frmDM_TienTe_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMTienTeDataProvider.GetListTienTeInfor();
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else
            {
                ucActions1.LoadEditor(null);
            }
            //ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].IsNewRow ? null : dgvList.Rows[e.RowIndex]);
        }
    }
}
