using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiDAL;
using ThietBiBLL;
using ThietBiPY.DanhMuc.thongtindonvi;
using ThietBiPY.DanhMuc;
using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.NghiepVu
{
    public partial class frm_bangiaothietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        int DonVi = 0;

        //
        public frm_bangiaothietbi_capnhat(int DonVi)
        {
            InitializeComponent();
            this.DonVi = DonVi;

            //
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("ĐVT", 50);
            lv_thietbi.Columns.Add("Tình trạng", 100);
            lv_thietbi.Columns.Add("Hiện trạng", 300);

            //
            cbo_donvibangiao.DataSource = new DONVI_BLL().donvi_danhsach().Where(c => c.DonViID == DonVi).ToList();
            cbo_donvibangiao.ValueMember = "DonViID";
            cbo_donvibangiao.DisplayMember = "TenDonVi";
            cbo_donvibangiao.Enabled = false;
            cbo_donvibangiao.SelectedIndexChanged += new EventHandler(cbo_donvibangiao_SelectedIndexChanged);
            cbo_donvibangiao_SelectedIndexChanged(null, null);

            cbo_donvinhan.DataSource = new DONVI_BLL().donvi_danhsach().Where(c => c.DonViID == DonVi).ToList();
            cbo_donvinhan.ValueMember = "DonViID";
            cbo_donvinhan.DisplayMember = "TenDonVi";
            cbo_donvinhan.Enabled = false;
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
            cbo_donvinhan_SelectedIndexChanged(null, null);
            
            danhmuc_macabiet();
            dtp_ngaybangiao.Value = DateTime.Now.Date;
        }
        public frm_bangiaothietbi_capnhat(int DonVi,string ma)
        {
            InitializeComponent();
            this.DonVi = DonVi;

            //
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("ĐVT", 50);
            lv_thietbi.Columns.Add("Tình trạng", 100);
            lv_thietbi.Columns.Add("Hiện trạng", 300);

            //
            this.ma = ma;
            var BANGIAO = new PHIEUBANGIAO_BLL().phieubangiao_thongtin(ma);

            if (BANGIAO.NgayVanBan != null) dtp_ngayvanban.Value = BANGIAO.NgayVanBan.Value.Date;
            txt_sovanban.Text = BANGIAO.SoVanBan;
            txt_thamquyenqd.Text = BANGIAO.ThamQuyenQD;
            if (BANGIAO.NgayBanGiao != null) dtp_ngaybangiao.Value = BANGIAO.NgayBanGiao.Value.Date;

            cbo_donvibangiao.DataSource = new DONVI_BLL().donvi_danhsach().Where(c => c.DonViID == BANGIAO.DonViBanGiao).ToList();
            cbo_donvibangiao.ValueMember = "DonViID";
            cbo_donvibangiao.DisplayMember = "TenDonVi";
            cbo_donvibangiao.Enabled = false;
            cbo_donvibangiao.SelectedIndexChanged += new EventHandler(cbo_donvibangiao_SelectedIndexChanged);
            cbo_donvibangiao_SelectedIndexChanged(null, null);

            danhmuc_bophanbangiao(BANGIAO.BoPhanBanGiao.ToString());
            danhmuc_nhanvienbangiao(BANGIAO.NhanVienBanGiao.ToString());

            cbo_donvinhan.DataSource = new DONVI_BLL().donvi_danhsach().Where(c => c.DonViID == BANGIAO.DonViNhan).ToList();
            cbo_donvinhan.ValueMember = "DonViID";
            cbo_donvinhan.DisplayMember = "TenDonVi";
            cbo_donvinhan.Enabled = false;
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
            cbo_donvinhan_SelectedIndexChanged(null, null);

            cbo_bophannhan.SelectedValue = BANGIAO.BoPhanNhan;
            danhmuc_nhanviennhan(BANGIAO.NhanVienNhan.ToString());

            danhmuc_macabiet();
            LST_TBDACHON = new CTBANGIAO_BLL().ctbangiao_danhsach(ma).Select(c => new THIETBI_MOI
            {
                BanGiaoID = c.BanGiaoID,
                ThietBiID = c.SOTHEODOI.GTTHIETBI.ThietBiID,
                MaThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.MaThietBi,
                SoHieu = c.SOTHEODOI.GTTHIETBI.THIETBI.SoHieu,

                TenLoaiTB = (c.SOTHEODOI.GTTHIETBI.THIETBI.LoaiTBID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định"),
                DonViTinh = (c.SOTHEODOI.GTTHIETBI.THIETBI.DVTID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.DONVITINH.TenDVT : "Chưa xác định"),
                TenThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi,

                GTThietBiID = c.GTThietBiID,
                MaCaBiet = c.SOTHEODOI.GTTHIETBI.MaCaBiet,

                TinhTrangID = c.SOTHEODOI.TinhTrang,
                TenTinhTrang = (c.SOTHEODOI.TinhTrang != 0 ? c.SOTHEODOI.TINHTRANG1.TenTinhTrang : "Chưa xác định"),
                HienTrang = c.SOTHEODOI.HienTrang,
            }).ToList<THIETBI_MOI>();

            //
            ListViewItem item = null;
            int dem = 0;
            foreach (var TB in LST_TBDACHON)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = TB.GTThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);
                item.SubItems.Add(TB.MaCaBiet);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.DonViTinh);
                item.SubItems.Add(TB.TenTinhTrang);
                item.SubItems.Add(TB.HienTrang);

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
        }

        //
        public frm_bangiaothietbi_capnhat()
        {
            InitializeComponent();
            //
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("ĐVT", 50);
            lv_thietbi.Columns.Add("Tình trạng", 100);
            lv_thietbi.Columns.Add("Hiện trạng", 300);

            //
           
            danhmuc_donvibangiao("");
            danhmuc_donvinhan("");

            danhmuc_macabiet();

            //
            dtp_ngaybangiao.Value = DateTime.Now.Date;

        }
        public frm_bangiaothietbi_capnhat(string ma)
        {
            InitializeComponent();
            //
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("ĐVT", 50);
            lv_thietbi.Columns.Add("Tình trạng", 100);
            lv_thietbi.Columns.Add("Hiện trạng", 300);

            //
            
            this.ma = ma;
            var BANGIAO = new PHIEUBANGIAO_BLL().phieubangiao_thongtin(ma);

            if (BANGIAO.NgayVanBan != null) dtp_ngayvanban.Value = BANGIAO.NgayVanBan.Value.Date;
            txt_sovanban.Text = BANGIAO.SoVanBan;
            txt_thamquyenqd.Text = BANGIAO.ThamQuyenQD;
            if (BANGIAO.NgayBanGiao != null) dtp_ngaybangiao.Value = BANGIAO.NgayBanGiao.Value.Date;
           
            danhmuc_donvibangiao(BANGIAO.DonViBanGiao.ToString());
            danhmuc_bophanbangiao(BANGIAO.BoPhanBanGiao.ToString());
            danhmuc_nhanvienbangiao(BANGIAO.NhanVienBanGiao.ToString());

            danhmuc_donvinhan(BANGIAO.DonViNhan.ToString());
            cbo_bophannhan.SelectedValue = BANGIAO.BoPhanNhan;
            danhmuc_nhanviennhan(BANGIAO.NhanVienNhan.ToString());

            danhmuc_macabiet();
            LST_TBDACHON = new CTBANGIAO_BLL().ctbangiao_danhsach(ma).Select(c => new THIETBI_MOI
            {
                BanGiaoID = c.BanGiaoID,
                ThietBiID=c.SOTHEODOI.GTTHIETBI.ThietBiID,
                MaThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.MaThietBi,
                SoHieu = c.SOTHEODOI.GTTHIETBI.THIETBI.SoHieu,

                TenLoaiTB = (c.SOTHEODOI.GTTHIETBI.THIETBI.LoaiTBID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định"),
                DonViTinh = (c.SOTHEODOI.GTTHIETBI.THIETBI.DVTID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.DONVITINH.TenDVT : "Chưa xác định"),
                TenThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi,

                GTThietBiID = c.GTThietBiID,
                MaCaBiet=c.SOTHEODOI.GTTHIETBI.MaCaBiet,

                TinhTrangID = c.SOTHEODOI.TinhTrang,
                TenTinhTrang = (c.SOTHEODOI.TinhTrang != 0 ? c.SOTHEODOI.TINHTRANG1.TenTinhTrang : "Chưa xác định"),
                HienTrang = c.SOTHEODOI.HienTrang,
            }).ToList<THIETBI_MOI>();

            //
            ListViewItem item = null;
            int dem = 0;
            foreach (var TB in LST_TBDACHON)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = TB.GTThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);
                item.SubItems.Add(TB.MaCaBiet);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.DonViTinh);
                item.SubItems.Add(TB.TenTinhTrang);
                item.SubItems.Add(TB.HienTrang);

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
        }

        #region "Danh mục"
        //
        public void danhmuc_macabiet()
        {
            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
            var LST = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == (int)cbo_donvibangiao.SelectedValue).Skip(0).Take(10).Select(c => c.GTTHIETBI.MaCaBiet);
            Str_Col.AddRange(LST.ToArray());
            txt_macabiet.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_macabiet.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_macabiet.AutoCompleteCustomSource = Str_Col;
        }
        //
        public void danhmuc_donvibangiao(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "Không có hoặc chưa xác định", DienThoai = "", DienGiai = "" });
            cbo_donvibangiao.DataSource = binding_donvi;
            cbo_donvibangiao.ValueMember = "DonViID";
            cbo_donvibangiao.DisplayMember= "TenDonVi";

            if (giatri == "")
            {
                cbo_donvibangiao.SelectedValue = 0;
            }
            else cbo_donvibangiao.SelectedValue = int.Parse(giatri);
            cbo_donvibangiao.SelectedIndexChanged += new EventHandler(cbo_donvibangiao_SelectedIndexChanged);
            cbo_donvibangiao_SelectedIndexChanged(null, null);
        }
        public void danhmuc_bophanbangiao(string giatri)
        {
            if (cbo_donvibangiao.SelectedIndex >= 0)
            {
                BindingSource binding_bophanbangiao = new BindingSource();
                binding_bophanbangiao.DataSource = new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == (int)cbo_donvibangiao.SelectedValue).ToList();
                binding_bophanbangiao.Add(new BOPHAN { BoPhanID = 0, TenBoPhan = "Chưa xác định hoặc không có", DonViID = (int)cbo_donvibangiao.SelectedValue, DienGiai = "" });

                cbo_bophanbangiao.DataSource = binding_bophanbangiao;
                cbo_bophanbangiao.ValueMember = "BoPhanID";
                cbo_bophanbangiao.DisplayMember = "TenBoPhan";

                if (cbo_bophanbangiao.Items.Count > 0)
                {
                    if (giatri == "")
                    {
                        cbo_bophanbangiao.SelectedIndex = 0;
                    }
                    else cbo_bophanbangiao.SelectedValue = int.Parse(giatri);
                }
            }
            else cbo_bophanbangiao.DataSource = null;
        }
        public void danhmuc_nhanvienbangiao(string giatri)
        {
            if (cbo_donvibangiao.SelectedIndex >= 0)
            {
                BindingSource binding_nhanvien = new BindingSource();

                binding_nhanvien.DataSource = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.DonViID == (int)cbo_donvibangiao.SelectedValue).Select(c => new
                {
                    NhanVienID = c.NhanVienID,
                    MaNV = c.MaNV,
                    HoTen = c.HoNV + " " + c.TenNV,
                    ChucVu = (c.ChucVuID != 0 ? c.CHUCVU.TenChucVu : "Chưa xác định"),
                    DonVi = (c.DonViID != 0 ? c.DONVI.TenDonVi : "Chưa xác định"),
                    CapBac = (c.ChucVuID != 0 ? c.CHUCVU.CapBac : 0),
                }).OrderByDescending(p => p.CapBac).ToList();


                binding_nhanvien.Add(new
                {
                    NhanVienID = (Int64)0,
                    MaNV = "000000",
                    HoTen = "[Chưa xác định hoặc không có]",
                    ChucVu = "Chưa xác định",
                    DonVi = "Chưa xác định",
                    CapBac = 0,
                });

                cbo_nhanvienbangiao.DataSource = binding_nhanvien;
                cbo_nhanvienbangiao.GroupingMembers = "DonVi";
                cbo_nhanvienbangiao.ValueMember = "NhanVienID";
                cbo_nhanvienbangiao.DisplayMembers = "MaNV,HoTen,ChucVu";

                if (giatri != "")
                {
                    cbo_nhanvienbangiao.SelectedValue = Int64.Parse(giatri);
                }
                else cbo_nhanvienbangiao.SelectedIndex = 0;

                txt_manhanvienbangiao.DataBindings.Clear();
                txt_manhanvienbangiao.Text = "";
                txt_manhanvienbangiao.DataBindings.Add(new Binding("Text", binding_nhanvien, "MaNV"));
                txt_manhanvienbangiao.Validated += new EventHandler(txt_manhanvienbangiao_Validated);
            }
            else
            {
                cbo_nhanvienbangiao.DataSource = null;
                txt_manhanvienbangiao.DataBindings.Clear();
                txt_manhanvienbangiao.Text = "";
            }
        }

        public void danhmuc_donvinhan(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "Không có hoặc chưa xác định", DienGiai = "", DienThoai = "" });
            cbo_donvinhan.DataSource = binding_donvi;
            cbo_donvinhan.ValueMember = "DonViID";
            cbo_donvinhan.DisplayMember = "TenDonVi";

            if (giatri == "")
            {
                cbo_donvinhan.SelectedValue = 0;
            }
            else cbo_donvinhan.SelectedValue = int.Parse(giatri);
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
            cbo_donvinhan_SelectedIndexChanged(null, null);
        }
        public void danhmuc_bophannhan(string giatri)
        {
            if (cbo_donvinhan.SelectedIndex >= 0)
            {
                BindingSource binding_bophan = new BindingSource();
                binding_bophan.DataSource = new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == (int)cbo_donvinhan.SelectedValue).ToList();

                binding_bophan.Add(new BOPHAN { BoPhanID = 0, TenBoPhan = "Chưa xác định hoặc không có", DonViID = (int)cbo_donvinhan.SelectedValue, DienGiai = "" });
                cbo_bophannhan.DataSource = binding_bophan;
                cbo_bophannhan.ValueMember = "BoPhanID";
                cbo_bophannhan.DisplayMember = "TenBoPhan";

                if (cbo_bophannhan.Items.Count > 0)
                {
                    if (giatri == "")
                    {
                        cbo_bophannhan.SelectedIndex = 0;
                    }
                    else cbo_bophannhan.SelectedValue = int.Parse(giatri);
                }
            }
            else cbo_bophannhan.DataSource = null; 
        }
        public void danhmuc_nhanviennhan(string giatri)
        {
            if (cbo_donvinhan.SelectedIndex >= 0)
            {
                BindingSource binding_nhanvien = new BindingSource();

                binding_nhanvien.DataSource = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.DonViID == (int)cbo_donvinhan.SelectedValue).Select(c => new
                {
                    NhanVienID = c.NhanVienID,
                    MaNV = c.MaNV,
                    HoTen = c.HoNV + " " + c.TenNV,
                    ChucVu = (c.ChucVuID != 0 ? c.CHUCVU.TenChucVu : "Chưa xác định"),
                    DonVi = (c.DonViID != 0 ? c.DONVI.TenDonVi : "Chưa xác định"),
                    CapBac = (c.ChucVuID != 0 ? c.CHUCVU.CapBac : 0),
                }).OrderByDescending(p => p.CapBac).ToList();

                binding_nhanvien.Add(new
                {
                    NhanVienID=(Int64)0,
                    MaNV="000000",
                    HoTen="[Chưa xác định hoặc không có]",
                    ChucVu="Chưa xác định",
                    DonVi="Chưa xác định",
                    CapBac=0,
                });

                cbo_nhanviennhan.DataSource = binding_nhanvien;
                cbo_nhanviennhan.GroupingMembers = "DonVi";
                cbo_nhanviennhan.ValueMember = "NhanVienID";
                cbo_nhanviennhan.DisplayMembers = "MaNV,HoTen,ChucVu";

                if (giatri != "")
                {
                    cbo_nhanviennhan.SelectedValue = Int64.Parse(giatri);
                }
                else cbo_nhanviennhan.SelectedIndex = 0;

                txt_manhanviennhan.DataBindings.Clear();
                txt_manhanviennhan.Text = "";
                txt_manhanviennhan.DataBindings.Add(new Binding("Text", binding_nhanvien, "MaNV"));
                txt_manhanviennhan.Validated += new EventHandler(txt_manhanviennhan_Validated);
            }
            else
            {
                cbo_nhanviennhan.DataSource = null;
                txt_manhanviennhan.DataBindings.Clear();
                txt_manhanviennhan.Text = "";
            }
        }

        //

        //
        #endregion

        //Khai báo
        List<THIETBI_MOI> LST_DSTHIETBI = new List<THIETBI_MOI>();
        List<THIETBI_MOI> LST_TBDACHON = new List<THIETBI_MOI>();
        public class THIETBI_MOI
        {
            public int BanGiaoID { get; set; }
            public long ThietBiID { get; set; }
            public long GTThietBiID { get; set; }
            public string TenThietBi { get; set; }
            public string MaThietBi { get; set; }
            public string SoHieu { get; set; }
            public string MaCaBiet { get; set; }
            public string TenLoaiTB { get; set; }
            public string DonViTinh { get; set; }
            public int TinhTrangID{ get; set; }
            public string TenTinhTrang { get; set; }
            public string HienTrang { get; set; }
        }
        
        //

        #region "Hàm xử lý"
        /* Lệnh xử lý */
        public void chonthietbi(string GTThietBiID)
        {
            //
            if (ma != "")
            {
                var TT = LST_TBDACHON.SingleOrDefault(c => c.GTThietBiID== Int64.Parse (GTThietBiID));
                if (TT != null)
                {
                    TT.BanGiaoID = int.Parse(ma);
                    ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                    item.Tag = TT.GTThietBiID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(TT.MaThietBi);
                    item.SubItems.Add(TT.SoHieu);
                    item.SubItems.Add (TT.MaCaBiet);
                    item.SubItems.Add(TT.TenThietBi);
                    item.SubItems.Add(TT.DonViTinh);
                    item.SubItems.Add(TT.TenTinhTrang);
                    item.SubItems.Add(TT.HienTrang);

                    for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                    {
                        if ((lv_thietbi.Items.Count + 1) % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                    return;
                }
            }
            //
            var TB = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.GTThietBiID == Int64.Parse(GTThietBiID)).Select(c => new THIETBI_MOI
            {
                ThietBiID =c.GTTHIETBI.ThietBiID,
                GTThietBiID = c.GTThietBiID,
                MaThietBi = c.GTTHIETBI.THIETBI.MaThietBi,
                SoHieu = c.GTTHIETBI.THIETBI.SoHieu,
                MaCaBiet = c.GTTHIETBI.MaCaBiet,

                TinhTrangID=c.TinhTrang,
                TenTinhTrang =(c.TinhTrang!=0?c.TINHTRANG1.TenTinhTrang:""),
                TenLoaiTB = (c.GTTHIETBI.THIETBI.LoaiTBID != 0 ? c.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định"),
                DonViTinh = (c.GTTHIETBI.THIETBI.DVTID != 0 ? c.GTTHIETBI.THIETBI.DONVITINH.TenDVT : "Chưa xác định"),
                HienTrang = c.HienTrang,
                TenThietBi = c.GTTHIETBI.THIETBI.TenThietBi,
            }).Single();

            if (ma != "") TB.BanGiaoID = int.Parse(ma);
            if (TB != null)
            {
                LST_TBDACHON.Add(TB);
                ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                item.Tag = TB.GTThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);
                item.SubItems.Add(TB.MaCaBiet);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.DonViTinh);
                item.SubItems.Add(TB.TenTinhTrang);
                item.SubItems.Add(TB.HienTrang);

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if ((lv_thietbi.Items.Count + 1) % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
        }
        public void loaibothietbi(string GTThietBiID)
        {
            var TB = LST_TBDACHON.Single(c => c.GTThietBiID == Int64.Parse(GTThietBiID));
            if (ma == "")
            {
                if (LST_TBDACHON.Remove(TB) == true)
                {
                    lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
                    lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
                }
            }
            else
            {
                TB.BanGiaoID = 0;
                lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
                lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
            }
        }
        public void capnhatthem(string tinhtrang,string hientrang)
        {
            ListViewItem lv = lv_thietbi.SelectedItems [0];
            var TB = LST_TBDACHON.Single(c => c.GTThietBiID == Int64.Parse(lv.Tag.ToString()));
            TB.TinhTrangID = int.Parse(tinhtrang);
            TB.HienTrang= hientrang;

            lv.SubItems[6].Text = tinhtrang;
            lv.SubItems [7].Text = hientrang ;
        }
        public void xuly(string yeucau)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            switch (yeucau)
            {
                case "luulai":

                    if (dtp_ngaybangiao.Value.Date == new DateTime(01, 01, 0001))
                    {
                        dtp_ngaybangiao.Focus();
                        DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập ngày bàn giao!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    //
                    var PHIEUBANGIAO = new PHIEUBANGIAO_BLL();

                    PHIEUBANGIAO.BANGIAO_DTO.SoVanBan = txt_sovanban.Text;
                    if (dtp_ngayvanban.Value.Date != new DateTime(01, 01, 0001)) PHIEUBANGIAO.BANGIAO_DTO.NgayVanBan = dtp_ngayvanban.Value.Date;
                    PHIEUBANGIAO.BANGIAO_DTO.ThamQuyenQD = txt_thamquyenqd.Text;
                    if (dtp_ngaybangiao.Value.Date != new DateTime(01, 01, 0001)) PHIEUBANGIAO.BANGIAO_DTO.NgayBanGiao = dtp_ngaybangiao.Value.Date;
                   
                    PHIEUBANGIAO.BANGIAO_DTO.DonViBanGiao = (int)cbo_donvibangiao.SelectedValue;
                    PHIEUBANGIAO .BANGIAO_DTO.BoPhanBanGiao = (int)cbo_bophanbangiao.SelectedValue ;
                    PHIEUBANGIAO.BANGIAO_DTO.NhanVienBanGiao = (cbo_nhanvienbangiao .SelectedIndex >=0?(Int64)cbo_nhanvienbangiao .SelectedValue:0) ;

                    PHIEUBANGIAO.BANGIAO_DTO.DonViNhan = (int)cbo_donvinhan.SelectedValue;
                    if (cbo_bophannhan.DataSource !=null) PHIEUBANGIAO.BANGIAO_DTO.BoPhanNhan = (int)cbo_bophannhan.SelectedValue;
                    PHIEUBANGIAO.BANGIAO_DTO.NhanVienNhan = (cbo_nhanviennhan.SelectedIndex >= 0 ? (Int64)cbo_nhanviennhan.SelectedValue : 0);

                    PHIEUBANGIAO.BANGIAO_DTO.GhiChu = txt_ghichu.Text;

                    PHIEUBANGIAO.LST_CTBANGIAO = LST_TBDACHON.Select(c => new CTBANGIAO
                    {
                        BanGiaoID =c.BanGiaoID,
                        GTThietBiID = c.GTThietBiID,
                    }).ToList();

                    if (ma == "")
                    {
                        if (PHIEUBANGIAO.phieubangiao_them() > 0)
                        {
                            guidulieu(PHIEUBANGIAO.BANGIAO_DTO.BanGiaoID.ToString());
                            this.Close();
                        }
                    }
                    else
                    {
                        if (PHIEUBANGIAO.phieubangiao_sua(ma) > 0)
                        {
                            guidulieu(PHIEUBANGIAO.BANGIAO_DTO.BanGiaoID.ToString());
                            this.Close();
                        }
                    }
                    break;

                case "dong":
                    this.Close();
                    break;
            }
        }
        
        /* Truyền trị */
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }
        #endregion

        #region "Sự kiện xử lý chính"
        private void btn_themvaodanhsach_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_tenthietbi.Tag !=null)
            {
                chonthietbi(txt_tenthietbi.Tag.ToString());
                txt_macabiet.Text = "";
                txt_tenthietbi.Tag = null;
                txt_tenthietbi.Text = "";
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly("luulai");
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Sự kiện cho nhập liệu"
        //
        private void frm_bangiaothietbi_capnhat_Load(object sender, EventArgs e)
        {
                       cbo_donvinhan.Enabled = true;
            txt_ghichu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichu).OnKeyPress);
            txt_thamquyenqd.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thamquyenqd).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void frm_bangiaothietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_dong_Click(null, null); break;
            }
        }
       
        //
        /* bên bàn giao */
        public void cbo_donvibangiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhmuc_bophanbangiao("0");
            danhmuc_nhanvienbangiao("0");
            danhmuc_macabiet();
        }
        private void btn_lamtuoi_donvibangiao_Click(object sender, EventArgs e)
        {
            danhmuc_donvibangiao("");
        }

        private void btn_thembophanbangiao_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (cbo_donvibangiao.SelectedIndex >= 0)
            {
                frm_bophan_capnhat frm = new frm_bophan_capnhat(cbo_donvibangiao.SelectedValue.ToString());
                frm.DuLieu = new frm_bophan_capnhat.passData(danhmuc_bophanbangiao);
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị bàn giao!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_lamtuoi_nhanvienbangiao_Click(object sender, EventArgs e)
        {
            cbo_donvibangiao_SelectedIndexChanged(null, null);
        }
        private void btn_themnhanvienbangiao_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (cbo_donvibangiao.SelectedIndex >= 0)
            {
                frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat((int)cbo_donvibangiao.SelectedValue);
                frm.DuLieu = new frm_nhanvien_capnhat.passData(danhmuc_nhanvienbangiao); ;
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị bàn giao!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btn_danhsachnhanvienbangiao_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            if (cbo_donvibangiao.SelectedIndex >= 0 && (int)cbo_donvibangiao.SelectedValue > 0)
            {
                DanhMuc.frm_nhanvien_dschon frm = new ThietBiPY.DanhMuc.frm_nhanvien_dschon(cbo_donvibangiao.SelectedValue.ToString());
                frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_dschon.passData(danhmuc_nhanvienbangiao);
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa xác định đơn vị bàn giao!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void txt_manhanvienbangiao_Validated(object sender, EventArgs e)
        {
            if (txt_manhanvienbangiao.Text != "" && txt_manhanvienbangiao.Text!="000000")
            {
                cbo_nhanvienbangiao.SelectedValue = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.MaNV == txt_manhanvienbangiao.Text).Single().NhanVienID;
            }
        }

        /* bên nhận */
        public void cbo_donvinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhmuc_bophannhan("0");
            danhmuc_nhanviennhan("0");
        }
        private void btn_lamtuoi_donvinhan_Click(object sender, EventArgs e)
        {
            danhmuc_donvinhan("");
        }
        private void btn_themdonvinhan_Click(object sender, EventArgs e)
        {
            frm_donvi_capnhat frm = new frm_donvi_capnhat();
            frm.DuLieu = new frm_donvi_capnhat.passData(danhmuc_donvinhan);
            frm.ShowDialog();
        }

        private void btn_thembophannhan_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (cbo_donvinhan.SelectedIndex >= 0)
            {
                frm_bophan_capnhat frm = new frm_bophan_capnhat(cbo_donvinhan.SelectedValue.ToString());
                frm.DuLieu = new frm_bophan_capnhat.passData(danhmuc_bophannhan);
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị nhận!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btn_lamtuoi_bophannhan_Click(object sender, EventArgs e)
        {
            cbo_donvinhan_SelectedIndexChanged(null, null);
        }
        private void btn_lamtuoi_bophanbangiao_Click(object sender, EventArgs e)
        {
            cbo_donvibangiao_SelectedIndexChanged(null, null);
        }
       
        private void btn_lamtuoi_nhanviennhan_Click(object sender, EventArgs e)
        {
            cbo_donvinhan_SelectedIndexChanged(null, null);
        }
        private void btn_themnhanviennhan_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (cbo_donvinhan.SelectedIndex >= 0)
            {
                frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat((int)cbo_donvinhan.SelectedValue);
                frm.DuLieu = new frm_nhanvien_capnhat.passData(danhmuc_nhanviennhan);
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị nhận!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btn_danhsachnhanviennhan_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if ((int)cbo_donvibangiao.SelectedValue > 0)
            {
                DanhMuc.frm_nhanvien_dschon frm = new ThietBiPY.DanhMuc.frm_nhanvien_dschon(cbo_donvinhan.SelectedValue.ToString());
                frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_dschon.passData(danhmuc_nhanviennhan);
                frm.ShowDialog();
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa xác định đơn vị nhận!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void txt_manhanviennhan_Validated(object sender, EventArgs e)
        {
            if (txt_manhanviennhan.Text != "" && txt_manhanviennhan.Text!="000000")
            {
                cbo_nhanviennhan.SelectedValue = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.MaNV == txt_manhanviennhan.Text).Single().NhanVienID;
            }
        }

        /* kê khai thiết bị */
        //

        private void context_menu_loaibo_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                loaibothietbi(lv_thietbi.SelectedItems[0].Tag.ToString());
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần loại bỏ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_danhsachthietbi_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if ((int)cbo_donvibangiao.SelectedValue > 0)
            {
                List<string> LST_CHON = new List<string>();
                if (ma == "")
                {
                    foreach (var TB in LST_TBDACHON)
                    {
                        LST_CHON.Add(TB.GTThietBiID.ToString());
                    }
                }
                else
                {
                    foreach (var TB in LST_TBDACHON.Where(c => c.BanGiaoID != 0).ToList())
                    {
                        LST_CHON.Add(TB.GTThietBiID.ToString());
                    }
                }
                frm_dschonthietbi_theonoisudung frm = new frm_dschonthietbi_theonoisudung(cbo_donvibangiao.SelectedValue.ToString(), LST_CHON);
                frm.DuLieu = new frm_dschonthietbi_theonoisudung.passData(chonthietbi);
                frm.ShowDialog();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị bàn giao!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbo_donvibangiao.Focus();
            }
        }


        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string chitiet = "";
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                lv_thietbi.ContextMenuStrip = context_menu;
                var GTTB = new GTTHIETBI_BLL().gtthietbi_thongtin(lv_thietbi.SelectedItems[0].Tag.ToString());
                chitiet = "Thiết bị: " + GTTB.THIETBI.TenThietBi + Environment.NewLine;
                chitiet += "Mã cá biệt: " + GTTB.MaCaBiet + Environment.NewLine;
                chitiet += "Thông tin: " + Environment.NewLine + " -Ngày nhập: " + GTTB.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy") + Environment.NewLine;
                chitiet += " -Nguyên giá: " + string.Format("{0:0,0 đ}", GTTB.CTPHIEUNHAP.DonGia);
            }
            else lv_thietbi.ContextMenuStrip = null;
            toolTip1.SetToolTip(lv_thietbi, chitiet);
        }

        private void dtp_ngayvanban_ValueChanged(object sender, EventArgs e)
        {
            if (ma == "")
            {
                if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001))
                {
                    dtp_ngaybangiao.Value = dtp_ngayvanban.Value.Date;
                    
                    if(DonVi!=0){
                        txt_sovanban.Text = string.Format("{0}-{1}-{2:000}",DonVi,dtp_ngaybangiao.Value.Year, new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Where(c => (c.DonViBanGiao == DonVi) && (c.NgayVanBan != null ? c.NgayVanBan.Value.Year == dtp_ngayvanban.Value.Year : c.NgayBanGiao.Value.Year == dtp_ngayvanban.Value.Year)).Count() + 1);
                }
                }
                else txt_sovanban.Text = string.Format("{0}-{1}-{2:000}", DonVi,dtp_ngaybangiao.Value.Year, new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Where(c =>(c.NgayVanBan != null ? c.NgayVanBan.Value.Year == dtp_ngayvanban.Value.Year : c.NgayBanGiao.Value.Year == dtp_ngayvanban.Value.Year)).Count() + 1);
            }
        }

        private void lv_thietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete: context_menu_loaibo_Click(null, null); break;
            }
        }

        private void btn_chitietthietbi_Click(object sender, EventArgs e)
        {
            if (txt_macabiet.Text != "")
            {
                frm_thietbi_thongtinchitiet frm = new frm_thietbi_thongtinchitiet(txt_macabiet.Text, cbo_donvibangiao.SelectedValue.ToString(), cbo_bophanbangiao.SelectedValue.ToString());
                frm.ShowDialog();
            }
        }

        private void txt_macabiet_TextChanged(object sender, EventArgs e)
        {
            if (txt_macabiet.Text != "")
            {
                string chitiet = "";

                var GTTB = new GTTHIETBI_BLL().gtthietbi_danhsach().Where(c => c.MaCaBiet.Equals(txt_macabiet.Text)).SingleOrDefault();
                if (GTTB != null)
                {

                    var TB = new SOTHEODOI_BLL().sotheodoi_chitietthietbi(GTTB.GTThietBiID.ToString());

                    if (TB != null)
                    {
                        txt_tenthietbi.Tag = TB.GTThietBiID.ToString();
                        txt_tenthietbi.Text = TB.GTTHIETBI.THIETBI.TenThietBi;

                        chitiet = "Mã thiết bị: " + TB.GTTHIETBI.THIETBI.MaThietBi + Environment.NewLine + "Số hiệu:" + TB.GTTHIETBI.THIETBI.SoHieu + Environment.NewLine + "Tên:" + TB.GTTHIETBI.THIETBI.TenThietBi;
                    }
                    else
                    {
                        txt_tenthietbi.Text = "[Không có thiết bị mang mã này]";
                        txt_tenthietbi.Tag = null;
                    }
                    toolTip1.SetToolTip(txt_tenthietbi, chitiet);
                }
            }
            else
            {
                txt_tenthietbi.Tag = null;
                txt_tenthietbi.Text = "";
            }
        }

        private void btn_kichthuockhung_Click(object sender, EventArgs e)
        {
            if (expandableSplitter1.Expanded == false)
            {
                expandableSplitter1.Expanded = true;
                btn_kichthuockhung.Image = Properties.Resources.top;
            }
            else
            {
                expandableSplitter1.Expanded = false;
                btn_kichthuockhung.Image = Properties.Resources.down;
            }
        }

        private void context_menu_xemchitiet_Click(object sender, EventArgs e)
        {
            frm_thietbi_thongtinchitiet frm = new frm_thietbi_thongtinchitiet(lv_thietbi.SelectedItems [0].SubItems[3].Text);
            frm.ShowDialog();
        }

        private void lv_thietbi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        //
        #endregion
    }
}
/*
 * Xử lý xong nghiệp vụ bàn giao (luân chuyển) thiết bị
 */