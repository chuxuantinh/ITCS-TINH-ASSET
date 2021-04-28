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

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_tylehaomon : DevComponents.DotNetBar.Office2007Form
    {
        public frm_tylehaomon()
        {
            InitializeComponent();
            lv_haomon.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_haomon.Columns.Add("Loại thiết bị", 300);
            lv_haomon.Columns.Add("Thời gian sử dụng (năm)", 200,HorizontalAlignment.Center);
            lv_haomon.Columns.Add("Tỷ lệ hao mòn (%/năm)", 200,HorizontalAlignment.Center);

            danhmuc_nhomthietbi("");
        }

        #region "Hàm xử lý"
        //
        public void danhmuc_nhomthietbi(string giatri)
        {
            BindingSource binding_nhomthietbi = new BindingSource();
            binding_nhomthietbi.DataSource = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList();
            binding_nhomthietbi.Add(new NHOMTHIETBI { NhomTBID = 0, TenNhomTB = "Chưa xác định", DienGiai = "" });
            cbo_nhomthietbi.DataSource = binding_nhomthietbi;
            cbo_nhomthietbi.ValueMember = "NhomTBID";
            cbo_nhomthietbi.DisplayMember = "TenNhomTB";

            if (giatri != "")
            {
                cbo_nhomthietbi.SelectedValue = int.Parse(giatri);
            }
            else cbo_nhomthietbi.SelectedIndex = 0;
            cbo_nhomthietbi.SelectedIndexChanged += new EventHandler(danhsach_tylehaomon);
            danhsach_tylehaomon(null, null);
        }
        public void danhsach_tylehaomon(object sender,EventArgs e)
        {
            var LST_HAOMON = new TYLEHAOMON_BLL().tylehaomon_danhsach().ToList();
            if (cbo_nhomthietbi.SelectedIndex >= 0)
            {
                LST_HAOMON = LST_HAOMON.Where(c => c.LOAITHIETBI.NhomTBID==(int)cbo_nhomthietbi.SelectedValue).ToList();
            }

            //
            lv_haomon.Items.Clear();
            if (LST_HAOMON.Count > 0)
            {
                ListViewItem item = null;
                int dem = 0;
                foreach (var HM in LST_HAOMON)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = HM.TyLeHaoMonID.ToString();
                    lv_haomon.Items.Add(item);
                    item.SubItems.Add(HM.LoaiTBID != 0 ? HM.LOAITHIETBI.TenLoaiTB : "Chưa xác định");
                    item.SubItems.Add(HM.ThoiGianSD.ToString());
                    item.SubItems.Add(HM.TLHaoMon.ToString ());
                    for (int cot = 0; cot < lv_haomon.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }

            //
            thongke();
        }

        public void nhandulieu(string LoaiTBID)
        {
            var NhomTB = new LOAITHIETBI_BLL().loaithietbi_thongtin(LoaiTBID).NhomTBID;
            danhmuc_nhomthietbi(NhomTB.ToString());
        }
        public void thongke()
        {
            lbl_thongke.Text = "Số lượng: " + lv_haomon.Items.Count.ToString();
        }
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            frm_tylehaomon_capnhat frm = null;
            switch (tt)
            {
                case (int)DIEUKHIEN .them :
                    frm = new frm_tylehaomon_capnhat();
                    frm.DuLieu = new frm_tylehaomon_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)DIEUKHIEN.sua :
                    if (lv_haomon.SelectedItems.Count > 0)
                    {
                        frm = new frm_tylehaomon_capnhat(lv_haomon.SelectedItems [0].Tag.ToString());
                        frm.DuLieu = new frm_tylehaomon_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.xoa :
                    if (lv_haomon.SelectedItems.Count > 0)
                    {
                        if (new TYLEHAOMON_BLL().tylehaomon_xoa(lv_haomon.SelectedItems[0].Tag.ToString()) > 0)
                        {
                            lv_haomon.Items.Remove(lv_haomon.SelectedItems[0]);
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)DIEUKHIEN.lamtuoi :
                    int giatriht = (int)cbo_nhomthietbi.SelectedValue;
                    danhmuc_nhomthietbi(giatriht.ToString());
                    break;
            }
            thongke();
        }
        //
        #endregion

        #region "Sự kiện"
        //
        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.them);
        }
        private void btn_hieuchinh_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.sua);
        }
        private void btn_xoadong_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.xoa);
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)DIEUKHIEN.lamtuoi);
        }

        //
        private void context_menu_hieuchinh_Click(object sender, EventArgs e)
        {
            btn_hieuchinh_Click(null, null);
        }
        private void context_menu_xoadong_Click(object sender, EventArgs e)
        {
            btn_xoadong_Click(null, null);
        }
        private void lv_haomon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_haomon.SelectedItems.Count > 0)
            {
                lv_haomon.ContextMenuStrip = context_menu;
            }
            else lv_haomon.ContextMenuStrip = null;
        } 
        
        //
        private void frm_tylehaomon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.F6: btn_themmoi_Click(null, null); break;
                case Keys.F7: btn_hieuchinh_Click(null, null); break;
                case Keys.Delete: btn_xoadong_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
        #endregion 

        private void cbo_nhomthietbi_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
            {
                return;
            }
            //user mouse is hovering over this drop-down item, update its data  
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {   // this tooltip simply shows the displayed text to the right of the drop-down  box, customize as needed  
                toolTip1.Show(cbo_nhomthietbi.GetItemText(cbo_nhomthietbi.Items[e.Index]), cbo_nhomthietbi, e.Bounds.Right, e.Bounds.Bottom);
            }
            e.DrawBackground();
            // draw text strings  
            e.Graphics.DrawString(cbo_nhomthietbi.Items[e.Index].ToString(), e.Font,
                Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
        }
        private void cbo_nhomthietbi_DropDownClosed(object sender, EventArgs e)
        {
            toolTip1.Hide(cbo_nhomthietbi);
        }
    }
}
