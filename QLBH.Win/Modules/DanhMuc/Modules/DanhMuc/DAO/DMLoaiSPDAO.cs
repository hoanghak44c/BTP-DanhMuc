using System;
using System.Collections.Generic;
using System.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DMLoaiSPDAO : SynchronizableDAO
    {
        private static DMLoaiSPDAO instance;
        
        private DMLoaiSPDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiSanPham;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DMLoaiSPDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiSPDAO();
                return instance;
            }
        }
        
        internal override void Synchronize(bool isComplete)
        {
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục chủng hàng";
            DmSegmentChungSynchronize.Instance.Synchronize(false);//tach
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục hãng sản xuất";
            DmSegmentHangSynchronize.Instance.Synchronize(false);
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục lĩnh vực";
            DmSegmentLinhVucSynchronize.Instance.Synchronize(false);
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục loại hàng hóa";
            DmSegmentLoaiSynchronize.Instance.Synchronize(false);
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục model sản phẩm";
            DmSegmentModelSynchronize.Instance.Synchronize(false);//tach
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục ngành hàng";
            DmSegmentNganhSynchronize.Instance.Synchronize(false);
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục nhóm hàng";
            DmSegmentNhomSynchronize.Instance.Synchronize(false);//tach
            frmProgress.Instance.Description = "Đồng bộ dữ liệu danh mục loại sản phẩm";
            DmLoaiSanPhamSynchronize.Instance.Synchronize(isComplete);
        }

        public List<DMLoaiSanPhamInfo> GetListLoaiSPInfo()
        {
            //return GetListAll<DMLoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spLoaiSanPhamSelectAll, Declare.TableNamespace.DmLoaiSanPham);
            return GetListAll<DMLoaiSanPhamInfo>(@"SELECT t1.idloaisp,
					 t1.maloaisp,
					 t1.tenloaisp,
					 t1.ghichu,
					 t1.sudung,
					 t1.nhomcha,
					 t1.linhvuc,
					 t1.nganh,
					 t1.loai,
					 t1.chung,
					 t1.nhom,
					 t1.hang,
					 t1.model,
					 t1.last_update_date
			FROM tbl_dm_loaisanpham t1", Declare.TableNamespace.DmLoaiSanPham);
        }

        public List<DMLoaiSPPairInfo> GetListLoaiSPPairInfo()
        {
            //return GetListAll<DMLoaiSPPairInfo>(Declare.StoreProcedureNamespace.spLoaiSanPhamSelectPair, Declare.TableNamespace.DmLoaiSanPham);
            return GetListAll<DMLoaiSPPairInfo>(@"SELECT t1.idloaisp, t1.maloaisp, t1.tenloaisp, t1.sudung
			        FROM tbl_dm_loaisanpham t1
		         WHERE t1.sudung = 1", Declare.TableNamespace.DmLoaiSanPham);
        }

        internal void Update(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamUpdate,
                ParseToParams<DMLoaiSanPhamInfo>(dmChucNangInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamUpdate);
            //SetParams(dmChucNangInfor);
            //ExecuteNoneQuery();
        }

        internal int Insert(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiSanPhamInsert,
                ParseToParams<DMLoaiSanPhamInfo>(dmChucNangInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamInsert);
            //SetParams(dmChucNangInfor);
            //Parameters["@IdChucNang"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdChucNang"].Value.ToString());
        }

        internal void Delete(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamDelete,
                dmChucNangInfor.IdLoaiSP);

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamDelete);
            //Parameters.AddWithValue("@IdChucNang", dmChucNangInfor.IdLoaiSP);
            //ExecuteNoneQuery();
        }

        internal bool Exist(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiSanPhamExist,
                dmChucNangInfor.IdLoaiSP,
                dmChucNangInfor.MaLoaiSP) > 0;

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdChucNang", dmChucNangInfor.IdLoaiSP);
            //Parameters.AddWithValue("@TenChucNang", dmChucNangInfor.MaLoaiSP);
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMLoaiSanPhamInfo> Search(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            return GetListCommand<DMLoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spLoaiSanPhamSearch,
                dmChucNangInfor.TenLoaiSP,
                dmChucNangInfor.MaLoaiSP);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamSearch);
            //Parameters.AddWithValue("@MaChucNang", dmChucNangInfor.TenLoaiSP);
            //Parameters.AddWithValue("@TenChucNang", dmChucNangInfor.MaLoaiSP);
            //return FillToList<DMLoaiSanPhamInfo>();
        }

        public DMLoaiSanPhamInfo GetLoaiSPByIdInfo(int idChucNang)
        {
            return GetObjectCommand<DMLoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spLoaiSanPhamGetById,
                idChucNang);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiSanPhamGetById);
            //Parameters.AddWithValue("@IdChucNang", idChucNang);
            //return FillToObject<DMLoaiSanPhamInfo>();
        }
        public DMLoaiSanPhamInfo GetLoaiSanPhamByText(string loaisp)
        {
            return GetObjectCommand<DMLoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spLoaiSanPhamGetByText, loaisp);
        }
    }
}
