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
using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.NghiepVu
{
    public partial class frm_kiemkethietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_kiemkethietbi_capnhat()
        {
            InitializeComponent();
            lv_thietbi_kiemke.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi_kiemke.Columns.Add("Mã cá biệt", 100);

            lv_thietbi_kiemke.Columns.Add("Tên thiết bị", 200);
            lv_thietbi_kiemke.Columns.Add("Tình trạng", 150);
            lv_thietbi_kiemke.Columns.Add("Hiện trạng", 200);

            lv_daidienkiemke.Columns[0].TextAlign = HorizontalAlignment.Center;

            dtp_ngaykiemke.Value = DateTime.Now.Date;
            danhmuc_manhanvienkiemke();
            danhmuc_donvikiemke("0");
            danhmuc_tinhtrang("0");
            
            cbo_donvikiemke.SelectedIndexChanged += new EventHandler(cbo_donvikiemke_SelectedIndexChanged);
            cbo_donvikiemke_SelectedIndexChanged(null, null);
        }
        public frm_kiemkethietbi_capnhat(string KiemKeID)
        {
            InitializeComponent();
            this.ma = KiemKeID;

            lv_thietbi_kiemke.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi_kiemke.Columns.Add("Mã cá biệt", 100);

            lv_thietbi_kiemke.Columns.Add("Tên thiết bị", 200);
            lv_thietbi_kiemke.Columns.Add("Tình trạng", 150);
            lv_thietbi_kiemke.Columns.Add("Hiện trạng", 200);

            lv_daidienkiemke.Columns[0].TextAlign = HorizontalAlignment.Center;

            var KK = new PHIEUKIEMKE_BLL().phieukiemke_thongtin(ma);

            if (KK.NgayKiemKe != null) dtp_ngaykiemke.Value = KK.NgayKiemKe.Value.Date;
            txt_sovanban.Text = KK.SoVanBan;
            if (KK.NgayVanBan != null) dtp_ngayvanban.Value = KK.NgayVanBan.Value.Date;
            txt_thamquyenqd.Text = KK.ThamQuyenQD;

            danhmuc_manhanvienkiemke();
            danhmuc_donvikiemke(KK.DonViKiemKe.ToString());
            cbo_bophankiemke.SelectedValue = KK.BoPhanKiemKe;
            txt_ghichu.Text = KK.GhiChu;
            LST_DACHON = new CTKIEMKE_BLL().ctkiemke_danhsach(ma).ToList();
            LST_DAIDIENKIEMKE = new DAIDIENKIEMKE_BLL().ddkiemke_danhsach(ma).ToList();

            ListViewItem item = null;
            int dem = 0;
            foreach (var TB in LST_DACHON)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = TB.GTThietBiID.ToString();
                lv_thietbi_kiemke.Items.Add(item);
                item.SubItems.Add(TB.SOTHEODOI.GTTHIETBI.MaCaBiet);
                item.SubItems.Add(TB.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi);
                item.SubItems.Add(TB.TinhTrang1!=0?TB.TINHTRANG2.TenTinhTrang :"Chưa xác định");
                item.SubItems.Add(TB.HienTrang1);
                if (dem % 2 == 0)
                {
                    for (int cot = 0; cot < lv_thietbi_kiemke.Columns.Count; cot++)
                    {
                        item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }

            foreach (var DD in LST_DAIDIENKIEMKE)
            {
                item = new ListViewItem((lv_daidienkiemke.Items.Count + 1).ToString());
                item.Tag = DD.NhanVienID.ToString();
                lv_daidienkiemke.Items.Add(item);
                item.SubItems.Add(DD.NHANVIEN.MaNV);
                item.SubItems.Add(DD.NHANVIEN.HoNV + " " + DD.NHANVIEN.TenNV);
                item.SubItems.Add(DD.QuyenKiemKe);

                for (int cot = 0; cot < lv_daidienkiemke.Columns.Count; cot++)
                {
                    if (lv_daidienkiemke.Items.Count % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }

            danhmuc_tinhtrang("0");
            danhmuc_macabiet();

            cbo_donvikiemke.SelectedIndexChanged += new EventHandler(cbo_donvikiemke_SelectedIndexChanged);
            cbo_donvikiemke_SelectedIndexChanged(null, null);
            cbo_bophankiemke.SelectedValue = KK.BoPhanKiemKe;
        }

        //
        //--- Đơn vị
        private void danhmuc_donvikiemke(string giatri)
        {
            BindingSource binding_donvikiemke = new BindingSource();
            binding_donvikiemke.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvikiemke.Add(new DONVI { DonViID = 0, TenDonVi = "Chưa xác định hoặc không có", DienThoai = "", DienGiai = "" });
            cbo_donvikiemke.DataSource = binding_donvikiemke;
            cbo_donvikiemke.ValueMember = "DonViID";
            cbo_donvikiemke.DisplayMember = "TenDonVi";

            if (giatri == "")
            {
                cbo_donvikiemke.SelectedIndex = 0;
            }
            else
            {
                cbo_donvikiemke.SelectedValue = int.Parse(giatri);
            }
        }
        private void btn_lamtuoi_donvikiemke_Click(object sender, EventArgs e)
        {
            danhmuc_donvikiemke("");
        }
        
        //--- Bộ phận
        private void cbo_donvikiemke_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource binding_bophankiemke = new BindingSource();
            binding_bophankiemke.DataSource = new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == (int)cbo_donvikiemke.SelectedValue).Select (c=>new {
                BoPhanID=c.BoPhanID ,
                TenBoPhan=c.TenBoPhan,
            }).ToList();
            binding_bophankiemke.Add(new{BoPhanID=0,TenBoPhan="Chưa xác định hoặc không có"});
            cbo_bophankiemke.DataSource = binding_bophankiemke;
            cbo_bophankiemke.ValueMember = "BoPhanID";
            cbo_bophankiemke.DisplayMember = "TenBoPhan";
            cbo_bophankiemke.SelectedValue = 0;

            danhmuc_macabiet();
        }
        private void btn_lamtuoi_bophankiemke_Click(object sender, EventArgs e)
        {
            cbo_donvikiemke_SelectedIndexChanged(null, null);
        }
        
        //--- Thiết bị
        private void danhmuc_tinhtrang(string giatri)
        {
            BindingSource binding_tinhtrang = new BindingSource();
            binding_tinhtrang.DataSource = new TINHTRANG_BLL().tinhtrang_danhsach().Select (c=>new {
                TinhTrangID=c.TinhTrangID,
                TenTinhTrang=c.TenTinhTrang,
            });
            binding_tinhtrang.Add(new { TinhTrangID = 0, TenTinhTrang = "Chưa xác định" });
            cbo_tinhtrang.DataSource = binding_tinhtrang;
            cbo_tinhtrang.ValueMember = "TinhTrangID";
            cbo_tinhtrang.DisplayMember = "TenTinhTrang";

            if (giatri != "")
            {
                cbo_tinhtrang.SelectedValue = int.Parse(giatri);
            }
            else cbo_tinhtrang.SelectedIndex = 0;
        }
        private void danhmuc_macabiet()
        {
            if (cbo_donvikiemke.SelectedIndex >= 0)
            {
                AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
                var TB = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == int.Parse(cbo_donvikiemke.SelectedValue.ToString())).Select(c => c.GTTHIETBI.MaCaBiet).ToList();

                foreach (var str in TB)
                {
                    Str_Col.Add(str.ToString());
                }
                txt_macabiet.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_macabiet.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_macabiet.AutoCompleteCustomSource = Str_Col;
            }
        }

        //
        #region "Đại diện kiểm kê"
        List<DAIDIENKIEMKE> LST_DAIDIENKIEMKE = new List<DAIDIENKIEMKE>();
        //
        public void danhmuc_manhanvienkiemke()
        {
            AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();

            foreach (var str in new NHANVIEN_BLL().nhanvien_danhsach().Skip(0).Take(10).Select(c => c.MaNV))
            {
                Str_Col.Add(str);
            }
            txt_ma_nhanvienkiemke.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_ma_nhanvienkiemke.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_ma_nhanvienkiemke.AutoCompleteCustomSource = Str_Col;
        }
        public void danhmuc_nhanvienkiemke(string giatri)
        {
            string chitiet = "";
            if (giatri != "")
            {
                var NV = new NHANVIEN_BLL().nhanvien_thongtin(giatri);
                txt_ma_nhanvienkiemke.Text = NV.MaNV;
                txt_hoten_nhanvienkiemke.Text = NV.HoNV + " " + NV.TenNV;
                txt_hoten_nhanvienkiemke.Tag = NV.NhanVienID.ToString();


                chitiet += "Đơn vị: " + (NV.DonViID != 0 ? NV.DONVI.TenDonVi : "[chưa cập nhật]") + Environment.NewLine;
                chitiet += "Chức vụ: " + (NV.ChucVuID != 0 ? NV.CHUCVU.TenChucVu : "[chưa cập nhật]") + Environment.NewLine;
                chitiet += "Điện thoại: " + NV.DienThoai;
                toolTip1.SetToolTip(txt_hoten_nhanvienkiemke, chitiet);
            }
            else
            {
                toolTip1.SetToolTip(txt_hoten_nhanvienkiemke, chitiet);
                txt_hoten_nhanvienkiemke.Tag = "0";
            }
        }
        public void xuly_nhanvienkiemke(string yc)
        {
            switch (yc)
            {
                case "danhsach":
                    DanhMuc.frm_nhanvien_dschon frm = new ThietBiPY.DanhMuc.frm_nhanvien_dschon();
                    frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_dschon.passData(danhmuc_nhanvienkiemke);
                    frm.ShowDialog();
                    break;

                case "lamtuoi":
                    danhmuc_nhanvienkiemke(txt_hoten_nhanvienkiemke.Tag.ToString());
                    break;
            }
        }

        private void txt_ma_nhanvienkiemke_Validated(object sender, EventArgs e)
        {
            string chitiet = "";
            var NV = new NHANVIEN_BLL().nhanvien_danhsach().SingleOrDefault(c => c.MaNV.Equals(txt_ma_nhanvienkiemke.Text.Trim()));
            if (NV != null)
            {
                txt_hoten_nhanvienkiemke.Text = NV.HoNV + " " + NV.TenNV;
                txt_hoten_nhanvienkiemke.Tag = NV.NhanVienID.ToString();

                chitiet += "Đơn vị: " + (NV.DonViID != 0 ? NV.DONVI.TenDonVi : "[chưa cập nhật]") + Environment.NewLine;
                chitiet += "Chức vụ: " + (NV.ChucVuID != 0 ? NV.CHUCVU.TenChucVu : "[chưa cập nhật]") + Environment.NewLine;
                chitiet += "Điện thoại: " + NV.DienThoai;
                toolTip1.SetToolTip(txt_hoten_nhanvienkiemke, chitiet);
            }
            else
            {
                txt_hoten_nhanvienkiemke.Text = "[không có nhân viên này]";
                txt_hoten_nhanvienkiemke.Tag = "0";
                toolTip1.SetToolTip(txt_hoten_nhanvienkiemke, chitiet);
            }
        }

        private void btn_danhsach_nhanvien_Click(object sender, EventArgs e)
        {
            xuly_nhanvienkiemke("danhsach");
        }
        private void btn_lamtuoi_nhanvienkiemke_Click(object sender, EventArgs e)
        {
            xuly_nhanvienkiemke("lamtuoi");
        }

        //
        private void btn_duavao_danhsachnhanvienkiemke_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_hoten_nhanvienkiemke.Tag.ToString() != "0")
            {
                var DD = new NHANVIEN_BLL().nhanvien_thongtin(txt_hoten_nhanvienkiemke.Tag.ToString());

                if (ma == "")
                {
                    LST_DAIDIENKIEMKE.Add(new DAIDIENKIEMKE
                    {
                        NhanVienID = DD.NhanVienID,
                        QuyenKiemKe = cbo_quyenkiemke.Text,
                    });
                }
                else
                {
                    LST_DAIDIENKIEMKE.Add(new DAIDIENKIEMKE
                    {
                        KiemKeID = int.Parse(ma),
                        NhanVienID = DD.NhanVienID,
                        QuyenKiemKe = cbo_quyenkiemke.Text,
                    });
                }
                ListViewItem item = new ListViewItem((lv_daidienkiemke.Items.Count + 1).ToString());
                item.Tag = DD.NhanVienID.ToString();
                lv_daidienkiemke.Items.Add(item);
                item.SubItems.Add(DD.MaNV);
                item.SubItems.Add(DD.HoNV + " " + DD.TenNV);
                item.SubItems.Add(cbo_quyenkiemke.Text);
            }
        }
        private void contextmenu_daidienkiemke_loaibo_Click(object sender, EventArgs e)
        {
            var DD = LST_DAIDIENKIEMKE.Single(c => c.NhanVienID == Int64.Parse(lv_daidienkiemke.SelectedItems[0].Tag.ToString()));
            if (ma == "")
            {
                if (LST_DAIDIENKIEMKE.Remove(DD) == true)
                {
                    lv_daidienkiemke.Items.Remove(lv_daidienkiemke.SelectedItems[0]);
                }
            }
            else
            {
                DD.KiemKeID = 0;
                lv_daidienkiemke.Items.Remove(lv_daidienkiemke.SelectedItems[0]);
            }
        }

        private void contextmenu_daidienkiemke_capnhatlai_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_daidienkiemke.SelectedItems[0];
            string quyenkiemke = item.SubItems[3].Text;
            if (new LopHoTro.INPUTBOX().InputBox("Cập nhật lại", "Quyền kiểm kê",ref quyenkiemke) == DialogResult.OK)
            {
                item.SubItems[3].Text = quyenkiemke;
            }
        }
        
        #endregion

        //
        public List<CTKIEMKE> LST_DACHON = new List<CTKIEMKE>();

        public void chonthietbi(string giatri)
        {
            var TB = new SOTHEODOI_BLL().sotheodoi_chitietthietbi(giatri);

            if (ma == "")
            {
                if (LST_DACHON.SingleOrDefault(c => c.GTThietBiID == Int64.Parse(giatri)) == null)
                {
                    LST_DACHON.Add(new CTKIEMKE
                    {
                        GTThietBiID = TB.GTThietBiID,
                        TinhTrang0 = TB.TinhTrang,
                        TinhTrang1 = int.Parse(cbo_tinhtrang.SelectedValue.ToString()),
                        HienTrang0 = TB.HienTrang,
                        HienTrang1 = txt_hientrang.Text,
                    });
                }
            }
            else //Nếu trong quá trình hiệu chỉnh có thêm mới
            {
                LST_DACHON.Add(new CTKIEMKE
                {
                    KiemKeID =int.Parse(ma),
                    GTThietBiID=TB.GTThietBiID,
                    TinhTrang0 =TB.TinhTrang,
                    TinhTrang1 =int.Parse (cbo_tinhtrang.SelectedValue .ToString()),
                    HienTrang0=TB.HienTrang,
                    HienTrang1 = txt_hientrang.Text,
                });
            }

            ListViewItem item = new ListViewItem((lv_thietbi_kiemke.Items.Count + 1).ToString());
            item.Tag = TB.GTThietBiID.ToString();
            lv_thietbi_kiemke.Items.Add(item);
            item.SubItems.Add(TB.GTTHIETBI.MaCaBiet);
            item.SubItems.Add(TB.GTTHIETBI.THIETBI.TenThietBi);
            if (txt_tenthietbi.Tag != null)
            {
                item.SubItems.Add(cbo_tinhtrang.Text);
                item.SubItems.Add(txt_hientrang.Text);
            }
            else
            {
                item.SubItems.Add(TB.TinhTrang != 0 ? TB.TINHTRANG1.TenTinhTrang : "Chưa xác định");
                item.SubItems.Add(TB.HienTrang);
            }
            if (lv_thietbi_kiemke.Items.Count % 2 == 0)
            {
                for (int cot = 0; cot < lv_thietbi_kiemke.Columns.Count; cot++)
                {
                    item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            txt_macabiet.Text = ""; txt_tenthietbi.Text = ""; txt_tenthietbi.Tag = null; cbo_tinhtrang.SelectedValue = 0;
        }

        private void capnhatlai_tt_ht(string TinhTrang, string HienTrang)
        {
            if (TinhTrang != "" || HienTrang != "")
            {
                var TB = LST_DACHON.Single(c => c.GTThietBiID == Int64.Parse(lv_thietbi_kiemke.SelectedItems[0].Tag.ToString()));
                TB.TinhTrang1 = int.Parse(TinhTrang);
                TB.HienTrang1 = HienTrang;

                ListViewItem item = lv_thietbi_kiemke.SelectedItems[0];
                item.SubItems[3].Text =(TinhTrang!="0"? new TINHTRANG_BLL().tinhtrang_thongtin(TinhTrang).TenTinhTrang:"Chưa xác định");
                item.SubItems[4].Text = HienTrang;
            }
        }
        public void loaibo()
        {
            Int64 giatri=Int64.Parse(lv_thietbi_kiemke.SelectedItems [0].Tag.ToString());

            if (ma == "")
            {
                var TB_XOA1 = LST_DACHON.Single(c => c.GTThietBiID == giatri);
                if (LST_DACHON.Remove(TB_XOA1) == true)
                {
                    lv_thietbi_kiemke.Items.Remove(lv_thietbi_kiemke.SelectedItems[0]);
                }
            }
            else
            {
                var TB_XOA2 = LST_DACHON.Single(c => c.GTThietBiID == giatri);
                TB_XOA2.KiemKeID = 0;
                lv_thietbi_kiemke.Items.Remove(lv_thietbi_kiemke.SelectedItems[0]);
            }
        }

        private void txt_macabiet_Validated(object sender, EventArgs e)
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
        }

        private void btn_danhsachthietbi_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if ((int)cbo_donvikiemke.SelectedValue != 0)
            {
                List<string> lstdachon = new List<string>();
                if (ma == "")
                {
                    foreach (var gt in LST_DACHON.Select(c => c.GTThietBiID).ToList())
                    {
                        lstdachon.Add(gt.ToString());
                    }
                }
                else
                {
                    foreach (var gt in LST_DACHON.Where(c => c.KiemKeID != 0).Select(c => c.GTThietBiID).ToList())
                    {
                        lstdachon.Add(gt.ToString());
                    }
                }

                DanhMuc.frm_dschonthietbi_theonoisudung frm = new ThietBiPY.DanhMuc.frm_dschonthietbi_theonoisudung(cbo_donvikiemke.SelectedValue.ToString(),cbo_bophankiemke.SelectedValue.ToString(), lstdachon);
                frm.panel_locdulieu.Visible = false;
                frm.DuLieu = new ThietBiPY.DanhMuc.frm_dschonthietbi_theonoisudung.passData(chonthietbi);
                frm.ShowDialog();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa xác định đơn vị kiểm kê!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cbo_donvikiemke.Focus();
            }
        }
        private void btn_themvao_danhsachkiemke_Click(object sender, EventArgs e)
        {
            if (txt_tenthietbi.Tag != null)
            {
                chonthietbi(txt_tenthietbi.Tag.ToString());
            }
        }

        private void lv_thietbi_kiemke_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thietbi_kiemke.SelectedItems.Count > 0)
            {
                lv_thietbi_kiemke.ContextMenuStrip = contextmenu_thietbi;
            }
            else lv_thietbi_kiemke.ContextMenuStrip = null;
        }

        private void contextmenu_loaibo_Click(object sender, EventArgs e)
        {
            loaibo();
        }

        private void contextmenu_capnhatthem_Click(object sender, EventArgs e)
        {
            var TB = LST_DACHON.Single(c => c.GTThietBiID == Int64.Parse(lv_thietbi_kiemke.SelectedItems[0].Tag.ToString()));
            capnhatphu.frm_nghiepvuthietbi_capnhat_tt_ht frm = new ThietBiPY.NghiepVu.capnhatphu.frm_nghiepvuthietbi_capnhat_tt_ht(TB.TinhTrang1.ToString(), TB.HienTrang1);
            frm.DuLieu = new ThietBiPY.NghiepVu.capnhatphu.frm_nghiepvuthietbi_capnhat_tt_ht.passData(capnhatlai_tt_ht);
            frm.ShowDialog();
        }

        private void btn_tuychinhkichthuoc_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                splitContainer1.Panel1Collapsed = true;
                btn_tuychinhkichthuoc.Image = Properties.Resources.down;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                btn_tuychinhkichthuoc.Image = Properties.Resources.top;
            }
        }

        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        private void btn_luulai_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            if (dtp_ngaykiemke.Value == new DateTime(01, 01, 0001))
            {
                dtp_ngaykiemke.Focus();
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn ngày kiểm kê!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((int)cbo_donvikiemke.SelectedValue == 0)
            {
                cbo_donvikiemke.Focus();
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị kiểm kê!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (LST_DACHON.Count() == 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Danh sách kiểm kê bị rỗng!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PHIEUKIEMKE_BLL PHIEUKIEMKE = new PHIEUKIEMKE_BLL();
            if (dtp_ngaykiemke.Value != new DateTime(01, 01, 0001)) PHIEUKIEMKE.KIEMKE_DTO.NgayKiemKe = dtp_ngaykiemke.Value.Date;
            if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001)) PHIEUKIEMKE.KIEMKE_DTO.NgayVanBan = dtp_ngayvanban.Value.Date;
            PHIEUKIEMKE.KIEMKE_DTO.SoVanBan = txt_sovanban.Text;
            PHIEUKIEMKE.KIEMKE_DTO.ThamQuyenQD = txt_thamquyenqd.Text;
            PHIEUKIEMKE.KIEMKE_DTO.DonViKiemKe = (int)cbo_donvikiemke.SelectedValue;
            PHIEUKIEMKE.KIEMKE_DTO.BoPhanKiemKe = (int)cbo_bophankiemke.SelectedValue;
            PHIEUKIEMKE.KIEMKE_DTO.GhiChu = txt_ghichu.Text;

            PHIEUKIEMKE.LST_CTKIEMKE = LST_DACHON;
            PHIEUKIEMKE.LST_DD_KK = LST_DAIDIENKIEMKE;

            if (ma == "")
            {
                if (PHIEUKIEMKE.phieukiemke_them() > 0)
                {
                    guidulieu(PHIEUKIEMKE.KIEMKE_DTO.KiemKeID.ToString());
                    this.Close();
                }
                else DevComponents.DotNetBar.MessageBoxEx.Show("Có lỗi!Xin thử lại,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PHIEUKIEMKE.phieukiemke_sua(ma) > 0)
                {
                    guidulieu(PHIEUKIEMKE.KIEMKE_DTO.KiemKeID.ToString());
                    this.Close();
                }
                else DevComponents.DotNetBar.MessageBoxEx.Show("Có lỗi!Xin thử lại,", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lv_daidienkiemke_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_daidienkiemke.SelectedItems.Count > 0)
            {
                lv_daidienkiemke.ContextMenuStrip = contextmenu_daidienkiemke;
            }
            else lv_daidienkiemke.ContextMenuStrip = null;
        }
        private void lv_daidienkiemke_DoubleClick(object sender, EventArgs e)
        {
            if (lv_daidienkiemke.SelectedItems.Count > 0)
            {
                contextmenu_capnhatthem_Click(null, null);
            }
        }

        private void dtp_ngaykiemke_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngaykiemke.Value != new DateTime(01, 01, 0001))
            {
                dtp_ngayvanban.Value = dtp_ngaykiemke.Value.Date;
                txt_sovanban.Text = string.Format("{0:000}", new PHIEUKIEMKE_BLL().phieukiemke_danhsach().Where(c => c.NgayKiemKe.Value.Year == dtp_ngaykiemke.Value.Date.Year).Count() + 1);
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_kiemkethietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape :btn_huybo_Click(null, null);break;
                case Keys.F12:btn_tuychinhkichthuoc_Click(null, null); break;
                case Keys.F8: btn_luulai_Click(null, null); break;
            }
        }
        private void frm_kiemkethietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_ghichu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichu).OnKeyPress);
            txt_hientrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_hientrang).OnKeyPress);
            txt_thamquyenqd.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thamquyenqd).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
