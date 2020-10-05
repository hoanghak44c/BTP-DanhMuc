using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core;

namespace QLBanHang.Modules.DanhMuc
{
    //todo: @HanhBD frmDM_DonViTinh
   public class frmDM_DonViTinh_OLD : DM_ChungBase
    {
        private int idDonViTinh = 0;
        
        public frmDM_DonViTinh_OLD()
        {
           ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmDonViTinh);
        }

        protected override void InitializeInstanceComponent()
        {
            dgvList.Columns["clId"].DataPropertyName = "IdDonViTinh";
            dgvList.Columns["clMa"].DataPropertyName = "KyHieu";
            dgvList.Columns["clTen"].DataPropertyName = "TenDonViTinh";
            dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
            dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }
        protected override void SetDataSource()
        {
            dgvList.DataSource = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
        }
        private DMDonViTinhInfor getinfor()
        {
            DMDonViTinhInfor dmDonViTinhInfor = new DMDonViTinhInfor();
            dmDonViTinhInfor.KyHieu = txtMa.Text;
            dmDonViTinhInfor.TenDonViTinh = txtTen.Text;
            dmDonViTinhInfor.GhiChu = txtMoTa.Text;
            dmDonViTinhInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmDonViTinhInfor.IdDonViTinh = Convert.ToInt32(getValue("clId"));
            return dmDonViTinhInfor;
        }
        protected override void AddItem()
        {
           DmDonViTinhProvider.Instance.Insert(getinfor());
           MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
           throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
            DMDonViTinhInfor khaibao = new DMDonViTinhInfor();
           khaibao.IdDonViTinh = Convert.ToInt32(getValue("clId"));
           DmDonViTinhProvider.Instance.Delete(khaibao);
           MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
           DmDonViTinhProvider.Instance.Update(getinfor());
           MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj, ActionState actionMode)
        {
           switch (actionMode)
           {
               case ActionState.ADD:
               case ActionState.UPDATE:
                   idDonViTinh = getEditId(obj);
                   if (txtMa.Text == String.Empty)
                   {
                       throw new Exception("Mã Không Được Để Trống!");
                   }
                   if (DmDonViTinhProvider.Instance.IsExisted(new DMDonViTinhInfor{IdDonViTinh = idDonViTinh,TenDonViTinh = txtTen.Text}))
                   {
                       //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                       //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                       throw new Exception("Mã Đã Tồn Tại!");
                   }
                   break;
           }            
        }

        private bool Exist(DMDonViTinhInfor dmDonViTinhInfor)
        {
           return dmDonViTinhInfor.IdDonViTinh != idDonViTinh &&
               dmDonViTinhInfor.KyHieu != null && dmDonViTinhInfor.KyHieu.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
