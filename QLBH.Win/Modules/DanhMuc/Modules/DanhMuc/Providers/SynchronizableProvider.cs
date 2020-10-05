using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBH.Core;
using QLBH.Core.Data;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public abstract class SynchronizableProvider
    {
        protected SynchronizableDAO controllerDAO;

        internal protected string Member { get; set; }

        internal bool IsSync()
        {
            return controllerDAO.IsSync();
        }

        internal void Synchronize()
        {
            try
            {
                controllerDAO.Synchronize();
            }
            catch (Exception ex)
            {
                frmProgress.Instance.Value = frmProgress.Instance.MaxValue;

                frmProgress.Instance.IsCompleted = true;
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        internal protected List<T> Validate<T>(List<T> result)
        {
            return Regmon.Instance.ValidResult(result, Member);
        }
    }
}
