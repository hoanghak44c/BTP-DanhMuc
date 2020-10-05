using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core;

// <Remarks>
// Tạo frmDM_TaxCode
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 09/03/2012
// Người sửa cuối:
// </remarks>
//todo: @HanhBD frmDM_TaxCode
namespace QLBanHang.Modules.DanhMuc
{
  public  class frmDM_TaxCode_Old :DM_ChungBase
    {
        private int idTaxCode = 0;

        public frmDM_TaxCode_Old()
        {
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmTaxCode);
        }

        protected override void InitializeInstanceComponent()
        {
            //todo: @HanhBD đặt lại tên các label cho hợp lý với từng danh mục cụ thể
            lblTieuDe.Text = "DANH MỤC MÃ SỐ THUẾ";
            groupBoxList.Text = "Danh sách mã số thuế";
            lblMa.Text = "Mã";
            lblTen.Text = "Tên";

            dgvList.Columns["clId"].DataPropertyName = "IdTaxCode";
            dgvList.Columns["clMa"].DataPropertyName = "Code";
            dgvList.Columns["clTen"].DataPropertyName = "Name";
            dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
            dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }

        protected override void SetDataSource()
        {
            dgvList.DataSource = DMTaxCodeDataProvider.GetListTaxCodeInfor();
        }

        private DMTaxCodeInfor getinfor()
        {
            DMTaxCodeInfor dmTaxCodeInfor = new DMTaxCodeInfor();
            dmTaxCodeInfor.Code = txtMa.Text;
            dmTaxCodeInfor.Name = txtTen.Text;
            dmTaxCodeInfor.GhiChu = txtMoTa.Text;
            dmTaxCodeInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmTaxCodeInfor.IdTaxCode = Convert.ToInt32(getValue("clId"));
            return dmTaxCodeInfor;
        }

        protected override void AddItem()
        {
            DMTaxCodeDataProvider.Instance.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
            DMTaxCodeInfor khaibao = new DMTaxCodeInfor();
            khaibao.IdTaxCode = Convert.ToInt32(getValue("clId"));
            DMTaxCodeDataProvider.Instance.Delete(khaibao);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
            DMTaxCodeDataProvider.Instance.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idTaxCode = getEditId(obj);
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã Không Được Để Trống!");
                    }
                    if (DMTaxCodeDataProvider.Instance.IsExisted(new DMTaxCodeInfor {IdTaxCode = idTaxCode,Code = txtMa.Text}))
                    {
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Đã Tồn Tại!");
                    }
                    break;
            }    
        }

        private bool Exist(DMTaxCodeInfor dmTaxCodeInfor)
        {
            return dmTaxCodeInfor.IdTaxCode != idTaxCode &&
                dmTaxCodeInfor.Code != null && dmTaxCodeInfor.Code.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
