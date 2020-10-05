using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public abstract class DmSegmentDataProvider : SynchronizableProvider
    {
        public abstract List<SegmentInfo> GetListSegmentInfor();

        public List<SegmentInfo> SearchSegmentInfor(string ma, string ten)
        {
            return GetListSegmentInfor().FindAll(
                delegate(SegmentInfo match)
                {
                    return (String.IsNullOrEmpty(ma) ||
                            match.Ma.ToLower().Contains(ma.ToLower())) &&
                           (String.IsNullOrEmpty(ten) ||
                            match.Ten.ToLower().Contains(ten.ToLower()));
                });
        }
    }

    public abstract class DmSegmentChildDataProvider : SynchronizableProvider
    {
        public abstract List<SegmentChildInfo> GetListSegmentChildInfor();

        public List<SegmentChildInfo> SearchSegmentChildInfor(string ma, string  ten)
        {
            return GetListSegmentChildInfor().FindAll(
                delegate(SegmentChildInfo match)
                    {
                        return (String.IsNullOrEmpty(ma) ||
                                match.Ma.ToLower().Contains(ma.ToLower())) &&
                               (String.IsNullOrEmpty(ten) ||
                                match.Ten.ToLower().Contains(ten.ToLower()));
                    });
        }
    }
}
