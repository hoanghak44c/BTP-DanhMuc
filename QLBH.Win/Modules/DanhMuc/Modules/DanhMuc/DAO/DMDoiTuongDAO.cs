using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBanHang.Modules.DongBoERP.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DMDoiTuongDAO : SynchronizableDAO
    {
        private static DMDoiTuongDAO instance;
        private DMDoiTuongDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmDoiTuong;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }
        public static DMDoiTuongDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMDoiTuongDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmDoiTuongSynchronize.Instance.LastUpdateDate =

                DmDoiTuongSyncProvider.Instance.GetLastUpdateDate().ToString(SynchronizeBase.DATE_SYNC_FORMAT);

            DmDoiTuongSupplierSynchronize.Instance.LastUpdateDate =

                DmDoiTuongSyncSupplierProvider.Instance.GetLastUpdateDate().ToString(SynchronizeBase.DATE_SYNC_FORMAT);
            
            DmDoiTuongSynchronize.Instance.Synchronize(false);

            DmDoiTuongSupplierSynchronize.Instance.Synchronize();
        }

        public List<DMDoiTuongInfo> GetListDoiTuongInfo()
        {
            //return GetListAll<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectAll, Declare.TableNamespace.DmDoiTuong);
            return GetListAll<DMDoiTuongInfo>(@"SELECT t1.iddoituong,
					 t1.idcha,
					 t1.madoituong,
					 t1.tendoituong,
					 t1.nguoilienlac,
					 t1.diachi,
					 t1.dienthoai,
					 t1.fax,
					 t1.email,
					 t1.masothue,
					 t1.type,
					 t1.sudung,
					 t1.ghichu,
					 t1.gioitinh,
					 t1.ngaysinh,
					 t1.idordertype,
					 t1.billto,
					 t1.shipto
			FROM tbl_dm_doituong t1
		 where t1.marieng is null", Declare.TableNamespace.DmDoiTuong);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Trả về danh sách khách lẻ có mã riêng khác null</returns>
        public List<DMDoiTuongInfo> GetListDoiTuongInfoEx()
        {
            //return GetListAll<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectEx, Declare.TableNamespace.DmDoiTuong);
            return GetListAll<DMDoiTuongInfo>(@"SELECT t1.iddoituong,
					 t1.idcha,
					 t1.madoituong,
					 t1.tendoituong,
					 t1.nguoilienlac,
					 t1.diachi,
					 t1.dienthoai,
					 t1.fax,
					 t1.email,
					 t1.masothue,
					 t1.type,
					 t1.sudung,
					 t1.ghichu,
					 t1.gioitinh,
					 t1.ngaysinh,
					 t1.idordertype,
					 t1.Marieng,
					 t1.socmnd,
					 t1.billto,
					 t1.shipto,
					 t1.hanmuctindung,
					 t1.hanmuctdconlai,
					 t1.congnokhachhang,
					 t1.hantra
			FROM tbl_dm_doituong t1
		 where t1.marieng is not null
			 and t1.type in (1, 3)", Declare.TableNamespace.DmDoiTuong);
        }

        public List<DMDoiTuongInfo> GetListDoiTuongInfoByType(int type)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectByType, type);
        }

        public List<DMDoiTuongInfo> GetListDmDoiTuongDTacGVan()
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetDTacGVan);
        }

        public List<DMDoiTuongInfo> GetListDoiTuongKLInfo(int idDTCha)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectKL, idDTCha);
        }
        public DMDoiTuongInfo GetListDoiTuongKLInfoByCode(int idDTCha, string code)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectKLByCode, idDTCha, code);
        }

        public List<DMDoiTuongPairInfo> GetListDoiTuongCBOInfo()
        {
            //return GetListAll<DMDoiTuongPairInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectPair, Declare.TableNamespace.DmDoiTuong);
            return GetListAll<DMDoiTuongPairInfo>(@"SELECT t1.iddoituong, t1.madoituong, t1.tendoituong, t1.sudung
	            FROM tbl_dm_doituong t1
             WHERE t1.sudung = 1", Declare.TableNamespace.DmDoiTuong);
        }
        internal void Update(DMDoiTuongInfo dmDoiTuongInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDoiTuongUpdate, ParseToParams(dmDoiTuongInfor));
        }
        public int Insert(DMDoiTuongInfo dmDoiTuongInfor)
        {
            var objStackTrace = new StackTrace(true);

            MethodBase methodExecuting = objStackTrace.GetFrame(1).GetMethod();

            if (methodExecuting.ReflectedType.Module.Name != GetType().Module.Name)
            {
                if(String.IsNullOrEmpty(dmDoiTuongInfor.MaRieng))
                {
                    throw new ManagedException("Đối tượng này phải có mã riêng.");
                }
            }
                
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spDoiTuongInsert, ParseToParams(dmDoiTuongInfor));
        }
        internal void Delete(DMDoiTuongInfo dmDoiTuongInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDoiTuongDelete, dmDoiTuongInfor.IdDoiTuong);
        }
        internal bool Exist(DMDoiTuongInfo dmDoiTuongInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spDoiTuongExist, 
                dmDoiTuongInfor.IdDoiTuong, 
                dmDoiTuongInfor.MaDoiTuong) > 0;
        }
        internal bool ExistLe(DMDoiTuongInfo dmDoiTuongInfo)
        {
           return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spDoiTuongLeExist,
               dmDoiTuongInfo.IdDoiTuong,
               dmDoiTuongInfo.MaRieng) > 0;
        }
        internal List<DMDoiTuongInfo> Search(DMDoiTuongInfo dmDoiTuongInfor)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSearch, dmDoiTuongInfor.MaDoiTuong,
                                    dmDoiTuongInfor.TenDoiTuong);
        }
        internal List<DMDoiTuongInfo> SearchRieng(DMDoiTuongInfo dmDoiTuongInfor)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSearchRieng,dmDoiTuongInfor.MaRieng,dmDoiTuongInfor.SoCMND);
        }
        public DMDoiTuongInfo GetDoiTuongByIdInfo(int idDoiTuong)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetById, idDoiTuong);
        }
        public List<DMDoiTuongPairInfo> GetCboDmDoiTuongByLoaiDT(int loaiDT)
        {
            return GetListCommand<DMDoiTuongPairInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByLoaiDT, loaiDT);
        }
        public List<DMDoiTuongInfo> GetDmDoiTuongByLoaiDT(int loaiDT)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongSelectAllByLoaiDT, loaiDT);
        }
        public DMDoiTuongInfo GetDmDoiTuongByLoaiDT_Code(int loaiDT, string code)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByLoaiDTCode, loaiDT, code);
        }

        public DMDoiTuongInfo GetDoiTuongByCode(string code)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByCode, code);
        }

        public DMDoiTuongInfo GetDoiTuongInfoBySoPO(string soPo)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByCode, soPo);
        }
        public DMDoiTuongInfo GetDoiTuongByText(string doituong)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByText, doituong);
        }
        public DMDoiTuongInfo GetDoiTuongKLByText(string doituong)
        {
            return GetObjectCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetKLByText, doituong);
        }
        public List<DMDoiTuongInfo>GetDoiTuongByMaDoiTuong(string madoituong)
        {
            return GetListCommand<DMDoiTuongInfo>(Declare.StoreProcedureNamespace.spDoiTuongGetByCode, madoituong);
        }
    }
}
