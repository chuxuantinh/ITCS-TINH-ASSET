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
using ThietBiPY.DanhMuc;

namespace ThietBiPY.BaoCao_ThongKe.thongkethietbi
{
    public partial class frm_thongke_thietbi_theonoisudung : DevComponents.DotNetBar.Office2007Form 
    {
        bool TSCD = false;
        public frm_thongke_thietbi_theonoisudung()
        {
            InitializeComponent();
            lv_thongke_donvi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thongke_donvi.Columns.Add("Đơn vị", 150);
            lv_thongke_donvi.Columns.Add("Số lượng", 60,HorizontalAlignment.Center);

            lv_chitiet_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_chitiet_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_chitiet_thietbi.Columns.Add("Ngày SD", 70);
            lv_chitiet_thietbi.Columns.Add("Hạn bảo hành", 170);

            lv_chitiet_thietbi.Columns.Add("Giá mua", 100,HorizontalAlignment.Right);
            lv_chitiet_thietbi.Columns.Add("Bộ phận sử dụng", 100);
            lv_chitiet_thietbi.Columns.Add("Tình trạng", 100);

            danhsach_thongkethietbi_donvi();

            cbo_loaitaisan.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Thiết bị",0),
                new LopHoTro.DOITUONG("Tài sản cố định",1),
            };
            cbo_loaitaisan.ValueMember = "value";
            cbo_loaitaisan.DisplayMember = "name";
            cbo_loaitaisan.SelectedIndex = 0;
            cbo_loaitaisan.SelectedIndexChanged += new EventHandler(cbo_loaitaisan_SelectedIndexChanged);

            btn_lamtuoi.Click += new EventHandler(btn_lamtuoi_toanbo_Click);
        }

       public int DonViID = 0;
       public frm_thongke_thietbi_theonoisudung(int DonViID)
        {
            InitializeComponent();
            this.btn_kichthuockhung.Visible = false;
            this.DonViID = DonViID;

            splitContainer1.Panel1Collapsed = true;
            btn_lamtuoi.Visible = true;
            btn_inthongke_cacdonvi.Visible = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.EnableGlass = false;

            this.Width = 520;

            lv_chitiet_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_chitiet_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_chitiet_thietbi.Columns.Add("Ngày SD", 70);
            lv_chitiet_thietbi.Columns.Add("Hạn bảo hành", 170);

            lv_chitiet_thietbi.Columns.Add("Giá mua", 100, HorizontalAlignment.Right);

            //

            var DV = new DONVI_BLL().donvi_thongtin(DonViID.ToString());

            lbl_donvi.Text = DV.TenDonVi;
            danhmuc_bophan(DonViID);

            cbo_loaitaisan.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Thiết bị",0),
                new LopHoTro.DOITUONG("Tài sản cố định",1),
            };
            cbo_loaitaisan.ValueMember = "value";
            cbo_loaitaisan.DisplayMember = "name";
            cbo_loaitaisan.SelectedIndex = 0;
            cbo_loaitaisan.SelectedIndexChanged += new EventHandler(cbo_loaitaisan_SelectedIndexChanged);

