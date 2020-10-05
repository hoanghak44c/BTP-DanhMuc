using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Properties;
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
    public partial class frmDM_ListBaseNew : DevExpress.XtraEditors.XtraForm
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
        public frmDM_ListBaseNew()
        {
            InitializeComponent();
            //Common.LoadStyle(this);
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
            dgvDanhSachMatHang.RefreshData();
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

        protected RepositoryItem CheckBoxEditor
        {
            get
            {
                foreach (RepositoryItem repositoryItem in grcBase.RepositoryItems)
                {
                    if (repositoryItem is RepositoryItemCheckEdit) return repositoryItem;
                }
                
                var riCheckBox = new RepositoryItemCheckEdit { ValueChecked = 1, ValueUnchecked = 0 };
                
                grcBase.RepositoryItems.Add(riCheckBox);

                return riCheckBox;
            }
        }

        protected void PopulateColumns(params string[] fieldNames)
        {
            ColumnView view = grcBase.MainView as ColumnView;
            DevExpress.XtraGrid.Columns.GridColumn column;
            if(view == null) return;
            view.Columns.Clear();            

            for (int i = 0; i < fieldNames.Length; i++)
            {
                column = view.Columns.AddField(fieldNames[i]);
                column.VisibleIndex = i;
                if (fieldNames[i] == "SuDung")
                {
                    column.ColumnEdit = CheckBoxEditor;
                    column.Width = column.GetBestWidth();
                }
            }
        }

        protected void Captions(params string[] captions)
        {
            ColumnView view = grcBase.MainView as ColumnView;
            if (view == null) return;
            for (int i = 0; i < captions.Length; i++)
            {
                view.Columns[i].Caption= captions[i];
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
                //if(!this.DesignMode) LoadData();
                //btnThemMoi.Text = Resources.btnAdd;
                btnCapNhat.Text = Resources.btnSave;
                btnXoa.Text = Resources.btnDelete;
                btnDong.Text = Resources.btnClose;
            }
            catch(System.Resources.MissingManifestResourceException)
            {
                //nothing to do here
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
                    LockControl.Lock(this.Name);
                    frmProgress.Instance.Text = String.Format("Đồng bộ {0}", this.Text);
                    frmProgress.Instance.DoWork(SyncProvider.Synchronize);
                    LoadData();
                    LockControl.Unlock(this.Name);
                }
            }
            catch (Exception ex)
            {
                LockControl.Unlock(this.Name);
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
                dgvDanhSachMatHang.SetFocusedValue(null);
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
            if (dgvDanhSachMatHang.GetFocusedValue() == null)
            {
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
                Oid = 0;
            }
        }

        public event DataGridViewCellMouseEventHandler OnGridHeaderDoubleClick;

        //void dgvDanhSachMatHang_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
            
        //    btnXoa.Enabled = false;
        //    btnCapNhat.Enabled = false;
        //    Oid = 0;
        //    dgvDanhSachMatHang.ClearSelection();
        //    dgvDanhSachMatHang.SetFocusedValue(null);
        //    if (OnGridHeaderDoubleClick != null)
        //        OnGridHeaderDoubleClick(sender, e);
        //}

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

        public event RowCellClickEventHandler OnGridCellClick;
        private void dgvDanhSachMatHang_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            try
            {
                btnXoa.Enabled = !IsSync;
                btnCapNhat.Enabled = true;
                if (OnGridCellClick != null)
                    OnGridCellClick(sender, e);
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

        private void frmDM_ListBaseNew_KeyDown(object sender, KeyEventArgs e)
        {
            QLBH.Core.QLBHUtils.PerformShortCutKey(this,e.KeyCode);
        }

        private void frmDM_ListBaseNew_Activated(object sender, EventArgs e)
        {
            //frmDM_ListBase_Load(sender,e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(dgvDanhSachMatHang);
            //grcBase.ShowPrintPreview();
        }
    }
}