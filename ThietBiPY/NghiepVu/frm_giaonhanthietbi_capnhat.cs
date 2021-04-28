using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiBLL;
using ThietBiDAL;
using Net.SourceForge.Vietpad.InputMethod;
using ThietBiPY.DanhMuc;
using DevComponents.DotNetBar;

namespace ThietBiPY.NghiepVu
{
    public partial class frm_giaonhanthietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {

        string ma = "";
        List<CTPHIEUNHAP> LST_CTPHIEUNHAP = new List<CTPHIEUNHAP>();

        //quản lý thiết bị đơn vị
        public frm_giaonhanthietbi_capnhat(int DonViID)
        {
            InitializeComponent();
            this.Text = "Nhập thêm thiết bị";

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Thiết bị", 200);
            lv_thietbi.Columns.Add("Mã thiết bị", 150);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("ĐVT", 60);
            lv_thietbi.Columns.Add("Số lượng", 70);
            lv_thietbi.Columns.Add("Đơn giá", 100);
            lv_thietbi.Columns.Add("Thành tiền", 200);

            //
            danhmuc_kieunhapthietbi("2");
            cbo_kieunhapthietbi.Enabled = false;

            danhmuc_nhanviennhan1("0");
            cbo_nhanviennhan1.Enabled = false;
            btn_lamtuoi_nhanviennhan1.Enabled = false;
            btn_danhsachchon_nhanviennhan1.Enabled = false;
            btn_themnhanviennhan1.Enabled = false;

            danhmuc_donvinhan(DonViID.ToString());
            btn_lamtuoi_donvinhan.Enabled = false;
            btn_themdonvinhan.Enabled = false;
            cbo_donvinhan.Enabled = false;

            danhmuc_bophannhan("0");
            danhmuc_nhanviennhan2("0");

            danhmuc_mathietbi();
            danhmuc_tenthietbi();

            dtp_ngaynhap.Value = DateTime.Now.Date;
            //
            btn_danhsachchon_nhacungcap.Click += new EventHandler(btn_danhsachchon_nhacungcap_Click);
            btn_danhsachchon_nhanviennhan1.Click += new EventHandler(btn_danhsachchon_nhanviennhan1_Click);

            btn_themnhanviennhan1.Click += new EventHandler(btn_themnhanviennhan1_Click);
            btn_themnhanviennhan2.Click += new EventHandler(btn_themnhanviennhan2_Click);

            btn_danhsachchon_nhanviennhan2.Click += new EventHandler(btn_danhsachchon_nhanviennhan2_Click);
            btn_themnhacungcap.Click += new EventHandler(btn_themnhacungcap_Click);

            //
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
        }
        public frm_giaonhanthietbi_capnhat(int DonViID,string PhieuNhapID)
        {
            InitializeComponent();
            this.Text = "Hiệu chỉnh nhập thêm thiết bị";
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Thiết bị", 200);
            lv_thietbi.Columns.Add("Mã thiết bị", 150);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("ĐVT", 60);
            lv_thietbi.Columns.Add("Số lượng", 70);
            lv_thietbi.Columns.Add("Đơn giá", 100);
            lv_thietbi.Columns.Add("Thành tiền", 200);

            //
            this.ma = PhieuNhapID;

            var PN = new PHIEUNHAP_BLL().phieunhap_thongtin(PhieuNhapID);
            danhmuc_kieunhapthietbi(PN.KieuNhapTB.ToString());
            cbo_kieunhapthietbi.Enabled = false;

            if (PN.NgayNhap != null) dtp_ngaynhap.Value = PN.NgayNhap.Value.Date;
            if (PN.NgayVanBan != null) dtp_ngayvanban.Value = PN.NgayVanBan.Value.Date;
            txt_sovanban.Text = PN.SoVanBan;

            danhmuc_kieunhapthietbi(PN.NCCID != 0 ? "1" : "2");
            if (PN.KieuNhapTB == (Int16)LopHoTro.KIEUPHIEUNHAP.tunhacungcap) danhmuc_nhacungcap(PN.NCCID.ToString());

            danhmuc_nhanviennhan1(PN.NhanVienNhan1.ToString());
            cbo_nhanviennhan1.Enabled = false;
            btn_lamtuoi_nhanviennhan1.Enabled = false;
            btn_danhsachchon_nhanviennhan1.Enabled = false;
            btn_themnhanviennhan1.Enabled = false;

            danhmuc_donvinhan(PN.DonViNhan.ToString());
            btn_lamtuoi_donvinhan.Enabled = false;
            btn_themdonvinhan.Enabled = false;
            cbo_donvinhan.Enabled = false;

            danhmuc_bophannhan(PN.BoPhanNhan.ToString());
            danhmuc_nhanviennhan2(PN.NhanVienNhan2.ToString());

            danhmuc_mathietbi();
            danhmuc_tenthietbi();

            txt_ghichu.Text = PN.GhiChu;

            LST_CTPHIEUNHAP = new CTPHIEUNHAP_BLL().ctphieunhap_danhsach().Where(c => c.PhieuNhapID == int.Parse(PhieuNhapID)).ToList();

            foreach (var TB in LST_CTPHIEUNHAP)
            {
                ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                item.Tag = TB.ThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.THIETBI.TenThietBi);
                item.SubItems.Add(TB.THIETBI.MaThietBi);
                item.SubItems.Add(TB.THIETBI.SoHieu);
                item.SubItems.Add(TB.THIETBI.DVTID != 0 ? TB.THIETBI.DONVITINH.TenDVT : "Chưa xác định");
                item.SubItems.Add(TB.SoLuong.ToString());
                item.SubItems.Add(string.Format("{0:0,0}", TB.DonGia) + " đ");
                item.SubItems.Add(string.Format("{0:0,0}", ((decimal)TB.SoLuong * TB.DonGia)) + " đ");

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if ((lv_thietbi.Items.Count + 1) % 2 == 0) item.SubItems[0].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
            tongthanhtien();

            //Các Event

            btn_danhsachchon_nhacungcap.Click += new EventHandler(btn_danhsachchon_nhacungcap_Click);
            btn_themnhacungcap.Click += new EventHandler(btn_themnhacungcap_Click);

            btn_danhsachchon_nhanviennhan1.Click += new EventHandler(btn_danhsachchon_nhanviennhan1_Click);
            btn_themnhanviennhan1.Click += new EventHandler(btn_themnhanviennhan1_Click);

            btn_themnhanviennhan2.Click += new EventHandler(btn_themnhanviennhan2_Click);
            btn_danhsachchon_nhanviennhan2.Click += new EventHandler(btn_danhsachchon_nhanviennhan2_Click);

            //
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
        }
        
