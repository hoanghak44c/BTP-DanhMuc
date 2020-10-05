using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmEditBase : DevExpress.XtraEditors.XtraForm
    {
        protected virtual void LoadData(){}

        protected virtual void CheckOnSave() { }

        protected virtual void SaveInstance()
        {
            throw new NotImplementedException("Chức năng này chưa được thực hiện");
        }

        protected virtual void CheckOnDelete() { }

        protected virtual void DeleteInstance()
        {
            throw new NotImplementedException("Chức năng này chưa được thực hiện");
        }

        protected virtual bool IsAddMode()
        {
            throw new NotImplementedException("Chức năng này chưa được thực hiện");
        }

        protected void Save()
        {
            CheckOnSave();

            SaveInstance();
        }

        protected void Delete()
        {
            CheckOnDelete();

            DeleteInstance();
        }

        protected void frmEditBase_Load(object sender, EventArgs e)
        {
            try
            {
                if(!DesignMode) LoadData();
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

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Save();

                if (IsAddMode())
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                //DialogResult = DialogResult.Abort;
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete();
                    MessageBox.Show("Xóa thành công bản ghi");
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                DialogResult = DialogResult.Abort;
            }
        }

        protected void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEditBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 271);
            this.Name = "frmEditBase";
            this.Load += this.frmEditBase_Load;
            this.ResumeLayout(false);

        }

        public frmEditBase()
        {
            InitializeComponent();
        }
    }
}
