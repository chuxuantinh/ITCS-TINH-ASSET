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

namespace ThietBiPY.DanhMuc
{
    public partial class frm_phutung : DevComponents.DotNetBar.Office2007Form 
    {
        List<PHUTUNG> LST_PHUTUNG = new List<PHUTUNG>();
        public frm_phutung()
        {
            InitializeComponent();
        }
        public frm_phutung(List<PHUTUNG> LST)
        {
            InitializeComponent();
            lv_phutung.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_phutung.Columns.Add("Tên phụ tùng", 200);
            lv_phutung.Columns.Add("Số hiệu", 200);
            lv_phutung.Columns.Add("Đơn vị tính", 100);
            lv_phutung.Columns.Add("Nước SX", 100);
            lv_phutung.Columns.Add("Năm SX", 100);

            LST_PHUTUNG = new PHUTUNG_BLL().phutung_danhsach().Where(c => c.ThietBiID == 0 && LST.SingleOrDefault(p => p.PhuTungID == c.PhuTungID) == null).ToList();//.Where(c => c.ThietBiID == null || c.ThietBiID == 0).ToList();
            hienthi_phutung(LST_PHUTUNG);
        }

        #region "Hàm xử lý"
        //
        public void hienthi_phutung(List<PHUTUNG> LST)
        {
            if (LST.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                lv_phutung.Items.Clear();

                foreach (var PT in LST)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = PT.PhuTungID.ToString();
                    lv_phutung.Items.Add(item);
                    item.SubItems.Add(PT.TenPhuTung);
                    item.SubItems.Add(PT.SoHieu);
                    item.SubItems.Add(PT.DVTID != 0 ? PT.DONVITINH.TenDVT : "Chưa xác định");
                    item.SubItems.Add(PT.NuocSX != 0||PT.NuocSX !=0 ? PT.NUOC.TenNuoc : "Chưa xác định");
                    item.SubItems.Add(PT.NamSX != 0 ? PT.NamSX.ToString() : "Chưa xác định");

                    for (int cot = 0; cot < lv_phutung.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
        }

        //
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                LST_PHUTUNG.Add(new PHUTUNG_BLL().phutung_thongtin(giatri));
                hienthi_phutung(LST_PHUTUNG);
            }
        }
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (giatri != null) DuLieu(giatri);
        }
        //
        #endregion

        #region "Sự kiện"
        private void btn_themphutung_Click(object sender, EventArgs e)
        {
            frm_phutung_capnhat frm = new frm_phutung_capnhat();
            frm.DuLieu = new frm_phutung_capnhat.passData(nhandulieu);
            frm.ShowDialog();
        }
        private void btn_chon_Click(object sender, EventArgs e)
        {
            List<string> LST = new List<string>();
            foreach (ListViewItem item in lv_phutung.Items)
            {
                if (item.Checked == true)
                {
                    guidulieu(item.Tag.ToString());
                    lv_phutung.Items.Remove(item);
                }
            }
            this.Close();
        }
        #endregion
    }
}