        //quản trị thiết bị
        public frm_giaonhanthietbi_capnhat()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Thiết bị", 200);
            lv_thietbi.Columns.Add("Mã thiết bị", 150);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("ĐVT", 60);
            lv_thietbi.Columns.Add("Số lượng", 70);
            lv_thietbi.Columns.Add("Đơn giá", 100);
            lv_thietbi.Columns.Add("Thành tiền", 200);

            //
            danhmuc_kieunhapthietbi("1");
            danhmuc_nhanviennhan1("0");
            danhmuc_donvinhan("");
            danhmuc_bophannhan("0");
            danhmuc_nhanviennhan2("0");

            danhmuc_mathietbi();
            danhmuc_tenthietbi();
            dtp_ngaynhap.Value = DateTime.Now.Date;
            //
            btn_danhsachchon_nhacungcap.Click += new EventHandler(btn_danhsachchon_nhacungcap_Click);
            btn_danhsachchon_nhanviennhan1.Click += new EventHandler(btn_danhsachchon_nhanviennhan1_Click);
            
            btn_themnhanviennhan1.Click += new EventHandler(btn_themnhanviennhan1_Click);
            btn_themnhanviennhan2.Click += new EventHandler(btn_themnhanviennhan2_Click);

            btn_danhsachchon_nhanviennhan2.Click += new EventHandler(btn_danhsachchon_nhanviennhan2_Click);

            btn_themnhacungcap.Click += new EventHandler(btn_themnhacungcap_Click);
            
            //
            cbo_donvinhan.SelectedIndexChanged+= new EventHandler(cbo_donvinhan_SelectedIndexChanged);
        }
        public frm_giaonhanthietbi_capnhat(string PhieuNhapID)
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Thiết bị", 200);
            lv_thietbi.Columns.Add("Mã thiết bị", 150);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("ĐVT", 60);
            lv_thietbi.Columns.Add("Số lượng", 70);
            lv_thietbi.Columns.Add("Đơn giá", 100);
            lv_thietbi.Columns.Add("Thành tiền", 200);

            //
            this.ma = PhieuNhapID;

            var PN = new PHIEUNHAP_BLL().phieunhap_thongtin(PhieuNhapID);
            danhmuc_kieunhapthietbi(PN.KieuNhapTB.ToString());

            if (PN.NgayNhap != null) dtp_ngaynhap.Value = PN.NgayNhap.Value.Date;
            if (PN.NgayVanBan != null) dtp_ngayvanban.Value = PN.NgayVanBan.Value.Date;
            txt_sovanban.Text = PN.SoVanBan;

            danhmuc_kieunhapthietbi(PN.NCCID != 0 ? "1" : "2");
            if (PN.KieuNhapTB == (Int16)LopHoTro.KIEUPHIEUNHAP.tunhacungcap) danhmuc_nhacungcap(PN.NCCID.ToString());

            danhmuc_nhanviennhan1(PN.NhanVienNhan1.ToString());
            danhmuc_donvinhan(PN.DonViNhan.ToString());
            danhmuc_bophannhan(PN.BoPhanNhan.ToString());
            danhmuc_nhanviennhan2(PN.NhanVienNhan2.ToString());

            danhmuc_mathietbi();
            danhmuc_tenthietbi();

