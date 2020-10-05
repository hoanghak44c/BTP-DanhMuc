using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DmNganhDataProvider : DmSegmentChildDataProvider,IDanhMucEditInfor<SegmentChildInfo>
    {

        private static DmNganhDataProvider instance;

        private DmNganhDataProvider(){}

        public static DmNganhDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmNganhDataProvider();
                return instance;
            }
        }

        public List<string> GetListNganhTonKho(int idKho)
        {
            return DmNganhDAO.Instance.GetListNganhTonKho(idKho);
        }

        #region Overrides of DmSegmentChildDataProvider

        public override List<SegmentChildInfo> GetListSegmentChildInfor()
        {
            return DmNganhDAO.Instance.GetListSegmentInfor();
        }

        #endregion

        public SegmentChildInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmNganhDAO.Instance.GetListSegmentInfor().Find(delegate(SegmentChildInfo match)
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