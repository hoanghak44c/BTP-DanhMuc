using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core;

//Note:@HanhBD frmDM_OrderType 
// <Remarks>
// tạo form danh mục OrderType
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 25/02/2012
// Người sửa cuối:28/02/2012
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{

    public partial class frmDM_OrderType_Old : DevExpress.XtraEditors.XtraForm
    {
        private int idOrderType = 0;
        //bool XacDinh = false;
        public frmDM_OrderType_Old()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmOrderType);
        }

        private void frmDM_OrderType_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMOrderTypeProvider.GetListOrderTypeInfor();
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                this.Dispose();
            }
        }

        private DMOrderTypeInfor getinfor()
        {
            DMOrderTypeInfor dmOrderTypeInfor = new DMOrderTypeInfor();
            dmOrderTypeInfor.OrderType = txtMaOrder.Text;
            dmOrderTypeInfor.Name = txtTenOrderType.Text;
            dmOrderTypeInfor.LineType = txtMaLine.Text;
            dmOrderTypeInfor.GhiChu = txtMoTa.Text;
            dmOrderTypeInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmOrderTypeInfor.IdOrderType = Convert.ToInt32(getValue("clIdOrderType"));
            return dmOrderTypeInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMOrderTypeProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMOrderTypeProvider.GetListOrderTypeInfor();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMOrderTypeInfor khaibao = new DMOrderTypeInfor();
            //khaibao.IdOrderType = Convert.ToInt32(getValue("clIdOrderType"));
            DMOrderTypeProvider.Delete(new DMOrderTypeInfor{IdOrderType = Convert.ToInt32(getValue("clIdOrderType"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMOrderTypeProvider.GetListOrderTypeInfor();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMaLine.Enabled = false;
            txtMoTa.Enabled = false;
            txtMaLine.Enabled = false;
            txtMaOrder.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMaLine.Enabled = true;
            txtMoTa.Enabled = true;
            txtMaLine.Enabled = true;
            txtMaOrder.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMaLine.Text = Convert.ToString(getValue("clLine"));
                txtMoTa.Text = Convert.ToString(getValue("clGhiChu"));
                txtMaOrder.Text = Convert.ToString(getValue("clCode"));
                txtTenOrderType.Text = Convert.ToString(getValue("clName"));
                chkSuDung.Checked = Convert.ToInt32(getValue("clSuDung")) == 1;
                return;
            }
            txtMaLine.Text = String.Empty;
            txtMoTa.Text = String.Empty;
            txtMaOrder.Text = String.Empty;
            chkSuDung.Checked = false;
            txtTenOrderType.Text = String.Empty;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMOrderTypeProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMOrderTypeProvider.GetListOrderTypeInfor();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idOrderType = getEditId(obj);
                    if (txtMaOrder.Text == String.Empty)
                    {
                        throw new Exception("Mã OrderType Không Được Để Trống!");
                    }
                    if (DMOrderTypeProvider.KiemTra(new DMOrderTypeInfor{IdOrderType = idOrderType,OrderType = txtMaOrder.Text}))
                    {
                        //todo: @HanhBD (PENDING) check delete references
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã OrderType Đã Tồn Tại!");
                    }                
                    break;
            }            
        }
        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["clIdOrderType"].Value);
        }

        private bool Exist(DMOrderTypeInfor dmOrderTypeInfor)
        {
            return dmOrderTypeInfor.IdOrderType != idOrderType &&
                dmOrderTypeInfor.OrderType!=null && dmOrderTypeInfor.OrderType.ToLower() == txtMaOrder.Text.Trim().ToLower();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else ucActions1.LoadEditor(null);
            //ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].IsNewRow ? null : dgvList.Rows[e.RowIndex]);
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }
    }
}