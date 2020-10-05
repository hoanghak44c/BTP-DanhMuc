using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DmLinhVucDataProvider : DmSegmentDataProvider, IDanhMucEditInfor<SegmentInfo>
    {

        private static DmLinhVucDataProvider instance;
        public static DmLinhVucDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmLinhVucDataProvider();
                return instance;
            }
        }


        #region Overrides of DmSegmentDataProvider

        public override List<SegmentInfo> GetListSegmentInfor()
        {
            return DmLinhVucDAO.Instance.GetListSegmentInfor();
        }

        #endregion

        public SegmentInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmLinhVucDAO.Instance.GetListSegmentInfor().Find(delegate(SegmentInfo match)
                                                                        { return match.Ma.Equals(keyParams[0]); });
        }

        public int Insert(SegmentInfo insertInfo)
        {
            throw new NotImplementedException();
        }

        public void Update(SegmentInfo updateInfo)
        {
            throw new NotImplementedException();
        }

        public void Delete(SegmentInfo deleteInfo)
        {
            throw new NotImplementedException();
        }

        public bool IsExisted(SegmentInfo checkInfo)
        {
            throw new NotImplementedException();
        }

        public bool IsUsed(SegmentInfo checkInfo)
        {
            throw new NotImplementedException();
        }
    }
}
