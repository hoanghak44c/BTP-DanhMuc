using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DmLoaiDataProvider : DmSegmentChildDataProvider,IDanhMucEditInfor<SegmentChildInfo>
    {
        private static DmLoaiDataProvider instance;

        public static DmLoaiDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiDataProvider();
                return instance;
            }
        }

        #region Overrides of DmSegmentChildDataProvider

        public override List<SegmentChildInfo> GetListSegmentChildInfor()
        {
            return DmLoaiDAO.Instance.GetListSegmentInfor();
        }

        #endregion

        public SegmentChildInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmLoaiDAO.Instance.GetListSegmentInfor().Find(delegate(SegmentChildInfo match)
                                                                     { return match.Ma.Equals(keyParams[0]); });
        }

        public int Insert(SegmentChildInfo insertInfo)
        {
            throw new NotImplementedException();
        }

        public void Update(SegmentChildInfo updateInfo)
        {
            throw new NotImplementedException();
        }

        public void Delete(SegmentChildInfo deleteInfo)
        {
            throw new NotImplementedException();
        }

        public bool IsExisted(SegmentChildInfo checkInfo)
        {
            throw new NotImplementedException();
        }

        public bool IsUsed(SegmentChildInfo checkInfo)
        {
            throw new NotImplementedException();
        }
    }
}