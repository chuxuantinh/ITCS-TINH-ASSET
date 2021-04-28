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



namespace ThietBiPY.DanhMuc
{
    public partial class frm_dschonthietbi_theonoisudung : DevComponents.DotNetBar.Office2007Form
    {

        List<string> LST_MADACHON = new List<string>();
        string DonVi = null, BoPhan = null;

        public frm_dschonthietbi_theonoisudung()
        {
            InitializeComponent();
        }
        public frm_dschonthietbi_theonoisudung(List<string> LST)
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 200);
            lv_thietbi.Columns.Add("Ngày SD", 70);
            lv_thietbi.Columns.Add("Hạn bảo hành", 160);

            lv_thietbi.Columns.Add("Giá mua", 100, HorizontalAlignment.Right);
            lv_thietbi.Columns.Add("Tình trạng", 100, HorizontalAlignment.Center);
            LST_MADACHON = LST;

            danhmuc_donvi("");
            danhmuc_tinhtrang("");
            txt_macabiet.TextChanged += new EventHandler(txt_macabiet_TextChanged);
            panel_locdulieu.Visible = true;
        }

        public frm_dschonthietbi_theonoisudung( string DonViID,List<string> LST)
        {
            InitializeComponent();
            panel_locdulieu.Visible = false;
            DonVi = DonViID;

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 200);
            lv_thietbi.Columns.Add("Ngày SD", 70);
            lv_thietbi.Columns.Add("Hạn bảo hành", 160);

            lv_thietbi.Columns.Add("Giá mua", 100, HorizontalAlignment.Right);
            lv_thietbi.Columns.Add("Tình trạng", 100,HorizontalAlignment.Center);
            LST_MADACHON = LST;
            hienthidanhsach();
        }
        public frm_dschonthietbi_theonoisudung(string DonViID,string BoPhanID, List<string> LST)
        {
            InitializeComponent();
            panel_locdulieu.Visible = false;
            this.DonVi = DonViID;
            this.BoPhan = BoPhanID;

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 200);
            lv_thietbi.Columns.Add("Ngày SD", 70);
            lv_thietbi.Columns.Add("Hạn bảo hành", 160);

            lv_thietbi.Columns.Add("Giá mua", 100, HorizontalAlignment.Right);
            lv_thietbi.Columns.Add("Tình trạng", 100, HorizontalAlignment.Center);
            LST_MADACHON = LST;
            hienthidanhsach();
        }

        //
        private void danhmuc_donvi(string giatri)
        {
            cbo_donvi.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Select(c => new
            {
                DonViID = c.DonViSD,
                TenDonVi = (c.DonViSD != 0 ? c.DONVI.TenDonVi : "Chưa xác định"),
            }).Distinct().ToList();
            cbo_donvi.ValueMember = "DonViID";
            cbo_donvi.DisplayMember = "TenDonVi";

            if (giatri != "") cbo_donvi.SelectedValue = int.Parse(giatri);
            else if (cbo_donvi.Items.Count > 0) cbo_donvi.SelectedIndex = 0;
            cbo_donvi.SelectedIndexChanged += new EventHandler(cbo_donvi_SelectIndexChanged);
            cbo_donvi_SelectIndexChanged(null, null);
        }
        private void cbo_donvi_SelectIndexChanged(object sender, EventArgs e)
        {
            if (cbo_donvi.SelectedIndex >= 0)
            {
                DonVi = cbo_donvi.SelectedValue.ToString();
                hienthidanhsach();
            }
        }
        
        private void danhmuc_tinhtrang(string giatri)
        {
            BindingSource binding_tinhtrang=new BindingSource ();
            binding_tinhtrang.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Select(c => new
            {
                TinhTrangID = c.TinhTrang,
                TenTinhTrang = (c.TinhTrang != 0 ? c.TINHTRANG1.TenTinhTrang : "Chưa xác định"),
            }).Distinct().ToList();
            binding_tinhtrang.Add(new { TinhTrangID = binding_tinhtrang.Count, TenTinhTrang = "Tất cả" });

            cbo_tinhtrang.DataSource = binding_tinhtrang;
            cbo_tinhtrang.ValueMember = "TinhTrangID";
            cbo_tinhtrang.DisplayMember = "TenTinhTrang";
            if (giatri != "") cbo_tinhtrang.SelectedValue = int.Parse(giatri);
            else if (cbo_tinhtrang.Items.Count > 0) cbo_tinhtrang.SelectedIndex = cbo_tinhtrang.Items.Count - 1;

            cbo_tinhtrang.SelectedIndexChanged += new EventHandler(cbo_tinhtrang_SelectedIndexChanged);
            cbo_tinhtrang_SelectedIndexChanged(null, null);
        }
        private void cbo_tinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tinhtrang.SelectedIndex >= 0)
            {
                this.DonVi = cbo_donvi.SelectedValue.ToString();
                hienthidanhsach();
            }
        }
        private void txt_macabiet_TextChanged(object sender, EventArgs e)
        {
            DonVi = cbo_donvi.SelectedValue.ToString();
            hienthidanhsach();
        }

        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //
        public void hienthidanhsach()
        {
            lv_thietbi.Items.Clear();
                //
                ListViewItem item = null;
                ListViewGroup group = null;
                int dem_gr = 0;

                var GR_SOTHEODOI = new SOTHEODOI_BLL().sotheodoi_danhsach().ToList();
                if (DonVi != null) GR_SOTHEODOI = GR_SOTHEODOI.Where(c => c.DonViSD == int.Parse(DonVi)).ToList();
                if (BoPhan != null) GR_SOTHEODOI = GR_SOTHEODOI.Where(c => c.BoPhanSD == int.Parse(BoPhan)).ToList();

                var GR_TB = GR_SOTHEODOI.Select(c => new
                    {
                        TenThietBi = c.GTTHIETBI.THIETBI.TenThietBi,
                        ThietBiID = c.GTTHIETBI.ThietBiID,
                    }).Distinct().ToList();

                foreach (var TB in GR_TB)
                {
                    dem_gr++;
                    group = new ListViewGroup(dem_gr.ToString() + ". " + TB.TenThietBi);
                    this.lv_thietbi.Groups.Add(group);

                    var LST_TB = new DBDataContext().SOTHEODOI_DONVI_BOPHAN_THIETBI(int.Parse(DonVi),null, TB.ThietBiID).Where(c => !LST_MADACHON.Contains(c.GTThietBiID.ToString())).ToList();
                    if(BoPhan!=null) LST_TB = new DBDataContext().SOTHEODOI_DONVI_BOPHAN_THIETBI(int.Parse(DonVi),int.Parse(BoPhan), TB.ThietBiID).Where(c => !LST_MADACHON.Contains(c.GTThietBiID.ToString())).ToList();
                   
                    if (cbo_tinhtrang.SelectedIndex < cbo_tinhtrang.Items.Count - 1)LST_TB = LST_TB.Where(c => c.TinhTrangID == int.Parse(cbo_tinhtrang.SelectedValue.ToString())).ToList();
                    if (txt_macabiet.Text != "") LST_TB = LST_TB.Where(c => c.MaCaBiet.Contains(txt_macabiet.Text)).ToList();
                   // if (cbo_bophan.SelectedIndex != cbo_bophan.Nodes.Count - 1) LST_TB = LST_TB.Where(c => c.BoPhanSD == (int)cbo_bophan.SelectedValue).ToList();
                    
                    int dem = 0;
                    foreach (var T in LST_TB)
                    {
                        dem++;
                        item = new ListViewItem(dem_gr.ToString() + "." + dem.ToString());
                        item.Group = group;
                        item.Tag = T.GTThietBiID.ToString();
                        lv_thietbi.Items.Add(item);
                        item.SubItems.Add(T.MaCaBiet);
                        item.SubItems.Add(T.NgayNhap.Value.ToString("dd/MM/yyyy"));

                        string songaybaohanhconlai = new LopHoTro.CHUYENKIEU().DateDiff(DateTime.Now.Date, T.NgayNhap.Value.Date.AddMonths(T.HanBaoHanh));
                        item.SubItems.Add((songaybaohanhconlai != string.Empty ? string.Format("Còn {0}", songaybaohanhconlai) : "Hết BH") + " | (" + T.HanBaoHanh.ToString() + " tháng)");
                        item.SubItems.Add(string.Format("{0:0,0 đ}", T.DonGia));

                        item.SubItems.Add(T.TenTinhTrang);
                        for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                        {
                            if (dem % 2 == 0)
                            {
                                item.SubItems[cot].BackColor = Color.AliceBlue;
                            }
                        }
                        if (songaybaohanhconlai == string.Empty) item.SubItems[3].BackColor = Color.LightCoral;
                    }
                }

        }
        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                guidulieu(lv_thietbi.SelectedItems[0].Tag.ToString());
                lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
            }
        }
        private void btn_chon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_thietbi.Items)
            {
                if (item.Checked == true)
                {
                    guidulieu(item.Tag.ToString());
                    lv_thietbi.Items.Remove(item);
                }
            }
        }
        private void frm_dschonthietbi_theonoisudung_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F12:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }
    }
}
