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

namespace ThietBiPY.HeThong
{
    public partial class frm_nguoidung_quantri : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_nguoidung_quantri()
        {
            InitializeComponent();
            lv_nguoidung.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nguoidung.Columns.Add("Tài khoản", 200);
            lv_nguoidung.Columns.Add("Nhân viên", 200);
            lv_nguoidung.Columns.Add("Quyền", 80);
            lv_nguoidung.Columns.Add("Trạng thái", 100);

            danhsach_nguoidung();
            danhmuc_trangthai("");
            danhmuc_tieuchi("");

            txt_tukhoa.TextChanged += new EventHandler(cbo_tieuchi_SelectIndexChanged);
            cbo_tieuchi_SelectIndexChanged(null, null);
        }

        //
        public void danhmuc_trangthai(string giatri)
        {
            cbo_trangthai.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Kích hoạt",1),
                new LopHoTro.DOITUONG ("Chưa kích hoạt",0),
            };
            cbo_trangthai.ValueMember = "value";
            cbo_trangthai.DisplayMember = "name";

            if (giatri != "")
            {
                cbo_trangthai.SelectedValue = int.Parse(giatri);
            }
            else cbo_trangthai.SelectedIndex = 0;
            cbo_trangthai.SelectedIndexChanged += new EventHandler(cbo_tieuchi_SelectIndexChanged);
        }
        public void danhmuc_tieuchi(string giatri)
        {
            cbo_tieuchi.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Tài khoản",1),
                new LopHoTro.DOITUONG ("Mã NV",2),
            };
            cbo_tieuchi.DisplayMember = "name";
            cbo_tieuchi.ValueMember = "value";
            if (giatri == "")
            {
                cbo_tieuchi.SelectedIndex = 0;
            }
            else cbo_tieuchi.SelectedValue = int.Parse(giatri);
            cbo_tieuchi.SelectedIndexChanged += new EventHandler(cbo_tieuchi_SelectIndexChanged);
        }

        //
        private void cbo_tieuchi_SelectIndexChanged(object sender, EventArgs e)
        {
            danhsach_nguoidung();
        }
        public void danhsach_nguoidung()
        {
            var LST_NGUOIDUNG = new NGUOIDUNG_BLL().nguoidung_danhsach().ToList();

            if (cbo_trangthai.SelectedIndex >= 0)
            {
                LST_NGUOIDUNG = LST_NGUOIDUNG.Where(c => c.TrangThai == ((int)cbo_trangthai.SelectedValue == 1 ? true : false)).ToList();
            }

            if (txt_tukhoa.Text != "")
            {
                switch ((int)cbo_tieuchi.SelectedValue)
                {
                    case 1:
                        LST_NGUOIDUNG = LST_NGUOIDUNG.Where(c => c.TaiKhoan.ToUpper().Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                    case 2:
                        LST_NGUOIDUNG = LST_NGUOIDUNG.Where(c => c.NHANVIEN.MaNV.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                }
            }

            lv_nguoidung.Items.Clear();
            ListViewItem item = null;
            int dem = 0;

            foreach (var ND in LST_NGUOIDUNG)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = ND.NguoiDungID.ToString();
                lv_nguoidung.Items.Add(item);
                item.SubItems.Add(ND.TaiKhoan);
                item.SubItems.Add((ND.NHANVIEN != null ? ND.NHANVIEN.MaNV : ""));
                item.SubItems.Add(ND.Quyen.ToString());
                item.SubItems.Add(ND.TrangThai == true ? "Kích hoạt" : "Chưa kích hoạt");

                for (int cot = 0; cot < lv_nguoidung.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }
        }

        //
        public void nhandulieu(string giatri)
        {
            var ND = new NGUOIDUNG_BLL().nguoidung_thongtin_ID(giatri).TrangThai;
            danhmuc_trangthai(ND == true ? "1" : "0");
        }

        private void contextmenu_hieuchinh_capquyen_Click(object sender, EventArgs e)
        {
            if (lv_nguoidung.SelectedItems.Count > 0)
            {
                frm_nguoidung_capquyen frm = new frm_nguoidung_capquyen(lv_nguoidung.SelectedItems[0].Tag.ToString());
                frm.DuLieu = new frm_nguoidung_capquyen.passData(nhandulieu);
                frm.ShowDialog();
            }
        }
        private void lv_nguoidung_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_nguoidung.SelectedItems.Count > 0)
            {
                lv_nguoidung.ContextMenuStrip = contextmenu_dieukhien;
            }
            else lv_nguoidung.ContextMenuStrip = null;
        }

        private void lv_nguoidung_DoubleClick(object sender, EventArgs e)
        {
            if(lv_nguoidung.SelectedItems.Count>0)contextmenu_hieuchinh_capquyen_Click(null, null);
        }


        private void btn_themnguoidung_Click(object sender, EventArgs e)
        {
            frm_nguoidung frm = new frm_nguoidung("dangki");
            frm.DuLieu = new frm_nguoidung.passData(nhandulieu);
            frm.ShowDialog();
        }
        //
    }
}
