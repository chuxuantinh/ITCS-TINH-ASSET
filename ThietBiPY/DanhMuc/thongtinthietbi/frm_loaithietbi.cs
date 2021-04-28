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

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_loaithietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_loaithietbi()
        {
            InitializeComponent();
            this.Text = "Loại thiết bị";
            load_nhomthietbi();

            lv_loaithietbi.Columns.Add("STT", 40,HorizontalAlignment .Center );
            lv_loaithietbi.Columns.Add("Loại thiết bị", 250);
//          lv_loaithietbi.Columns.Add("Nhóm thiết bị", 200);
            lv_loaithietbi.Columns.Add("Diễn giải",lv_loaithietbi.Width- lv_loaithietbi.Columns[0].Width - lv_loaithietbi.Columns[1].Width-2);

            cbo_nhomthietbi.SelectedIndexChanged += new EventHandler(cbo_nhomthietbi_select);
            cbo_nhomthietbi_select(null, null);
        }

        List<LOAITHIETBI> LST_LOAITB = new List<LOAITHIETBI>();

        #region "Các hàm xử lý"
        //danh sách nhóm thiết bị
        public void load_nhomthietbi()
        {
            BindingSource binding_nhomthietbi = new BindingSource();
            binding_nhomthietbi.DataSource = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList();
            binding_nhomthietbi.Add(new NHOMTHIETBI
            {
                NhomTBID = 0,
                TenNhomTB ="Chưa xác định",
                DienGiai = "",
            });
            if (binding_nhomthietbi.Count > 0)
            {
                cbo_nhomthietbi.DataSource = binding_nhomthietbi;
                cbo_nhomthietbi.ValueMember = "NhomTBID";
                cbo_nhomthietbi.DisplayMember = "TenNhomTB";
            }
        }

        // danh sách loại thiết bị theo nhóm
        public void hienthiloaithietbi(List<LOAITHIETBI> LST)
        {
            lv_loaithietbi.Items.Clear();
            if (LST.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                
                foreach (var L in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = L.LoaiTBID.ToString();
                    lv_loaithietbi.Items.Add(item);
                    item.SubItems.Add(L.TenLoaiTB);
                    item.SubItems.Add(L.DienGiai);
                    for (int cot = 0; cot < lv_loaithietbi.Columns.Count; cot++)
                    {
                        if(dem%2==0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        if (cot == 2) item.SubItems[cot].ForeColor = Color.Blue;
                    }
                }
            }
            thongke();

        }
        public void thongke() { lbl_thongke.Text = "Tổng số: " + lv_loaithietbi.Items.Count.ToString(); }

        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                load_nhomthietbi();
                cbo_nhomthietbi.SelectedValue = new LOAITHIETBI_BLL().loaithietbi_thongtin(giatri).NhomTBID;
            }
        }
        public void bangdieukhien(int tt)
        {
            frm_loaithietbi_capnhat frm = null;
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN .them :
                    frm = new frm_loaithietbi_capnhat(cbo_nhomthietbi.SelectedValue.ToString());
                    frm.DuLieu = new frm_loaithietbi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN .sua :
                    if (lv_loaithietbi.SelectedItems.Count > 0)
                    {
                        frm = new frm_loaithietbi_capnhat(lv_loaithietbi.SelectedItems[0].Tag.ToString(),cbo_nhomthietbi.SelectedValue.ToString());
                        frm.DuLieu = new frm_loaithietbi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_loaithietbi.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new LOAITHIETBI_BLL().loaithietbi_xoa(lv_loaithietbi.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_loaithietbi.Items.Remove(lv_loaithietbi.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            thongke();
        }
        public void cbo_nhomthietbi_select(object sender, EventArgs e)
        {
            if (cbo_nhomthietbi.SelectedIndex >= 0)
            {
                LST_LOAITB = new LOAITHIETBI_BLL().loaithietbi_danhsach().Where(c => c.NhomTBID == (int)cbo_nhomthietbi.SelectedValue).ToList();
                hienthiloaithietbi(LST_LOAITB);
            }
        }
        #endregion

        #region "Sự kiện"
        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.them);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            int nhomtb =(int) cbo_nhomthietbi.SelectedValue;
            load_nhomthietbi();
           if(new NHOMTHIETBI_BLL ().nhomthietbi_thongtin (nhomtb.ToString ())!=null) cbo_nhomthietbi.SelectedValue = nhomtb;
        }
        private void txt_loaithietbi_TextChanged(object sender, EventArgs e)
        {
            if (txt_loaithietbi.Text.Length > 0)
            {
                var LST_TIM = LST_LOAITB.Where(c => c.TenLoaiTB.ToUpper().Contains(txt_loaithietbi.Text.ToUpper())).ToList();
                hienthiloaithietbi(LST_TIM);
            }
            else cbo_nhomthietbi_select(null, null);

        }

        private void lv_loaithietbi_DoubleClick(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void frm_loaithietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_sua_Click(null, null); break;
                case Keys.Delete: btn_xoa_Click(null, null); break;
            }
        }
        private void lv_loaithietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_loaithietbi.SelectedItems.Count > 0)
            {
                lv_loaithietbi.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_loaithietbi.ContextMenuStrip = null;
        }

        private void menustrip_btn_sua_Click(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void menustrip_btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa_Click(null, null);
        }
        private void frm_loaithietbi_Load(object sender, EventArgs e)
        {
            txt_loaithietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_loaithietbi).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        #endregion
    }
}
