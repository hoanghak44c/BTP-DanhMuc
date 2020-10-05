using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

// <Remarks>
// Tạo frmDM_PhongBan
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 08/03/2012
// Người sửa cuối:
// </remarks>
//todo @Hanh frmDM_PhongBan
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_PhongBan_Old : DM_ChungBase
    {
        private int idPhongBan = 0;

        public frmDM_PhongBan_Old()
        {
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmPhongBan);
        }

        protected override void InitializeInstanceComponent()
        {
            dgvList.Columns["clId"].DataPropertyName = "IdPhongBan";
            dgvList.Columns["clMa"].DataPropertyName = "MaPhongBan";
            dgvList.Columns["clTen"].DataPropertyName = "TenPhongBan";
            dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
            dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }

        protected override void SetDataSource()
        {
            dgvList.DataSource = DMPhongBanDataProvider.Instance.GetListPhongBanInfor();
        }

        private DMPhongBanInfor getinfor()
        {
            DMPhongBanInfor dmPhongBanInfor = new DMPhongBanInfor();
            dmPhongBanInfor.MaPhongBan = txtMa.Text;
            dmPhongBanInfor.TenPhongBan = txtTen.Text;
            dmPhongBanInfor.GhiChu = txtMoTa.Text;
            dmPhongBanInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmPhongBanInfor.IdPhongBan = Convert.ToInt32(getValue("clId"));
            return dmPhongBanInfor;
        }

        protected override void AddItem()
        {
            DMPhongBanDataProvider.Instance.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
            DMPhongBanInfor khaibao = new DMPhongBanInfor();
            khaibao.IdPhongBan = Convert.ToInt32(getValue("clId"));
            DMPhongBanDataProvider.Instance.Delete(khaibao);
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
            DMPhongBanDataProvider.Instance.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idPhongBan = getEditId(obj);
                    if (txtMa.Text == String.Empty)
                    {
                        throw new Exception("Mã Không Được Để Trống!");
                    }
                    if (DMPhongBanDataProvider.Instance.IsExisted(new DMPhongBanInfor { IdPhongBan = idPhongBan, MaPhongBan = txtMa.Text }))
                    {
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Đã Tồn Tại!");
                    }
                    break;
            }
        }

        private bool Exist(DMPhongBanInfor dmPhongBanInfor)
        {
            return dmPhongBanInfor.IdPhongBan != idPhongBan &&
                dmPhongBanInfor.MaPhongBan != null && dmPhongBanInfor.MaPhongBan.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
