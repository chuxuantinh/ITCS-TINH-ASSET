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

namespace ThietBiPY.DanhMuc.thongtinnhanvien
{
    public partial class frm_chucvu : DevComponents.DotNetBar.Office2007Form 
    {
        List<CHUCVU> LST_CHUCVU = new List<CHUCVU>();

        public frm_chucvu()
        {
            InitializeComponent();
            lv_chucvu.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_chucvu.Columns.Add("Chức vụ", 200);
            lv_chucvu.Columns.Add("Cấp bậc", 70,HorizontalAlignment.Center);
            lv_chucvu.Columns.Add("Diễn giải", lv_chucvu.Width - lv_chucvu.Columns[0].Width - lv_chucvu.Columns[1].Width - lv_chucvu.Columns[2].Width - 2);

            LST_CHUCVU = new CHUCVU_BLL().chucvu_danhsach().ToList();
            danhsachchucvu(LST_CHUCVU);
        }

        #region "Hàm xử lý"
        public void danhsachchucvu(List<CHUCVU> LST)
        {
            lv_chucvu.Items.Clear();
            if (LST.Count() > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var CV in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = CV.ChucVuID.ToString();
                    lv_chucvu.Items.Add(item);
                    item.SubItems.Add(CV.TenChucVu);
                    item.SubItems.Add(CV.CapBac.ToString());
                    item.SubItems.Add(CV.DienGiai);

                    for (int cot = 0; cot < lv_chucvu.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        if (cot == 2) item.SubItems[cot].ForeColor = Color.Brown;
                    }
                }
            }
            thongke();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                LST_CHUCVU = new CHUCVU_BLL().chucvu_danhsach().ToList();
                danhsachchucvu(LST_CHUCVU);
            }
        }
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_chucvu_capnhat frm = null;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them :
                    frm = new frm_chucvu_capnhat();
                    frm.DuLieu = new frm_chucvu_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua :
                    if (lv_chucvu.SelectedItems.Count > 0)
                    {
                        frm = new frm_chucvu_capnhat(lv_chucvu.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_chucvu_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_chucvu.SelectedItems.Count > 0)
                    {
                        if (new CHUCVU_BLL().chucvu_xoa(lv_chucvu.SelectedItems[0].Tag.ToString()) > 0)
                        {
                            lv_chucvu.Items.Remove(lv_chucvu.SelectedItems[0]);
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        public void thongke()
        {
            lbl_thongke.Text = "Tổng số: " + lv_chucvu.Items.Count.ToString();
        }
        #endregion

        #region "Sự kiện"
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            LST_CHUCVU = new CHUCVU_BLL().chucvu_danhsach().ToList();
            danhsachchucvu(LST_CHUCVU);
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
        private void lv_chucvu_DoubleClick(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void frm_chucvu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_sua_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
        private void txt_chucvu_TextChanged(object sender, EventArgs e)
        {
            if (txt_chucvu.Text.Length > 0)
            {
                danhsachchucvu(LST_CHUCVU.Where(c => c.TenChucVu.ToUpper().Contains(txt_chucvu.Text.ToUpper())).ToList());
            }
            else
            {
                danhsachchucvu(LST_CHUCVU);
            }
        }
        private void frm_chucvu_Load(object sender, EventArgs e)
        {
            txt_chucvu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_chucvu).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        #endregion
    }
}
