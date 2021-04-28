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
using ThietBiPY.BaoCao_ThongKe.report;
using ThietBiPY.LopHoTro;

namespace ThietBiPY.BaoCao_ThongKe
{
    public partial class frm_hoso_bangiaothietbi : DevComponents.DotNetBar.Office2007Form
    {
        int DonVi = 0;

        public frm_hoso_bangiaothietbi()
        {
            InitializeComponent();
            lv_hosobangiao.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_hosobangiao.Columns.Add("Ngày bàn giao", 100);
            lv_hosobangiao.Columns.Add("Số văn bản", 100);
            lv_hosobangiao.Columns.Add("Đơn vị bàn giao", 200);
            lv_hosobangiao.Columns.Add("Bộ phận bàn giao", 200);

            lv_hosobangiao.Columns.Add("Đơn vị nhận", 200);
            lv_hosobangiao.Columns.Add("Bộ phận nhận", 200);
            lv_hosobangiao.Columns.Add("Số lượng", 100,HorizontalAlignment.Center);
            lv_hosobangiao.Columns.Add("Ghi chú",400);
            danhmuc_namhoso("");
        }

        public frm_hoso_bangiaothietbi(int DonVi)
        {
            InitializeComponent();
            //-- Kiểm tra quyền rùi thiết lập chức năng
            switch (PHANQUYEN.quyen)
            {
                case (int)QUYEN.nhanviendonvi:
                    btn_hieuchinh.Visible = false;
                    btn_xoadong.Visible = false;
                    break;
            }

            //--
            this.DonVi = DonVi;

            //
            btn_chondonvi.Visible = false;

            lv_hosobangiao.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_hosobangiao.Columns.Add("Ngày bàn giao", 100);
            lv_hosobangiao.Columns.Add("Số văn bản", 100);
            lv_hosobangiao.Columns.Add("Đơn vị bàn giao", 200);
            lv_hosobangiao.Columns.Add("Bộ phận bàn giao", 200);

            lv_hosobangiao.Columns.Add("Đơn vị nhận", 200);
            lv_hosobangiao.Columns.Add("Bộ phận nhận", 200);
            lv_hosobangiao.Columns.Add("Số lượng", 100, HorizontalAlignment.Center);
            lv_hosobangiao.Columns.Add("Ghi chú", 400);
            danhmuc_namhoso("");
        }

        #region "Hàm xử lý"

        //
        public void danhmuc_namhoso(string giatri)
        {
            var LST=new PHIEUBANGIAO_BLL().phieubangiao_danhsach().OrderByDescending(c => c.NgayBanGiao.Value.Year).ToList ();
            if(DonVi!=0)LST=LST.Where (c=>c.DonViBanGiao==DonVi ).ToList ();

            cbo_nam.DataSource = LST.Select(c => c.NgayBanGiao.Value.Year).Distinct().ToList();

            if (cbo_nam.Items.Count > 0)
            {
                if (giatri == "")
                {
                    cbo_nam.SelectedIndex = 0;
                }
                else cbo_nam.SelectedText = giatri;
            }
            cbo_nam.SelectedIndexChanged += new EventHandler(danhsach_hosobangiao);
            danhsach_hosobangiao(null, null);
        }
        public void danhsach_hosobangiao(object sender,EventArgs e)
        {
            var LST_BANGIAO = new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Where(c => c.NgayBanGiao.Value.Year == int.Parse(cbo_nam.Text)).OrderByDescending(c => c.NgayBanGiao).ToList();
            if (DonVi != 0) LST_BANGIAO = LST_BANGIAO.Where(c => c.DonViBanGiao == DonVi).ToList();

            ListViewItem item = null;
            int dem = 0;
            lv_hosobangiao.Items.Clear();
            foreach (var BG in LST_BANGIAO)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = BG.BanGiaoID.ToString();
                lv_hosobangiao.Items.Add(item);
                item.SubItems.Add(BG.NgayBanGiao.Value.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(BG.SoVanBan);
                item.SubItems.Add(BG.DonViBanGiao != 0 ? BG.DONVI.TenDonVi : "Chưa xác định");
                item.SubItems.Add(BG.BoPhanBanGiao != 0 ? BG.BOPHAN.TenBoPhan : "Chưa xác định");

                item.SubItems.Add(BG.DonViNhan != 0 ? BG.DONVI1.TenDonVi : "Chưa xác định");
                item.SubItems.Add(BG.BoPhanNhan!= 0 ? BG.BOPHAN1.TenBoPhan : "Chưa xác định");
                item.SubItems.Add(new CTBANGIAO_BLL().ctbangiao_danhsach(BG.BanGiaoID.ToString()).Count().ToString());
                item.SubItems.Add(BG.GhiChu);

                for (int cot = 0; cot < lv_hosobangiao.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                }
            }

            //
            if (DonVi == 0)
            {
                txt_thongkesoluong.Text = "Năm: "+cbo_nam.Text +"-Tất cả đơn vị: " + lv_hosobangiao.Items.Count.ToString();
            }
            else
            {
                var CT_DV = new DONVI_BLL().donvi_thongtin(DonVi.ToString());
                txt_thongkesoluong.Text = "Năm: " + cbo_nam.Text+"-"+CT_DV.TenDonVi + ": " + lv_hosobangiao.Items.Count.ToString();
            }
        }
        public void nhandulieu(string giatri)
        {
            string nam = new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Where(c => c.BanGiaoID == int.Parse(giatri)).Single().NgayBanGiao.Value.Year.ToString();
            danhmuc_namhoso(giatri);
        }
        