            danhmuc_tinhtrang("", DonViID.ToString());
            btn_lamtuoi.Click += new EventHandler(btn_lamtuoi_bophan_Click);
       }
        
        //
       private void danhmuc_bophan(int DonViID)
       {
           BindingSource binding_bophan = new BindingSource();
           binding_bophan.DataSource = (from t in
                                            ((from c in new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonViID)
                                              select new
                                              {
                                                  BoPhanID = c.BoPhanSD,
                                              }).GroupBy(c => c.BoPhanID)
                                                .Select(c => new { BoPhanID = c.Key, SoLuong = c.Count() }))
                                        join bp in new BOPHAN_BLL().bophan_danhsach().ToList() on t.BoPhanID equals bp.BoPhanID
                                        select new
                                        {
                                            BoPhanID = t.BoPhanID,
                                            TenBoPhan = bp.TenBoPhan,
                                            SoLuong = t.SoLuong,
                                        }).ToList();

           binding_bophan.Add(new { BoPhanID = binding_bophan.Count + 1, TenBoPhan = "Tất cả", SoLuong = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonViID).Count() });
           cbo_bophan.DataSource = binding_bophan;
           cbo_bophan.ValueMember = "BoPhanID";
           cbo_bophan.DisplayMembers = "TenBoPhan,SoLuong";

           cbo_bophan.SelectedIndex = cbo_bophan.Nodes.Count - 1;
           cbo_bophan.SelectedIndexChanged += new EventHandler(cbo_bophan_SelectedIndexChanged);
           cbo_bophan_SelectedIndexChanged(null, null);
       }
       private void danhmuc_tinhtrang(string giatri,string DonVi)
       {
           BindingSource binding_tinhtrang = new BindingSource();
           binding_tinhtrang.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Where (c=>c.DonViSD==int.Parse(DonVi)).Select(c => new
           {
               TinhTrangID=c.TinhTrang,
               TenTinhTrang=(c.TinhTrang !=0?c.TINHTRANG1.TenTinhTrang:"Chưa xác định"),
           }).Distinct().ToList();
          // binding_tinhtrang.Add(new { TinhTrangID = 0, TenTinhTrang = "Chưa xác định" });
           binding_tinhtrang.Add(new { TinhTrangID = binding_tinhtrang.Count, TenTinhTrang = "Tất cả" });
           cbo_tinhtrang.DataSource = binding_tinhtrang;

           if (binding_tinhtrang.Count > 0)
           {
               cbo_tinhtrang.ValueMember = "TinhTrangID";
               cbo_tinhtrang.DisplayMember = "TenTinhTrang";

               if (giatri != "") cbo_tinhtrang.SelectedValue = int.Parse(giatri);
               else cbo_tinhtrang.SelectedIndex = cbo_tinhtrang.Items.Count - 1;

               cbo_tinhtrang.SelectedIndexChanged += new EventHandler(cbo_bophan_SelectedIndexChanged);
           }
       }


        private void danhsach_thongkethietbi_donvi()
        {
            var LST_TK_DONVI = from tk_dv in
                                   ((from so in new SOTHEODOI_BLL().sotheodoi_danhsach()
                                     select new
                                    {
                                        DonViSD = so.DonViSD,
                                        GTThietBiID=so.GTThietBiID,
                                    }).GroupBy(g => g.DonViSD)
                                       .Select(c => new { DonViID = c.Key, SoLuong = c.Count() }))
                               join dv in new DONVI_BLL().donvi_danhsach() on tk_dv.DonViID equals dv.DonViID
                               select new
                          {
                              DonViID = tk_dv.DonViID,
                              TenDonVi = dv.TenDonVi,
                              SoLuong = tk_dv.SoLuong,
                          };
                               
            lv_thongke_donvi.Items.Clear();

            if (LST_TK_DONVI != null)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var DV in LST_TK_DONVI.ToList())
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    lv_thongke_donvi.Items.Add(item);
                    item.Tag = DV.DonViID.ToString();
                    item.SubItems.Add(DV.TenDonVi);
                    item.SubItems.Add(DV.SoLuong.ToString());
                }
            }
        }

        //
        private void cbo_loaitaisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_loaitaisan.SelectedIndex >= 0)
            {
                TSCD = (int.Parse(cbo_loaitaisan.SelectedValue.ToString()) == 0 ? false : true);
                cbo_bophan_SelectedIndexChanged(null, null);
            }
        }

        //Làm tươi
        private void btn_lamtuoi_toanbo_Click(object sender, EventArgs e)
        {
            string giatri_donvi = "";
            int giatri_loaits = 0, giatri_tinhtrang = 0;

            if (lv_thongke_donvi.SelectedItems.Count > 0) giatri_donvi = lv_thongke_donvi.SelectedItems[0].Tag.ToString();
            giatri_tinhtrang = int.Parse(cbo_tinhtrang.SelectedValue.ToString());
            giatri_loaits = cbo_loaitaisan.SelectedIndex;

            lbl_donvi.Text = ""; cbo_bophan.Nodes.Clear();
            lv_chitiet_thietbi.Items.Clear();
            danhsach_thongkethietbi_donvi();

            foreach (ListViewItem item in lv_thongke_donvi.Items)
            {
                if (item.Tag.ToString().Equals(giatri_donvi))
                {
                    item.Selected = true;
                    break;
                }
            }
            cbo_loaitaisan.SelectedIndex = giatri_loaits;
        }
        private void btn_lamtuoi_bophan_Click(object sender, EventArgs e)
        {
            int giatri_loaits = 0, giatri_tinhtrang = 0;

            giatri_tinhtrang = int.Parse(cbo_tinhtrang.SelectedValue.ToString());
            giatri_loaits = cbo_loaitaisan.SelectedIndex;

            lbl_donvi.Text = ""; cbo_bophan.Nodes.Clear();
            lv_chitiet_thietbi.Items.Clear();

            danhmuc_bophan(DonViID);
            cbo_loaitaisan.SelectedIndex = giatri_loaits;
            cbo_bophan_SelectedIndexChanged(null, null);
        }

        //
        private void lv_thongke_donvi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thongke_donvi.SelectedItems.Count > 0)
            {
                DonViID = int.Parse(lv_thongke_donvi.SelectedItems[0].Tag.ToString());
                lbl_donvi.Text = lv_thongke_donvi.SelectedItems[0].SubItems[1].Text;
                danhmuc_bophan(DonViID);

                danhmuc_tinhtrang("",lv_thongke_donvi.SelectedItems[0].Tag.ToString());
            }
            else
            {
                lbl_donvi.Text = "";
                cbo_bophan.Nodes.Clear();
                lv_chitiet_thietbi.Items.Clear();
            }
        }
        private void cbo_bophan_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv_chitiet_thietbi.Items.Clear();
            if (cbo_bophan.Nodes.Count > 0)
            {
                //
                ListViewItem item = null;
                ListViewGroup group = null;
                int dem_gr = 0;

                foreach (var TB in new DBDataContext().SOTHEODOI_DONVI(DonViID))
                {
                    dem_gr++;
                    group = new ListViewGroup(dem_gr.ToString() + ". " + TB.TenThietBi);
                    this.lv_chitiet_thietbi.Groups.Add(group);

                    var LST_TB = new DBDataContext().SOTHEODOI_DONVI_BOPHAN_THIETBI(DonViID, null, TB.ThietBiID).ToList();

                    if (TSCD == true) LST_TB = LST_TB.Where(c => c.DonGia >= 10000000).ToList();
                    if (cbo_tinhtrang.SelectedIndex != cbo_tinhtrang.Items.Count - 1) LST_TB = LST_TB.Where(c => c.TinhTrangID == int.Parse(cbo_tinhtrang.SelectedValue.ToString())).ToList();
                    if (cbo_bophan.SelectedIndex != cbo_bophan.Nodes.Count - 1) LST_TB = LST_TB.Where(c => c.BoPhanSD == int.Parse(cbo_bophan.SelectedValue.ToString())).ToList();
                    int dem = 0;
                    
                    foreach (var T in LST_TB)
                    {
                        dem++;
                        item = new ListViewItem(dem_gr.ToString() + "." + dem.ToString());
                        item.Group = group;
                        item.Tag = T.MaCaBiet;

                        lv_chitiet_thietbi.Items.Add(item);
                        item.SubItems.Add(T.MaCaBiet);
                        item.SubItems.Add(T.NgayNhap.Value.ToString("dd/MM/yyyy"));

                        string songaybaohanhconlai = new LopHoTro.CHUYENKIEU().DateDiff(DateTime.Now.Date, T.NgayNhap.Value.Date.AddMonths(T.HanBaoHanh));
                        item.SubItems.Add((songaybaohanhconlai!=string.Empty?string.Format("Còn {0}",songaybaohanhconlai):"Hết BH") + " | (" +T.HanBaoHanh.ToString()+" tháng)");
                        item.SubItems.Add(string.Format("{0:0,0 đ}", T.DonGia));
                        item.SubItems.Add(T.TenBoPhan);
                        item.SubItems.Add(T.TenTinhTrang);

                        for (int cot = 0; cot < lv_chitiet_thietbi.Columns.Count; cot++)
                        {
                            if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        }
                        if (songaybaohanhconlai == string.Empty) item.SubItems[3].BackColor = Color.LightCoral;
                    }
                }
                //
            }
            txt_demsoluong.Text = lv_chitiet_thietbi.Items.Count.ToString();
        }

        //In thống kê
        private void inthongke(string yeucau)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            switch (yeucau)
            {
                case "cacdonvi":
                    BaoCao_ThongKe.report.frm_bienban_thongketinhtrang frm = new ThietBiPY.BaoCao_ThongKe.report.frm_bienban_thongketinhtrang();
                    frm.ShowDialog();
                    break;
                case "donvichitiet":
                    if (DonViID>0)
                    {
                        BaoCao_ThongKe.report.frm_bienban_theodonvisudung frm_dv= new ThietBiPY.BaoCao_ThongKe.report.frm_bienban_theodonvisudung(DonViID.ToString(),TSCD);
                        frm_dv.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn đơn vị cần xem!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        private void btn_inthongke_cacdonvi_Click(object sender, EventArgs e)
        {
            inthongke("cacdonvi");
        }
        private void btn_inthongke_chitietdonvi_Click(object sender, EventArgs e)
        {
            inthongke("donvichitiet");
        }

        private void contextmenu_thongtinthietbi_xemchitiet_Click(object sender, EventArgs e)
        {
            if (lv_chitiet_thietbi.SelectedItems.Count > 0)
            {
                frm_thietbi_thongtinchitiet frm=null;
                if (cbo_bophan.SelectedIndex != cbo_bophan.Nodes.Count - 1)
                {
                     frm = new frm_thietbi_thongtinchitiet(lv_chitiet_thietbi.SelectedItems[0].Tag.ToString(), DonViID.ToString(), cbo_bophan.SelectedValue.ToString());
                }
                else frm = new frm_thietbi_thongtinchitiet(lv_chitiet_thietbi.SelectedItems[0].Tag.ToString(), DonViID.ToString(), "0");
                frm.ShowDialog();
            }
        }
        private void lv_chitiet_thietbi_DoubleClick(object sender, EventArgs e)
        {
            contextmenu_thongtinthietbi_xemchitiet_Click(null, null);
        }
        private void lv_chitiet_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_chitiet_thietbi.SelectedItems.Count > 0)
            {
                lv_chitiet_thietbi.ContextMenuStrip = contextmenu_thongtinthietbi;
            }
            else lv_chitiet_thietbi.ContextMenuStrip = null;
        }

        private void btn_kichthuockhung_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                btn_kichthuockhung.Text = "Hiện";
                splitContainer1.Panel1Collapsed = true;
            }
            else
            {
                btn_kichthuockhung.Text = "Ẩn";
                splitContainer1.Panel1Collapsed = false;
            }
        }

        private void frm_thongke_thietbi_theonoisudung_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    if (this.btn_kichthuockhung.Visible == false)
                    {
                        btn_lamtuoi_bophan_Click(null, null);
                    }
                    else btn_lamtuoi_toanbo_Click(null, null);
                    break;
            }
        }
    }
}
