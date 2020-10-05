using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseItemSegment : frmLookUp_BaseNew_1<ItemSegmentInfo>
    {
        private int IdNhomNguoiDung;
        private int SuDung;
        private int ChietKhau;
        private int ItemType = 6;//loai segment

        public frmLookUpBaseItemSegment(){}

        public frmLookUpBaseItemSegment(bool isMultiSelect, int idNhomNguoiDung, int type, int suDung, int chietKhau) : base(isMultiSelect)
        {
            this.SuDung = suDung;
            this.ChietKhau = chietKhau;
            this.IdNhomNguoiDung = idNhomNguoiDung;
            this.ItemType = type;
        }

        public frmLookUpBaseItemSegment(bool isMultiSelect, int idNhomNguoiDung, int type, int suDung, int chietKhau, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            this.SuDung = suDung;
            this.ChietKhau = chietKhau;
            this.IdNhomNguoiDung = idNhomNguoiDung;
            this.ItemType = type;
        }
        protected override void OnLoad()
        {
            ListInitInfo = ItemSegmentDataProvider.Instance.GetAllItemsByType(IdNhomNguoiDung, ItemType, ChietKhau,
                                                                              SuDung);
        }
    }
}