        //
        public void bangdieukhien(int tt)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN .sua :
                    if (lv_hosobangiao.SelectedItems.Count > 0)
                    {
                        NghiepVu.frm_bangiaothietbi_capnhat frm = new ThietBiPY.NghiepVu.frm_bangiaothietbi_capnhat(DonVi,lv_hosobangiao.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new ThietBiPY.NghiepVu.frm_bangiaothietbi_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN .xoa :
                    if (lv_hosobangiao.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new PHIEUBANGIAO_BLL().phieubangiao_xoa(lv_hosobangiao.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_hosobangiao.Items.Remove(lv_hosobangiao.SelectedItems[0]);
                                
                                if (DonVi == 0)
                                {
                                    txt_thongkesoluong.Text = "Năm: "+cbo_nam.Text+"-"+"Tất cả đơn vị: " + lv_hosobangiao.Items.Count.ToString();
                                }
                                else
                                {
                                    var CT_DV = new DONVI_BLL().donvi_thongtin(DonVi.ToString());
                                    txt_thongkesoluong.Text = "Năm: " + cbo_nam.Text + "-" + CT_DV.TenDonVi + ": " + lv_hosobangiao.Items.Count.ToString();
                                }
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    danhmuc_namhoso(cbo_nam.Text);
                    break;

                case (int)LopHoTro.DIEUKHIEN.invanban :
                    if (lv_hosobangiao.SelectedItems.Count > 0)
                    {
                        frm_bienban_bangiaothietbi frm = new frm_bienban_bangiaothietbi(lv_hosobangiao.SelectedItems[0].Tag.ToString());
                        frm.ShowDialog ();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần in!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion

        #region "Sự kiện"
        private void frm_hoso_bangiaothietbi_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btn_lamtuoi_Click(null, null);
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }
        private void lv_hosobangiao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btn_lamtuoi_Click(null, null);
                    break;

                case Keys.F7:
                    btn_hieuchinh_Click(null, null);
                    break;

                case Keys.Delete:
                    break;
            }
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }
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
        #endregion   

        private void btn_chondonvi_Click(object sender, EventArgs e)
        {
            string giatri = "";
            if (new HOPCHON_DONVI().InputBox("", "Chọn đơn vị", ref giatri) == DialogResult.OK)
            {
                DonVi = int.Parse(giatri);
                danhmuc_namhoso("");
                danhsach_hosobangiao(null, null);
            }
        }
    }

    //
    public class HOPCHON_DONVI
    {
        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            //Form form = new Form();

            DevComponents.DotNetBar.Office2007Form form = new DevComponents.DotNetBar.Office2007Form();
            DevComponents.DotNetBar.LabelX label = new DevComponents.DotNetBar.LabelX();

            DevComponents.DotNetBar.Controls.ComboBoxEx combo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            DevComponents.DotNetBar.ButtonX buttonOk = new DevComponents.DotNetBar.ButtonX();
            DevComponents.DotNetBar.ButtonX buttonCancel = new DevComponents.DotNetBar.ButtonX();

            form.EnableGlass = false;
            form.Text = title;
            label.Text = promptText;
            //combo.SelectedValue = int.Parse(value);

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            combo.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            combo.Anchor = combo.Anchor | AnchorStyles.Right;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, combo, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var LST_DV = new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Select(c => new
            {
                DonViID = c.DonViBanGiao,
                TenDonVi = c.DONVI.TenDonVi,
            }).Distinct().OrderBy(c => c.TenDonVi).ToList();
            LST_DV.Add(new { DonViID = 0, TenDonVi = "Tất cả" });

            combo.DataSource = LST_DV;
            
            combo.DisplayMember = "TenDonVi";
            combo.ValueMember = "DonViID";

            DialogResult dialogResult = form.ShowDialog();
            value = combo.SelectedValue.ToString();
            return dialogResult;
        }
    }
    //
}

/* 
 * Bùi Thành Nhân - 20/06/2011
 * Xử lý xong nghiệp vụ bàn giao (luân chuyển) thiết bị
 */
