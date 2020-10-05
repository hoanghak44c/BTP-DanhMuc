using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

// <Remarks>
// form frmDM_ListBase
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 21/04/2012
// Ngày sửa cuối:
// </remarks>
//todo : @HanhBD frmDM_ListBase
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_ListBase : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        public int IdMa = 0;
        public bool isAdd;
        public int Oid;
        private bool isSync;
        protected SynchronizableProvider SyncProvider;

        /// <summary>
        /// Lấy thuộc tính IsSync để xác định xem danh mục có phải đồng bộ hay không.
        /// </summary>
        public bool IsSync
        {
            get { return isSync; }
            private set { isSync = value; }
        }

        #endregion

        #region"Phương thức khởi tạo"
        public frmDM_ListBase()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            dgvDanhSachMatHang.AutoGenerateColumns = false;
        }
        #endregion

        #region"Các phương thức"

        #region LoadData
        protected virtual void LoadData(){}
        #endregion

        #region ReLoad
        public void ReLoad()
        {
            LoadData();
            dgvDanhSachMatHang.Refresh();
        }
        #endregion

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var & !IsSync;
            btnCapNhat.Enabled = var;
        }
        #endregion

        protected void LoadSync()
        {
            if (SyncProvider == null) return;
            IsSync = SyncProvider.IsSync();
            if (IsSync)
            {
                btnThemMoi.Text = "    Đồng bộ";
                OnThemMoi = null;
                OnThemMoi += frmDM_ListBase_OnSync;
            }            
        }

        #endregion

        #region "Các sự kiện"

        private void frmDM_ListBase_Load(object sender, EventArgs e)
        {
            try
            {
                this.CancelButton = btnDong;
                SetControl(false);
                if(!this.DesignMode) LoadData();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        public event EventHandler OnXoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (OnXoa != null)
                        OnXoa(sender, e);
                }

            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        public event EventHandler OnThemMoi;

        private void frmDM_ListBase_OnSync(object sender, EventArgs e)
        {
            try
            {
                if (IsSync)
                {
                    frmProgress.Instance.DoWork(SyncProvider.Synchronize);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDanhSachMatHang.ClearSelection();
                dgvDanhSachMatHang.CurrentCell = null;
                Oid = 0;
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;

                if (OnThemMoi != null)
                    OnThemMoi(sender, e);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        public event EventHandler OnCapNhat;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (OnCapNhat != null)
                    OnCapNhat(sender, e);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        void dgvDanhSachMatHang_MouseUp(object sender, MouseEventArgs e)
        {
            if (dgvDanhSachMatHang.CurrentCell == null)
            {
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
                Oid = 0;
            }
        }

        public event DataGridViewCellMouseEventHandler OnGridHeaderDoubleClick;

        void dgvDanhSachMatHang_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            Oid = 0;
            dgvDanhSachMatHang.ClearSelection();
            dgvDanhSachMatHang.CurrentCell = null;
            if (OnGridHeaderDoubleClick != null)
                OnGridHeaderDoubleClick(sender, e);
        }

        public event EventHandler OnGridDoubleClick;

        private void dgvDanhSachMatHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //if (Oid != 0)
                //{
                    if (OnGridDoubleClick != null)
                        OnGridDoubleClick(sender, e);
                //}
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        public event DataGridViewCellEventHandler OnGridCellClick;

        private void dgvDanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && !dgvDanhSachMatHang.Rows[e.RowIndex].IsNewRow)
                {
                    btnXoa.Enabled = !IsSync;
                    btnCapNhat.Enabled = true;
                    if (OnGridCellClick != null)
                        OnGridCellClick(sender, e);
                }else
                {
                    btnXoa.Enabled = false;
                    btnCapNhat.Enabled = false;
                    Oid = 0;
                    dgvDanhSachMatHang.ClearSelection();
                    dgvDanhSachMatHang.CurrentCell = null;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        void frmDM_ListBase_MouseUp(object sender, MouseEventArgs e)
        {
            dgvDanhSachMatHang_MouseUp(sender, e);
        }

        #endregion


    }
}