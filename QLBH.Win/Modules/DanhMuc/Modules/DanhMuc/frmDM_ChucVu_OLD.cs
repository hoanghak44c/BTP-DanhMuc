using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

// <Remarks>
// Tạo frmDM_ChucVu
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 08/03/2012
// Người sửa cuối:
// </remarks>

//todo: @HanhBD frmDM_ChucVu

namespace QLBanHang.Modules.DanhMuc
{
   public class frmDM_ChucVu_OLD :DM_ChungBase
    {
        private int idChucVu = 0;

        public frmDM_ChucVu_OLD()
        {
           ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmChucVu);
        }

        protected override void InitializeInstanceComponent()
        {
            dgvList.Columns["clId"].DataPropertyName = "IdChucVu";
            dgvList.Columns["clMa"].DataPropertyName = "MaChucVu";
            dgvList.Columns["clTen"].DataPropertyName = "TenChucVu";
            dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
            dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }

        protected override void SetDataSource()
        {
            dgvList.DataSource = DMChucVuDataProvider.GetListChucVuInfor();
        }

        private DMChucVuInfor getinfor()
        {
            DMChucVuInfor dmChucVuInfor = new DMChucVuInfor();
            dmChucVuInfor.MaChucVu = txtMa.Text;
            dmChucVuInfor.TenChucVu = txtTen.Text;
            dmChucVuInfor.GhiChu = txtMoTa.Text;
            dmChucVuInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmChucVuInfor.IdChucVu = Convert.ToInt32(getValue("clId"));
            return dmChucVuInfor;
        }

        protected override void AddItem()
        {
            DMChucVuDataProvider.Instance.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
            DMChucVuInfor khaibao = new DMChucVuInfor();
            khaibao.IdChucVu = Convert.ToInt32(getValue("clId"));
            DMChucVuDataProvider.Instance.Delete(khaibao);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
            DMChucVuDataProvider.Instance.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj,ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idChucVu = getEditId(obj);
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã Không Được Để Trống!");
                    }
                    if (DMChucVuDataProvider.Instance.IsExisted(new DMChucVuInfor{IdChucVu = idChucVu,TenChucVu = txtTen.Text}))
                    {
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Đã Tồn Tại!");
                    }
                    break;
            }            
        }

        private bool Exist(DMChucVuInfor dmChucVuInfor)
        {
            return dmChucVuInfor.IdChucVu != idChucVu &&
                dmChucVuInfor.MaChucVu != null && dmChucVuInfor.MaChucVu.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
