//TODO: @HanhBD em căn cứ các bảng có cùng số trường thì tách làm một form
//create table TBL_DM_ORDERTYPE(8)
//(
//  IDORDERTYPE NUMBER not null,
//  CODE        NVARCHAR2(50),
//  NAME        NVARCHAR2(150),
//  GHICHU      NVARCHAR2(250),
//  SUDUNG      NUMBER,
//  LINE        NVARCHAR2(50),
//  ORDERCK     NVARCHAR2(50),
//  LINECK      NVARCHAR2(50)
//)

//create table TBL_DM_BIEUTHUE(6)
//(
//  IDBIEUTHUE  NUMBER not null,
//  MABIEUTHUE  NVARCHAR2(50),
//  TENBIEUTHUE NVARCHAR2(100),
//  GIATRI      NUMBER,
//  SUDUNG      NUMBER,
//  GHICHU      NVARCHAR2(250)
//)

//create table TBL_DM_TIENTE(6)
//(
//  IDTIENTE  NUMBER not null,
//  KYHIEU    VARCHAR2(10) not null,
//  TENTIENTE NVARCHAR2(100) not null,
//  GHICHU    NVARCHAR2(250),
//  SUDUNG    NUMBER not null,
//  TYGIA     NUMBER
//)

//create table TBL_DM_CHUCNANG(5)
//(
//  IDCHUCNANG  NUMBER not null,
//  MACHUCNANG  NVARCHAR2(5) not null,
//  TENCHUCNANG NVARCHAR2(150) not null,
//  GHICHU      NVARCHAR2(250),
//  SUDUNG      NUMBER not null
//)

//create table TBL_DM_DONVITINH(5)
//(
//  IDDONVITINH  NUMBER not null,
//  KYHIEU       NVARCHAR2(10) not null,
//  TENDONVITINH NVARCHAR2(50),
//  GHICHU       NVARCHAR2(250),
//  SUDUNG       NUMBER not null
//)

//create table TBL_DM_PHONGBAN(5)
//(
//  IDPHONGBAN  NUMBER not null,
//  MAPHONGBAN  VARCHAR2(10),
//  TENPHONGBAN NVARCHAR2(100),
//  GHICHU      NVARCHAR2(250),
//  SUDUNG      NUMBER
//)

//create table TBL_DM_CHUCVU(5)
//(
//  IDCHUCVU  NUMBER not null,
//  MACHUCVU  VARCHAR2(50),
//  TENCHUCVU NVARCHAR2(100),
//  GHICHU    NVARCHAR2(250),
//  SUDUNG    NUMBER
//)

//create table TBL_DM_DUAN(5)
//(
//  IDDUAN  NUMBER not null,
//  MADUAN  NVARCHAR2(20),
//  TENDUAN NVARCHAR2(100),
//  GHICHU  NVARCHAR2(250),
//  SUDUNG  NUMBER
//)

//create table TBL_DM_NHOMNGUOIDUNG(4)
//(
//  IDNHOMNGUOIDUNG NUMBER not null,
//  MANHOM          NVARCHAR2(5),
//  TENNHOM         NVARCHAR2(50),
//  SUDUNG          NUMBER
//)

//@All ***************      CHÚ Ý       *******************
//@All - Khai báo các object Info ĐỦ ĐỂ HIỂN THỊ
//@All - Không viết hàm QUÁ DÀI
//@All - Các đoạn code dùng lại thì phải viết thành hàm riêng
//@All - Đặt tên hàm, biến cẩn thận dễ hiểu
//@All - Dùng Convert.ToInt32 khi cần chuyển đổi sang kiểu int

