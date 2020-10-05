﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietSegmentChildModelController : ChiTietDmSegmentChildBaseController<SegmentChildInfo>
    {
        public ChiTietSegmentChildModelController()
        {
            Provider = DmModelDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma,dm.MaCha);
        }

        protected override SegmentChildInfo GetFormInfo()
        {
            return new SegmentChildInfo
            {
                Ten = txtTen.Text.Trim(),
                Ma = txtMa.Text.Trim(),
                MaCha = txtMaCha.Text.Trim()
            };
        }
    }
}
