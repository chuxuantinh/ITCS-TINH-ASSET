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

namespace ThietBiPY.NghiepVu
{
    public partial class frm_danhgialaithietbi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_danhgialaithietbi()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Bộ phận sử dụng", 150);
            lv_thietbi.Columns.Add("Tình trạng", 120);
            lv_thietbi.Columns.Add("Hiện trạng", 200);

            danhmuc_donvi("");
        }

        int DonViID = 0, BoPhanID = 0;
        public frm_danhgialaithietbi(string DonViID)
        {
            InitializeComponent();
            this.panel_tren.Visible = false;

            this.DonViID = int.Parse(DonViID);
            lv_thietbi.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã cá biệt", 100);
            lv_thietbi.Columns.Add("Bộ phận sử dụng", 150);
            lv_thietbi.Columns.Add("Tình trạng", 120);
            lv_thietbi.Columns.Add("Hiện trạng", 200);

            danhsach_bophan();
        }

        //
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().Select(c => new
            {
                DonViID = c.DonViID,
                TenDonVi = c.TenDonVi,
            });
            if(binding_donvi.Count==0) binding_donvi.Add(new {DonViID = 0, TenDonVi = "Chưa xác định" });

            cbo_donvisudung.DataSource = binding_donvi;
            cbo_donvisudung.ValueMember = "DonViID";
            cbo_donvisudung.DisplayMember = "TenDonVi";

            cbo_donvisudung.SelectedIndexChanged += new EventHandler(cbo_donvisudung_SelectedIndexChanged);
            if (giatri != "") cbo_donvisudung.SelectedValue = int.Parse(giatri);
            else cbo_donvisudung.SelectedIndex = 0;
            cbo_donvisudung_SelectedIndexChanged(null, null);

        }
        private void cbo_donvisudung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_donvisudung.SelectedIndex >= 0)
            {
                DonViID = int.Parse(cbo_donvisudung.SelectedValue.ToString());
                danhsach_bophan();
            }
        }
      
        //
        public void danhsach_bophan()
        {
            var LST_BP= new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == DonViID).Select(c => new
            {
                BoPhanID=c.BoPhanID,
                TenBoPhan=c.TenBoPhan,
            }).ToList();

            LST_BP.Add (new{BoPhanID=0,TenBoPhan="Chưa xác định"});

            trv_bophan.Nodes.Clear();
            lv_thietbi.Items.Clear();

            var DV=new DONVI_BLL().donvi_thongtin(DonViID.ToString());
            if (DV != null)
            {
                TreeNode node_goc = new TreeNode(DV.TenDonVi);
                node_goc.Nodes.Add(new TreeNode("Tất cả"));
                TreeNode node_cha = null;
                foreach (var BP in LST_BP)
                {
                    node_cha = new TreeNode(BP.TenBoPhan);
                    node_cha.Tag = BP.BoPhanID.ToString();
                    node_goc.Nodes.Add(node_cha);
                }
                node_goc.Expand();
                trv_bophan.Nodes.Add(node_goc);
            }
        }

        //
        public void nhandulieu(string giatri)
        {
            if (giatri != "")
            {
                trv_bophan_AfterSelect(null, null);
            }
        }
        private void trv_bophan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                lv_thietbi.Items.Clear();

                    ListViewItem item = null;
                    ListViewGroup group = null;
                    int dem_gr = 0;

                    foreach (var TB in new DBDataContext().SOTHEODOI_DONVI(DonViID))
                    {
                        dem_gr++;
                        group = new ListViewGroup(dem_gr.ToString() + ". " + TB.TenThietBi);
                        this.lv_thietbi.Groups.Add(group);

                        var LST_TB = new DBDataContext().SOTHEODOI_DONVI_BOPHAN_THIETBI(DonViID, null, TB.ThietBiID).ToList();
                        
                        if (trv_bophan.SelectedNode.Index > 0)
                        {
                            BoPhanID = int.Parse(trv_bophan.SelectedNode.Tag.ToString());
                            LST_TB = LST_TB.Where(c => c.BoPhanSD == int.Parse(trv_bophan.SelectedNode.Tag.ToString())).ToList();
                            txt_tongsothietbi.Text = "Tổng số: " + new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonViID && c.BoPhanSD == int.Parse(trv_bophan.SelectedNode.Tag.ToString())).Count().ToString();
                        }
                        else txt_tongsothietbi.Text = "Tổng số: " + new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonViID).Count().ToString();

                        int dem = 0;
                        foreach (var T in LST_TB)
                        {
                            dem++;
                            item = new ListViewItem(dem_gr.ToString() + "." + dem.ToString());
                            item.Group = group;
                            item.Tag = T.GTThietBiID.ToString();

                            lv_thietbi.Items.Add(item);
                            item.SubItems.Add(T.MaCaBiet);

                            item.SubItems.Add(T.TenBoPhan);
                            item.SubItems.Add(T.TenTinhTrang);
                            item.SubItems.Add(T.HienTrang);
                            for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                            {
                                if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                            }
                        }
                    }
                }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                lv_thietbi.ContextMenuStrip = contextmenu_thietbi;
            }
            else lv_thietbi.ContextMenuStrip = null;
        }

        private void contextmenu_thietbi_danhgialai_Click(object sender, EventArgs e)
        {
            NghiepVu.capnhatphu.frm_danhgialaithietbi_capnhat frm = new ThietBiPY.NghiepVu.capnhatphu.frm_danhgialaithietbi_capnhat(lv_thietbi.SelectedItems[0].Tag.ToString());
            frm.DuLieu = new ThietBiPY.NghiepVu.capnhatphu.frm_danhgialaithietbi_capnhat.passData(nhandulieu);
            frm.ShowDialog();
        }

        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                contextmenu_thietbi_danhgialai_Click(null, null);
            }
        }
        //

    }
}
