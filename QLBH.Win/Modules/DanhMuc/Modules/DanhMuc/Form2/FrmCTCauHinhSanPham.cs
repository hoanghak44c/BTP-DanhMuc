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
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;

namespace QLBanHang.Modules.DanhMuc.Form2
{
    public partial class FrmCTCauHinhSanPham : CTCauHinhSanPhamView, ICTCauHinhSanPhamView
    {
        public FrmCTCauHinhSanPham()
        {

        }
        public FrmCTCauHinhSanPham(object ItemRowHanle)
            : base(ItemRowHanle)
        {

        }
        private void btnESanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Controller.ChonSP();
        }

        private void btnESanPham_TextChanged(object sender, EventArgs e)
        {
            Controller.SearchByIdSP();
        }

        public void Initialize()
        {
            InitializeComponent();
        }

        public int IdSanPham
        {
            get { return Convert.ToInt32(btnESanPham.Text); }
            set { btnESanPham.Text = Convert.ToInt32(value).ToString(); }
        }

        public string TenCauHinh { get; set; }

        public string GiaTri { get; set; }

        public int SoTT { get; set; }

        public object DataSource
        {
            get { return grdChiTietCauHinhSanPham.DataSource; }
            set { grdChiTietCauHinhSanPham.DataSource = value; }
        }

        public string Hang
        {
            get { return txtHang.Text; }
            set { txtHang.Text = value; }
        }

        public string logo
        {
            get { return txtLogo.Text; }
            set { txtLogo.Text = value; }
        }

        public int TrangThai { get; set; }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Controller.Save();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Controller.Exit();
        }
        public void Upload(string filename, string host, string username, string password)
        {
            FileInfo fileInf = new FileInfo(filename);
            long size = fileInf.Length;
            //string uri = "ftp://" + host + "/" + fileInf.Name;
            FtpWebRequest reqFTP = default(FtpWebRequest);

            // Create FtpWebRequest object from the Uri provided
            string tenfile = fileInf.Name;
            string[] tenfiles = tenfile.Split('.');

            tenfile = tenfiles[0];
            if (tenfile != "") tenfile = ConvertStringToUnSign(txtHang.Text.Trim());
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

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            this.pictureELogo.Location = new System.Drawing.Point(90, 98);
            this.pictureELogo.Name = "pictureBox1";
            this.pictureELogo.Size = new System.Drawing.Size(200, 95);
            this.pictureELogo.TabIndex = 1;
            this.pictureELogo.TabStop = false;

            OpenFileDialog logo = new OpenFileDialog();
            logo.Filter = "Images (*.jpg)|*.jpg";
            if (logo.ShowDialog() == DialogResult.OK)
                txtLogo.Text = logo.FileName;


            //---------upload anh logo len server 17/06/2013

            Upload(txtLogo.Text, "192.168.8.15", "pos", "pos@TA1174&&?");

            string path = String.Format("http://logo.trananh.com.vn/{0}.jpg", txtHang.Text);
            System.Net.WebRequest req = System.Net.WebRequest.Create(path);
            System.Net.WebResponse response = req.GetResponse();
            System.IO.Stream stream = response.GetResponseStream();
            if (path != null)
            {
                //Image im = new Bitmap(path, true);
                Image im = Image.FromStream(stream);
                pictureELogo.Image = im;
                //Crop(im, 192, 83, AnchorPosition.Center);
            }
        }
        public Image Crop(Image imgPhoto, int Width, int Height, frm_ChiTiet_CauHinhSanPham.AnchorPosition Anchor)
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
                    case frm_ChiTiet_CauHinhSanPham.AnchorPosition.Top:
                        destY = 0;
                        break;
                    case frm_ChiTiet_CauHinhSanPham.AnchorPosition.Bottom:
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
                    case frm_ChiTiet_CauHinhSanPham.AnchorPosition.Left:
                        destX = 0;
                        break;
                    case frm_ChiTiet_CauHinhSanPham.AnchorPosition.Right:
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
            Controller.SaoChep();
        }
    }
}