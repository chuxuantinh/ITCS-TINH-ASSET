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
using ThietBiPY.LopHoTro;

namespace ThietBiPY.HeThong
{
    public partial class frm_nhatkihethong : Form
    {
        public frm_nhatkihethong()
        {
            InitializeComponent();
            danhsachthoigian();
            cbo_thoigian.SelectedIndex = 0;

            lv_danhsachlog.Columns.Add("STT", 60, HorizontalAlignment.Center);
            lv_danhsachlog.Columns.Add("NguoiDung", 100);
            lv_danhsachlog.Columns[1].Text = "Người dùng";
            lv_danhsachlog.Columns.Add("Server", 100);
            lv_danhsachlog.Columns[2].Text = "Máy chủ";
            lv_danhsachlog.Columns.Add("DiaChiMac", 100);
            lv_danhsachlog.Columns[3].Text = "Địa chỉ MAC";
            lv_danhsachlog.Columns.Add("ThoiGian", 100);
            lv_danhsachlog.Columns[4].Text = "Thời gian";
            lv_danhsachlog.Columns.Add("NoiDung", lv_danhsachlog.Width - lv_danhsachlog.Columns[0].Width -
                lv_danhsachlog.Columns[1].Width - lv_danhsachlog.Columns[2].Width - lv_danhsachlog.Columns[3].Width - lv_danhsachlog.Columns[4].Width);
            lv_danhsachlog.Columns[5].Text = "Thao tác";

            locdanhsach(null, null);
        }
        List<NHATKITRUYCAP> LST_TRUYCAP = new List<NHATKITRUYCAP>();

        #region "Hàm xử lý"
        public void danhsachthoigian()
        {
            cbo_thoigian.Items.AddRange(new DOITUONG[]{
                new DOITUONG ("Hôm nay",0),
                new DOITUONG ("1 tuần",7),
                new DOITUONG ("1 tháng",30),
            });
            cbo_thoigian .SelectedIndexChanged += new EventHandler(locdanhsach );
            dtp_ngaycuthe.ValueChanged += new EventHandler(locdanhsach);
        }
        public void loaddanhsach_nhatki(List<NHATKITRUYCAP> LST)
        {
            if (LST != null)
            {
                int dem = 0;
                lv_danhsachlog.Items.Clear();
                foreach (var t in LST)
                {
                    dem++;
                    ListViewItem item = new ListViewItem();
                    item.Text = dem.ToString();
                    item.Tag = t.TruyCapID.ToString();
                    lv_danhsachlog.Items.Add(item);
                    item.SubItems.Add(t.NguoiDung);
                    item.SubItems.Add(t.Server);
                    item.SubItems.Add(t.DiaChiMAC);
                    item.SubItems.Add(t.ThoiGian.ToString());
                    item.SubItems.Add(t.NoiDung);

                    if (dem % 2 == 0)
                    {
                        for (int cot = 0; cot < lv_danhsachlog.Columns.Count; cot++) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void thongke()
        {
            lbl_soluongthaotac.Text = "Tổng số thao tác : " + lv_danhsachlog.Items.Count.ToString();
        }
        public void xoa_dongchon()
        {
            this.Cursor = Cursors.WaitCursor;
            List<NHATKITRUYCAP> LST_NK = new List<NHATKITRUYCAP>();
            foreach (ListViewItem item in lv_danhsachlog.SelectedItems)
            {
                LST_NK.Add(LST_TRUYCAP.Single(c=>c.TruyCapID ==int.Parse (item.Tag.ToString())));
            }
            if (new NHATKITRUYCAP_BLL().nhatkitruycap_xoa(LST_NK)>0)
            {
                foreach (ListViewItem item in lv_danhsachlog.SelectedItems)
                {
                    lv_danhsachlog.Items.Remove(item);
                }
            }
            this.Cursor = Cursors.Default;
            thongke();
        }

        public void locdanhsach(object sender, EventArgs e)
        {
            var LST_DSNHATKY_LOC = new NHATKITRUYCAP_BLL().nhatkitruycap_danhsach().ToList();

            //dùng mốc thời gian
            if (opt_mocthoigian.Checked)
            {
                if (cbo_thoigian.Items.Count > 0)
                {
                    int mocthoigian = ((DOITUONG)cbo_thoigian.SelectedItem).value;
                    if (mocthoigian == 0)
                    {
                        LST_DSNHATKY_LOC = LST_DSNHATKY_LOC.Where(c => c.ThoiGian.Value.Date == DateTime.Now.Date.AddDays((Double)mocthoigian)).ToList();
                    }
                    else LST_DSNHATKY_LOC = LST_DSNHATKY_LOC.Where(c => c.ThoiGian.Value.Date <= DateTime.Now.Date.AddDays((Double)mocthoigian)).ToList();
                }
            }

            //dùng thời gian cụ thể
            else
            {
                if (dtp_ngaycuthe.Value.Date != new DateTime(01, 01, 0001))
                    LST_DSNHATKY_LOC = LST_DSNHATKY_LOC.Where(c => c.ThoiGian.Value.Date == dtp_ngaycuthe.Value.Date).ToList();
            }
            loaddanhsach_nhatki(LST_DSNHATKY_LOC);
        }
        //
        public string thongtinchitiet()
        {
            string chitiet = "";
            if (lv_danhsachlog.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_danhsachlog.SelectedItems[0];
                chitiet = item.SubItems[0].Text + Environment.NewLine + item.SubItems[3].Text;
            }
            return chitiet;
        }
        #endregion

        #region "Sự kiện"
        private void menustrip_btn_xoa_Click(object sender, EventArgs e)
        {
            xoa_dongchon();
        }
        private void opt_mocthoigian_CheckedChanged(object sender, EventArgs e)
        {
            if (opt_mocthoigian.Checked)
            {
                cbo_thoigian.Enabled = true;
                dtp_ngaycuthe.Enabled = false;
            }
            else
            {
                dtp_ngaycuthe.Enabled = true;
                cbo_thoigian.Enabled = false;
            }
        }
        private void lv_danhsachlog_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_danhsachlog.SelectedItems.Count > 0)
            {
                lv_danhsachlog.ContextMenuStrip = contextMenuStrip1;
            }
            else lv_danhsachlog.ContextMenuStrip = null;
        }
        #endregion
    }
}
