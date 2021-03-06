using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core;

// <Remarks>
// T?o DM_ChungBase
// Người tạo: Bùi Ðức Hạnh
// Ngày tạo : 07/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc
{
    //todo: @HanhBD DM_ChungBase
    public abstract partial class DM_ChungBase : DevExpress.XtraEditors.XtraForm
    {
        public DM_ChungBase()
        {
            InitializeComponent();
            InitializeInstanceComponent();
        }

        protected abstract void InitializeInstanceComponent();
        protected abstract void SetDataSource();//hàm không cần thực thi
        protected abstract void AddItem();
        protected abstract void SyncItem();
        protected abstract void DeleteItem();
        protected abstract void UpdateItem();
        protected abstract void ValidItem(object obj, ActionState actionMode);

        private void DM_ChungBase_Load(object sender, EventArgs e)
        {
            SetDataSource();
        }

        private void ucActions1_OnAdd(object obj)
        {
            AddItem();
            SetDataSource();
        }

        private void ucActions1_OnSynchronize()
        {
            SyncItem();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            DeleteItem();
            SetDataSource();
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtMoTa.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtMoTa.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMa.Text = Convert.ToString(getValue("clMa"));
                txtTen.Text = Convert.ToString(getValue("clTen"));
                txtMoTa.Text = Convert.ToString(getValue("clMoTa"));
                chkSuDung.Checked = Convert.ToInt32(getValue("clSuDung")) == 1;
                return;
            }
            txtMa.Text = String.Empty;
            txtTen.Text = String.Empty;
            txtMoTa.Text = String.Empty;
            chkSuDung.Checked = false;
        }

        protected object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            UpdateItem();
            SetDataSource();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            ValidItem(obj, actionMode);
        }

        protected int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["clId"].Value);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(null);
            else
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
        }
    }
}