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

namespace ThietBiPY.BaoCao_ThongKe.thongkethietbi
{
    public partial class frm_thongke_thietbi_theoloaithietbi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_thongke_thietbi_theoloaithietbi()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50,HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Loại thiết bị", 400);
            lv_thietbi.Columns.Add("Số lượng",100,HorizontalAlignment.Center);

            danhmuc_nhomthietbi("");
        }

        //
        public void danhmuc_nhomthietbi(string giatri)
        {
            BindingSource binding_nhomthietbi = new BindingSource();
            binding_nhomthietbi.DataSource = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().Select(c => new
            {
                NhomTBID = c.NhomTBID,
                TenNhomTB = c.TenNhomTB,
            });
            binding_nhomthietbi.Add(new { NhomTBID = 0, TenNhomTB = "Chưa xác định" });
            cbo_nhomthietbi.DataSource = binding_nhomthietbi;
            cbo_nhomthietbi.ValueMember = "NhomTBID";
            cbo_nhomthietbi.DisplayMember = "TenNhomTB";

            if (giatri == "")
            {
                cbo_nhomthietbi.SelectedIndex = 0;
            }
            else cbo_nhomthietbi.SelectedValue = int.Parse(giatri);
            cbo_nhomthietbi.SelectedIndexChanged += new EventHandler(hienthi_thongke_thietbi);
            hienthi_thongke_thietbi(null, null);
        }
        public void hienthi_thongke_thietbi(object sender,EventArgs e)
        {
            var LST_LOAITHIETBI = new LOAITHIETBI_BLL().loaithietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.LoaiTBID,
                TenLoaiTB = c.TenLoaiTB,
                NhomTBID = c.NhomTBID ,
                SoLuongTB = new THIETBI_BLL ().thietbi_danhsach ().Where (t=>t.LoaiTBID == c.LoaiTBID ).Count (),
            }).ToList();
            if (cbo_nhomthietbi.SelectedIndex >= 0)
            {
                LST_LOAITHIETBI = LST_LOAITHIETBI.Where(c => c.NhomTBID == (int)cbo_nhomthietbi.SelectedValue).OrderByDescending (c=>c.SoLuongTB ).ToList();
            }

            lv_thietbi.Items.Clear();
            if (LST_LOAITHIETBI.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var LTB in LST_LOAITHIETBI)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = LTB.LoaiTBID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(LTB.TenLoaiTB);
                    item.SubItems.Add(LTB.SoLuongTB.ToString());

                    for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            //
            txt_thongke.Text = "Tổng cộng : " + LST_LOAITHIETBI.Where(c => c.SoLuongTB > 0).Count().ToString() + " thiết bị";
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            int giatribandau = (int)cbo_nhomthietbi.SelectedValue;
            danhmuc_nhomthietbi(giatribandau.ToString());
        }

        private void lv_thietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                lv_thietbi.ContextMenuStrip = context_menu;
            }
            else lv_thietbi.ContextMenuStrip = null;
        }
        private void context_menu_xemdanhsachthietbi_Click(object sender, EventArgs e)
        {
            if (int.Parse(lv_thietbi.SelectedItems[0].SubItems[2].Text) > 0)
            {
                frm_thongke_thietbi_theoloaithietbi_chitiet frm = new frm_thongke_thietbi_theoloaithietbi_chitiet(lv_thietbi.SelectedItems[0].Tag.ToString());
                frm.ShowDialog();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa có thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            context_menu_xemdanhsachthietbi_Click(null, null);
        }
    }
}
