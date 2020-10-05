using System;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietDmChungController<T> : frmChiTiet_DMChung
    {
        #region Declare

        private string sMa, sTen;
        protected T dm;
        protected frmDM_ListBaseNew frmList;
        protected IDanhMucEditInfor<T> Provider;
        #endregion

        #region "Các phương thức"

        protected override bool IsAddMode()
        {
            return frmList.isAdd;
        }

        protected override void LoadData()
        {
            if (IsAddMode())
            {
                Reset();
                btnXoa.Enabled = false;
                txtMa.Enabled = true;
            }
            txtMa.Focus();
            if (!IsAddMode())
            {
                txtMa.Enabled = false;
                dm = Provider.GetFullInfoByKey(frmList.Oid);
                SetFormInfo();
                txtTen.Focus();
                btnXoa.Enabled = true;
            }
            if (frmList.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        protected virtual void SetFormInfo()
        {
            throw new NotImplementedException();
        }

        protected void SetFormInfo(string sTen, string sMa, string sMoTa, int iSuDung)
        {
            txtTen.Text = this.sTen = sTen;
            txtMa.Text = this.sMa = sMa;
            txtMoTa.Text = sMoTa;
            chkSuDung.Checked = iSuDung == 1;
        }

        protected virtual T GetFormInfo()
        {
            return default(T);
        }

        #region Update

        protected override void CheckOnSave()
        {
            base.CheckOnSave();

            if (String.IsNullOrEmpty(txtMa.Text))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã không được để trống!");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên không được để trống!");
            }

            if (Provider.IsExisted(GetFormInfo()))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã đã tồn tại trong hệ thống!");
            }

            if (frmList.IsSync)
            {
                if (txtTen.Text != sTen)
                {
                    txtTen.Focus();
                    throw new InvalidOperationException("Tên đã bị thay đổi !");
                }
                if (txtMa.Text != sMa)
                {
                    txtMa.Focus();
                    throw new InvalidOperationException("Mã đã bị thay đổi !");
                }
            }
        }

        protected override void SaveInstance()
        {
            if (IsAddMode())
            {
                Provider.Insert(GetFormInfo());
            }
            else
            {
                Provider.Update(GetFormInfo());
            }

            frmList.ReLoad();
        }

        #endregion

        #region Delete

        protected override void CheckOnDelete()
        {
            base.CheckOnDelete();

            if (IsAddMode())
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmList.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            if (Provider.IsUsed(GetFormInfo()))
            {
                throw new InvalidOperationException("Mã này đang được sử dụng!");
            }
        }

        protected override void DeleteInstance()
        {
            Provider.Delete(GetFormInfo());

            frmList.ReLoad();
        }

        #endregion

        protected void Reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtMoTa.Text = "";
            chkSuDung.Checked = true;
            txtMa.Focus();
        }

        #endregion
    }

    public class ChiTietDmChungController1<T> : frmChiTiet_DMChung
    {
        #region Declare

        private string sMa, sTen;
        protected T dm;
        protected frmDM_ListBaseNew frmList;
        protected IDanhMucEditInfor<T> Provider;
        #endregion

        #region "Các phương thức"

        protected override bool IsAddMode()
        {
            return frmList.isAdd;
        }

        protected override void LoadData()
        {
            if (IsAddMode())
            {
                Reset();
                btnXoa.Enabled = false;
                txtMa.Enabled = true;
            }
            txtMa.Focus();
            if (!IsAddMode())
            {
                txtMa.Enabled = false;
                dm = Provider.GetFullInfoByKey(frmList.Oid);
                SetFormInfo();
                txtTen.Focus();
                btnXoa.Enabled = true;
            }
            if (frmList.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        protected virtual void SetFormInfo()
        {
            throw new NotImplementedException();
        }

        protected void SetFormInfo(string sTen, string sMa, string sMoTa, int iSuDung)
        {
            txtTen.Text = this.sTen = sTen;
            txtMa.Text = this.sMa = sMa;
            txtMoTa.Text = sMoTa;
            chkSuDung.Checked = iSuDung == 1;
        }

        protected virtual T GetFormInfo()
        {
            return default(T);
        }

        #region Update

        protected override void CheckOnSave()
        {
            base.CheckOnSave();

            if (String.IsNullOrEmpty(txtMa.Text))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã không được để trống!");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên không được để trống!");
            }

            if (Provider.IsExisted(GetFormInfo()))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã đã tồn tại trong hệ thống!");
            }

            if (frmList.IsSync)
            {
                if (txtTen.Text != sTen)
                {
                    txtTen.Focus();
                    throw new InvalidOperationException("Tên đã bị thay đổi !");
                }
                if (txtMa.Text != sMa)
                {
                    txtMa.Focus();
                    throw new InvalidOperationException("Mã đã bị thay đổi !");
                }
            }
        }

        protected override void SaveInstance()
        {
            if (IsAddMode())
            {
                Provider.Insert(GetFormInfo());
            }
            else
            {
                Provider.Update(GetFormInfo());
            }

            frmList.ReLoad();
        }

        #endregion

        #region Delete

        protected override void CheckOnDelete()
        {
            base.CheckOnDelete();

            if (IsAddMode())
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmList.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            if (Provider.IsUsed(GetFormInfo()))
            {
                throw new InvalidOperationException("Mã này đang được sử dụng!");
            }
        }

        protected override void DeleteInstance()
        {
            Provider.Delete(GetFormInfo());

            frmList.ReLoad();
        }

        #endregion

        protected void Reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtMoTa.Text = "";
            chkSuDung.Checked = true;
            txtMa.Focus();
        }

        #endregion
    }
}
