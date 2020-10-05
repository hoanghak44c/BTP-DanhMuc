using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.HeThong;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public abstract class SynchronizableDAO : BaseDAO
    {
        internal bool IsSync()
        {
            return DmListDAO.Instance.IsSync(CRUDTableName);
        }

        internal virtual void Synchronize()
        {
            //LockControl.Lock(CRUDTableName, 0);
            Synchronize(true);
        }

        internal virtual void Synchronize(bool isCompleted)
        {
            throw new NotImplementedException("Chức năng đồng bộ bảng dữ liệu " + CRUDTableName + " chưa được thực hiện.");
        }
    }

}
