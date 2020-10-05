using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

// <Remarks>
// Tạo frmDM_ChucNang
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 07/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc
{
    //todo: @HanhBD frmDM_ChucNang
    public class frmDM_ChucNang_OLD : DM_ChungBase
    {
        public frmDM_ChucNang_OLD()
        {
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmChucNang);
        }

        private int idChucNang =0;

        protected override void InitializeInstanceComponent()
        {
            dgvList.Columns["clId"].DataPropertyName = "IdChucNang";
            dgvList.Columns["clMa"].DataPropertyName = "MaChucNang";
            dgvList.Columns["clTen"].DataPropertyName = "TenChucNang";
            dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
            dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }

        protected override void SetDataSource()
        {
            dgvList.DataSource = DMChucNangDataProvider.Instance.GetChucNangInfor();
        }

        private DMChucNangInfor getinfor()
        {
            DMChucNangInfor dmChucNangInfor = new DMChucNangInfor();
            dmChucNangInfor.MaChucNang = txtMa.Text;
            dmChucNangInfor.TenChucNang = txtTen.Text;
            dmChucNangInfor.GhiChu = txtMoTa.Text;
            dmChucNangInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmChucNangInfor.IdChucNang = Convert.ToInt32(getValue("clId"));
            return dmChucNangInfor;
        }

        protected override void AddItem()
        {
            DMChucNangDataProvider.Instance.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
            //todo: @HanhBD (PENDING) implement synchronize this
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
            //todo: @HanhBD em có thể viết như sau cho gọn, tương tự các form khác
            DMChucNangDataProvider.Instance.Delete(new DMChucNangInfor { IdChucNang = Convert.ToInt32(getValue("clId")) });
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
            DMChucNangDataProvider.Instance.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idChucNang = getEditId(obj);
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã Không Được Để Trống!");
                    }
                    if (DMChucNangDataProvider.Instance.IsExisted(new DMChucNangInfor{IdChucNang = idChucNang,TenChucNang = txtTen.Text}))
                    {
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Đã Tồn Tại!");
                    }
                    break;
            }
        }

        private bool Exist(DMChucNangInfor dmChucNangInfor)
        {
            return dmChucNangInfor.IdChucNang != idChucNang &&
                dmChucNangInfor.MaChucNang != null && dmChucNangInfor.MaChucNang.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
