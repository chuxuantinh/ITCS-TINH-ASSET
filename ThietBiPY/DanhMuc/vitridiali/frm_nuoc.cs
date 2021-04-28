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
using ThietBiPY.DanhMuc.vitridiali;

namespace ThietBiPY.DanhMuc.vitridiali
{
    public partial class frm_nuoc : DevComponents.DotNetBar.Office2007Form 
    {
        List<NUOC> LST_NUOC = new List<NUOC>();

        public frm_nuoc()
        {
            InitializeComponent();
            lv_danhmuc.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_danhmuc.Columns.Add("Tên nước", lv_danhmuc.Width - lv_danhmuc.Columns[0].Width - 2);
            hienthi();
        }

        #region "Hàm xử lý"
        public void hienthi()
        {
            LST_NUOC = new NUOC_BLL().nuoc_danhsach().ToList();
            lv_danhmuc.Items.Clear();
           int dem = 0;

            if (LST_NUOC != null)
            {
                foreach (var N in LST_NUOC)
                {
                    dem++;
                    ListViewItem item = new ListViewItem(dem.ToString());
                    item.Tag = N.NuocID.ToString();
                    lv_danhmuc.Items.Add(item);
                    item.SubItems.Add(N.TenNuoc);

                    for (int cot = 0; cot < lv_danhmuc.Columns.Count; cot++)
                    {
                        item.SubItems[0].ForeColor = Color.Blue;
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "") hienthi();
        }
        public void chucnang(int lenh)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            frm_nuoc_capnhat frm = null;
            switch (lenh)
            {
                case 1:
                    frm = new frm_nuoc_capnhat();
                    frm.DuLieu = new frm_nuoc_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;
                case 2:
                    if (lv_danhmuc.SelectedItems.Count > 0)
                    {
                        frm = new frm_nuoc_capnhat(lv_danhmuc.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_nuoc_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    break;
                case 3:
                    if (lv_danhmuc.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng được chọn!", "Xóa", MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new NUOC_BLL().nuoc_xoa(lv_danhmuc.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_danhmuc.Items.Remove(lv_danhmuc.SelectedItems[0]);
                            }
                        }
                    }
                    break;

                case 4:
                    if (lv_danhmuc.SelectedItems.Count > 0)
                    {
                        ListViewItem item = (ListViewItem)lv_danhmuc.SelectedItems[0].Clone();
                       NUOC_BLL NUOC = new NUOC_BLL();
                        NUOC.NUOC_DTO.TenNuoc = "Sao chép-" + item.SubItems[1].Text;
                        if (NUOC.nuoc_them() > 0)
                        {
                            item.Tag = NUOC.NUOC_DTO.NuocID.ToString();
                            item.SubItems[0].Text = (lv_danhmuc.Items.Count + 1).ToString();
                            item.SubItems[1].Text = NUOC.NUOC_DTO.TenNuoc;
                            lv_danhmuc.Items.Add(item);
                        }
                    }
                    break;
            }
            thongke();
        }
        public void thongke()
        {
            lbl_thongke.Text = "Số lượng: " + (lv_danhmuc.Items.Count).ToString();
        }
        #endregion

        #region "Các nút lệnh"
        private void btn_danhmuc_them_Click(object sender, EventArgs e)
        {
            chucnang(1);
        }
        private void btn_danhmuc_sua_Click(object sender, EventArgs e)
        {
            chucnang(2);
        }
        private void btn_danhmuc_xoa_Click(object sender, EventArgs e)
        {
            chucnang(3);
        }
        private void btn_danhmuc_lamtuoi_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        #endregion

        private void menustrip_chucnangphu_suadong_Click(object sender, EventArgs e)
        {
            btn_danhmuc_sua_Click(null, null);
        }
        private void menustrip_chucnangphu_xoadong_Click(object sender, EventArgs e)
        {
            btn_danhmuc_xoa_Click(null, null);
        }
        private void menustrip_chucnangphu_nhandoidong_Click(object sender, EventArgs e)
        {
            chucnang(4);
        }

        private void lv_danhmuc_DoubleClick(object sender, EventArgs e)
        {
            btn_danhmuc_sua_Click(null, null);
        }
        private void frm_nuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btn_danhmuc_xoa_Click(null, null);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btn_danhmuc_lamtuoi_Click(null, null);
            }
        }
        private void lv_danhmuc_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_danhmuc.SelectedItems.Count > 0)
            {
                lv_danhmuc.ContextMenuStrip = menustrip_chucnangphu;
            }
            else lv_danhmuc.ContextMenuStrip = null;
        }
    }
}
