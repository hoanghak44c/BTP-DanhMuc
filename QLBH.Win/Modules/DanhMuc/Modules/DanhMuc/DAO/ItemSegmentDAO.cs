using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class ItemSegmentDAO : BaseDAO
    {
        private static ItemSegmentDAO instance;
        private ItemSegmentDAO()
        {
            //CRUDTableName = Declare.TableNamespace.BangGia;
            //UseCaching = true;
        }
        public static ItemSegmentDAO Instance
        {
            get
            {
                if (instance == null) instance = new ItemSegmentDAO();
                return instance;
            }
        }

        #region tim kiem item
        //0-linhvuc,1-nganh,2-loai,3-chung,4-nhom,5-model,6-sanpham,7-hang
        public List<ItemSegmentInfo> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return GetListCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaNSD, idNhomNguoiDung, type, chietKhau, suDung);
        }
        public ItemSegmentInfo GetAllItemsByTypeandText(int idNhomNguoiDung, int type, int chietKhau, int suDung, string text)
        {
            return GetObjectCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetAllByMaNSDText, idNhomNguoiDung, type, chietKhau, suDung, text);
        }
        public ItemSegmentInfo GetItemByTypeandCode(int idNhomNguoiDung, int type, string maHang)
        {
            return GetObjectCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetItemByTypeAndCode, idNhomNguoiDung, type, maHang);
        }
        public ItemSegmentInfo GetItemChietKhauByCode(int idNhomNguoiDung, string maHang, int suDung)
        {
            return GetObjectCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetItemCKhauByCode, idNhomNguoiDung, maHang, suDung);
        }
        public ItemSegmentInfo GetHangSanXuat(string ma, string ten)
        {
            return GetObjectCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetGetHangSanXuat, ma, ten);
        }
        public ItemSegmentInfo GetHangInfo(string ma, string ten)
        {
            return GetObjectCommand<ItemSegmentInfo>(Declare.StoreProcedureNamespace.spMatHangGetGetHangInfo, ma, ten);
        }

        #endregion
    }
}
