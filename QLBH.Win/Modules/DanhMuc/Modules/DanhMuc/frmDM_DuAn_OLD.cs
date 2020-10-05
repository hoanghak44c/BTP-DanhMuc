using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core;

namespace QLBanHang.Modules.DanhMuc
{
   public class frmDM_DuAn_OLD :DM_ChungBase
    {
        private int idDuAn = 0;
        
        public frmDM_DuAn_OLD()
        {
           ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmDuAn);
        }

        protected override void InitializeInstanceComponent()
        {
           dgvList.Columns["clId"].DataPropertyName = "IdDuAn";
           dgvList.Columns["clMa"].DataPropertyName = "MaDuAn";
           dgvList.Columns["clTen"].DataPropertyName = "TenDuAn";
           dgvList.Columns["clMota"].DataPropertyName = "GhiChu";
           dgvList.Columns["clSuDung"].DataPropertyName = "SuDung";
        }

        protected override void SetDataSource()
        {
           dgvList.DataSource = DMDuAnDataProvider.Instance.GetListDuAnInfo();
        }

        private DMDuAnInfor getinfor()
        {
           DMDuAnInfor dmDuAnInfor = new DMDuAnInfor();
           dmDuAnInfor.MaDuAn = txtMa.Text;
           dmDuAnInfor.TenDuAn = txtTen.Text;
           dmDuAnInfor.GhiChu = txtMoTa.Text;
           dmDuAnInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmDuAnInfor.IdDuAn = Convert.ToInt32(getValue("clId"));
           return dmDuAnInfor;
        }

        protected override void AddItem()
        {
           DMDuAnDataProvider.Instance.Insert(getinfor());
           MessageBox.Show("Thêm bảng thành công!");
        }

        protected override void SyncItem()
        {
           throw new NotImplementedException("Synchronize function is not implemented.");
        }

        protected override void DeleteItem()
        {
           DMDuAnInfor khaibao = new DMDuAnInfor();
           khaibao.IdDuAn = Convert.ToInt32(getValue("clId"));
           DMDuAnDataProvider.Instance.Delete(khaibao);
           MessageBox.Show("Xóa Thành Công", "Thông Báo");
        }

        protected override void UpdateItem()
        {
            DMDuAnDataProvider.Instance.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
        }

        protected override void ValidItem(object obj, ActionState actionMode)
        {
           switch (actionMode)
           {
               case ActionState.ADD:
               case ActionState.UPDATE:
                   idDuAn = getEditId(obj);
                   if (txtMa.Text == String.Empty)
                   {
                       throw new Exception("Mã Không Được Để Trống!");
                   }
                   if (DMDuAnDataProvider.Instance.IsExisted(new DMDuAnInfor{IdDuAn = idDuAn,MaDuAn = txtMa.Text}))
                   {
                       //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                       //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                       throw new Exception("Mã Đã Tồn Tại!");
                   }
                   break;
           }            
        }

        private bool Exist(DMDuAnInfor dmDuAnInfor)
        {
           return dmDuAnInfor.IdDuAn != idDuAn &&
               dmDuAnInfor.MaDuAn != null && dmDuAnInfor.MaDuAn.ToLower() == txtMa.Text.Trim().ToLower();
        }
    }
}