            txt_ghichu.Text = PN.GhiChu;

            LST_CTPHIEUNHAP = new CTPHIEUNHAP_BLL().ctphieunhap_danhsach().Where(c => c.PhieuNhapID== int.Parse(PhieuNhapID)).ToList();

            foreach (var TB in LST_CTPHIEUNHAP)
            {
                ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                item.Tag = TB.ThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.THIETBI.TenThietBi);
                item.SubItems.Add(TB.THIETBI.MaThietBi);
                item.SubItems.Add(TB.THIETBI.SoHieu);
                item.SubItems.Add(TB.THIETBI.DVTID != 0 ? TB.THIETBI.DONVITINH.TenDVT : "Chưa xác định");
                item.SubItems.Add(TB.SoLuong.ToString());
                item.SubItems.Add(string.Format("{0:0,0}", TB.DonGia)+ " đ");
                item.SubItems.Add(string.Format("{0:0,0}", ((decimal)TB.SoLuong * TB.DonGia)) + " đ");

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if ((lv_thietbi.Items.Count + 1) % 2 == 0) item.SubItems[0].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
            tongthanhtien();

            //Các Event

            btn_danhsachchon_nhacungcap.Click += new EventHandler(btn_danhsachchon_nhacungcap_Click);
            btn_themnhacungcap.Click += new EventHandler(btn_themnhacungcap_Click);

            btn_danhsachchon_nhanviennhan1.Click += new EventHandler(btn_danhsachchon_nhanviennhan1_Click);
            btn_themnhanviennhan1.Click += new EventHandler(btn_themnhanviennhan1_Click);
            
            btn_themnhanviennhan2.Click += new EventHandler(btn_themnhanviennhan2_Click);
            btn_danhsachchon_nhanviennhan2.Click += new EventHandler(btn_danhsachchon_nhanviennhan2_Click);

