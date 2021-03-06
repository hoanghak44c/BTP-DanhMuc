﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietSegmentHangController : ChiTietDmSegmentBaseController<SegmentInfo>
    {
        public ChiTietSegmentHangController()
        {
            Provider = DmHangDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma);
        }

        protected override SegmentInfo GetFormInfo()
        {
            return new SegmentInfo
                       {
                           Ten = txtTen.Text.Trim(),
                           Ma = txtMa.Text.Trim(),
                       };
        }
    }
}
