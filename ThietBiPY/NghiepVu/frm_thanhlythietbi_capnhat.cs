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
    public partial class frm_thanhlythietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        //
        List<CTTHANHLY> lST_DSDACHON = new List<CTTHANHLY>();
        string ma = "";

        //
        public frm_thanhlythietbi_capnhat()
        {
            InitializeComponent();

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên TB", 200);
            lv_thietbi.Columns.Add("Giá trị thanh lý (đồng)", 150, HorizontalAlignment.Right);

            danhmuc_danhsachnhanvien();
            danhmuc_danhsachthietbi();

            dtp_ngaythanhly.Value = DateTime.Now.Date;
        }
        public frm_thanhlythietbi_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Tên TB", 200);
            lv_thietbi.Columns.Add("Giá trị thanh lý (đồng)", 150, HorizontalAlignment.Right);

            lST_DSDACHON = new CTTHANHLY_BLL().ctthanhly_danhsach(ma).ToList();
            var THANHLY = new PHIEUTHANHLY_BLL().phieuthanhly_thongtin(ma);
            dtp_ngayvanban.Value = THANHLY.NgayVanBan.Value.Date;
            txt_sovanban.Text = THANHLY.SoVanBan;
            dtp_ngaythanhly.Value = THANHLY.NgayThanhLy.Value.Date;
            txt_thamquyenqd.Text = THANHLY.ThamQuyenQD;

            if (THANHLY.DaiDienThanhLy != 0)
            {
                var NV = new NHANVIEN_BLL().nhanvien_thongtin(THANHLY.DaiDienThanhLy.ToString());
                txt_daidienthanhly.Tag = NV.NhanVienID.ToString();
                txt_daidienthanhly.Text = NV.HoNV + " " + NV.TenNV;
                txt_madaidienthanhly.Text = NV.MaNV;
            }
            txt_daidienbenmua.Text = THANHLY.DaiDienBenMua;
            txt_ghichu.Text = THANHLY.GhiChu;

            if (lST_DSDACHON.Count > 0)
            {
                foreach (var TB in lST_DSDACHON)
                {
                    ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                    item.Tag = TB.GTThietBiID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(TB.SOTHEODOI.GTTHIETBI.MaCaBiet);

                    item.SubItems.Add(TB.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi);
                    item.SubItems.Add(string.Format("{0:0,0}", TB.GiaTriThanhLy));
                }
            }
            danhmuc_danhsachnhanvien();
            danhmuc_danhsachthietbi();
        }

        #region "Hàm xử lý"
        //danh mục
        public void danhmuc_danhsachnhanvien()
        {
            AutoCompleteStringCollection Str_Collection1 = new AutoCompleteStringCollection();

            txt_madaidienthanhly.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_madaidienthanhly.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var str in new NHANVIEN_BLL().nhanvien_danhsach().Skip(0).Take(10).Select(c => c.MaNV).ToList())
            {
                Str_Collection1.Add(str);
            }
            txt_madaidienthanhly.AutoCompleteCustomSource = Str_Collection1;
        }
        public void danhmuc_danhsachnhanvien(string giatri)
        {
            if (giatri != "")
            {
                var NV = new NHANVIEN_BLL().nhanvien_thongtin(giatri);
                txt_madaidienthanhly.Text = NV.MaNV;
                txt_daidienthanhly.Tag = giatri;
                txt_daidienthanhly.Text = NV.HoNV + " " + NV.TenNV;
            }
        }
        public void danhmuc_danhsachthietbi()
        {
            AutoCompleteStringCollection Str_Collection = new AutoCompleteStringCollection();
            txt_macabiet.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_macabiet.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var TB in new GTTHIETBI_BLL().gtthietbi_danhsach().Skip(0).Take(10).Select(c => c.MaCaBiet).ToList())
            {
                Str_Collection.Add(TB);
            }
            txt_macabiet.AutoCompleteCustomSource = Str_Collection;
        }

        //truyền trị
        public delegate void passData(string ThanhLyID);
        public passData DuLieu;
        public void guidulieu(string ThanhLyID)
        {
            if (DuLieu != null) DuLieu(ThanhLyID);
        }

        //thao tác với danh sách thiết bị thanh lý
        private void themthietbivaodanhsach(string giatri)
        {
            //--đối với thêm mới - Nếu thiết bị chưa có trong danh sách chọn
            if (lST_DSDACHON.SingleOrDefault(c => c.GTThietBiID == Int64.Parse(giatri)) == null)
            {
                var TB = new SOTHEODOI_BLL().sotheodoi_chitietthietbi (giatri);
                if (ma == "") //đối với thêm mới
                {
                    lST_DSDACHON.Add(new CTTHANHLY
                    {
                        GTThietBiID=TB.GTThietBiID,
                        GiaTriThanhLy = decimal.Parse(txt_giatrithanhly.Text.Replace(",", "").Replace(".", "")),
                    });
                }
                else //đối với hiệu chỉnh
                {
                    lST_DSDACHON.Add(new CTTHANHLY
                    {
                        ThanhLyID = int.Parse(ma),
                        GTThietBiID=TB.GTThietBiID,
                        GiaTriThanhLy = decimal.Parse(txt_giatrithanhly.Text.Replace(",", "").Replace(".", "")),
                    });
                }

                ListViewItem item = new ListViewItem((lv_thietbi.Items.Count + 1).ToString());
                item.Tag = TB.GTThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.GTTHIETBI.MaCaBiet);
                item.SubItems.Add(TB.GTTHIETBI.THIETBI.TenThietBi);

                item.SubItems.Add(string.Format("{0:0,0}", decimal.Parse(txt_giatrithanhly.Text.Replace(",", "").Replace(".", ""))));
                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if (lv_thietbi.Items.Count % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            else //hiệu chỉnh thiết bị
            {
                var TB_SUA = lST_DSDACHON.Single(c => c.GTThietBiID == Int64.Parse(giatri));
                TB_SUA.GiaTriThanhLy += decimal.Parse(txt_giatrithanhly.Text.Replace(",", "").Replace(".", ""));

                foreach (ListViewItem item in lv_thietbi.Items)
                {
                    if (item.Tag.Equals(giatri))
                    {
                        item.SubItems[3].Text = string.Format("{0:0,0}", TB_SUA.GiaTriThanhLy);
                        return;
                    }
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_thietbi.Items.Count.ToString();
        }
        private void capnhat_giatri(string giatri)
        {
            var TB_SUA = lST_DSDACHON.Single(c => c.GTThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString()));
            TB_SUA.GiaTriThanhLy = decimal.Parse(giatri);
            ListViewItem item = lv_thietbi.SelectedItems[0];
            item.SubItems[3].Text = string.Format("{0:0,0}", TB_SUA.GiaTriThanhLy);
        }

        private void contextmenu_thietbi_capnhat_Click(object sender, EventArgs e)
        {
            var TB = lST_DSDACHON.Single(c => c.GTThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString()));
            NghiepVu.capnhatphu.frm_thanhlythietbi_capnhat_gt frm = new ThietBiPY.NghiepVu.capnhatphu.frm_thanhlythietbi_capnhat_gt(TB.GiaTriThanhLy.ToString());
            frm.DuLieu = new ThietBiPY.NghiepVu.capnhatphu.frm_thanhlythietbi_capnhat_gt.passData(capnhat_giatri);
            frm.ShowDialog();
        }
        private void contextmenu_thietbi_loaibo_Click(object sender, EventArgs e)
        {
            if (ma == "")
            {
                for (int i = 0; i < lv_thietbi.SelectedItems.Count; i++)
                {
                    var TB_XOA = lST_DSDACHON.Single(c => c.GTThietBiID == Int64.Parse(lv_thietbi.SelectedItems[i].Tag.ToString()));
                    if (lST_DSDACHON.Remove(TB_XOA))
                    {
                        lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[i]);
                        i--;
                    }
                }
            }
            else
            {
                var TB_HIEUCHINH = lST_DSDACHON.Single(c => c.GTThietBiID== Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString()));
                TB_HIEUCHINH.ThanhLyID = 0;
                lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
            }
            lbl_thongke.Text = "Tổng số: " + lv_thietbi.Items.Count.ToString();
        }
        #endregion

        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                lv_thietbi.ContextMenuStrip = contextmenu_thietbi;
            }
            else lv_thietbi.ContextMenuStrip = null;
        }

        //
        private void btn_danhsachdaidienthanhly_Click(object sender, EventArgs e)
        {
            DanhMuc.frm_nhanvien_dschon frm = new ThietBiPY.DanhMuc.frm_nhanvien_dschon();
            frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_dschon.passData(danhmuc_danhsachnhanvien);
            frm.ShowDialog();
        }
        private void btn_them_daidienthanhly_Click(object sender, EventArgs e)
        {
            DanhMuc.frm_nhanvien_capnhat frm = new ThietBiPY.DanhMuc.frm_nhanvien_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.frm_nhanvien_capnhat.passData(danhmuc_danhsachnhanvien);
            frm.ShowDialog();
        }
        private void txt_madaidienthanhly_Validated(object sender, EventArgs e)
        {
            if (txt_madaidienthanhly.Text != "")
            {
                var NV = new NHANVIEN_BLL().nhanvien_danhsach().SingleOrDefault(c => c.MaNV.Equals(txt_madaidienthanhly.Text.Trim()));
                txt_daidienthanhly.Text = (NV != null ? NV.HoNV + " " + NV.TenNV : "[không có nhân viên này]");
                txt_daidienthanhly.Tag = (NV != null ? NV.NhanVienID.ToString() : "0");
            }
            else txt_daidienthanhly.Text = "[chưa xác định hoặc không có]";
        }
        
        //
        private void btn_themvaodanhsach_Click(object sender, EventArgs e)
        {
            if (txt_tenthietbi.Tag != null)
            {
                themthietbivaodanhsach(txt_tenthietbi.Tag.ToString());
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn thiết bị cần thanh lý!","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
        private void btn_danhsachthietbi_Click(object sender, EventArgs e)
        {
            List<string> lst_dachon = new List<string>();

            if (ma == "")
            {
                foreach (var TB in lST_DSDACHON)
                {
                    lst_dachon.Add(TB.GTThietBiID.ToString());
                }
            }
            else
            {
                foreach (var TB in lST_DSDACHON.Where (c=>c.ThanhLyID !=0).ToList())
                {
                    lst_dachon.Add(TB.GTThietBiID.ToString());
                }
            }
            DanhMuc.frm_dschonthietbi_theonoisudung frm = new ThietBiPY.DanhMuc.frm_dschonthietbi_theonoisudung(lst_dachon);
            frm.DuLieu = new ThietBiPY.DanhMuc.frm_dschonthietbi_theonoisudung.passData(themthietbivaodanhsach);
            frm.ShowDialog();
        }
       
        //
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (dtp_ngayvanban.Value == new DateTime(01, 01, 0001))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn ngày văn bản!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtp_ngayvanban.Focus();
            }
            else if (dtp_ngaythanhly.Value == new DateTime(01, 01, 0001))
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn ngày thanh lý!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dtp_ngaythanhly.Focus();
            }
            else
            {
                var THANHLY = new PHIEUTHANHLY_BLL();
                THANHLY.THANHLY_DTO.SoVanBan = txt_sovanban.Text;
                THANHLY.THANHLY_DTO.NgayVanBan = dtp_ngayvanban.Value.Date;
                THANHLY.THANHLY_DTO.NgayThanhLy = dtp_ngaythanhly.Value.Date;

                THANHLY.THANHLY_DTO.ThamQuyenQD = txt_thamquyenqd.Text;
                THANHLY.THANHLY_DTO.DaiDienThanhLy = Int64.Parse(txt_daidienthanhly.Tag.ToString());
                THANHLY.THANHLY_DTO.DaiDienBenMua = txt_daidienbenmua.Text;
                THANHLY.THANHLY_DTO.GhiChu = txt_ghichu.Text;
                THANHLY.LST_CTTHANHLY = lST_DSDACHON;

                if (ma == "")
                {
                    if (THANHLY.phieuthanhly_them() > 0)
                    {
                        guidulieu(THANHLY.THANHLY_DTO.ThanhLyID.ToString());
                        this.Close();
                    }
                }
                else
                {
                    if (THANHLY.phieuthanhly_sua(ma) > 0)
                    {
                        guidulieu(THANHLY.THANHLY_DTO.ThanhLyID.ToString());
                        this.Close();
                    }
                }
            }
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_thanhlythietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void dtp_ngayvanban_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_ngayvanban.Value != new DateTime(01, 01, 0001)) txt_sovanban.Text = "TL_" + dtp_ngayvanban.Value.Date.ToString("ddMMyyyy");
        }

        //
        private void frm_thanhlythietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_ghichu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichu).OnKeyPress);
            txt_daidienbenmua.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_daidienbenmua).OnKeyPress);
            txt_thamquyenqd.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thamquyenqd).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
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
        private void btn_kichthuoc_khungvanban_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                splitContainer1.Panel1Collapsed = true;
                btn_kichthuoc_khungvanban.Image = Properties.Resources.down;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                btn_kichthuoc_khungvanban.Image = Properties.Resources.top;
            }
        }

        private void txt_giatrithanhly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!=',' && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
