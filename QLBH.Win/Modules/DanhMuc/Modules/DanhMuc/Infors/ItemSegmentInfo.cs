using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{    
    [Serializable]
    public class ItemSegmentInfo
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Nhom { get; set; }
        public int ChietKhau { get; set; }
    }
}
