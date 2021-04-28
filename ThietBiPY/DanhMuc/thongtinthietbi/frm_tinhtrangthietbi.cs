using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Net.SourceForge.Vietpad.InputMethod;
using ThietBiBLL;
using ThietBiDAL;

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_tinhtrangthietbi : DevComponents.DotNetBar.Office2007Form 
    {
        List<TINHTRANG> LST_TINHTRANG = new List<TINHTRANG>();
        public frm_tinhtrangthietbi()
        {
            InitializeComponent();
            this.Text = "Tình trạng";

            lv_tinhtrang.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_tinhtrang.Columns.Add("Tình trạng", 200);

            lv_tinhtrang.Columns.Add("Mặc định", 70,HorizontalAlignment.Center);
            lv_tinhtrang.Columns.Add("Trạng thái", 80,HorizontalAlignment.Center);
            lv_tinhtrang.Columns.Add("Diễn giải", lv_tinhtrang.Width - lv_tinhtrang.Columns[0].Width - lv_tinhtrang.Columns[1].Width - 2);

            LST_TINHTRANG = new TINHTRANG_BLL().tinhtrang_danhsach().ToList();
            hienthi_danhsachtinhtrang(LST_TINHTRANG);
        }

        //
        public void hienthi_danhsachtinhtrang(List<TINHTRANG> LST)
        {
            lv_tinhtrang.Items.Clear();

            if (LST.Count>0)
            {
                int dem = 0;
                ListViewItem item = null;
                foreach (var T in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = T.TinhTrangID.ToString();
                    lv_tinhtrang.Items.Add(item);
                    item.SubItems.Add(T.TenTinhTrang);
                    item.SubItems.Add(T.MacDinh == true ? "X" : "");
                    item.SubItems.Add(T.TrangThai==true?"X":"");
                    item.SubItems.Add(T.DienGiai);

                    for (int cot = 0; cot < lv_tinhtrang.Columns.Count; cot++)
                    {
                      if(dem%2==0)item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                LST_TINHTRANG = new TINHTRANG_BLL().tinhtrang_danhsach().ToList();
                hienthi_danhsachtinhtrang(LST_TINHTRANG);
            }
        }
        public void thongke()
        {
            lbl_thongke.Text = "Tổng số: " + lv_tinhtrang.Items.Count.ToString();
        }
        public void timkiem_tinhtrang()
        {
            if (txt_tinhtrang.Text.Length > 0)
            {
                var LST = LST_TINHTRANG.Where(c => c.TenTinhTrang.ToUpper().Contains(txt_tinhtrang.Text.ToUpper())).ToList();
                hienthi_danhsachtinhtrang(LST);
            }
        }
        public void bangdieukhien(int tt)
        {
            frm_tinhtrangthietbi_capnhat frm = null;
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them:
                    frm = new frm_tinhtrangthietbi_capnhat();
                    frm.DuLieu = new frm_tinhtrangthietbi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua:
                    if (lv_tinhtrang.SelectedItems.Count > 0)
                    {
                        if (lv_tinhtrang.SelectedItems[0].SubItems[1].Text == "Đã thanh lý") return;
                            frm = new frm_tinhtrangthietbi_capnhat(lv_tinhtrang.SelectedItems[0].Tag.ToString());
                            frm.DuLieu = new frm_tinhtrangthietbi_capnhat.passData(nhandulieu);
                            frm.ShowDialog();
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa:
                    if (lv_tinhtrang.SelectedItems.Count > 0)
                    {
                        if (lv_tinhtrang.SelectedItems[0].SubItems[1].Text == "Đã thanh lý") return;
                            if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn!", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                if (new TINHTRANG_BLL().tinhtrang_xoa(lv_tinhtrang.SelectedItems[0].Tag.ToString()) > 0)
                                {
                                    lv_tinhtrang.Items.Remove(lv_tinhtrang.SelectedItems[0]);
                                }
                            }
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
            thongke();
        }
        //

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

        private void txt_tinhtrang_TextChanged(object sender, EventArgs e)
        {
            timkiem_tinhtrang();
        }
        #endregion

        private void menustrip_btn_sua_Click(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
        private void menustrip_btn_xoa_Click(object sender, EventArgs e)
        {
            btn_xoa_Click(null, null);
        }
        private void lv_tinhtrang_DoubleClick(object sender, EventArgs e)
        {
            btn_sua_Click(null, null);
        }
    }
}
