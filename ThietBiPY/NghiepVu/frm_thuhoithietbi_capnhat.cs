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
using ThietBiPY.DanhMuc.thongtinthietbi;
using ThietBiPY.NghiepVu.capnhatphu;

using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.NghiepVu
{
    public partial class frm_thuhoithietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_thuhoithietbi_capnhat()
        {
            InitializeComponent();
            lv_thietbithuhoi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbithuhoi.Columns.Add("Mã thiết bị", 100);
            lv_thietbithuhoi.Columns.Add("Số hiệu", 100);
            lv_thietbithuhoi.Columns.Add("Tên thiết bị", 200);
            lv_thietbithuhoi.Columns.Add("Đơn vị tính", 100);
            lv_thietbithuhoi.Columns.Add("Số lượng", 100);
            lv_thietbithuhoi.Columns.Add("Hiện trạng", 200);

            danhmuc_donvithuhoi("0");
            cbo_donvithuhoi_SelectedIndexChanged(null, null);
            danhmuc_donvibithuhoi("0");
            cbo_donvibithuhoi_SelectedIndexChanged(null, null);
            danhmuc_lidothuhoi("0");
            danhmuc_mathietbi();
        }
        public frm_thuhoithietbi_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var THUHOI = new PHIEUTHUHOI_BLL().phieuthuhoi_thongtin(ma);

            this.Text = "Hiệu chỉnh chứng từ thu hồi: ID=" + ma + "-Ngày thu hồi:" + THUHOI.NgayThuHoi.Value.Year.ToString("dd/MM/yyyy");
            lv_thietbithuhoi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbithuhoi.Columns.Add("Mã thiết bị", 100);
            lv_thietbithuhoi.Columns.Add("Số hiệu", 100);
            lv_thietbithuhoi.Columns.Add("Tên thiết bị", 200);
            lv_thietbithuhoi.Columns.Add("Đơn vị tính", 100);
            lv_thietbithuhoi.Columns.Add("Số lượng", 100);
            lv_thietbithuhoi.Columns.Add("Hiện trạng", 200);

            if (THUHOI.NgayVanBan != null) dtp_ngayvanban.Value = THUHOI.NgayVanBan.Value.Date;
            txt_sovanban.Text = THUHOI.SoVanBan;
            if (THUHOI.NgayThuHoi != null) dtp_ngaythuhoi.Value = THUHOI.NgayThuHoi.Value.Date;
            txt_thamquyenqd.Text = THUHOI.ThamQuyenQD;

            danhmuc_donvithuhoi(THUHOI.DonViThuHoi.ToString());
            cbo_donvithuhoi_SelectedIndexChanged(null, null);
            cbo_daidienthuhoi.SelectedValue = THUHOI.DaiDienThuHoi;

            danhmuc_donvibithuhoi(THUHOI.DonViSuDung .ToString());
            cbo_donvibithuhoi_SelectedIndexChanged(null, null);
            cbo_bophanbithuhoi.SelectedValue = THUHOI.BoPhanSuDung;

            danhmuc_lidothuhoi(THUHOI.LiDoThuHoi.ToString());
            txt_ghichuthem.Text = THUHOI.GhiChu;
            danhmuc_mathietbi();

            LST_DACHON = new CTTHUHOI_BLL().ctthuhoi_danhsach(ma).ToList();
            ListViewItem item = null;
            int dem=0;
            foreach (var TB in LST_DACHON)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = TB.ThietBiID.ToString();
                lv_thietbithuhoi.Items.Add(item);
                item.SubItems.Add(TB.THIETBI.MaThietBi);
                item.SubItems.Add(TB.THIETBI.SoHieu);
                item.SubItems.Add(TB.THIETBI.TenThietBi);
                item.SubItems.Add(TB.THIETBI.DVTID != 0 ? TB.THIETBI.DONVITINH.TenDVT : "");
                item.SubItems.Add(TB.SoLuong.ToString());
                item.SubItems.Add(TB.HienTrang);

                for (int cot = 0; cot < lv_thietbithuhoi.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_thietbithuhoi.Items.Count.ToString();
        }

        #region "Phần biên bản thu hồi"
        //
        private void dtp_ngayvanban_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001)) txt_sovanban.Text = "THUHOI" + dtp_ngayvanban.Value.Date.ToString("ddMMyyyy");
        }
        public void danhmuc_donvithuhoi(string giatri)
        {
            BindingSource binding_donvithuhoi = new BindingSource();
            binding_donvithuhoi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvithuhoi.Add(new DONVI { DonViID = 0, TenDonVi = "[Chưa xác định hoặc không có]", DienThoai = "", DienGiai = "" });
            cbo_donvithuhoi.DataSource = binding_donvithuhoi;
            cbo_donvithuhoi.ValueMember = "DonViID";
            cbo_donvithuhoi.DisplayMember = "TenDonVi";

            if (binding_donvithuhoi.Count > 0)
            {
                if (giatri != "")
                {
                    cbo_donvithuhoi.SelectedValue = int.Parse(giatri);
                }
                else cbo_donvithuhoi.SelectedIndex = 0;
                cbo_donvithuhoi.SelectedIndexChanged += new EventHandler(cbo_donvithuhoi_SelectedIndexChanged);
            }
        }
        private void cbo_donvithuhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhmuc_daidienthuhoi("0");
        }
        private void btn_lamtuoi_donvithuhoi_Click(object sender, EventArgs e)
        {
            danhmuc_daidienthuhoi("");
        }
        
        public void danhmuc_daidienthuhoi(string giatri)
        {
            BindingSource binding_daidienthuhoi = new BindingSource();
            binding_daidienthuhoi.DataSource = new NHANVIEN_BLL().nhanvien_danhsach().Where(c => c.DonViID == (int)cbo_donvithuhoi.SelectedValue).Select(c => new
            {
                NhanVienID = c.NhanVienID,
                MaNV = c.MaNV,
                HoTen = c.HoNV + " " + c.TenNV,
            }).ToList();
            binding_daidienthuhoi.Add(new { NhanVienID = (Int64)0, MaNV = "00000", HoTen = "[Chưa xác định hoặc không có]" });
            cbo_daidienthuhoi.DataSource = binding_daidienthuhoi;
            cbo_daidienthuhoi.DisplayMembers = "MaNV,HoTen";



            cbo_daidienthuhoi.ValueMember = "NhanVienID";

            if (giatri != "")
            {
                cbo_daidienthuhoi.SelectedValue = Int64.Parse(giatri);
            }
        }
        private void btn_them_nguoithuchien_Click(object sender, EventArgs e)
        {
            DanhMuc.frm_nhanvien_capnhat frm = new ThietBiPY.DanhMuc.frm_nhanvien_capnhat((int)cbo_donvithuhoi.SelectedValue);
            frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_capnhat.passData(danhmuc_daidienthuhoi);
            frm.ShowDialog();
        }
        private void btn_lamtuoi_nguoithuchien_Click(object sender, EventArgs e)
        {
            cbo_donvithuhoi_SelectedIndexChanged(null, null);
        }
        
        //
        public void danhmuc_donvibithuhoi(string giatri)
        {
            BindingSource binding_donvibithuhoi = new BindingSource();
            binding_donvibithuhoi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvibithuhoi.Add(new DONVI { DonViID = 0, TenDonVi = "[Chưa xác định hoặc không có]", DienThoai = "", DienGiai = "" });
            cbo_donvibithuhoi.DataSource = binding_donvibithuhoi;
            cbo_donvibithuhoi.ValueMember = "DonViID";
            cbo_donvibithuhoi.DisplayMember = "TenDonVi";

            if (binding_donvibithuhoi.Count > 0)
            {
                if (giatri != "")
                {
                    cbo_donvibithuhoi.SelectedValue = int.Parse(giatri);
                }
                else cbo_donvibithuhoi.SelectedIndex = 0;
                cbo_donvibithuhoi.SelectedIndexChanged += new EventHandler(cbo_donvibithuhoi_SelectedIndexChanged);
            }
        }
        private void cbo_donvibithuhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            danhmuc_bophanbithuhoi("0");
        }
        
        public void danhmuc_bophanbithuhoi(string giatri)
        {
            BindingSource binding_bophanbithuhoi = new BindingSource();
            binding_bophanbithuhoi.DataSource = new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == (int)cbo_donvithuhoi.SelectedValue).Select(c => new
            {
                BoPhanID = c.BoPhanID,
                TenBoPhan = c.TenBoPhan,
            }).ToList();
            binding_bophanbithuhoi.Add(new { BoPhanID = 0, TenBoPhan = "[Chưa xác định hoặc không có]" });
            cbo_bophanbithuhoi.DataSource = binding_bophanbithuhoi;
            cbo_bophanbithuhoi.DisplayMember = "TenBoPhan";
            cbo_bophanbithuhoi.ValueMember = "BoPhanID";

            if (giatri != "")
            {
                cbo_bophanbithuhoi.SelectedValue = int.Parse(giatri);
            }
            else cbo_bophanbithuhoi.SelectedIndex = 0;
        }
        private void btn_lamtuoi_donvibithuhoi_Click(object sender, EventArgs e)
        {
            danhmuc_donvibithuhoi("");
        }
        private void btn_lamtuoi_bophanbithuhoi_Click(object sender, EventArgs e)
        {
            cbo_donvibithuhoi_SelectedIndexChanged(null, null);
        }

        //
        public void danhmuc_lidothuhoi(string giatri)
        {
            BindingSource binding_lidothuhoi = new BindingSource();
            binding_lidothuhoi.DataSource = new TINHTRANG_BLL().tinhtrang_danhsach().ToList();
            binding_lidothuhoi.Add(new TINHTRANG { TinhTrangID = 0, TenTinhTrang = "[Cập nhật sau]", DienGiai = "" });
            cbo_lidothuhoi.DataSource = binding_lidothuhoi;
            cbo_lidothuhoi.ValueMember = "TinhTrangID";
            cbo_lidothuhoi.DisplayMember = "TenTinhTrang";

            if (binding_lidothuhoi.Count > 0)
            {
                if (giatri != "")
                {
                    cbo_lidothuhoi.SelectedValue = int.Parse(giatri);
                }
                else cbo_lidothuhoi.SelectedIndex = 0;
            }
        }
        private void btn_lamtuoi_lidothuhoi_Click(object sender, EventArgs e)
        {
            danhmuc_lidothuhoi("");
        }
        private void btn_them_lidothuhoi_Click(object sender, EventArgs e)
        {
            frm_tinhtrangthietbi_capnhat frm = new frm_tinhtrangthietbi_capnhat();
            frm.DuLieu = new frm_tinhtrangthietbi_capnhat.passData(danhmuc_lidothuhoi);
            frm.ShowDialog();
        }
        #endregion

        #region "Phần kê khai chi tiết"
        List<CTTHUHOI> LST_DACHON = new List<CTTHUHOI>();

        //Xử lý
        public void danhmuc_mathietbi()
        {
            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
            foreach (var str in new THIETBI_BLL().thietbi_danhsach().Skip(0).Take(10).Select(c => new { MaThietBi = c.MaThietBi }))
            {
                Str_Col.Add(str.MaThietBi);
            }
            txt_mathietbi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_mathietbi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_mathietbi.AutoCompleteCustomSource = Str_Col;
        }
        public void themthietbivaodanhsach(string ThietBiID)
        {
            var TB_KIEMTRA = LST_DACHON.SingleOrDefault(c => c.ThietBiID == Int64.Parse(ThietBiID));

            if (TB_KIEMTRA == null)
            {
                var TB = new THIETBI_BLL().thietbi_thongtin(ThietBiID);

                if (ma == "")
                {
                    LST_DACHON.Add(new CTTHUHOI
                    {
                        ThietBiID = TB.ThietBiID,
                        SoLuong = (Int16)input_soluongthuhoi.Value,
                        HienTrang = txt_hientrang.Text,
                    });
                }
                else
                {
                    LST_DACHON.Add(new CTTHUHOI
                    {
                        ThuHoiID = int.Parse (ma),
                        ThietBiID = TB.ThietBiID,
                        SoLuong = (Int16)input_soluongthuhoi.Value,
                        HienTrang = txt_hientrang.Text,
                    });
                }
                ListViewItem item = new ListViewItem((lv_thietbithuhoi.Items.Count + 1).ToString());
                item.Tag = TB.ThietBiID.ToString();
                lv_thietbithuhoi.Items.Add(item);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.DVTID != 0 ? TB.DONVITINH.TenDVT : "");
                item.SubItems.Add(input_soluongthuhoi.Value.ToString());
                item.SubItems.Add(txt_hientrang.Text);

                for (int cot = 0; cot < lv_thietbithuhoi.Columns.Count; cot++)
                {
                    if (lv_thietbithuhoi.Items.Count % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            else
            {
                TB_KIEMTRA.SoLuong += (Int16)input_soluongthuhoi.Value;
                TB_KIEMTRA.HienTrang = txt_hientrang.Text;
                foreach (ListViewItem item in lv_thietbithuhoi.Items)
                {
                    if (item.Tag.ToString() == ThietBiID)
                    {
                        item.SubItems [5].Text =TB_KIEMTRA.SoLuong .ToString ();
                        item .SubItems [6].Text =TB_KIEMTRA.HienTrang;
                    }
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_thietbithuhoi.Items.Count.ToString();
        }

        private void loaibokhoidanhsach()
        {
            var TB = LST_DACHON.Single(c => c.ThietBiID == Int64.Parse(lv_thietbithuhoi.SelectedItems [0].Tag .ToString()));
            if (ma == "")LST_DACHON.Remove(TB);
            else TB.ThuHoiID = 0;

            ListViewItem item = lv_thietbithuhoi.SelectedItems[0];
            lv_thietbithuhoi.Items.Remove(item);
            lbl_thongke.Text = "Tổng số: " + lv_thietbithuhoi.Items.Count.ToString();
        }
        public void capnhatsoluong_hientrang(string soluong, string hientrang)
        {
            ListViewItem item = lv_thietbithuhoi.SelectedItems [0];
            var TB = LST_DACHON.Single(c => c.ThietBiID == Int64.Parse(item.Tag.ToString()));
            TB.SoLuong = Int16.Parse(soluong);
            TB.HienTrang = hientrang;
            item.SubItems[5].Text = soluong;
            item.SubItems[6].Text = hientrang;
        }

        //
        private void contextmenu_dieukhien_capnhat_Click(object sender, EventArgs e)
        {
            var TB = LST_DACHON.Single(c => c.ThietBiID == Int64.Parse(lv_thietbithuhoi.SelectedItems[0].Tag.ToString()));
            frm_thuhoithietbi_capnhatsl_ht frm = new frm_thuhoithietbi_capnhatsl_ht(TB.SoLuong.ToString(), TB.HienTrang);
            frm.DuLieu = new frm_thuhoithietbi_capnhatsl_ht.passData(capnhatsoluong_hientrang);
            frm.ShowDialog();
        }
        private void contextmenu_dieukhien_loaibo_Click(object sender, EventArgs e)
        {
            loaibokhoidanhsach();
        }

        private void txt_mathietbi_Validated(object sender, EventArgs e)
        {
            string chitiet = "";
            if (txt_mathietbi.Text != "")
            {
                var TB = new THIETBI_BLL().thietbi_danhsach().SingleOrDefault(c => c.MaThietBi.Equals(txt_mathietbi.Text.Trim()));
                if (TB != null)
                {
                    txt_tenthietbi.Tag = TB.ThietBiID.ToString();
                    txt_tenthietbi.Text = TB.TenThietBi;
                    chitiet = "Mã thiết bị: " + TB.MaThietBi + Environment.NewLine + "Số hiệu: " + TB.SoHieu + Environment.NewLine;
                    chitiet += "Tên thiết bị: " + TB.TenThietBi + Environment.NewLine;
                    chitiet += "Nước SX: " + (TB.NuocSX != 0 ? TB.NUOC.TenNuoc : "[cập nhật sau]") + Environment.NewLine;
                    toolTip1.SetToolTip(txt_tenthietbi, chitiet);
                }
                else
                {
                    txt_tenthietbi.Tag = null;
                    txt_tenthietbi.Text = "[không có thiết bị này]";
                }
            }
            else
            {
                txt_tenthietbi.Tag = null;
                txt_tenthietbi.Text = "";
            }
        }
        private void btn_danhsachchon_thietbi_Click(object sender, EventArgs e)
        {
            List<string> lst_dachon = new List<string>();
            if (ma == "")
            {
                foreach (var TB in LST_DACHON)
                {
                    lst_dachon.Add(TB.ThietBiID.ToString());
                }
            }
            else
            {
                foreach (var TB in LST_DACHON.Where(c => c.ThuHoiID != 0).ToList())
                {
                    lst_dachon.Add(TB.ThietBiID.ToString());
                }
            }
            DanhMuc.frm_thietbi_dschon frm = new ThietBiPY.DanhMuc.frm_thietbi_dschon(lst_dachon);
            frm.DuLieu = new ThietBiPY.DanhMuc.frm_thietbi_dschon.passData(themthietbivaodanhsach);
            frm.ShowDialog();
        }
        private void btn_themvaodanhsach_Click(object sender, EventArgs e)
        {
           DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
           if (txt_tenthietbi.Tag != null) themthietbivaodanhsach(txt_tenthietbi.Tag.ToString());
           else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn thiết bị!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void lv_thietbithuhoi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thietbithuhoi.SelectedItems.Count > 0)
            {
                lv_thietbithuhoi.ContextMenuStrip = contextmenu_dieukhien;
            }
            else lv_thietbithuhoi.ContextMenuStrip = null;
        }
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri) { if (DuLieu != null)DuLieu(giatri); }

        private void btn_luulai_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (dtp_ngaythuhoi.Value == new DateTime(01, 01, 0001))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập ngày thu hồi!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtp_ngaythuhoi.Focus();
            }
            else
            {
                PHIEUTHUHOI_BLL PHIEUTHUHOI = new PHIEUTHUHOI_BLL();
                PHIEUTHUHOI.THUHOI_DTO.SoVanBan = txt_sovanban.Text;
                if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001)) PHIEUTHUHOI.THUHOI_DTO.NgayVanBan = dtp_ngayvanban.Value.Date;
                if (dtp_ngaythuhoi.Value != new DateTime(01, 01, 0001)) PHIEUTHUHOI.THUHOI_DTO.NgayThuHoi = dtp_ngaythuhoi.Value.Date;
                PHIEUTHUHOI.THUHOI_DTO.ThamQuyenQD = txt_thamquyenqd.Text;

                PHIEUTHUHOI.THUHOI_DTO.DonViThuHoi = (int)cbo_donvithuhoi.SelectedValue;
                PHIEUTHUHOI.THUHOI_DTO.DaiDienThuHoi = (Int64)cbo_daidienthuhoi.SelectedValue;
                PHIEUTHUHOI.THUHOI_DTO.DonViSuDung = (int)cbo_donvibithuhoi.SelectedValue;
                PHIEUTHUHOI.THUHOI_DTO.BoPhanSuDung = (int)cbo_bophanbithuhoi.SelectedValue;
               
                PHIEUTHUHOI.THUHOI_DTO.LiDoThuHoi = (int)cbo_lidothuhoi.SelectedValue;
                PHIEUTHUHOI.THUHOI_DTO.GhiChu = txt_ghichuthem.Text;

                PHIEUTHUHOI.LST_CTTHUHOI = LST_DACHON;

                if (ma == "")
                {
                    if (PHIEUTHUHOI.phieuthuhoi_them() > 0)
                    {
                        guidulieu(PHIEUTHUHOI.THUHOI_DTO.ThuHoiID.ToString());
                        Console.WriteLine("ID: " + PHIEUTHUHOI.THUHOI_DTO.ThuHoiID.ToString());
                        this.Close();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Có lỗi!Vui lòng kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (PHIEUTHUHOI.phieuthuhoi_sua(ma) > 0)
                    {
                        guidulieu(PHIEUTHUHOI.THUHOI_DTO.ThuHoiID.ToString());
                        Console.WriteLine("ID: " + PHIEUTHUHOI.THUHOI_DTO.ThuHoiID.ToString());
                        this.Close();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Có lỗi!Vui lòng kiểm tra lại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void frm_thuhoithietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void frm_thuhoithietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_ghichuthem.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichuthem).OnKeyPress);
            txt_hientrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_hientrang).OnKeyPress);
            txt_thamquyenqd.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thamquyenqd).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
