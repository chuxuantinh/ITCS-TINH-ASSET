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
using ThietBiPY.LopHoTro;
using ThietBiPY.NghiepVu;
using ThietBiPY.BaoCao_ThongKe.report;

namespace ThietBiPY.BaoCao_ThongKe
{
    public partial class frm_hoso_thanhlythietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_hoso_thanhlythietbi()
        {
            InitializeComponent();

            lv_danhsachthietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_danhsachthietbi.Columns.Add("Ngày thanh lý",90);
            lv_danhsachthietbi.Columns.Add("Số văn bản", 90);
            lv_danhsachthietbi.Columns.Add("Ngày văn bản", 90);
            lv_danhsachthietbi.Columns.Add("Bên mua",200);
            //lv_danhsachthietbi.Columns.Add("Số lượng", 70);

            danhmuc_nam("");
            cbo_nam.SelectedIndexChanged += new EventHandler(danhsach_thanhlythietbi);
            danhsach_thanhlythietbi(null, null);
        }

        #region "Hàm xử lý"
        //
        public void danhmuc_nam(string giatri)
        {
            cbo_nam.DataSource = new PHIEUTHANHLY_BLL().phieuthanhly_danhsach().Select(c => new
            {
                NamThanhLy = c.NgayThanhLy.Value.Year.ToString(),
            }).Distinct().ToList();
            cbo_nam.ValueMember = "NamThanhLy";
            cbo_nam.DisplayMember = "NamThanhLy";

            if (cbo_nam.Items.Count > 0)
            {
                if (giatri == "")
                {
                    cbo_nam.SelectedIndex = 0;
                }
                else cbo_nam.SelectedValue = new PHIEUTHANHLY_BLL().phieuthanhly_thongtin(giatri).NgayThanhLy.Value.Year.ToString();
            }
        }
        public void danhsach_thanhlythietbi(object sender,EventArgs e)
        {
            var LST_THANHLY = new PHIEUTHANHLY_BLL().phieuthanhly_danhsach().Where (c=>c.NgayThanhLy.Value.Year==int.Parse(cbo_nam.SelectedValue.ToString())).ToList();
            if (LST_THANHLY != null)
            {
                ListViewItem item = null;
                int dem = 0;
                lv_danhsachthietbi.Items.Clear();
                foreach (var TL in LST_THANHLY)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    lv_danhsachthietbi.Items.Add(item);
                    item.Tag = TL.ThanhLyID.ToString();
                    item.SubItems.Add(TL.NgayThanhLy.Value.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(TL.SoVanBan);
                    item.SubItems.Add(TL.NgayVanBan.Value.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(TL.DaiDienBenMua);
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_danhsachthietbi.Items.Count.ToString();
        }

        //
        public void xuly(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            switch (tt)
            {
                case (int)DIEUKHIEN.invanban :
                    if (lv_danhsachthietbi.SelectedItems.Count > 0)
                    {
                        frm_bienban_thanhlythietbi frm = new frm_bienban_thanhlythietbi(lv_danhsachthietbi.SelectedItems[0].Tag.ToString());
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần in!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.sua:
                    if (lv_danhsachthietbi.SelectedItems.Count > 0)
                    {
                        frm_thanhlythietbi_capnhat frm = new frm_thanhlythietbi_capnhat(lv_danhsachthietbi.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_thanhlythietbi_capnhat.passData(danhmuc_nam);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.xoa :
                    if (lv_danhsachthietbi.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("xóa chứng từ đang chọn!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new PHIEUTHANHLY_BLL().phieuthanhly_xoa(lv_danhsachthietbi.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_danhsachthietbi.Items.Remove(lv_danhsachthietbi.SelectedItems[0]);
                                lbl_thongke.Text = "Tổng số: " + lv_danhsachthietbi.Items.Count.ToString();
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.lamtuoi:
                    danhmuc_nam("");
                    break;
            }
        }
        #endregion

        #region "Sự kiện"
        private void lv_danhsachthietbi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_danhsachthietbi.SelectedItems.Count > 0)
            {
                lv_danhsachthietbi.ContextMenuStrip = contextmenu_dieukhien;
            }
            else lv_danhsachthietbi.ContextMenuStrip = null;
        }
        private void btn_inhoso_Click(object sender, EventArgs e)
        {
            xuly((int)DIEUKHIEN.invanban);
        }
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            xuly((int)DIEUKHIEN.sua);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            xuly((int)DIEUKHIEN.xoa);
        }
        #endregion

    }
}
