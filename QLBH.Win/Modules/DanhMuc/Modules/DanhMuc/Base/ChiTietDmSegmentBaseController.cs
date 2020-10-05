using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietDmSegmentBaseController<T> : frmChiTietSegment_DMChung
    {
        #region Declare

        private string sMa, sTen;
        protected T dm;
        protected frmDM_ListBaseNew frmList;
        protected IDanhMucEditInfor<T> Provider;
        #endregion


        protected override void LoadData()
        {
            //dm = Provider.GetFullInfoByKey(dm);
            SetFormInfo();
        }
        protected virtual void SetFormInfo()
        {
            throw new NotImplementedException();
        }

        protected void SetFormInfo(string sTen, string sMa)
        {
            txtTen.Text = this.sTen = sTen;
            txtMa.Text = this.sMa = sMa;
        }
        protected virtual T GetFormInfo()
        {
            return default(T);
        }
    }

    public class ChiTietDmSegmentChildBaseController<T> : frmChiTietSegmentChild_DMChung
    {
        #region Declare

        private string sMa, sTen,sMaCha;
        protected T dm;
        protected frmDM_ListBaseNew frmList;
        protected IDanhMucEditInfor<T> Provider;
        #endregion


        protected override void LoadData()
        {
            //dm = Provider.GetFullInfoByKey(frmList.Oid);
            SetFormInfo();
        }
        protected virtual void SetFormInfo()
        {
            throw new NotImplementedException();
        }

        protected void SetFormInfo(string sTen, string sMa, string sMaCha)
        {
            txtTen.Text = this.sTen = sTen;
            txtMa.Text = this.sMa = sMa;
            txtMaCha.Text = this.sMaCha = sMaCha;
        }
        protected virtual T GetFormInfo()
        {
            return default(T);
        }
    }
}
