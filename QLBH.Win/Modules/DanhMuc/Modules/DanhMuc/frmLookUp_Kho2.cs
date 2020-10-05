using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_Kho2 :frmLookUpBaseKho2
    {
        private GridColumn colMaKho;
        private GridColumn colTenKho;

        public frmLookUp_Kho2(int idNhanVien)
            : base(idNhanVien)
        {
            InitializeComponent();
        }

        public frmLookUp_Kho2(int idNhanVien, bool isMultiSelect)
            : base(idNhanVien, isMultiSelect)
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.colMaKho = new GridColumn();
            this.colTenKho = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new GridColumn[] {
            this.colMaKho,
            this.colTenKho});
            // 
            // colMaKho
            // 
            this.colMaKho.FieldName = "MaKho";
            this.colMaKho.Caption = "Mã Kho";
            this.colMaKho.Name = "colMaKho";
            this.colMaKho.OptionsColumn.AllowEdit = false;
            this.colMaKho.OptionsColumn.ReadOnly = true;
            this.colMaKho.Visible = true;
            //this.colMaKho.Width = 120;
            // 
            // colTenKho
            // 
            //this.colTenKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Caption = "Tên Kho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.OptionsColumn.AllowEdit = false;
            this.colTenKho.OptionsColumn.ReadOnly = true;
            this.colTenKho.Visible = true;
            // 
            // frmLookUp_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_Kho";
            this.Text = "Tìm kiếm nhanh kho";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
