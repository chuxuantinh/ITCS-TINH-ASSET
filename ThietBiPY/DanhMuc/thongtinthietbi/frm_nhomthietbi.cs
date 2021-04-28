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
using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_nhomthietbi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_nhomthietbi()
        {
            InitializeComponent();
            this.Text = "Nhóm thiết bị";
            lv_nhomthietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nhomthietbi.Columns.Add("Nhóm thiết bị", 200);
            lv_nhomthietbi.Columns.Add("Diễn giải", lv_nhomthietbi.Width - lv_nhomthietbi.Columns[0].Width - lv_nhomthietbi.Columns[1].Width - 2);

            LST_NHOMTB = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList();
            hienthinhomthietbi(LST_NHOMTB);
        }
        List<NHOMTHIETBI> LST_NHOMTB = new List<NHOMTHIETBI>();

        #region "Xử lý"
        public void hienthinhomthietbi(List<NHOMTHIETBI> LST)
        {
            if (LST != null)
            {
                ListViewItem item = null;
                lv_nhomthietbi.Items.Clear();
                int dem = 0;

                foreach (var TB in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = TB.NhomTBID.ToString();
                    lv_nhomthietbi.Items.Add(item);
                    item.SubItems.Add(TB.TenNhomTB);
                    item.SubItems.Add(TB.DienGiai);

                    for (int cot = 0; cot < lv_nhomthietbi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
        }
        public void timkiem()
        {
            hienthinhomthietbi(LST_NHOMTB.Where(c => c.TenNhomTB.ToUpper().Contains(txt_nhomthietbi.Text.ToUpper())).ToList());
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                LST_NHOMTB = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList();
                hienthinhomthietbi(LST_NHOMTB);
            }
        }

        public void thongke()
        {
            lbl_thongke.Text = "Tổng số: " + lv_nhomthietbi.Items.Count.ToString();
        }
        public void dieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_nhomthietbi_capnhat frm = null;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them:
                    frm = new frm_nhomthietbi_capnhat();
                    frm.DuLieu = new frm_nhomthietbi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua:
                    if (lv_nhomthietbi.SelectedItems.Count > 0)
                    {
                        frm = new frm_nhomthietbi_capnhat(lv_nhomthietbi.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_nhomthietbi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                case (int)LopHoTro.DIEUKHIEN.xoa:
                    if (lv_nhomthietbi.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng chọn!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new NHOMTHIETBI_BLL().nhomthietbi_xoa(lv_nhomthietbi.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_nhomthietbi.Items.Remove(lv_nhomthietbi.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }

            thongke();
        }
        #endregion

        #region "Sự kiện"
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            LST_NHOMTB = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList ();
            hienthinhomthietbi(LST_NHOMTB);
        }
        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            dieukhien((int)LopHoTro.DIEUKHIEN.them);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            dieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            dieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }

        private void frm_nhomthietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_sua_Click(null, null); break;
                case Keys.Delete: btn_xoa_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }

        private void lv_nhomthietbi_DoubleClick(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void menustrip_btn_sua_Click(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void menustrip_btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa_Click(null, null);
        }

        private void lv_nhomthietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_nhomthietbi.SelectedItems.Count > 0)
            {
                lv_nhomthietbi.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_nhomthietbi.ContextMenuStrip = null;
        }
        private void txt_nhomthietbi_TextChanged(object sender, EventArgs e)
        {
            if (txt_nhomthietbi.Text.Length > 0) timkiem();
        }
        #endregion

        private void frm_nhomthietbi_Load(object sender, EventArgs e)
        {
            txt_nhomthietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_nhomthietbi).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
