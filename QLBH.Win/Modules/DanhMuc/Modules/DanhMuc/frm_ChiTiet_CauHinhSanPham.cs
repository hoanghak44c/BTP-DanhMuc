using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
//using Microsoft.Office.Interop.Excel;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using Image = System.Drawing.Image;
using Rectangle = System.Drawing.Rectangle;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frm_ChiTiet_CauHinhSanPham : DevExpress.XtraEditors.XtraForm
    {
        frm_DM_CauHinhSanPham frmCauHinh;
        //public bool isAdd;
        private string TenSanPham;
        private int Sott;
        private int IdSanPham;
        private string TenCauHinh,GiaTri;
        List<DMCauHinhSanPhamInfo> lst = new List<DMCauHinhSanPhamInfo>();
        public frm_ChiTiet_CauHinhSanPham(frm_DM_CauHinhSanPham frm)
        {
            InitializeComponent();
            this.frmCauHinh = frm;
        }
        public frm_ChiTiet_CauHinhSanPham(frm_DM_CauHinhSanPham frm,int idSanPham,string tenSanPham,string tenCauHinh,string giaTri)
        {
            InitializeComponent();
            this.frmCauHinh = frm;
            this.IdSanPham = idSanPham;
            this.TenSanPham = tenSanPham;
            this.TenCauHinh = tenCauHinh;
            this.GiaTri = giaTri;
        }
        protected virtual bool HasChanged()
        {
            return false;
        }
        #region bteSanPham
        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_SanPham frmLookUpSanPham = new frmLookUp_SanPham(false, String.Format("%{0}%", bteSanPham.Text));
            if (frmLookUpSanPham.ShowDialog() == DialogResult.OK)
            {
                bteSanPham.EditValue = String.Empty;
                bteSanPham.Tag = frmLookUpSanPham.SelectedItem;
                bteSanPham.Text = frmLookUpSanPham.SelectedItem.TenSanPham;
                DMCauHinhSanPhamInfo obj = DMCauHinhSanPhamDataProvider.Instance.GetNhaCCByIdSanPham(((DMSanPhamInfo)bteSanPham.Tag).IdSanPham);
                txtNhaCC.Text = obj.Hang;
                try
                {
                    string path = String.Format("http://logo.trananh.com.vn/{0}.jpg", txtNhaCC.Text);
                    System.Net.WebRequest req = System.Net.WebRequest.Create(path);
                    System.Net.WebResponse response = req.GetResponse();
                    System.IO.Stream stream = response.GetResponseStream();
                    if (path != null)
                    {
                        //Image im = new Bitmap(path, true);
                        Image im = Image.FromStream(stream);
                        pteLogo.Size = new Size(192, 83);
                        pteLogo.Image = Crop(im, 192, 83, AnchorPosition.Center);
                    }
                }
                catch (Exception)
                {
                    clsUtils.MsgCanhBao("Sản phẩm chưa có Logo!");
                }
            }
        }

        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_SanPham frmLookUpSanPham = new frmLookUp_SanPham(false, String.Format("%{0}%", bteSanPham.Text));
                if (frmLookUpSanPham.ShowDialog() == DialogResult.OK)
                {
                    bteSanPham.Tag = frmLookUpSanPham.SelectedItem;
                    bteSanPham.Text = frmLookUpSanPham.SelectedItem.TenSanPham;
                    DMCauHinhSanPhamInfo obj = DMCauHinhSanPhamDataProvider.Instance.GetNhaCCByIdSanPham(((DMSanPhamInfo)bteSanPham.Tag).IdSanPham);
                    txtNhaCC.Text = obj.Hang;
                    try
                    {
                        string path = String.Format("http://logo.trananh.com.vn/{0}.jpg", txtNhaCC.Text);
                        System.Net.WebRequest req = System.Net.WebRequest.Create(path);
                        System.Net.WebResponse response = req.GetResponse();
                        System.IO.Stream stream = response.GetResponseStream();
                        if (path != null)
                        {
                            //Image im = new Bitmap(path, true);
                            Image im = Image.FromStream(stream);
                            pteLogo.Size = new Size(192, 83);
                            pteLogo.Image = Crop(im, 192, 83, AnchorPosition.Center);
                        }
                    }
                    catch (Exception)
                    {
                        clsUtils.MsgCanhBao("Sản phẩm chưa có Logo!");
                    }
                }
            }
        }

        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteSanPham.Text)) bteSanPham.Tag = null;
        }
        #endregion
        private bool Check()
        {
            if (String.IsNullOrEmpty(bteSanPham.Text))
            {
                bteSanPham.Focus();
                throw new InvalidOperationException("Bạn chưa chọn sản phẩm!");
            }
            //if (String.IsNullOrEmpty(txtLogo.Text))
            //{
            //    txtLogo.Focus();
            //    throw new InvalidOperationException("Bạn chưa chọn ảnh!");
            //}
            return true;
        }
        
        private void Save()
        {
            if (Check())
            {
                try
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if (TenCauHinh == "" && GiaTri == "")
                    {
                        DMSanPhamInfo obj = (DMSanPhamInfo)bteSanPham.Tag;
                        for (int i = 0; i < lst.Count; i++)
                        {
                            DMCauHinhSanPhamInfo infor = lst[i];
                            DMCauHinhSanPhamDataProvider.Instance.Insert(obj.IdSanPham, infor.TenCauHinh, infor.GiaTri, infor.SoTT);
                        }
                        //DMCauHinhSanPhamDataProvider.Instance.UpdateLogo(obj.IdSanPham, txtLogo.Text);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    else
                    {
                        //DMSanPhamInfo obj = (DMSanPhamInfo)bteSanPham.Tag;
                        for (int i = 0; i < lst.Count; i++)
                        {
                            DMCauHinhSanPhamInfo infor = lst[i];
                            DMCauHinhSanPhamDataProvider.Instance.Update(IdSanPham, infor.TenCauHinh, infor.GiaTri, infor.SoTT);
                        }
                        //DMCauHinhSanPhamDataProvider.Instance.UpdateLogo(IdSanPham, txtLogo.Text);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                }
                catch (Exception)
                {
                    ConnectionUtil.Instance.RollbackTransaction();
                    throw;
                }
            }
        }
        #region Event
        private void frm_ChiTiet_CauHinhSanPham_Load(object sender, EventArgs e)
        {
            //if (frmCauHinh.isAdd)
            //{
            //    bteSanPham.Enabled = true;
            //    txtNhaCC.Text = "";
            //    txtLogo.Text = "";
            //    //pteLogo.
            //    //grcChiTietCauHinh.DataSource = lst;
            //    grcChiTietCauHinh.DataSource = new BindingList<DMCauHinhSanPhamInfo>(lst)
            //                                       {
            //                                           AllowEdit = true,
            //                                           AllowNew = true,
            //                                           AllowRemove = true,
            //                                       };
            //}
            //else
            //{
                txtLogo.Enabled = false;
                txtNhaCC.Enabled = false;
                bteSanPham.Tag = DmSanPhamProvider.GetSanPhamById(IdSanPham);
                bteSanPham.Text = TenSanPham;
                //txtLogo.Text = Logo;
                DMCauHinhSanPhamInfo nhaCC = DMCauHinhSanPhamDataProvider.Instance.GetNhaCCByIdSanPham(IdSanPham);
                txtNhaCC.Text = nhaCC.Hang;
                try
                {
                    string path = String.Format("http://logo.trananh.com.vn/{0}.jpg", txtNhaCC.Text);
                    System.Net.WebRequest req = System.Net.WebRequest.Create(path);
                    System.Net.WebResponse response = req.GetResponse();
                    System.IO.Stream stream = response.GetResponseStream();
                    if (path != null)
                    {
                        //Image im = new Bitmap(path, true);
                        Image im = Image.FromStream(stream);
                        pteLogo.Image = im;
                        //Crop(im, 192, 83, AnchorPosition.Center);
                    }
                }
                catch (Exception)
                {
                    clsUtils.MsgCanhBao("Sản phẩm chưa có Logo!");
                }
                
                lst = DMCauHinhSanPhamDataProvider.Instance.GetCauHinhByIdSanPham(IdSanPham);
                grcChiTietCauHinh.DataSource = new BindingList<DMCauHinhSanPhamInfo>(lst)
                {
                    AllowEdit = true,
                    AllowNew = true,
                    AllowRemove = true,
                };
                //grcChiTietCauHinh.DataSource = null;
                //grcChiTietCauHinh.DataSource = lst;
            //}
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this.pteLogo.Location = new System.Drawing.Point(90, 98);
            this.pteLogo.Name = "pictureBox1";
            this.pteLogo.Size = new System.Drawing.Size(200, 95);
            this.pteLogo.TabIndex = 1;
            this.pteLogo.TabStop = false;

            OpenFileDialog logo = new OpenFileDialog();
            logo.Filter = "Images (*.jpg)|*.jpg";
            if (logo.ShowDialog() == DialogResult.OK)
                txtLogo.Text = logo.FileName;
           

            //---------upload anh logo len server 17/06/2013

            Upload(txtLogo.Text, "192.168.8.15", "pos", "pos@TA1174&&?");

            string path = String.Format("http://logo.trananh.com.vn/{0}.jpg", txtNhaCC.Text);
            System.Net.WebRequest req = System.Net.WebRequest.Create(path);
            System.Net.WebResponse response = req.GetResponse();
            System.IO.Stream stream = response.GetResponseStream();
            if (path != null)
            {
                //Image im = new Bitmap(path, true);
                Image im = Image.FromStream(stream);
                pteLogo.Image = im;
                //Crop(im, 192, 83, AnchorPosition.Center);
            }


        }
        public void Upload(string filename, string host, string username, string password)
        {
            FileInfo fileInf = new FileInfo(filename);
            long size= fileInf.Length;
            //string uri = "ftp://" + host + "/" + fileInf.Name;
            FtpWebRequest reqFTP = default(FtpWebRequest);

            // Create FtpWebRequest object from the Uri provided
            string tenfile = fileInf.Name;
            string[] tenfiles = tenfile.Split('.');

            tenfile = tenfiles[0];
            if (tenfile != "") tenfile = ConvertStringToUnSign(txtNhaCC.Text.Trim());
            tenfile = tenfile + "." + tenfiles[1];
            string uri = "ftp://" + host + "/" + tenfile + "";
            UriBuilder newUriPort = new UriBuilder(uri);
            newUriPort.Port = 2121;
            uri = newUriPort.Uri.ToString();
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential(username, password);

            // By default KeepAlive is true, where the control connection is not closed
            // after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;
          
            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen = 0;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload image Error");
            }
        }


        public static string ConvertStringToUnSign(string s)
        {
            if (s.Length <= 0) s = "";
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
       
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            try
            {
                Save();
                if (frmCauHinh.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                //frmCauHinh.ReLoad();
                frmCauHinh.SetControl(false);
                this.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (HasChanged())
            {
                if (MessageBox.Show("Dữ liệu chưa được lưu có thể sẽ bị mất. Bạn có chắc chắn muốn thoát ?", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                }
                return;
            }
            DialogResult = DialogResult.Cancel;
        }
        #endregion

        public enum AnchorPosition
        {
            Top, Center, Bottom, Left, Right
        }
        public Image Crop(Image imgPhoto, int Width, int Height, AnchorPosition Anchor)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentW;
                switch (Anchor)
                {
                    case AnchorPosition.Top:
                        destY = 0;
                        break;
                    case AnchorPosition.Bottom:
                        destY = (int)(Height - (sourceHeight * nPercent));
                        break;
                    default:
                        destY = (int)((Height - (sourceHeight * nPercent)) / 3);
                        break;
                }
            }
            else
            {
                nPercent = nPercentH;
                switch (Anchor)
                {
                    case AnchorPosition.Left:
                        destX = 0;
                        break;
                    case AnchorPosition.Right:
                        destX = (int)(Width - (sourceWidth * nPercent));
                        break;
                    default:
                        destX = (int)((Width - (sourceWidth * nPercent)) / 2);
                        break;
                }
            }
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format32bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.SmoothingMode = SmoothingMode.HighQuality;
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBilinear;
            grPhoto.CompositingQuality = CompositingQuality.HighQuality;
            grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //grPhoto.SmoothingMode = SmoothingMode.HighSpeed;

            //grPhoto.InterpolationMode = InterpolationMode.Low;

            //grPhoto.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);
            grPhoto.DrawRectangle(new Pen(Color.White, 4), new Rectangle(destX, destY, destWidth, destHeight));
            grPhoto.Dispose();
            //OnSharpen

            //if (Width < 168)
            //{

            //    BitmapFilter.Sharpen(bmPhoto, 14);

            //}
            return bmPhoto;
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                frmLookUp_SanPham frmLookUpSanPham = new frmLookUp_SanPham("%%");
                if (frmLookUpSanPham.ShowDialog() == DialogResult.OK)
                {
                    DMSanPhamInfo dmSanPhamInfo = frmLookUpSanPham.SelectedItem;
                    if (DMCauHinhSanPhamDataProvider.Instance.DaCoCauHinh(dmSanPhamInfo.IdSanPham))
                    {
                        if (MessageBox.Show("Sản phẩm này đã có cấu hình, bạn chắc chắn có muốn ghi đè không?", "Xác nhận", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    }
                    else if (MessageBox.Show("Bạn chắc chắn sẽ sao chép cấu hình cho sản phẩm " + dmSanPhamInfo.MaSanPham + " không?", "Xác nhận", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) return;

                    try
                    {
                        ConnectionUtil.Instance.BeginTransaction();

                        DMCauHinhSanPhamDataProvider.Instance.Delete(dmSanPhamInfo.IdSanPham);

                        for (int i = 0; i < lst.Count; i++)
                        {
                            DMCauHinhSanPhamInfo infor = lst[i];
                            DMCauHinhSanPhamDataProvider.Instance.Insert(dmSanPhamInfo.IdSanPham, infor.TenCauHinh, infor.GiaTri, infor.SoTT);
                        }

                        ConnectionUtil.Instance.CommitTransaction();

                    }
                    catch (Exception)
                    {
                        ConnectionUtil.Instance.RollbackTransaction();
                        throw;
                    }

                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }
    }
}