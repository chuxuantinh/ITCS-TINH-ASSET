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

namespace ThietBiPY.DanhMuc.thongtindonvi
{
    public partial class frm_bophan : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_bophan()
        {
            InitializeComponent();
            lv_bophan.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_bophan.Columns.Add("Bộ phận", 250);
            lv_bophan.Columns.Add("Diễn giải", lv_bophan.Width - lv_bophan.Columns[0].Width - lv_bophan.Columns[1].Width-2);
            danhmuc_donvi("");
            loc_danhsachbophan();
            txt_bophan.TextChanged += new EventHandler(txt_bophan_TextChanged);
        }

        #region "Hàm xử lý"
        //
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "[Chưa xác định..]", DienThoai = "", DienGiai = "" });
            cbo_donvi.DataSource = binding_donvi;
            cbo_donvi.ValueMember = "DonViID";
            cbo_donvi.DisplayMember = "TenDonVi";

            if (giatri == "")
            {
                cbo_donvi.SelectedIndex = 0;
            }
            else cbo_donvi.SelectedValue = int.Parse(giatri);
            cbo_donvi.SelectedIndexChanged += new EventHandler(cbo_donvi_SelectIndexChanged);
        }
        public void cbo_donvi_SelectIndexChanged(object sender, EventArgs e)
        {
            loc_danhsachbophan();
        }
        public void txt_bophan_TextChanged(object sender, EventArgs e)
        {
            loc_danhsachbophan();
        }

        public void thongke()
        {
            txt_thongke.Text = "Tổng số: " + lv_bophan.Items.Count.ToString();
        }
        public void hienthi_danhsachbophan(List<BOPHAN> LST)
        {
            lv_bophan.Items.Clear();
            if (LST.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var BP in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = BP.BoPhanID.ToString();
                    lv_bophan.Items.Add(item);
                    item.SubItems.Add(BP.TenBoPhan);
                    item.SubItems.Add(BP.DienGiai);

                    for (int cot = 0; cot < lv_bophan.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void loc_danhsachbophan()
        {
            var LST = new BOPHAN_BLL().bophan_danhsach().ToList();
            if (cbo_donvi.SelectedIndex >= 0)
            {
                LST = LST.Where(c => c.DonViID == (int)cbo_donvi.SelectedValue).ToList();
            }
            if (txt_bophan.Text != "")
            {
                LST = LST.Where(c => c.TenBoPhan.ToUpper().Contains(txt_bophan.Text.ToUpper())).ToList();
            }

            hienthi_danhsachbophan(LST);
        }
        //
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                danhmuc_donvi(new BOPHAN_BLL().bophan_thongtin(giatri).DonViID.ToString());
            }
        }
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_bophan_capnhat frm =null;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them:
                    frm = new frm_bophan_capnhat(cbo_donvi.SelectedValue.ToString());
                    frm.DuLieu = new frm_bophan_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua :
                    if (lv_bophan.SelectedItems.Count > 0)
                    {
                        frm = new frm_bophan_capnhat(lv_bophan.SelectedItems[0].Tag.ToString(),cbo_donvi.SelectedValue.ToString());
                        frm.DuLieu =new frm_bophan_capnhat.passData(nhandulieu);
                        frm.ShowDialog(); 
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_bophan.SelectedItems.Count > 0)
                    {
                        if (new BOPHAN_BLL().bophan_xoa(lv_bophan.SelectedItems[0].Tag.ToString()) > 0)
                        {
                            lv_bophan.Items.Remove(lv_bophan.SelectedItems[0]);
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    loc_danhsachbophan();
                    break;
            }
            thongke();
        }

        #endregion

        #region "Sự kiện"
        //
        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.them);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }

        private void frm_bophan_Load(object sender, EventArgs e)
        {
            txt_bophan.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_bophan).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void frm_bophan_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_sua_Click(null, null); break;
                case Keys.Delete: btn_xoadong_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }

        private void contextmenu_dieukhien_hieuchinh_Click(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void contextmenu_dieukhien_xoadong_Click(object sender, EventArgs e)
        {
            btn_xoadong_Click(null, null);
        }

        private void lv_bophan_DoubleClick(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }

        private void cbo_donvi_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }
            //user mouse is hovering over this drop-down item, update its data 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {   // this tooltip simply shows the displayed text to the right of the drop-down  box, customize as needed 
                toolTip1.Show(cbo_donvi.GetItemText(cbo_donvi.Items[e.Index]), cbo_donvi, e.Bounds.Right, e.Bounds.Bottom);
            }
            e.DrawBackground();
            // draw text strings 
            e.Graphics.DrawString(cbo_donvi.Items[e.Index].ToString(), e.Font,
                Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void cbo_donvi_DropDownClosed(object sender, EventArgs e)
        {
            toolTip1.Hide(cbo_donvi);
        }
        //
        #endregion
    }
}
