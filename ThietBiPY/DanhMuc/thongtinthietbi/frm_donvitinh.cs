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
    public partial class frm_donvitinh : Form
    {
        public frm_donvitinh()
        {
            InitializeComponent();

            lv_donvitinh.Columns.Add("STT",50, HorizontalAlignment.Center);
            lv_donvitinh.Columns.Add("Đơn vị tính", 200);
            lv_donvitinh.Columns.Add("Diễn giải", lv_donvitinh.Width - lv_donvitinh.Columns[0].Width - lv_donvitinh.Columns[1].Width - 2);

            LST_DVT = new DONVITINH_BLL().donvitinh_danhsach().ToList();
            hienthi_donvitinh(LST_DVT);
        }

        //khai báo
        List<DONVITINH> LST_DVT = new List<DONVITINH>();
        
        #region "xử lý"
        public void hienthi_donvitinh(List<DONVITINH> LST)
        {
            lv_donvitinh.Items.Clear();

            if (LST != null)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var DVT in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = DVT.DVTID.ToString();
                    lv_donvitinh.Items.Add(item);
                    item.SubItems.Add(DVT.TenDVT);
                    item.SubItems.Add(DVT.DienGiai);

                    for (int cot = 0; cot < lv_donvitinh.Columns.Count; cot++) if(dem%2==0)item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
            thongke();
        }
        public void dieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_donvitinh_capnhat frm = null;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them:
                    frm = new frm_donvitinh_capnhat();
                    frm.DuLieu = new frm_donvitinh_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua:
                    if (lv_donvitinh.SelectedItems.Count > 0)
                    {
                        frm = new frm_donvitinh_capnhat(lv_donvitinh.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_donvitinh_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;


                case (int)LopHoTro.DIEUKHIEN.xoa:
                    if (lv_donvitinh.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng chọn!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new DONVITINH_BLL().donvitinh_xoa(lv_donvitinh.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_donvitinh.Items.Remove(lv_donvitinh.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }

            thongke();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                LST_DVT = new DONVITINH_BLL().donvitinh_danhsach().ToList();
                hienthi_donvitinh(LST_DVT);
            }
        }
        public void thongke() { lbl_thongke.Text = "Tổng số: " + lv_donvitinh.Items.Count.ToString(); }
        public void timkiem()
        {
            if(txt_donvitinh.Text.Length >0)hienthi_donvitinh(LST_DVT.Where(c => c.TenDVT.ToUpper().Contains(txt_donvitinh.Text.ToUpper().Trim())).ToList());
        }

        public string hienthithongtin()
        {
            var TT = new DONVITINH_BLL().donvitinh_thongtin(lv_donvitinh.SelectedItems[0].Tag.ToString());
            return "Tên gọi: " + TT.TenDVT + Environment.NewLine + "Diễn giải: " + Environment.NewLine + (TT.DienGiai== "" || TT.DienGiai ==null ?"chưa cập nhật":TT.DienGiai);
        }
        #endregion
       
        #region "Sự kiện"
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            LST_DVT = new DONVITINH_BLL().donvitinh_danhsach().ToList();
            hienthi_donvitinh(LST_DVT);
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

        private void lv_donvitinh_DoubleClick(object sender, EventArgs e)
        {
            dieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }

        private void frm_donvitinh_KeyDown(object sender, KeyEventArgs e)
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

        private void menustrip_btn_chitiet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hienthithongtin());
        }
        private void menustrip_btn_sua_Click(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void menustrip_btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa_Click(null, null);
        }

        private void lv_donvitinh_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_donvitinh.SelectedItems.Count > 0)
            {
                tooltip_chitiet.SetToolTip(lv_donvitinh, hienthithongtin());
                lv_donvitinh.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_donvitinh.ContextMenuStrip = null;
        }

        private void txt_donvitinh_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }
        #endregion

 

        private void frm_donvitinh_Load(object sender, EventArgs e)
        {
            txt_donvitinh.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_donvitinh).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
