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
using ThietBiPY.BaoCao_ThongKe.report;

namespace ThietBiPY.BaoCao_ThongKe
{
    public partial class frm_hoso_thuhoithietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_hoso_thuhoithietbi()
        {
            InitializeComponent();
            lv_danhsachchungtu.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_danhsachchungtu.Columns.Add("Ngày thu hồi",100, HorizontalAlignment.Center);
            lv_danhsachchungtu.Columns.Add("Số văn bản", 200);
            lv_danhsachchungtu.Columns.Add("Lí do thu hồi", 200);
            lv_danhsachchungtu.Columns.Add("Đơn vị",200);
            lv_danhsachchungtu.Columns.Add ("Bộ phận",200);
            danhmuc_namvanban("");
            cbo_nam.SelectedIndexChanged += new EventHandler(danhmuc_chungtuthuhoi);
            danhmuc_chungtuthuhoi(null, null);
        }

        //
        public void danhmuc_namvanban(string giatri)
        {
            var NAM = new PHIEUTHUHOI_BLL().phieuthuhoi_danhsach().Select(c => new {NAMTHUHOI= c.NgayThuHoi.Value.Year.ToString()}).Distinct().ToList();
            cbo_nam.DataSource = NAM;
            cbo_nam.ValueMember = "NAMTHUHOI";
            cbo_nam.DisplayMember = "NAMTHUHOI";

            if (giatri != "")
            {
                cbo_nam.SelectedValue = giatri;
            }
            else if(NAM.Count>0) cbo_nam.SelectedIndex = 0;
        }
        public void danhmuc_chungtuthuhoi(object sender,EventArgs e)
        {
            if (cbo_nam.SelectedIndex >= 0)
            {
                var CT = new PHIEUTHUHOI_BLL().phieuthuhoi_danhsach().Where(c => c.NgayThuHoi.Value.Year == int.Parse(cbo_nam.SelectedValue.ToString())).ToList();
                if (CT != null)
                {
                    lv_danhsachchungtu.Items.Clear();
                    ListViewItem item = null;
                    int dem = 0;
                    foreach (var T in CT)
                    {
                        dem++;
                        item = new ListViewItem(dem.ToString());
                        item.Tag = T.ThuHoiID.ToString();
                        lv_danhsachchungtu.Items.Add(item);
                        item.SubItems.Add(T.NgayThuHoi.Value.Date.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(T.SoVanBan);
                        item.SubItems.Add(T.LiDoThuHoi != 0 ? T.TINHTRANG.TenTinhTrang : "");
                        item.SubItems.Add(T.DonViSuDung != 0 ? T.DONVI1.TenDonVi : "");
                        item.SubItems.Add(T.BoPhanSuDung != 0 ? T.BOPHAN.TenBoPhan : "");

                        for (int cot = 0; cot < lv_danhsachchungtu.Columns.Count; cot++)
                        {
                            if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                        }
                    }
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_danhsachchungtu.Items.Count.ToString();
        }

        //
        public void nhandulieu(string ThanhLyID)
        {
            if (ThanhLyID != "")
            {
                danhmuc_namvanban(new PHIEUTHUHOI_BLL().phieuthuhoi_thongtin(ThanhLyID).NgayThuHoi.Value.Date.ToString());
            }
        }
        public void bangdieukhien(int tt)
        {
            switch (tt)
            {
                case (int)DIEUKHIEN.sua :
                    NghiepVu.frm_thuhoithietbi_capnhat frm = new ThietBiPY.NghiepVu.frm_thuhoithietbi_capnhat(lv_danhsachchungtu.SelectedItems[0].Tag.ToString());
                    frm.DuLieu = new ThietBiPY.NghiepVu.frm_thuhoithietbi_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)DIEUKHIEN.xoa :
                    if (new PHIEUTHUHOI_BLL().phieuthuhoi_xoa(lv_danhsachchungtu.SelectedItems[0].Tag.ToString()) > 0)
                    {
                        lv_danhsachchungtu.Items.Remove(lv_danhsachchungtu.SelectedItems[0]);
                    }
                    break;

                case (int)DIEUKHIEN.invanban :
                    frm_bienban_thuhoithietbi frm_thuhoi = new frm_bienban_thuhoithietbi(lv_danhsachchungtu.SelectedItems[0].Tag.ToString());
                    frm_thuhoi.ShowDialog();
                    break;
            }
            lbl_thongke.Text = "Tổng số: " + lv_danhsachchungtu.Items.Count.ToString();
        }
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (lv_danhsachchungtu.SelectedItems.Count > 0)
            {
                bangdieukhien((int)DIEUKHIEN.sua);
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
             DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
             if (lv_danhsachchungtu.SelectedItems.Count > 0)
             {
                 if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa chứng từ đang chọn ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                 {
                     bangdieukhien((int)DIEUKHIEN.xoa);
                 }
             }
             else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_inchungtu_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass =false;
            if (lv_danhsachchungtu.SelectedItems.Count > 0)
            {
                bangdieukhien((int)DIEUKHIEN.invanban);
            }
            else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần in!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
