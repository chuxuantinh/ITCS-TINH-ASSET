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

namespace ThietBiPY.DanhMuc.thongtindonvi
{
    public partial class frm_donvi : DevComponents.DotNetBar.Office2007Form 
    {

        List<DONVI> LST_DONVI = new List<DONVI>();
        public frm_donvi()
        {
            InitializeComponent();
            this.Text = "Đơn vị";

            lv_donvi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_donvi.Columns.Add("Đơn vị", 200);
            lv_donvi.Columns.Add("Điện thoại", 200);
            lv_donvi.Columns.Add("Diễn giải", lv_donvi.Width - lv_donvi.Columns[0].Width - lv_donvi.Columns[1].Width - lv_donvi.Columns[2].Width - 2);

            LST_DONVI = new DONVI_BLL().donvi_danhsach().ToList();
            danhsachdonvi(LST_DONVI);
        }

        #region "Hàm xử lý"
        //
        public void danhsachdonvi(List<DONVI> LST)
        {
            lv_donvi.Items.Clear();
            if (LST != null)
            {
                ListViewItem item = null;
                int dem = 0;

                foreach (var DV in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = DV.DonViID.ToString();
                    lv_donvi.Items.Add(item);
                    item.SubItems.Add(DV.TenDonVi);
                    item.SubItems.Add(DV.DienThoai);
                    item.SubItems.Add(DV.DienGiai);
                    for (int cot = 0; cot < lv_donvi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        item.SubItems[0].ForeColor = Color.Blue;
                    }
                }
            }
            thongke();
        }
        public void thongke()
        {
            lbl_thongke.Text = "Tổng số: " + lv_donvi.Items.Count.ToString();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                LST_DONVI = new DONVI_BLL().donvi_danhsach().ToList();
                danhsachdonvi(LST_DONVI); 
            }
        }
        public void bangdieukhien(int tt)
        {
            frm_donvi_capnhat frm = null;
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN .them :
                    frm = new frm_donvi_capnhat();
                    frm.DuLieu = new frm_donvi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua :
                    if (lv_donvi.SelectedItems.Count > 0)
                    {
                        frm = new frm_donvi_capnhat(lv_donvi.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_donvi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_donvi.SelectedItems.Count > 0)
                    {
                        if (new DONVI_BLL().donvi_xoa(lv_donvi.SelectedItems[0].Tag.ToString()) > 0)
                        {
                            lv_donvi.Items.Remove(lv_donvi.SelectedItems[0]);
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            thongke();
        }
        //
        #endregion
        //
        #region "Sự kiện"
        private void txt_donvi_TextChanged(object sender, EventArgs e)
        {
            if (txt_donvi.Text.Length > 0)
            {
                danhsachdonvi(LST_DONVI.Where(c => c.TenDonVi.ToUpper().Contains(txt_donvi.Text.ToUpper())).ToList());
            }
            else danhsachdonvi(LST_DONVI);
        }

        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            LST_DONVI = new List<DONVI>();
            LST_DONVI = new DONVI_BLL().donvi_danhsach().ToList();
            danhsachdonvi(LST_DONVI);
            this.Cursor = Cursors.Default;
        }
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


        private void lv_donvi_DoubleClick(object sender, EventArgs e)
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

        private void lv_donvi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_donvi.SelectedItems.Count > 0)
            {
                lv_donvi.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_donvi.ContextMenuStrip = null;
        }
        private void frm_donvi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_sua_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
                case Keys.Delete: btn_xoa_Click(null, null); break;
            }
        }

        private void frm_donvi_Load(object sender, EventArgs e)
        {
            txt_donvi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_donvi).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        //
        #endregion
    }
}
