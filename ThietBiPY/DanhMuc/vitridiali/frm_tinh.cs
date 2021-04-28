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
    public partial class frm_tinh : DevComponents.DotNetBar.Office2007Form 
    {
        List<TINH> LST_TINH = new List<TINH>();

        public frm_tinh()
        {
            InitializeComponent();
            lv_danhmuc.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_danhmuc.Columns.Add("Tên tỉnh", 250);
            lv_danhmuc.Columns.Add("Tên nước", lv_danhmuc.Width - lv_danhmuc.Columns[0].Width - lv_danhmuc.Columns[1].Width - 2);
        }

        #region "Hàm Xử Lý"
        //
        public void danhmuc_nuoc(string giatri)
        {
            //LST_TINH = new TINH_BLL().tinh_danhsach().ToList();
            BindingSource binding_tinh = new BindingSource();
            binding_tinh.DataSource = new NUOC_BLL().nuoc_danhsach().Select(c => new NUOC
            {
                NuocID =c.NuocID ,
                TenNuoc=c.TenNuoc +"  ("+new TINH_BLL ().tinh_danhsach().Where(t=>t.NuocID==c.NuocID ).Count ().ToString ()+")",
            }).ToList();

            binding_tinh.Add(new NUOC
            {
                NuocID = 0,
                TenNuoc = "Chưa xác định" + "  (" + new TINH_BLL().tinh_danhsach().Where(t => t.NuocID == 0).Count().ToString() + ")",
            });
            cbo_tennuoc.DataSource = binding_tinh;
            cbo_tennuoc.DisplayMember = "TenNuoc";
            cbo_tennuoc.ValueMember = "NuocID";
            if (giatri != "")
            {
                cbo_tennuoc.SelectedValue = int.Parse(giatri);
            }
            else cbo_tennuoc.SelectedIndex = 0;
            cbo_tennuoc.SelectedIndexChanged += new EventHandler(cbo_tenuoc_select);
            cbo_tenuoc_select(null, null);
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                danhmuc_nuoc(new TINH_BLL().tinh_thongtin(giatri).NuocID.ToString());
            }
        }
        public void thongke()
        {
            lbl_thongke.Text = "Số lượng: " + (lv_danhmuc.Items.Count).ToString();
        }

        //Hiển thị danh sách ra lưới View
        private void cbo_tenuoc_select(object sender, EventArgs e)
        {
            ListViewItem item = null;
            lv_danhmuc.Items.Clear();
            LST_TINH = new TINH_BLL().tinh_danhsach().Where(c => c.NuocID == (int)cbo_tennuoc.SelectedValue).ToList();
            if (LST_TINH != null)
            {
                int dem = 0;
                foreach (var T in LST_TINH)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = T.TinhID.ToString();
                    lv_danhmuc.Items.Add(item);
                    item.SubItems.Add(T.TenTinh);
                    item.SubItems.Add(T.NuocID !=0?T.NUOC.TenNuoc :"Chưa xác định");

                    for (int cot = 0; cot < lv_danhmuc.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        item.SubItems[0].Font = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
                        item.SubItems[0].BackColor = Color.WhiteSmoke;
                    }
                }
            }
            thongke();
        }
        #endregion
          
        #region "Các sự kiện"
        //
        private void frm_tinh_Load(object sender, EventArgs e)
        {
            danhmuc_nuoc("");
        }
        
        //
        private void menustrip_chucnangphu_xoadong_Click(object sender, EventArgs e)
        {
            btn_danhmuc_xoa_Click(null, null);
        }
        private void menustrip_chucnangphu_lamtuoi_Click(object sender, EventArgs e)
        {
            btn_danhmuc_lamtuoi_Click(null, null);
        }

        //
        private void btn_danhmuc_them_Click(object sender, EventArgs e)
        {
            frm_tinh_capnhat frm = new frm_tinh_capnhat(cbo_tennuoc.SelectedValue.ToString());
            frm.DuLieu = new frm_tinh_capnhat.passData(nhandulieu);
            frm.ShowDialog();
        }
        private void btn_danhmuc_sua_Click(object sender, EventArgs e)
        {
            if (lv_danhmuc.SelectedItems.Count > 0)
            {
                frm_tinh_capnhat frm = new frm_tinh_capnhat(lv_danhmuc.SelectedItems[0].Tag.ToString(),cbo_tennuoc.SelectedValue.ToString());
                frm.DuLieu = new frm_tinh_capnhat.passData(nhandulieu);
                frm.ShowDialog();
            }
        }
        private void btn_danhmuc_xoa_Click(object sender, EventArgs e)
        {

            if (lv_danhmuc.SelectedItems.Count > 0)
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng được chọn!", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (new TINH_BLL ().tinh_xoa(lv_danhmuc.SelectedItems[0].Tag.ToString()) > 0)
                    {
                        lv_danhmuc.Items.Remove(lv_danhmuc.SelectedItems[0]);
                        thongke();
                    }
                }
            }
        }
        private void btn_danhmuc_lamtuoi_Click(object sender, EventArgs e)
        {
            int vitricu = (int)cbo_tennuoc.SelectedValue ;
            danhmuc_nuoc(vitricu.ToString());
        }

        //
        private void lv_danhmuc_DoubleClick(object sender, EventArgs e)
        {
            btn_danhmuc_sua_Click(null, null);
        }
        private void lv_danhmuc_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_danhmuc.SelectedItems.Count > 0)
            {
                lv_danhmuc.ContextMenuStrip = menustrip_chucnangphu;
            }
            else lv_danhmuc.ContextMenuStrip = null;
        }

        private void frm_tinh_KeyDown(object sender, KeyEventArgs e)
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
        #endregion
    }
}
