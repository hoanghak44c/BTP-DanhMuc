using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Data;
using QLBH.Core.Form;
using System.Collections;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmLookUp_SanPham : frmLookUpBaseSanPham
    {
        private GridColumn ColMaSanPham;
        private GridColumn ColTenSanPham;
        private int idKho, idTrungTam;
        private bool exists, isTonAo;

        public frmLookUp_SanPham()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        public frmLookUp_SanPham(int idKho, int idTrungTam, bool exists, bool isTonAo)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }


        public frmLookUp_SanPham(string searchInput) : base(searchInput)
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        /// <param name="searchInput"></param>
        public frmLookUp_SanPham(int idKho, int idTrungTam, bool exists, bool isTonAo, string searchInput)
            : base(searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPham(bool isMultiSelect) : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPham(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect)
            : base(isMultiSelect)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPham(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPham(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        protected override void OnLoad()
        {
            if(idKho == 0 && idTrungTam == 0 && !exists)
                base.OnLoad();
            else
            {
                ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo(idKho, idTrungTam, exists, isTonAo);
            }
        }

        private void InitializeComponent()
        {
            this.ColMaSanPham = new GridColumn();
            this.ColTenSanPham = new GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLookUp
            // 
            this.grvLookUp.Columns.AddRange(new [] {
            this.ColMaSanPham,
            this.ColTenSanPham});
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.FieldName = "MaSanPham";
            this.ColMaSanPham.Caption = "Mã Sản Phẩm";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.OptionsColumn.AllowEdit = false;
            this.ColMaSanPham.OptionsColumn.ReadOnly = true;
            this.ColMaSanPham.Visible = true;
            //this.ColMaSanPham.Width = 120;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.FieldName = "TenSanPham";
            this.ColTenSanPham.Caption = "Tên Sản Phẩm";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.OptionsColumn.AllowEdit = false;
            this.ColTenSanPham.OptionsColumn.ReadOnly = true;
            this.ColTenSanPham.Visible = true;
            // 
            // frmLookUp_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_SanPham";
            this.Text = "Tìm kiếm nhanh sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.grvLookUp)).EndInit();
            this.ResumeLayout(false);

        }
    }

    public class frmLookUp_SanPhamUsing : frmLookUp_SanPham
    {
        public frmLookUp_SanPhamUsing(string searchInput) : base(searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmSanPhamProvider.Instance.GetListDmSanPhamInfoUsing();
        }
    }

    public class frmLookUpBaseSanPham1 : frmLookUp_Base1<DMSanPhamInfo>
    {

        public frmLookUpBaseSanPham1() { }

        public frmLookUpBaseSanPham1(IDataPageRetriever<DMSanPhamInfo> virtualModeProvider) : base(virtualModeProvider) { }

        public frmLookUpBaseSanPham1(string searchInput) : base(searchInput) { }

        public frmLookUpBaseSanPham1(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseSanPham1(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo();
        }

        protected override string[] LookUpPropertyNames()
        {
            return new[] { "TenLoaiSP" };
        }
    }

    public class frmLookUp_SanPhamTestVirtualMode : frmLookUpBaseSanPham1
    {
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSanPham;
        private int idKho, idTrungTam;
        private bool exists, isTonAo;

        #region Contructor

        public frmLookUp_SanPhamTestVirtualMode()
        {
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(IDataPageRetriever<DMSanPhamInfo> virtualModeProvider)
            : base(virtualModeProvider)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        public frmLookUp_SanPhamTestVirtualMode(int idKho, int idTrungTam, bool exists, bool isTonAo)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(string searchInput)
            : base(searchInput)
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho">Id Kho</param>
        /// <param name="idTrungTam">Id Trung Tam</param>
        /// <param name="exists">Chỉ tìm các sản phẩm còn tồn</param>
        /// <param name="isTonAo">Tìm theo tồn ảo</param>
        /// <param name="searchInput"></param>
        public frmLookUp_SanPhamTestVirtualMode(int idKho, int idTrungTam, bool exists, bool isTonAo, string searchInput)
            : base(searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(bool isMultiSelect)
            : base(isMultiSelect)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect)
            : base(isMultiSelect)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            InitializeComponent();
        }

        public frmLookUp_SanPhamTestVirtualMode(int idKho, int idTrungTam, bool exists, bool isTonAo, bool isMultiSelect, string searchInput)
            : base(isMultiSelect, searchInput)
        {
            this.idKho = idKho;
            this.idTrungTam = idTrungTam;
            this.exists = exists;
            this.isTonAo = isTonAo;
            InitializeComponent();
        }
        
        #endregion
        
        protected override void OnLoad()
        {
            if (idKho == 0 && idTrungTam == 0 && !exists)
                base.OnLoad();
            else
            {
                ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo(idKho, idTrungTam, exists, isTonAo);
            }
        }

        protected override string[] LookUpPropertyNames()
        {
            return new[] { "TenLoaiSP" };
        }

        private void InitializeComponent()
        {
            this.ColMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLookUp
            // 
            this.dgvLookUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaSanPham,
            this.ColTenSanPham});
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.DataPropertyName = "MaSanPham";
            this.ColMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.ReadOnly = true;
            this.ColMaSanPham.Width = 120;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenSanPham.DataPropertyName = "TenSanPham";
            this.ColTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.ReadOnly = true;
            // 
            // frmLookUp_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Name = "frmLookUp_SanPham";
            this.Text = "Tìm kiếm nhanh sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUp)).EndInit();
            this.ResumeLayout(false);

        }

    }

    public interface IDataPageRetriever<T>
    {
        List<T> SupplyPageOfData(string conditionLookUp, int lowerPageBoundary, int rowsPerPage);
    }

    public interface IDataPageRetriever
    {
        DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage);
    }
    
    public class DataRetriever : IDataPageRetriever
    {
        private string tableName;
        private SqlCommand command;

        private int rowCountValue = -1;

        public int RowCount
        {
            get
            {
                // Return the existing value if it has already been determined. 
                if (rowCountValue != -1)
                {
                    return rowCountValue;
                }

                // Retrieve the row count from the database.
                rowCountValue = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionUtil.Instance.GetConnection(), CommandType.Text,
                                        "SELECT COUNT(*) FROM tbl_sanpham"));
                return rowCountValue;
            }
        }

        private DataColumnCollection columnsValue;

        //public DataColumnCollection Columns
        //{
        //    get
        //    {
        //        // Return the existing value if it has already been determined. 
        //        if (columnsValue != null)
        //        {
        //            return columnsValue;
        //        }

        //        // Retrieve the column information from the database.
        //        command.CommandText = "SELECT * FROM " + tableName;
        //        GtidDataAdapter adapter = new GtidDataAdapter();
        //        adapter.SelectCommand = command;
        //        DataTable table = new DataTable();
        //        table.Locale = System.Globalization.CultureInfo.InvariantCulture;
        //        adapter.FillSchema(table, SchemaType.Source);
        //        columnsValue = table.Columns;
        //        return columnsValue;
        //    }
        //}

        private string commaSeparatedListOfColumnNamesValue = null;

        //private string CommaSeparatedListOfColumnNames
        //{
        //    get
        //    {
        //        // Return the existing value if it has already been determined. 
        //        if (commaSeparatedListOfColumnNamesValue != null)
        //        {
        //            return commaSeparatedListOfColumnNamesValue;
        //        }

        //        // Store a list of column names for use in the 
        //        // SupplyPageOfData method.
        //        System.Text.StringBuilder commaSeparatedColumnNames =
        //            new System.Text.StringBuilder();
        //        bool firstColumn = true;
        //        foreach (DataColumn column in Columns)
        //        {
        //            if (!firstColumn)
        //            {
        //                commaSeparatedColumnNames.Append(", ");
        //            }
        //            commaSeparatedColumnNames.Append(column.ColumnName);
        //            firstColumn = false;
        //        }

        //        commaSeparatedListOfColumnNamesValue =
        //            commaSeparatedColumnNames.ToString();
        //        return commaSeparatedListOfColumnNamesValue;
        //    }
        //}

        // Declare variables to be reused by the SupplyPageOfData method. 

        private string columnToSortBy;
        private GtidDataAdapter adapter = new GtidDataAdapter();

        public DataTable SupplyPageOfData(int lowerPageBoundary, int rowsPerPage)
        {
            //// Store the name of the ID column. This column must contain unique  
            //// values so the SQL below will work properly. 
            //if (columnToSortBy == null)
            //{
            //    columnToSortBy = this.Columns[0].ColumnName;
            //}

            //if (!this.Columns[columnToSortBy].Unique)
            //{
            //    throw new InvalidOperationException(String.Format(
            //        "Column {0} must contain unique values.", columnToSortBy));
            //}

            //// Retrieve the specified number of rows from the database, starting 
            //// with the row specified by the lowerPageBoundary parameter.
            //command.CommandText = "Select Top " + rowsPerPage + " " +
            //    CommaSeparatedListOfColumnNames + " From " + tableName +
            //    " WHERE " + columnToSortBy + " NOT IN (SELECT TOP " +
            //    lowerPageBoundary + " " + columnToSortBy + " From " +
            //    tableName + " Order By " + columnToSortBy +
            //    ") Order By " + columnToSortBy;
            //adapter.SelectCommand = command;

            adapter.SelectCommand = new GtidCommand(String.Format(@"select * from (select a.masanpham, a.tensanpham, rownum my_limiter from tbl_sanpham a ) 
                where my_limiter > {0}*{1} and my_limiter <= ({0}+1)*{1}", lowerPageBoundary / rowsPerPage, rowsPerPage), ConnectionUtil.Instance.GetConnection());
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }

    }

    public class Cache<T>
    {
        private static int RowsPerPage;

        // Represents one page of data.   
        public struct DataPage
        {
            public List<T> table;
            private int lowestIndexValue;
            private int highestIndexValue;

            public DataPage(List<T> table, int rowIndex)
            {
                this.table = table;
                lowestIndexValue = MapToLowerBoundary(rowIndex);
                highestIndexValue = MapToUpperBoundary(rowIndex);
                System.Diagnostics.Debug.Assert(lowestIndexValue >= 0);
                System.Diagnostics.Debug.Assert(highestIndexValue >= 0);
            }

            public int LowestIndex
            {
                get
                {
                    return lowestIndexValue;
                }
            }

            public int HighestIndex
            {
                get
                {
                    return highestIndexValue;
                }
            }

            public static int MapToLowerBoundary(int rowIndex)
            {
                // Return the lowest index of a page containing the given index. 
                //return (rowIndex / RowsPerPage) * RowsPerPage;
                return (rowIndex/RowsPerPage);
            }

            private static int MapToUpperBoundary(int rowIndex)
            {
                // Return the highest index of a page containing the given index. 
                //return MapToLowerBoundary(rowIndex) + RowsPerPage - 1;
                return MapToLowerBoundary(rowIndex) * RowsPerPage + RowsPerPage - 1;
            }
        }

        private DataPage[] cachePages;
        private IDataPageRetriever<T> dataSupply;

        public Cache(IDataPageRetriever<T> dataSupplier, int rowsPerPage)
        {
            dataSupply = dataSupplier;
            RowsPerPage = rowsPerPage;
            LoadFirstTwoPages();
        }

        private string query;

        public string Query
        {
            get { return query; }
            set { query = value; }
        }

        public int RowCount
        {
            get { 
                int result = 0, count = 0;
                foreach (var cachePage in cachePages)
                {
                    if (cachePage.table.Count == 0) break;
                    count = Convert.ToInt32(((IPagingInfo)cachePage.table[cachePage.table.Count - 1]).RecordNumber);
                    if(count > result) result = count;
                }
                return result;
            }
        }

        // Sets the value of the element parameter if the value is in the cache. 
        private bool IfPageCached_ThenSetElement(int rowIndex,
            int columnIndex, ref object element)
        {
            if (IsRowCachedInPage(0, rowIndex))
            {
                if (cachePages[0].table.Count == 0 || rowIndex >= cachePages[0].table.Count) 
                
                    element = null;
                
                //else if (cachePages[0].table.Count > 0 && rowIndex == cachePages[0].table.Count)
                    
                //    element = cachePages[0].table[rowIndex - 1];                    
                
                else

                element = cachePages[0].table[rowIndex % RowsPerPage];

                return true;
            }
            else if (IsRowCachedInPage(1, rowIndex))
            {
                if (cachePages[1].table.Count == 0 || rowIndex >= cachePages[0].table.Count)
                
                    element = null;
                
                //else if (rowIndex == cachePages[1].table.Count)
                    
                //    element = cachePages[0].table[rowIndex - 1];
                
                else
                
                    element = cachePages[1].table[rowIndex % RowsPerPage];

                return true;
            }

            return false;
        }

        public object RetrieveElement(int rowIndex, int columnIndex)
        {
            object element = null;

            if (IfPageCached_ThenSetElement(rowIndex, columnIndex, ref element))
            {
                return element;
            }
            else
            {
                return RetrieveData_CacheIt_ThenReturnElement(
                    rowIndex, columnIndex);
            }
        }

        private void LoadFirstTwoPages()
        {
            cachePages = new DataPage[]{
            new DataPage(dataSupply.SupplyPageOfData(query, 0, RowsPerPage), 0), 
            new DataPage(dataSupply.SupplyPageOfData(query, 1, RowsPerPage), RowsPerPage)};
        }

        private string oldQuery;
        private object RetrieveData_CacheIt_ThenReturnElement(
            int rowIndex, int columnIndex)
        {
            // Retrieve a page worth of data containing the requested value.
            List<T> table = dataSupply.SupplyPageOfData(query, 
                DataPage.MapToLowerBoundary(rowIndex), RowsPerPage);

            if (table.Count == 0) return null;
            // Replace the cached page furthest from the requested cell 
            // with a new page containing the newly retrieved data.
            cachePages[GetIndexToUnusedPage(rowIndex)] = new DataPage(table, rowIndex);
            oldQuery = query;

            return RetrieveElement(rowIndex, columnIndex);
        }

        // Returns the index of the cached page most distant from the given index 
        // and therefore least likely to be reused. 
        private int GetIndexToUnusedPage(int rowIndex)
        {
            if (rowIndex > cachePages[0].HighestIndex &&
                rowIndex > cachePages[1].HighestIndex)
            {
                int offsetFromPage0 = rowIndex - cachePages[0].HighestIndex;
                int offsetFromPage1 = rowIndex - cachePages[1].HighestIndex;
                if (offsetFromPage0 < offsetFromPage1)
                {
                    return 1;
                }
                return 0;
            }
            else
            {
                int offsetFromPage0 = cachePages[0].LowestIndex - rowIndex;
                int offsetFromPage1 = cachePages[1].LowestIndex - rowIndex;
                if (offsetFromPage0 < offsetFromPage1)
                {
                    return 1;
                }
                return 0;
            }

        }

        // Returns a value indicating whether the given row index is contained 
        // in the given DataPage.  
        private bool IsRowCachedInPage(int pageNumber, int rowIndex)
        {
            return rowIndex <= cachePages[pageNumber].HighestIndex &&
                rowIndex >= cachePages[pageNumber].LowestIndex && query == oldQuery;
        }

    }

    public partial class frmLookUp_Base1<T> : DevExpress.XtraEditors.XtraForm
    {
        private DataGridViewCheckBoxColumn colCheckSeleted;

        private bool isMultiSelect;

        protected List<T> ListInitInfo;

        protected List<T> listResult;

        private int oldIndex, oldIndexSearch;

        private string sNewSearch, sOldSearch;

        private SortedList<int, string> lstNewTerms, lstOldTerms;

        private string[] lookupTerms;

        private T selectedItem;

        private List<T> selectedItems;

        private Hashtable cacheProperties;

        public frmLookUp_Base1()
        {
            InitializeComponent();
            dgvLookUp.AutoGenerateColumns = false;
            sOldSearch = sNewSearch = String.Empty;
            selectedItems = new List<T>();
        }

        private Cache<T> memoryCache;

        public frmLookUp_Base1(IDataPageRetriever<T> virtualModeProvider)
        {
            InitializeComponent();
            dgvLookUp.AutoGenerateColumns = false;
            sOldSearch = sNewSearch = String.Empty;
            selectedItems = new List<T>();
            dgvLookUp.VirtualMode = true;
            memoryCache = new Cache<T>(virtualModeProvider, 20);
            this.dgvLookUp.RowCount = memoryCache.RowCount % 20 == 0 ? memoryCache.RowCount + 1 : memoryCache.RowCount;
            dgvLookUp.CellValueNeeded += new DataGridViewCellValueEventHandler(dgvLookUp_CellValueNeeded);

            cacheProperties = new Hashtable();
            foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
            {
                if (!cacheProperties.ContainsKey(propertyInfo.Name)) cacheProperties.Add(propertyInfo.Name, propertyInfo);
            }
        }

        void dgvLookUp_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            string dataPropertyName = dgvLookUp.Columns[e.ColumnIndex].DataPropertyName;

            if (String.IsNullOrEmpty(dataPropertyName)) return;

            if (!String.IsNullOrEmpty(memoryCache.Query)) Debug.Print(memoryCache.Query + e.RowIndex);

            object element = memoryCache.RetrieveElement(e.RowIndex, e.ColumnIndex);
            
            if(element != null)
                e.Value = (cacheProperties[dataPropertyName] as PropertyInfo).GetValue(element, null);

            if (memoryCache.RowCount > this.dgvLookUp.RowCount)
                this.dgvLookUp.RowCount = memoryCache.RowCount % 20 == 0 ? memoryCache.RowCount + 1 : memoryCache.RowCount;
        }

        public frmLookUp_Base1(string searchInput)
        {
            InitializeComponent();
            dgvLookUp.AutoGenerateColumns = false;
            sOldSearch = sNewSearch = searchInput;
            selectedItems = new List<T>();
        }

        public frmLookUp_Base1(bool isMultiSelect)
        {
            InitializeComponent();
            dgvLookUp.AutoGenerateColumns = false;
            sOldSearch = sNewSearch = String.Empty;
            selectedItems = new List<T>();
            this.isMultiSelect = isMultiSelect;
            if (isMultiSelect)
            {
                colCheckSeleted = new DataGridViewCheckBoxColumn();
                colCheckSeleted.Width = 40;
                dgvLookUp.Columns.Add(colCheckSeleted);
            }
        }

        public frmLookUp_Base1(bool isMultiSelect, string searchInput)
        {
            InitializeComponent();
            dgvLookUp.AutoGenerateColumns = false;
            sOldSearch = sNewSearch = searchInput;
            selectedItems = new List<T>();
            this.isMultiSelect = isMultiSelect;
            if (isMultiSelect)
            {
                colCheckSeleted = new DataGridViewCheckBoxColumn();
                colCheckSeleted.Width = 40;
                dgvLookUp.Columns.Add(colCheckSeleted);
            }
        }

        public T SelectedItem
        {
            get { return selectedItem; }
        }

        public List<T> SelectedItems
        {
            get { return selectedItems; }
        }

        private List<T> ContainsOptimizedList
        {
            get
            {
                if (!sNewSearch.Equals(sOldSearch) && sNewSearch.Contains(sOldSearch)) return listResult;
                return ReSearch();
            }
        }

        private List<T> EndsOptimizedList
        {
            get
            {
                if (!sNewSearch.Equals(sOldSearch) && sNewSearch.EndsWith(sOldSearch)) return listResult;
                return ReSearch();
            }
        }

        private List<T> StartsOptimizedList
        {
            get
            {
                if (!sNewSearch.Equals(sOldSearch) && sNewSearch.StartsWith(sOldSearch)) return listResult;
                return ReSearch();
            }
        }

        private List<T> ReSearch()
        {
            listResult = ListInitInfo;
            foreach (var lstNewTerm in lstNewTerms)
            {
                if (lstNewTerm.Key == 0)
                {
                    compareOperate = new StartsOperation(lstNewTerm.Value);
                    listResult = listResult.FindAll(Match);
                }
                else if (lstNewTerm.Key == lookupTerms.Length - 1)
                {
                    compareOperate = new EndsOperation(lstNewTerm.Value);
                    listResult = listResult.FindAll(Match);
                }
                else
                {
                    compareOperate = new ContainsOperation(lstNewTerm.Value);
                    listResult = listResult.FindAll(Match);
                }
            }

            return listResult;
        }

        private abstract class CompOpBase
        {
            protected readonly string Spec;
            protected CompOpBase(string spec)
            {
                this.Spec = spec;
            }

            public abstract bool isSatisfy(string input);

        }

        private class ContainsOperation : CompOpBase
        {
            public ContainsOperation(string spec) : base(spec) { }
            public override bool isSatisfy(string input)
            {
                return input.Contains(Spec);
            }
        }

        private class StartsOperation : CompOpBase
        {
            public StartsOperation(string spec) : base(spec) { }
            public override bool isSatisfy(string input)
            {
                return input.StartsWith(Spec);
            }
        }

        private class EndsOperation : CompOpBase
        {
            public EndsOperation(string spec) : base(spec) { }
            public override bool isSatisfy(string input)
            {
                return input.EndsWith(Spec);
            }
        }

        private class EqualsOperation : CompOpBase
        {
            public EqualsOperation(string spec) : base(spec) { }
            public override bool isSatisfy(string input)
            {
                return input.Equals(Spec);
            }
        }

        private bool lookUp(T match, CompOpBase lookUpOperation)
        {
            foreach (DataGridViewColumn column in dgvLookUp.Columns)
            {
                if (column.Displayed && !String.IsNullOrEmpty(column.DataPropertyName))
                {
                    object value = typeof(T).GetProperty(column.DataPropertyName).GetValue(match, null);
                    if (value != null)
                    {
                        if (lookUpOperation.isSatisfy(value.ToString().ToLower())) return true;
                    }
                }
            }

            foreach (var lookUpPropertyName in LookUpPropertyNames())
            {
                PropertyInfo propertyInfo = typeof(T).GetProperty(lookUpPropertyName);

                if (propertyInfo == null) throw new ArgumentException(String.Format("Không có thuộc tính {0}", lookUpPropertyName));

                object value = propertyInfo.GetValue(match, null);
                if (value != null)
                {
                    if (lookUpOperation.isSatisfy(value.ToString().ToLower())) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Dùng để look up các thuộc tính khác ngoài các thuộc tính được hiển thị
        /// </summary>
        /// <returns></returns>
        protected virtual string[] LookUpPropertyNames()
        {
            return new string[] { };
        }

        protected virtual void OnLoad()
        {
            throw new NotImplementedException("Chức năng này chưa được thực hiện.");
        }

        private void SelectItem()
        {
            selectedItem = default(T);
            selectedItems.Clear();
            if (!isMultiSelect)
            {
                if (dgvLookUp.CurrentRow != null)
                {
                    selectedItem = (T)dgvLookUp.CurrentRow.DataBoundItem;
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }
            else
            {
                foreach (DataGridViewRow dataGridViewRow in dgvLookUp.Rows)
                {
                    if (dataGridViewRow.Cells[0].Value != null && Convert.ToBoolean(dataGridViewRow.Cells[0].Value))
                    {
                        selectedItems.Add((T)dataGridViewRow.DataBoundItem);
                    }
                }
                this.DialogResult = DialogResult.OK;
                return;
            }

            DialogResult = DialogResult.Cancel;
        }

        private CompOpBase compareOperate = null;

        private bool Match(T match)
        {
            return lookUp(match, compareOperate);
        }

        protected virtual string GetSearchTerm()
        {
            return txtLookUp.Text ?? String.Empty;
        }

        private void txtLookUp_TextChanged(object sender, EventArgs e)
        {
            memoryCache.Query = txtLookUp.Text;
            dgvLookUp.Refresh();
            return;

            string searchTerm = GetSearchTerm().ToLower();

            string sTemp = String.Empty;

            lstNewTerms = new SortedList<int, string>();

            lookupTerms = searchTerm.Split('%');

            int indexSearch = -1;

            if (listResult == null) listResult = ListInitInfo;

            for (int i = 0; i < lookupTerms.Length; i++)
            {
                if (!String.IsNullOrEmpty(lookupTerms[i]))
                {
                    if (!lstNewTerms.ContainsValue(lookupTerms[i])) lstNewTerms.Add(i, lookupTerms[i]);
                }
            }

            if (lookupTerms.Length == 1)
            {
                if (!String.IsNullOrEmpty(lookupTerms[0]))
                {
                    compareOperate = new EqualsOperation(lookupTerms[0]);
                    sNewSearch = lookupTerms[0];
                    listResult = ListInitInfo.FindAll(Match);
                }
                else
                {
                    listResult = ListInitInfo;
                }
                indexSearch = 0;
            }
            else
            {
                if (lstOldTerms != null)
                {
                    if (lstOldTerms.Count > lstNewTerms.Count)
                    {
                        listResult = ReSearch();
                        indexSearch = -1;
                    }
                    else
                    {
                        foreach (var lstNewTerm in lstNewTerms)
                        {
                            if (!lstOldTerms.TryGetValue(lstNewTerm.Key, out sTemp) || sTemp != lstNewTerm.Value)
                            {
                                sOldSearch = sTemp ?? String.Empty;
                                sNewSearch = lstNewTerm.Value;
                                indexSearch = lstNewTerm.Key;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    listResult = ReSearch();
                    indexSearch = -1;
                }

                if (indexSearch == 0)
                {
                    compareOperate = new StartsOperation(lstNewTerms[indexSearch]);
                    listResult = StartsOptimizedList.FindAll(Match);
                }
                else if (indexSearch == lookupTerms.Length - 1)
                {
                    compareOperate = new EndsOperation(lstNewTerms[indexSearch]);
                    listResult = EndsOptimizedList.FindAll(Match);
                }
                else if (indexSearch > -1)
                {
                    compareOperate = new ContainsOperation(lstNewTerms[indexSearch]);
                    listResult = ContainsOptimizedList.FindAll(Match);
                }
            }
            dgvLookUp.DataBindings.Clear();
            dgvLookUp.DataSource = listResult;
            dgvLookUp.ClearSelection();
            sOldSearch = sNewSearch;
            lstOldTerms = lstNewTerms;
            oldIndexSearch = indexSearch;
            tsStatus.Text = String.Format("Có {0} kết quả được tìm thấy", listResult.Count);
        }

        private void dgvLookUp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int len = dgvLookUp.Rows.Count.ToString().Length;
            foreach (DataGridViewRow dataGridViewRow in dgvLookUp.Rows)
            {
                dataGridViewRow.HeaderCell.Value = (dgvLookUp.Rows.IndexOf(dataGridViewRow) + 1).ToString().PadLeft(len, ' ');
            }
        }

        private void txtLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                dgvLookUp.Focus();
                if (dgvLookUp.Rows.Count > 0) dgvLookUp.CurrentCell = dgvLookUp.Rows[0].Cells[0];
                if (dgvLookUp.CurrentRow != null) dgvLookUp.CurrentRow.Selected = true;
            }
        }

        private void txtLookUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keyChar = e.KeyChar;
        }

        private void txtLookUp_Enter(object sender, EventArgs e)
        {
            dgvLookUp.ClearSelection();
            txtLookUp.SelectionStart = oldIndex;
        }

        private void txtLookUp_Leave(object sender, EventArgs e)
        {
            oldIndex = txtLookUp.SelectionStart;
        }

        void dgvLookUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[0-9a-zA-Z-!#\$%&'\*\+/=\?\^`\{\}\|~\w\s]", RegexOptions.Singleline))
            {
                txtLookUp.Text = txtLookUp.Text.Insert(oldIndex, Convert.ToString(e.KeyChar));
                oldIndex += 1;
                txtLookUp.Focus();
            }
        }

        private void dgvLookUp_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectItem();
                    e.Handled = true;
                    return;
                case Keys.Delete:
                    txtLookUp.Text = txtLookUp.Text.Remove(oldIndex, 1);
                    txtLookUp.Focus();
                    return;
                case Keys.Back:
                    if (oldIndex > 0) txtLookUp.Text = txtLookUp.Text.Remove(oldIndex - 1, 1);
                    oldIndex -= 1;
                    txtLookUp.Focus();
                    return;
            }
        }

        private void dgvLookUp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                SelectItem();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        void dgvLookUp_CurrentCellDirtyStateChanged(object sender, System.EventArgs e)
        {
            if (dgvLookUp.Columns[dgvLookUp.CurrentCell.ColumnIndex] is DataGridViewCheckBoxColumn)
                if (dgvLookUp.IsCurrentCellDirty) dgvLookUp.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void frmLookUp_Base_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode ) OnLoad();
            if (!this.dgvLookUp.VirtualMode)
            {
                listResult = ListInitInfo;
                dgvLookUp.DataSource = listResult = ListInitInfo;                
            }
            dgvLookUp.ClearSelection();
            txtLookUp.Text = sNewSearch;
            txtLookUp.Focus();
        }

        void frmLookUp_Base_Activated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLookUp.Text)) txtLookUp.Text = sNewSearch;
            txtLookUp.Focus();
            if (!String.IsNullOrEmpty(txtLookUp.Text)) txtLookUp.SelectionStart = txtLookUp.Text.Length - 1;
        }

        private void frmLookUp_Base_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                selectedItem = default(T);
                selectedItems.Clear();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void frmLookUp_Base_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Debug.Print(((int)e.KeyChar).ToString());
            ////SendKeys.Send(e.KeyChar.ToString());
        }
    }

    partial class frmLookUp_Base1<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLookUp = new QLBH.Core.Form.GtidDataGridView();
            this.txtLookUp = new QLBH.Core.Form.GtidTextBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUp)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(516, 17);
            this.tsStatus.Spring = true;
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLookUp);
            this.panel1.Controls.Add(this.dgvLookUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 472);
            this.panel1.TabIndex = 7;
            // 
            // dgvLookUp
            // 
            this.dgvLookUp.AllowUserToAddRows = false;
            this.dgvLookUp.AllowUserToDeleteRows = false;
            this.dgvLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLookUp.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLookUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookUp.Location = new System.Drawing.Point(3, 39);
            this.dgvLookUp.Name = "dgvLookUp";
            this.dgvLookUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLookUp.Size = new System.Drawing.Size(525, 430);
            this.dgvLookUp.TabIndex = 6;

            this.dgvLookUp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLookUp_MouseDoubleClick);
            this.dgvLookUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLookUp_KeyDown);
            this.dgvLookUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(dgvLookUp_KeyPress);
            this.dgvLookUp.CurrentCellDirtyStateChanged += new System.EventHandler(dgvLookUp_CurrentCellDirtyStateChanged);
            this.dgvLookUp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLookUp_DataBindingComplete);
            // 
            // txtLookUp
            // 
            this.txtLookUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLookUp.Location = new System.Drawing.Point(3, 12);
            this.txtLookUp.Name = "txtLookUp";
            this.txtLookUp.Size = new System.Drawing.Size(525, 21);
            this.txtLookUp.TabIndex = 7;
            this.txtLookUp.TextChanged += new System.EventHandler(this.txtLookUp_TextChanged);
            this.txtLookUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLookUp_KeyDown);
            this.txtLookUp.KeyPress += new KeyPressEventHandler(txtLookUp_KeyPress);
            this.txtLookUp.Leave += new System.EventHandler(this.txtLookUp_Leave);
            this.txtLookUp.Enter += new System.EventHandler(this.txtLookUp_Enter);
            // 
            // frmLookUp_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "frmLookUp_Base";
            this.Text = "frmLookUp_Base";
            this.Load += new System.EventHandler(this.frmLookUp_Base_Load);
            this.Activated += new System.EventHandler(frmLookUp_Base_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLookUp_Base_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLookUp_Base_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        protected System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Panel panel1;
        protected GtidTextBox txtLookUp;
        protected GtidDataGridView dgvLookUp;

    }
}
