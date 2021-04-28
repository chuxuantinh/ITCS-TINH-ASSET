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
using iTextSharp.text.pdf;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_thietbi_macabiet : DevComponents.DotNetBar.Office2007Form
    {

        int phanloai = 0;
        List<string> lst_tenmacabiet = new List<string>();
        public frm_thietbi_macabiet()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("Mã thiết bị", 150);
            lv_thietbi.Columns.Add("Số hiệu", 150);

            lv_thietbi_giatri.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi_giatri.Columns.Add("Mã cá biệt", 100, HorizontalAlignment.Center);
            lv_thietbi_giatri.Columns.Add("Ngày nhập", 150,HorizontalAlignment.Center);
            lv_thietbi_giatri.Columns.Add("Đơn giá", 100, HorizontalAlignment.Right);
            lv_thietbi_giatri.Columns.Add("Tình trạng",100, HorizontalAlignment.Center);
            lv_thietbi_giatri.Columns.Add("Đơn vị sử dụng",200, HorizontalAlignment.Center);

            tabControl_chonkieu_SelectedIndexChanged(null, null);
            lv_thietbi.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(lv_thietbi_ItemSelectionChanged);

            Barcode128 code128 = new Barcode128();
            code128.CodeType = Barcode.CODE128;
            code128.ChecksumText = true;
            code128.GenerateChecksum = true;
            code128.StartStopText = true;
            code128.Code = lbl_macabiet.Text;

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
            pic_mavach.Image = bm;
            //
          }

        //-- thiết bị
        int vitri_page_thietbi = 0, tongso_page_thietbi = 1, sodong_thietbi = 50;

        //Xác định tính duy nhất của thiết bị
        public class Lay1GiaTriThietBi : IEqualityComparer<GTTHIETBI>
        {
            public bool Equals(GTTHIETBI x, GTTHIETBI y)
            {
                if (x == null || y == null)
                    return false;
                else
                    return x.ThietBiID== y.ThietBiID;
            }

            public int GetHashCode(GTTHIETBI obj)
            {
                return obj.ThietBiID.GetHashCode();
            }

        }
        
        private void btn_thietbi_lui_Click(object sender, EventArgs e)
        {
          if(vitri_page_thietbi>0)vitri_page_thietbi -= 1;
          danhmuc_thietbi();
        }
        private void btn_thietbi_tien_Click(object sender, EventArgs e)
        {
            if (vitri_page_thietbi < tongso_page_thietbi - 1)
            {
                vitri_page_thietbi += 1;
                danhmuc_thietbi();
            }
        }

        //-- Tương tác 2 listview
        List<SOTHEODOI> LST_THIETBI_GIATRI = new List<SOTHEODOI>();

        private void lv_thietbi_ItemSelectionChanged(object sender, EventArgs e)
        {
            string chitiet="";
            lv_thietbi_giatri.Items.Clear();
            lst_tenmacabiet.Clear();

            if (lv_thietbi.SelectedItems.Count > 0)
            {
                ListViewItem lv = lv_thietbi.SelectedItems[0];
                chitiet=  lv.SubItems[1].Text + Environment.NewLine + "Mã TB: " + lv.SubItems[2].Text + Environment.NewLine + "Số hiệu: " + lv.SubItems[3].Text;


                LST_THIETBI_GIATRI.Clear();
                LST_THIETBI_GIATRI = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.GTTHIETBI.ThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString())).ToList();
                if (phanloai == 1)
                {
                    if (cbo_loaithietbi.SelectedIndex < cbo_loaithietbi.Items.Count-1) LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.THIETBI.LoaiTBID == (int)cbo_loaithietbi.SelectedValue).ToList();
                }
                else if (phanloai == 2)
                {
                    if (cbo_donvisudung.SelectedIndex < cbo_donvisudung.Items.Count - 1) LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.DonViSD == (int)cbo_donvisudung.SelectedValue).ToList();
                }
                else if (phanloai == 3)
                {
                    if (dtp_phanloai_ngaynhap.Value != new DateTime(01, 01, 0001)) LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date==dtp_phanloai_ngaynhap.Value.Date).ToList();
                }

                AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
                foreach (var str in LST_THIETBI_GIATRI.Skip(0).Take(10).Select(c => c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.SoVanBan).ToList())
                {
                    Str_Col.Add(str);
                }
                txt_sovanban.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_sovanban.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_sovanban.AutoCompleteCustomSource = Str_Col;

                //
                
                danhmuc_giatrithietbi(LST_THIETBI_GIATRI);
                panel_dieukhien.Enabled = true;
            }
            else panel_dieukhien.Enabled = false;
            toolTip1.SetToolTip(lv_thietbi, chitiet);
        } 
        private void lv_thietbi_giatri_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string chitiet = "";
            if (lv_thietbi_giatri.SelectedItems.Count > 0)
            {
                var GTTB = new GTTHIETBI_BLL().gtthietbi_thongtin(lv_thietbi_giatri.SelectedItems[0].Tag.ToString());
                
                chitiet = "Đơn giá: " + string.Format("{0:0,0 đồng}", GTTB.CTPHIEUNHAP.DonGia) + Environment.NewLine;
                chitiet += "Chứng từ nhập: " + (GTTB.CTPHIEUNHAP.PHIEUNHAP.SoVanBan!=""?GTTB.CTPHIEUNHAP.PHIEUNHAP.SoVanBan:"[không có]") + " - Ngày nhập: " + GTTB.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy") + Environment.NewLine;
                chitiet += "Nhà cung cấp: " + (GTTB.CTPHIEUNHAP.PHIEUNHAP.NCCID != 0 ? GTTB.CTPHIEUNHAP.PHIEUNHAP.NHACUNGCAP.TenNCC : "[chưa cập nhật]");
                lv_thietbi_giatri.ContextMenuStrip = contextmenu_giatrithietbi;

                //

                try
                {
                    lbl_macabiet.Text = GTTB.MaCaBiet;

                    Barcode128 code128 = new Barcode128();
                    code128.CodeType = Barcode.CODE128;
                    code128.ChecksumText = true;
                    code128.GenerateChecksum = true;
                    code128.StartStopText = true;
                    code128.Code = lbl_macabiet.Text;

                    System.Drawing.Bitmap bm = new System.Drawing.Bitmap(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
                    pic_mavach.Image = bm;
                }
                catch
                {
                    pic_mavach.Image = null;
                    lbl_macabiet.Text = "";
                }
                //
            }
            else
            {
                lv_thietbi_giatri.ContextMenuStrip = null;
                pic_mavach.Image = null;
                lbl_macabiet.Text = "";
            }
            toolTip1.SetToolTip(lv_thietbi_giatri, chitiet);
        }
       
        //-- Hệ thống xử lý chính
        public void danhmuc_thietbi()
        {
            //LST_THIETBI = new GTTHIETBI_BLL().gtthietbi_danhsach().OrderBy(c => c.THIETBI.TenThietBi).Distinct(new Lay1GiaTriThietBi() ).ToList();
            var LST_THIETBI = (from std in new SOTHEODOI_BLL().sotheodoi_danhsach()
                               join gttb in new GTTHIETBI_BLL().gtthietbi_danhsach().Distinct(new Lay1GiaTriThietBi()) on std.GTThietBiID equals gttb.GTThietBiID
                               join tb in new THIETBI_BLL().thietbi_danhsach() on gttb.ThietBiID equals tb.ThietBiID
                               select new
                               {
                                   ThietBiID = tb.ThietBiID,
                                   TenThietBi = tb.TenThietBi,
                                   MaThietBi = tb.MaThietBi,
                                   SoHieu = tb.SoHieu,
                                   DonViSD = std.DonViSD,
                                   LoaiTB = tb.LoaiTBID,

                                   NgayNhap = gttb.CTPHIEUNHAP.PHIEUNHAP.NgayNhap,
                                   TenDonVi = (std.DonViSD != 0 ? std.DONVI.TenDonVi : "Chưa xác định"),
                                   TenLoaiTB = (tb.LoaiTBID != 0 ? tb.LOAITHIETBI.TenLoaiTB : "Chưa xác định"),
                               }).Distinct().ToList();

            switch (phanloai)
            {
                case 1:

                    if (cbo_loaithietbi.SelectedIndex >= 0 && cbo_loaithietbi.SelectedIndex != cbo_loaithietbi.Items.Count - 1)
                    {
                        LST_THIETBI = LST_THIETBI.Where(c => c.LoaiTB == int.Parse(cbo_loaithietbi.SelectedValue.ToString())).ToList();
                    }
                    break;

                case 2:
                    if (cbo_donvisudung.SelectedIndex >= 0 && cbo_donvisudung.SelectedIndex != cbo_donvisudung.Items.Count - 1)
                    {
                        LST_THIETBI = LST_THIETBI.Where(c => c.DonViSD == (int)cbo_donvisudung.SelectedValue).ToList();
                    }
                    break;

                case 3:
                    if (dtp_phanloai_ngaynhap.Value != new DateTime(01, 01, 0001))
                    {
                        LST_THIETBI = LST_THIETBI.Where(c => c.NgayNhap.Value.Date == dtp_phanloai_ngaynhap.Value.Date).ToList();
                    }
                    break;
            }

            //
            lv_thietbi_giatri.Items.Clear();
            lv_thietbi.Items.Clear();
            lst_tenmacabiet.Clear();

            //
            int dem = 0;
            ListViewItem item = new ListViewItem();
            tongso_page_thietbi = (int)(Math.Floor((decimal)LST_THIETBI.Count / sodong_thietbi)) + (LST_THIETBI.Count % sodong_thietbi == 0 ? 0 : 1);
            txt_page_thietbi_tongso.Text = tongso_page_thietbi.ToString();
            txt_page_thietbi_vitri.Text = (vitri_page_thietbi + 1).ToString();

            foreach (var TB in LST_THIETBI.Skip(vitri_page_thietbi * sodong_thietbi).Take(sodong_thietbi).ToList())
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = TB.ThietBiID.ToString();
                lv_thietbi.Items.Add(item);
                item.SubItems.Add(TB.TenThietBi);
                item.SubItems.Add(TB.MaThietBi);
                item.SubItems.Add(TB.SoHieu);

                for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }

        }
        private void danhmuc_giatrithietbi(List<SOTHEODOI> LST)
        {
            int dem = 0;
            ListViewItem item = null;
            lv_thietbi_giatri.Items.Clear();

            if (LST.Count > 0)
            {
                foreach (var GT in LST)
                {
                    dem++;
                    lst_tenmacabiet.Add(GT.GTTHIETBI.MaCaBiet);

                    item = new ListViewItem(dem.ToString());
                    item.Tag = GT.GTThietBiID.ToString();
                    lv_thietbi_giatri.Items.Add(item);
                    item.SubItems.Add(GT.GTTHIETBI.MaCaBiet);
                    item.SubItems.Add(GT.GTTHIETBI.CTNhapID != 0 ? GT.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy") : "");
                    item.SubItems.Add(string.Format("{0:0,0 đồng}", (GT.GTTHIETBI.CTNhapID != 0 ? GT.GTTHIETBI.CTPHIEUNHAP.DonGia : 0)));
                    item.SubItems.Add(GT.TinhTrang != 0 ? GT.TINHTRANG1.TenTinhTrang : "Chưa xác định");
                    item.SubItems.Add(GT.DonViSD != 0 ? GT.DONVI.TenDonVi : "Chưa xác định");

                    for (int cot = 0; cot < lv_thietbi_giatri.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
        }
        public void timkiem_giatrithietbi(object sender,EventArgs e)
        {
            LST_THIETBI_GIATRI.Clear();
            LST_THIETBI_GIATRI = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.GTTHIETBI.ThietBiID == Int64.Parse(lv_thietbi.SelectedItems[0].Tag.ToString())).ToList();

            //
            switch (phanloai)
            {
                case 1:
                    LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.THIETBI.LoaiTBID == int.Parse(cbo_loaithietbi.SelectedValue.ToString())).ToList();
                    break;

                case 2:
                    LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.DonViSD == int.Parse(cbo_donvisudung.SelectedValue.ToString())).ToList();
                    break;

                case 3:
                    LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date == dtp_phanloai_ngaynhap.Value.Date).ToList();
                    break;
            }
            //

            if (opt_timtheo_sovanban.Checked)
            {
                LST_THIETBI_GIATRI = LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.SoVanBan.Contains(txt_sovanban.Text.Trim())).ToList();
            }
            else if (opt_timtheo_ngaynhapve.Checked)
            {
                if (dtp_ngaynhapve.Value != new DateTime(01, 01, 0001)) LST_THIETBI_GIATRI=LST_THIETBI_GIATRI.Where(c => c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date == dtp_ngaynhapve.Value.Date).ToList();
            }
            danhmuc_giatrithietbi(LST_THIETBI_GIATRI);
        }

        //Bộ lọc
        private void opt_timtheo_sovanban_CheckedChanged(object sender, EventArgs e)
        {
            chonkieutimkiem(null,null);
        }
        private void opt_timtheo_ngaynhapve_CheckedChanged(object sender, EventArgs e)
        {
            chonkieutimkiem(null, null);
        }
        private void opt_timtheo_tatca_CheckedChanged(object sender, EventArgs e)
        {
            chonkieutimkiem(null, null);
        }

        private void pic_mavach_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "File ảnh (*.gif)|*.gif";
            diag.FileName = lbl_macabiet.Text;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                Barcode128 code128 = new Barcode128();
                code128.CodeType = Barcode.CODE128;
                code128.ChecksumText = true;
                code128.GenerateChecksum = true;
                code128.StartStopText = true;
                code128.Code = lbl_macabiet.Text;


                Bitmap bm_out = new Bitmap((int)code128.BarcodeSize.Width, (int)code128.BarcodeSize.Height + 10);
                Graphics g = Graphics.FromImage(bm_out);

                StringFormat strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;

                g.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.Transparent), new PointF(0, 0));
                g.DrawString(lbl_macabiet.Text, new Font("Tahoma", 10), new SolidBrush(Color.Black), new PointF((int)code128.BarcodeSize.Width / 2, (int)code128.BarcodeSize.Height + 0), strFormat);
                bm_out.Save(diag.FileName);
            }

        }

        //Bộ phân loại
        public void chonkieutimkiem(object sender, EventArgs e)
        {
            if (opt_timtheo_sovanban.Checked)
            {
                txt_sovanban.Enabled = true;
                txt_sovanban.TextChanged += new EventHandler(timkiem_giatrithietbi);

                dtp_ngaynhapve.Enabled = false;
            }
            else if (opt_timtheo_ngaynhapve.Checked)
            {
                txt_sovanban.Enabled = false;
                dtp_ngaynhapve.Enabled = true;
                dtp_ngaynhapve.ValueChanged += new EventHandler(timkiem_giatrithietbi);
            }
            else
            {
                txt_sovanban.Enabled = false;
                dtp_ngaynhapve.Enabled = false;
            }
            timkiem_giatrithietbi(null, null);
        }
        private void tabControl_chonkieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_chonkieu.SelectedTab == tabPage_loaithietbi)
            {
                phanloai = 1;
                danhmuc_phanloaithietbi("");
            }
            else if (tabControl_chonkieu.SelectedTab == tabPage_donvi)
            {
                phanloai = 2;
                danhmuc_phanloaidonvi("");
            }
            else if (tabControl_chonkieu.SelectedTab == tabPage_ngaynhap)
            { 
                phanloai = 3;
                dtp_phanloai_ngaynhap.Value = DateTime.Now.Date;
                dtp_phanloai_ngaynhap.ValueChanged += new EventHandler(dtp_phanloai_ngaynhap_ValueChanged);
                dtp_phanloai_ngaynhap_ValueChanged(null, null);
            }
        }
        private void btn_lamtuoi_loaithietbi_Click(object sender, EventArgs e)
        {
            danhmuc_phanloaithietbi(cbo_loaithietbi.SelectedValue.ToString());
        }

        //---
        private void danhmuc_phanloaithietbi(string giatri)
        {
            BindingSource binding_loaithietbi = new BindingSource();
            binding_loaithietbi.DataSource = new GTTHIETBI_BLL().gtthietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.THIETBI.LoaiTBID,
                TenLoaiTB = (c.THIETBI.LoaiTBID != 0 ? c.THIETBI.LOAITHIETBI.TenLoaiTB : "[Chưa xác định]"),
            }).Distinct().ToList();
            binding_loaithietbi.Add(new { LoaiTBID = binding_loaithietbi.Count, TenLoaiTB = "Tất cả" });
            //ADD them item tất cả, mục đích chỉ lệ thuộc vào Index chứ ko Value

            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.DisplayMember = "TenLoaiTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";

            if (giatri != "") cbo_loaithietbi.SelectedValue = int.Parse(giatri);
            else cbo_loaithietbi.SelectedIndex = 0;

            cbo_loaithietbi.SelectedIndexChanged += new EventHandler(cbo_loaithietbi_SelectedIndexChanged);
            cbo_loaithietbi_SelectedIndexChanged(null, null);
        }
        private void cbo_loaithietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitri_page_thietbi = 0;
            danhmuc_thietbi();
        }

        private void danhmuc_phanloaidonvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Select(c => new
            {
                TenDonVi = c.DonViSD != 0 ? c.DONVI.TenDonVi : "Chưa xác định",
                DonViID = c.DonViSD,
            }).Distinct().ToList();
            binding_donvi.Add(new { TenDonVi = "Tất cả", DonViID = binding_donvi.Count });
            cbo_donvisudung.DataSource = binding_donvi;
            cbo_donvisudung.ValueMember = "DonViID";
            cbo_donvisudung.DisplayMember = "TenDonVi";

            if (giatri != "") cbo_donvisudung.SelectedValue = int.Parse(giatri);
            else cbo_donvisudung.SelectedIndex = 0;

            cbo_donvisudung.SelectedIndexChanged += new EventHandler(cbo_donvisudung_SelectedIndexChanged);
            cbo_donvisudung_SelectedIndexChanged(null, null);
        }
        private void cbo_donvisudung_SelectedIndexChanged(object sender, EventArgs e)
        {
            vitri_page_thietbi = 0;
            danhmuc_thietbi();
        }
        private void dtp_phanloai_ngaynhap_ValueChanged(object sender, EventArgs e)
        {
            vitri_page_thietbi = 0;
            danhmuc_thietbi();
        }

        //---
        private void contextmenu_giatrithietbi_xemchitiet_Click(object sender, EventArgs e)
        {
            var GTTB = new GTTHIETBI_BLL().gtthietbi_thongtin(lv_thietbi_giatri.SelectedItems[0].Tag.ToString());
            frm_thietbi_thongtinchitiet frm = new frm_thietbi_thongtinchitiet(GTTB.MaCaBiet);
            frm.ShowDialog();
        }
        private void contextmenu_giatrithietbi_capnhatmacabiet_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_thietbi_giatri.SelectedItems[0];
            string value = item.SubItems[1].Text;
            if (new LopHoTro.INPUTBOX().InputBox("Cập nhật mã cá biệt", lv_thietbi.SelectedItems[0].SubItems[1].Text, ref value) == DialogResult.OK)
            {
                var GTTB = new GTTHIETBI_BLL();
                GTTB.GTTHIETBI_DTO.MaCaBiet = value;
                if (GTTB.gtthietbi_macabiet(item.Tag.ToString()) > 0)
                {
                    item.SubItems[1].Text = value;
                }
            }
        }

        //In danh sách các mã vạch
        private void btn_in_dsmacabiet_Click(object sender, EventArgs e)
        {
            if (lst_tenmacabiet.Count > 0)
            {
                BaoCao_ThongKe.report.frm_bienban_macabiet frm = new ThietBiPY.BaoCao_ThongKe.report.frm_bienban_macabiet(lst_tenmacabiet);
                frm.ShowDialog();
            }
        }
        private void lv_thietbi_giatri_DoubleClick(object sender, EventArgs e)
        {
            if (lv_thietbi_giatri.SelectedItems.Count > 0)
            {
                contextmenu_giatrithietbi_capnhatmacabiet_Click(null, null);
            }
        }
    }
}

public class TB_MACABIET
{
     public Int64  ThietBiID{get;set;}
     public string TenThietBi { get; set; }
     public string MaThietBi { get; set; }
     public string SoHieu { get; set; }
     public int DonViSD { get; set; }
     public int LoaiTB { get; set; }
     public string TenDonVi{ get; set; }
     public string TenLoaiTB { get; set; }
}