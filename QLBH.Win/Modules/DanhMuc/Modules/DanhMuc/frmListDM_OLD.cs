using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core;

namespace QLBanHang.Modules.DanhMuc
{
    // <Remarks>
    // form ListDM
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 22/02/2012
    // Ngày sửa cuối :28/02/2012
    // </remarks>
    
    //Note:@HanhBD frmListDM 
    //private string TblName ;
    public partial class frmListDM_OLD : Form
    {
        public frmListDM_OLD()
        {
            InitializeComponent();
        }

        private void frmListDM_Load(object sender, EventArgs e)
        {
            try
            {
                //Lay du lieu tu bang khai bao, load vao list
                dgvListDM.DataSource = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
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

        private void dgvListDM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && dgvListDM.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvListDM.Rows[e.RowIndex]);
            else
            {
                ucActions1.LoadEditor(null);
            }
            //ucActions1.LoadEditor(dgvListDM.Rows[e.RowIndex].IsNewRow ? null : dgvListDM.Rows[e.RowIndex]);
        }

        private object getValue(string colName)
        {
            if (dgvListDM.CurrentRow != null && !dgvListDM.CurrentRow.IsNewRow)
                return dgvListDM.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if(obj != null)
            {
                txtTenBang.Text = Convert.ToString(getValue("clTblName"));
                txtTenDanhMuc.Text = Convert.ToString(getValue("clName"));
                chkSuDung.Checked = Convert.ToInt32(getValue("clOnlyPOS")) == 1;
                return;
            }
            txtTenBang.Text = String.Empty;
            txtTenDanhMuc.Text = String.Empty;
            chkSuDung.Checked = false;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtTenBang.Enabled = false;
            txtTenDanhMuc.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtTenBang.Enabled = txtTenBang.Text.Trim() == String.Empty;
            txtTenDanhMuc.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD: case ActionState.UPDATE:
                    if (txtTenBang.Text == String.Empty)
                    {
                        throw new Exception("Tên Bảng Không Được Để Trống!");
                    }
                    if (KhaiBaoDMDataProvider.Kiemtra(new DMListInfor{ TblName = txtTenBang.Text, Name = txtTenDanhMuc.Text}))
                    {
                        throw new Exception("Tên Bảng Đã Tồn Tại!");
                    }
                    break;
            }
        }

        private DMListInfor getinfor()
        {
            DMListInfor khaiBaoDMInfo = new DMListInfor();
            khaiBaoDMInfo.Name = txtTenDanhMuc.Text;
            khaiBaoDMInfo.TblName = txtTenBang.Text;
            khaiBaoDMInfo.OnlyPOS = Convert.ToInt32(chkSuDung.Checked);
            return khaiBaoDMInfo;
        }

        private void ucActions1_OnAdd(object obj)
        {
            KhaiBaoDMDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvListDM.DataSource = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
        }

        private void ucActions1_OnUpdate(object obj)
        {
            KhaiBaoDMDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvListDM.DataSource = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
        }

        private void ucActions1_OnDelete(object obj)
        {
            DMListInfor khaibao = new DMListInfor();
            khaibao.TblName = txtTenBang.Text.Trim();
            KhaiBaoDMDataProvider.Delete(khaibao);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvListDM.DataSource = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private bool Exist(DMListInfor khaiBaoDMInfo)
        {
            return khaiBaoDMInfo.TblName.ToLower() == txtTenBang.Text.Trim().ToLower();
        }
    }
}