            //
            cbo_donvinhan.SelectedIndexChanged += new EventHandler(cbo_donvinhan_SelectedIndexChanged);
        }

        #region "Danh mục và bảng chọn"
        //
        public void danhmuc_kieunhapthietbi(string giatri)
        {
            cbo_kieunhapthietbi.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG("Từ nhà cung cấp",1),
                new LopHoTro.DOITUONG("Từ nguồn khác",2),
          };
            cbo_kieunhapthietbi.ValueMember = "value";
            cbo_kieunhapthietbi.DisplayMember = "name";
            if (giatri != "")
            {
                cbo_kieunhapthietbi.SelectedValue = int.Parse(giatri);
            }
            else cbo_kieunhapthietbi.SelectedIndex = 0;
            cbo_kieunhapthietbi.SelectedIndexChanged += new EventHandler(cbo_kieunhapthietbi_SelectedIndexChanged);
            cbo_kieunhapthietbi_SelectedIndexChanged(null, null);
        }

        //
        public void danhmuc_nhacungcap(string giatri)
        {
            BindingSource binding_nhacungcap = new BindingSource();
            binding_nhacungcap.DataSource = new NHACUNGCAP_BLL().nhacungcap_danhsach().Select(c => new
            {
                NCCID=c.NCCID ,
                TenNCC=c.TenNCC ,
                DaiDien = c.HoNguoiLH + " " + c.TenNguoiLH ,
            });
            binding_nhacungcap.Add(new { NCCID = 0, TenNCC = "[Chưa xác định hoặc không có]", DaiDien = "[Chưa có]" });

            cbo_nhacungcap.DataSource = binding_nhacungcap;

            if (binding_nhacungcap.Count > 0)
            {
                cbo_nhacungcap.DisplayMembers = "TenNCC,DaiDien";
                cbo_nhacungcap.ValueMember = "NCCID";

                if (giatri != "") cbo_nhacungcap.SelectedValue = int.Parse(giatri);
                else if (binding_nhacungcap.Count > 0) cbo_nhacungcap.SelectedIndex = 0;
            }
            else cbo_bophannhan.DataSource = binding_nhacungcap;
        }
        public void danhmuc_nhanviennhan1(string giatri)
        {
            BindingSource binding_nhanvien = new BindingSource();
            binding_nhanvien.DataSource = new NHANVIEN_BLL().nhanvien_danhsach().Select(c => new
            {
                NhanVienID = c.NhanVienID,
                HoTen = c.HoNV + " " + c.TenNV,
                ChucVu = (c.ChucVuID != 0 ? c.CHUCVU.TenChucVu : "Chưa xác định"),
                DonVi = (c.DonViID != 0 ? c.DONVI.TenDonVi : "Chưa xác định"),
                CapBac = (c.ChucVuID !=0?c.CHUCVU.CapBac:0),
            }).OrderBy (p=>p.CapBac).ToList();

            binding_nhanvien.Add(new
            {
                NhanVienID = (Int64)0,
                HoTen = "[Chưa xác định hoặc không có]",
                ChucVu = "Chưa xác định",
                DonVi = "Chưa xác định",
                CapBac = 0,
            });

            cbo_nhanviennhan1.DataSource = binding_nhanvien;
            cbo_nhanviennhan1.GroupingMembers = "DonVi";
            cbo_nhanviennhan1.ValueMember = "NhanVienID";
            cbo_nhanviennhan1.DisplayMembers = "HoTen,ChucVu";

            if (giatri != "")
            {
                cbo_nhanviennhan1.SelectedValue = Int64.Parse(giatri);
            }
            else if (binding_nhanvien.Count > 0) cbo_nhanviennhan1.SelectedIndex = 0;
        }
        public void danhmuc_nhanviennhan2(string giatri)
        {
            if (cbo_donvinhan.SelectedValue != null)
            {
                BindingSource binding_nhanvien = new BindingSource();
                binding_nhanvien.DataSource = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.DonViID == (int)cbo_donvinhan.SelectedValue).Select(c => new
                {
                    NhanVienID = c.NhanVienID,
                    HoTen = c.HoNV + " " + c.TenNV,
                    ChucVu = (c.ChucVuID != 0 ? c.CHUCVU.TenChucVu : "Chưa xác định"),
                    DonVi = (c.DonViID != 0 ? c.DONVI.TenDonVi : "Chưa xác định"),
                    CapBac = (c.ChucVuID != 0 ? c.CHUCVU.CapBac : 0),
                }).OrderBy(p => p.CapBac).ToList();

                binding_nhanvien.Add(new
                {
                    NhanVienID=(Int64)0,
                    HoTen="[Chưa xác định hoặc không có]",
                    ChucVu = "Chưa xác định",
                    DonVi="Chưa xác định",
                    CapBac=0,
                });
                cbo_nhanviennhan2.DataSource = binding_nhanvien;
                cbo_nhanviennhan2.GroupingMembers = "DonVi";
                cbo_nhanviennhan2.ValueMember = "NhanVienID";
                cbo_nhanviennhan2.DisplayMembers = "HoTen,ChucVu";

                if (giatri != "")
                {
                    cbo_nhanviennhan2.SelectedValue = Int64.Parse(giatri);
                }
                else if (binding_nhanvien.Count > 0) cbo_nhanviennhan2.SelectedIndex = 0;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa xác định đơn vị nhận!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void danhmuc_donvinhan(string giatri)
        {
            BindingSource binding_donvinhan = new BindingSource();
            binding_donvinhan.DataSource = new DONVI_BLL().donvi_danhsach().Select(c=>new {
                DonViID=c.DonViID,
                TenDonVi=c.TenDonVi,
            }).ToList ();
            binding_donvinhan.Add(new { DonViID = 0, TenDonVi = "Chưa xác định" });
            cbo_donvinhan.DataSource = binding_donvinhan;
            cbo_donvinhan.ValueMember = "DonviID";
            cbo_donvinhan.DisplayMember = "TenDonVi";

            if (giatri != "")
            {
                cbo_donvinhan.SelectedValue = int.Parse(giatri);
            }
            else if (binding_donvinhan.Count > 0) cbo_donvinhan.SelectedIndex = 0;
        }
        public void cbo_donvinhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_bophannhan.SelectedIndex >= 0)
            {
                danhmuc_bophannhan("0");
                danhmuc_nhanviennhan2("");
            }
        }
        public void danhmuc_bophannhan(string giatri)
        {
            if (cbo_donvinhan.SelectedValue !=null )
            {
                BindingSource binding_bophannhan = new BindingSource();
                binding_bophannhan.DataSource = new BOPHAN_BLL().bophan_danhsach().Where (c=>c.DonViID==(int)cbo_donvinhan.SelectedValue).Select(c => new
                {
                    BoPhanID = c.BoPhanID,
                    TenBoPhan = c.TenBoPhan,
                }).ToList();

                binding_bophannhan.Add(new { BoPhanID = 0, TenBoPhan = "[Chưa xác định hoặc không có]" });
                cbo_bophannhan.DataSource = binding_bophannhan;
                cbo_bophannhan.ValueMember = "BoPhanID";
                cbo_bophannhan.DisplayMember = "TenBoPhan";


                if (giatri != null)
                {
                    cbo_bophannhan.SelectedValue = int.Parse(giatri);
                }
                else if (binding_bophannhan.Count > 0) cbo_donvinhan.SelectedIndex = 0;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa xác định đơn vị nhận!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //bảng chọn danh mục
        public void bangchondanhmuc(string chon)
        {
            frm_nhanvien_dschon frm_nv = null;
            switch (chon)
            {
                case "nhacungcap":
                    frm_nhacungcap_dschon frm_ncc = new frm_nhacungcap_dschon();
                    frm_ncc.DuLieu = new frm_nhacungcap_dschon.passData(danhmuc_nhacungcap);
                    frm_ncc.ShowDialog();
                    break;

                case "nhanviennhan1":
                    frm_nv = new frm_nhanvien_dschon();
                    frm_nv.DuLieu = new frm_nhanvien_dschon.passData(danhmuc_nhanviennhan1);
                    frm_nv.ShowDialog();
                    break;

                case "nhanviennhan2":
                    frm_nv = new frm_nhanvien_dschon(cbo_donvinhan.SelectedValue.ToString());
                    frm_nv.DuLieu = new frm_nhanvien_dschon.passData(danhmuc_nhanviennhan2);
                    frm_nv.ShowDialog();
                    break;
            }
        }
        private void btn_danhsachchon_nhacungcap_Click(object sender, EventArgs e)
        {
            bangchondanhmuc("nhacungcap");
        }
        private void btn_danhsachchon_nhanviennhan1_Click(object sender, EventArgs e)
        {
            bangchondanhmuc("nhanviennhan1");
        }
        private void btn_danhsachchon_nhanviennhan2_Click(object sender, EventArgs e)
        {
            bangchondanhmuc("nhanviennhan2");
        }

        #endregion

        //thêm danh mục
        private void btn_themnhacungcap_Click(object sender, EventArgs e)
        {
            frm_nhacungcap_capnhat frm = new frm_nhacungcap_capnhat();
            frm.DuLieu = new frm_nhacungcap_capnhat.passData(danhmuc_nhacungcap);
            frm.ShowDialog();
        }
        private void btn_themnhanviennhan1_Click(object sender, EventArgs e)
        {
            frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat();
            frm.DuLieu = new frm_nhanvien_capnhat.passData(danhmuc_nhanviennhan1);
            frm.ShowDialog();
        }
        private void btn_themnhanviennhan2_Click(object sender, EventArgs e)
        {
            frm_nhanvien_capnhat frm = new frm_nhanvien_capnhat((int)cbo_donvinhan.SelectedValue);
            frm.DuLieu = new frm_nhanvien_capnhat.passData(danhmuc_nhanviennhan2);
            frm.ShowDialog();
        }

        //
        private void cbo_kieunhapthietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_kieunhapthietbi.SelectedIndex >=0)
            {
                if ((int)cbo_kieunhapthietbi.SelectedValue == 1)
                {
                    danhmuc_nhacungcap("1");
                    cbo_nhacungcap.Enabled = true;
                    btn_danhsachchon_nhacungcap.Enabled = true;
                    btn_lamtuoi_nhacungcap.Enabled = true;
                    btn_themnhacungcap.Enabled = true;

                    txt_sovanban.Enabled = true;
                    dtp_ngayvanban.Enabled = true;
                }
                else
                {
                    cbo_nhacungcap.Enabled = false;
                    cbo_nhacungcap.Nodes.Clear();
                    btn_danhsachchon_nhacungcap.Enabled = false;
                    btn_lamtuoi_nhacungcap.Enabled = false;
                    btn_themnhacungcap.Enabled = false;

                    // txt_sovanban.Text = ""; txt_sovanban.Enabled = false;
                     dtp_ngayvanban.Value = new DateTime(01,01,0001); dtp_ngayvanban.Enabled = false;
                }
            }
        }

        #region "Hàm xử lý"
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //
        public void capnhatlaithietbi(string giatri)
        {
            var CTPHIEU = LST_CTPHIEUNHAP.Single(c => c.ThietBiID == Int64.Parse(giatri));
            CTPHIEU.SoLuong += (Int16)input_soluong.Value;
            CTPHIEU.DonGia += decimal.Parse(txt_dongia.Text);

            foreach (ListViewItem item in lv_thietbi.Items)
            {
                if (item.Tag.ToString().Contains(giatri))
                {
                    item.SubItems[5].Text = CTPHIEU.SoLuong.ToString();
                    item.SubItems[6].Text = string.Format("{0:0,0}", CTPHIEU.DonGia);
                    item.SubItems[7].Text = string.Format("{0:0,0}", (decimal)CTPHIEU.SoLuong * CTPHIEU.DonGia);
                }
            }
            tongthanhtien();
        }
        public void chonthietbi(string giatri)
        {
            //Dựa vào ID của thiết bị để biết đã nhập thiết bị vào phiếu chưa
            //Nếu tồn tại thì cập nhật số lượng, còn chưa thì thêm mới
            if (txt_dongia.Text != "") txt_dongia.Text = txt_dongia.Text.Replace(".", ",").Replace(" ", "");

            if (LST_CTPHIEUNHAP.SingleOrDefault(c => c.ThietBiID == Int64.Parse(giatri)) != null)
            {
                var CTPHIEU = LST_CTPHIEUNHAP.Single(c => c.ThietBiID == Int64.Parse(giatri));
                CTPHIEU.SoLuong += (Int16)input_soluong.Value;
                CTPHIEU.DonGia += decimal.Parse(txt_dongia.Text);

                foreach (ListViewItem item in lv_thietbi.Items)
                {
                    if (item.Tag.ToString().Contains(giatri))
                    {
                        item.SubItems[5].Text = CTPHIEU.SoLuong.ToString();
                        item.SubItems[6].Text = string.Format("{0:0,0}", CTPHIEU.DonGia) + " đ";
                        item.SubItems[7].Text = string.Format("{0:0,0}", (decimal)CTPHIEU.SoLuong * CTPHIEU.DonGia) + " đ";
                    }
                }
            }
            else 
            {
                if (txt_dongia.Text.Length == 0)
                {
                    errorProvider1.SetError(txt_dongia, "chưa nhập đơn giá mua");
                    txt_dongia.Focus();
                    return;
                }
                errorProvider1.Clear();
                var TB = new THIETBI_BLL().thietbi_thongtin(giatri);

                if (ma == "") //Nếu là thêm mới
                {
                    LST_CTPHIEUNHAP.Add(new CTPHIEUNHAP { ThietBiID = TB.ThietBiID, SoLuong = (Int16)input_soluong.Value, DonGia = decimal.Parse(txt_dongia.Text) });
                }
               //Nếu là cập nhật lại
               else LST_CTPHIEUNHAP.Add(new CTPHIEUNHAP { PhieuNhapID = int.Parse(ma), ThietBiID = TB.ThietBiID, SoLuong = (Int16)input_soluong.Value, DonGia = decimal.Parse(txt_dongia.Text) });
                
                ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                item.Tag = giatri;
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);
                item.SubItems.Add(TB.DVTID != 0 ? TB.DONVITINH.TenDVT : "Chưa xác định");
                item.SubItems.Add(input_soluong.Value.ToString());
                item.SubItems.Add(string.Format("{0:0,0}", decimal.Parse(txt_dongia.Text)));
                item.SubItems.Add(string.Format("{0:0,0}", ((decimal)input_soluong.Value * decimal.Parse(txt_dongia.Text))));

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if ((lv_thietbi.Items.Count + 1) % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            txt_mathietbi.Text = ""; txt_tenthietbi.Text = ""; txt_tenthietbi.Tag = null; input_soluong.Value = 1;
            lbl_thongke.Text = "Số lượng: " + lv_thietbi.Items.Count.ToString();
            tongthanhtien();
        }
        public void capnhat_sl_dg_thietbi(string soluong, string dongia)
        {
            ListViewItem lv = lv_thietbi.SelectedItems[0];
            lv.SubItems[5].Text = soluong;
            lv.SubItems[6].Text = string.Format("{0:0,0}", decimal.Parse(dongia));
            lv.SubItems[7].Text = string.Format("{0:0,0}", decimal.Parse(soluong) * decimal.Parse(dongia));

            var TB_SUA = LST_CTPHIEUNHAP.Single(c => c.ThietBiID == Int64.Parse(lv.Tag.ToString()));
            TB_SUA.SoLuong = Int16.Parse(soluong);
            TB_SUA.DonGia = decimal.Parse(dongia);

            tongthanhtien();
        }
        public void tongthanhtien()
        {
            if (LST_CTPHIEUNHAP.Count > 0)
            {
                decimal S = 0;
                LopHoTro.CHUYENKIEU objconvert = new ThietBiPY.LopHoTro.CHUYENKIEU();

                foreach (var CT in LST_CTPHIEUNHAP)
                {
                    S += (decimal)CT.SoLuong * CT.DonGia;
                }
                lbl_tongthanhtien.Text = string.Format("Tổng cộng: {0:0,0}đ (chữ: {1:0})", S, objconvert.DecimalToString (S)); 
            }
            else  lbl_tongthanhtien.Text = "Tổng cộng: 0 đồng";
        }
        //
        
        #endregion

        private void btn_danhsachchonthietbi_Click(object sender, EventArgs e)
        {
            List<string> LST_DACHON = new List<string>();
            foreach (var T in LST_CTPHIEUNHAP)
            {
                LST_DACHON.Add(T.ThietBiID.ToString());
            }
            frm_thietbi_dschon frm = new frm_thietbi_dschon(LST_DACHON);
            frm.DuLieu = new frm_thietbi_dschon.passData(chonthietbi);
            frm.ShowDialog();
        }

        //
        public void nhanthietbi(string giatri)
        {
            if (giatri != "")
            {
                var TB = new THIETBI_BLL().thietbi_thongtin(giatri);
                if (TB != null)
                {
                    txt_mathietbi.Text = TB.MaThietBi;
                    txt_tenthietbi.Text = TB.TenThietBi;
                    txt_tenthietbi.Tag = TB.ThietBiID.ToString();
                }
            }
        }
        private void btn_themthietbi_Click(object sender, EventArgs e)
        {
            DanhMuc.frm_thietbi_capnhat frm = new frm_thietbi_capnhat();
            frm.DuLieu = new frm_thietbi_capnhat.passData(nhanthietbi);
            frm.ShowDialog();
        }

        private void btn_xong_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            if (txt_tenthietbi.Tag != null) chonthietbi(txt_tenthietbi.Tag.ToString());
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn thiết bị!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            if (dtp_ngaynhap.Value.Date == new DateTime(01, 01, 0001))
            {
                dtp_ngaynhap.Focus();
                errorProvider1.SetError(dtp_ngaynhap, "chưa chọn ngày nhập");
            }
            else
            {
                //
                var PHIEUNHAP = new PHIEUNHAP_BLL();

                PHIEUNHAP.PHIEUNHAP_DTO.KieuNhapTB = Int16.Parse(cbo_kieunhapthietbi.SelectedValue.ToString());
                if (dtp_ngaynhap.Value.Date != new DateTime(01, 01, 0001)) PHIEUNHAP.PHIEUNHAP_DTO.NgayNhap = dtp_ngaynhap.Value.Date;
                if (dtp_ngayvanban.Value.Date != new DateTime(01, 01, 0001)) PHIEUNHAP.PHIEUNHAP_DTO.NgayVanBan = dtp_ngayvanban.Value.Date;
                PHIEUNHAP.PHIEUNHAP_DTO.SoVanBan = txt_sovanban.Text;
                PHIEUNHAP.PHIEUNHAP_DTO.ThamQuyenQD = txt_thamquyenqd.Text;
                PHIEUNHAP.PHIEUNHAP_DTO.NCCID = (cbo_nhacungcap.Nodes.Count > 0 ? (int)cbo_nhacungcap.SelectedValue : 0);
                PHIEUNHAP.PHIEUNHAP_DTO.NhanVienNhan1 = (Int64)cbo_nhanviennhan1.SelectedValue;
                PHIEUNHAP.PHIEUNHAP_DTO.DonViNhan = (int)cbo_donvinhan.SelectedValue;
                PHIEUNHAP.PHIEUNHAP_DTO.BoPhanNhan = (int)cbo_bophannhan.SelectedValue;
                PHIEUNHAP.PHIEUNHAP_DTO.NhanVienNhan2 = (Int64)cbo_nhanviennhan2.SelectedValue;

                PHIEUNHAP.PHIEUNHAP_DTO.GhiChu = txt_ghichu.Text;

                PHIEUNHAP.LST_CTPHIEUNHAP = LST_CTPHIEUNHAP;

                if (ma == "")
                {
                    if (PHIEUNHAP.phieunhap_them() > 0)
                    {
                        guidulieu(PHIEUNHAP.PHIEUNHAP_DTO.PhieuNhapID.ToString());
                        this.Close();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Lỗi!Vui lòng thử lại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (PHIEUNHAP.phieunhap_sua(ma) > 0)
                    {
                        guidulieu(PHIEUNHAP.PHIEUNHAP_DTO.PhieuNhapID.ToString());
                        this.Close();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Lỗi!Vui lòng thử lại", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        private void contextmenu_thietbi_hieuchinh_Click(object sender, EventArgs e)
        {
            var TB = LST_CTPHIEUNHAP.Single(c => c.ThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString()));
            capnhatphu.frm_giaonhanthietbi_capnhatsl_dg frm = new ThietBiPY.NghiepVu.capnhatphu.frm_giaonhanthietbi_capnhatsl_dg(TB.SoLuong.ToString(), TB.DonGia.ToString());
            frm.DuLieu = new ThietBiPY.NghiepVu.capnhatphu.frm_giaonhanthietbi_capnhatsl_dg.passData(capnhat_sl_dg_thietbi );
            frm.ShowDialog();
        }
        private void contextmenu_thietbi_xoadong_Click(object sender, EventArgs e)
        {
            var TB = LST_CTPHIEUNHAP.Single(c => c.ThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString()));
            if (ma != "") //Nếu là cập nhật
            {
                TB.PhieuNhapID = 0;
            }
                //Nếu là đang thêm mới
            else LST_CTPHIEUNHAP.Remove(TB);
            ListViewItem lv = lv_thietbi.SelectedItems[0];
            lv_thietbi.Items.Remove(lv);
        }

        //
        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            contextmenu_thietbi_hieuchinh_Click(null, null);
        }
        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (lv_thietbi.SelectedItems.Count > 0)
            {
                lv_thietbi.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_thietbi.ContextMenuStrip = null;
        }

        //
        private void frm_giaonhanthietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_thamquyenqd.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thamquyenqd).OnKeyPress);
            txt_ghichu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichu).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void frm_giaonhanthietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }

        private void btn_lamtuoi_nhacungcap_Click(object sender, EventArgs e)
        {
            danhmuc_nhacungcap("");
        }

        private void btn_lamtuoi_donvinhan_Click(object sender, EventArgs e)
        {
            danhmuc_donvinhan("");
        }
        private void btn_themdonvinhan_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtindonvi.frm_donvi_capnhat frm = new ThietBiPY.DanhMuc.thongtindonvi.frm_donvi_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtindonvi.frm_donvi_capnhat.passData(danhmuc_donvinhan);
            frm.ShowDialog();
        }

        private void btn_lamtuoi_bophannhan_Click(object sender, EventArgs e)
        {
            danhmuc_bophannhan("");
        }
        private void btn_thembophannhan_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtindonvi.frm_bophan_capnhat frm = new ThietBiPY.DanhMuc.thongtindonvi.frm_bophan_capnhat(cbo_donvinhan.SelectedValue.ToString());
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtindonvi.frm_bophan_capnhat.passData(danhmuc_bophannhan);
            frm.ShowDialog();
        }

        private void btn_lamtuoi_nhanviennhan2_Click(object sender, EventArgs e)
        {
            danhmuc_nhanviennhan2("");
        }
        private void btn_lamtuoi_nhanviennhan1_Click(object sender, EventArgs e)
        {
            danhmuc_nhanviennhan1("");
        }

        private void dtp_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            if (ma == "")
            {
                if ((int)cbo_kieunhapthietbi.SelectedValue == (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap)
                {
                    if (dtp_ngaynhap.Value != new DateTime(01, 01, 0001))
                    {
                        dtp_ngayvanban.Value = dtp_ngaynhap.Value;
                    }
                }
                else if ((int)cbo_kieunhapthietbi.SelectedValue == (int)LopHoTro.KIEUPHIEUNHAP.tunguonkhac)
                {
                    txt_sovanban.Text = string.Format("NK-{0}-{1:000}",dtp_ngaynhap.Value.Date.Year, new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c => c.KieuNhapTB == int.Parse(cbo_kieunhapthietbi.SelectedValue.ToString()) && c.NgayNhap.Value.Year == dtp_ngaynhap.Value.Date.Year).Count() + 1);
                }
            }
        }

        private void dtp_ngayvanban_ValueChanged(object sender, EventArgs e)
        {
            if (ma == "")
            {
                if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001))
                {
                    if ((int)cbo_kieunhapthietbi.SelectedValue == (int)LopHoTro.KIEUPHIEUNHAP.tunhacungcap)
                    {
                        txt_sovanban.Text = string.Format("NCC-{0}-{1:000}",dtp_ngayvanban.Value.Date.Year, new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c => c.KieuNhapTB == int.Parse(cbo_kieunhapthietbi.SelectedValue.ToString()) && c.NgayVanBan.Value.Year == dtp_ngayvanban.Value.Year).Count() + 1);
                    }
                }
                else txt_sovanban.Text = "";
            }
        }

        //
        private void danhmuc_mathietbi()
        {
            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
  
            foreach (var str in new THIETBI_BLL().thietbi_danhsach().Skip(0).Take(10).Select(c => c.MaThietBi).ToList())
            {
                Str_Col.Add(str);
            }
            txt_mathietbi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_mathietbi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_mathietbi.AutoCompleteCustomSource = Str_Col;
        }
        private void danhmuc_tenthietbi()
        {
            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
            foreach (var str in new THIETBI_BLL().thietbi_danhsach().Skip(0).Take(50).Select(c => c.TenThietBi).ToList())
            {
                Str_Col.Add(str);
            }
            txt_tenthietbi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_tenthietbi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_tenthietbi.AutoCompleteCustomSource = Str_Col;
        }


        private void btn_kichthuoc_khungnhaplieu_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                splitContainer1.Panel1Collapsed = true;
                btn_kichthuoc_khungnhaplieu.Image = Properties.Resources.down;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                btn_kichthuoc_khungnhaplieu.Image = Properties.Resources.top;
            }
        }
        private void txt_tenthietbi_Validated(object sender, EventArgs e)
        {
            if (txt_tenthietbi.Text != "")
            {
                var TB = new THIETBI_BLL().thietbi_thongtin_timten(txt_tenthietbi.Text.ToUpper());
                if (TB != null)
                {
                    txt_tenthietbi.Tag = TB.ThietBiID.ToString();
                    txt_mathietbi.Text = TB.MaThietBi;
                }
                else { txt_tenthietbi.Tag = null; txt_mathietbi.Text = ""; }
            }
        }
        private void txt_mathietbi_TextChanged(object sender, EventArgs e)
        {
            if (txt_mathietbi.Text != "")
            {
                var TB = new THIETBI_BLL().thietbi_danhsach().SingleOrDefault(c => c.MaThietBi.Equals(txt_mathietbi.Text.Trim()));
                if (TB != null)
                {
                    txt_tenthietbi.Text = TB.TenThietBi;
                    txt_tenthietbi.Tag = TB.ThietBiID.ToString();
                }
                else
                {
                    txt_tenthietbi.Text = "[Không tìm thấy]";
                    txt_tenthietbi.Tag = null;
                }
            }
            else { txt_tenthietbi.Text = ""; txt_tenthietbi.Tag = null; }
        }
        //
        
    }
}

    //Số văn bản : được xác định dựa vào năm và số văn bản có được. Ví dụ:
    //+ Năm 2009: hiện tại đã có 10 văn bản, bây h nếu thêm VB mới thì được tự động tạo là 11