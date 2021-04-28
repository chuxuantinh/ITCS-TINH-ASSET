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

namespace ThietBiPY.BaoCao_ThongKe
{
    public partial class frm_hoso_kiemkethietbi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_hoso_kiemkethietbi()
        {
            InitializeComponent();

            lv_hosokiemke.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_hosokiemke.Columns.Add("Ngày kiểm kê", 100);
            lv_hosokiemke.Columns.Add("Số văn bản", 200);
            lv_hosokiemke.Columns.Add("Đơn vị kiểm kê", 200);
            lv_hosokiemke.Columns.Add("Bộ phận kiểm kê", 200);

            danhmuc_namhoso("");
            danhmuc_hoso(null, null);
        }

        //
        public void danhmuc_namhoso(string giatri)
        {
            var LST_NAM = new PHIEUKIEMKE_BLL().phieukiemke_danhsach().Select(c => new {
                Nam=c.NgayKiemKe.Value.Date.Year.ToString (),
            }).Distinct ().ToList ();

            cbo_nam.DataSource = LST_NAM;
            cbo_nam.ValueMember = "Nam";
            cbo_nam.ValueMember = "Nam";

            if (giatri != "") cbo_nam.SelectedValue = giatri;
            else if (cbo_nam.Items.Count > 0) cbo_nam.SelectedIndex = 0;
            cbo_nam.SelectedIndexChanged += new EventHandler(danhmuc_hoso);
        }
        public void danhmuc_hoso(object sender, EventArgs e)
        {
            if (cbo_nam.SelectedIndex >= 0)
            {
                var LST_HS = new PHIEUKIEMKE_BLL().phieukiemke_danhsach().Where(c => c.NgayKiemKe.Value.Date.Year == int.Parse(cbo_nam.SelectedValue.ToString())).ToList();
                ListViewItem item = null;
                int dem = 0;
                lv_hosokiemke.Items.Clear();

                foreach (var HS in LST_HS)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = HS.KiemKeID.ToString();
                    lv_hosokiemke.Items.Add(item);
                    item.SubItems.Add(HS.NgayKiemKe.Value.Date.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(HS.SoVanBan);
                    item.SubItems.Add(HS.DonViKiemKe != 0 ? HS.DONVI.TenDonVi : "Chưa xác định");
                    item.SubItems.Add(HS.BoPhanKiemKe != 0 ? HS.BOPHAN.TenBoPhan : "Chưa xác định");

                    for (int cot = 0; cot < lv_hosokiemke.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            lbl_thongke.Text = "Tổng số: " + lv_hosokiemke.Items.Count.ToString();
        }

        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void nhandulieu(string giatri)
        {
            if (giatri != "")
            {
                var NAM = new PHIEUKIEMKE_BLL().phieukiemke_thongtin(giatri).NgayKiemKe.Value.Date.Year.ToString();
                danhmuc_namhoso(NAM);
            }
        }

        //
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.sua :
                    if (lv_hosokiemke.SelectedItems.Count > 0)
                    {
                        NghiepVu.frm_kiemkethietbi_capnhat frm = new ThietBiPY.NghiepVu.frm_kiemkethietbi_capnhat(lv_hosokiemke.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new ThietBiPY.NghiepVu.frm_kiemkethietbi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_hosokiemke.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa chứng từ đang chọn!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new PHIEUKIEMKE_BLL().phieukiemke_xoa(lv_hosokiemke.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_hosokiemke.Items.Remove(lv_hosokiemke.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;

                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    danhmuc_namhoso("");
                    break;

                case (int)LopHoTro.DIEUKHIEN.invanban :
                    if (lv_hosokiemke.SelectedItems.Count > 0)
                    {
                        BaoCao_ThongKe.report.frm_bienban_kiemkethietbi frm = new ThietBiPY.BaoCao_ThongKe.report.frm_bienban_kiemkethietbi(lv_hosokiemke.SelectedItems[0].Tag.ToString());
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn chứng từ cần in!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
            }
        }

        //
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }
        private void btn_inhoso_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.invanban);
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }
    }
}
