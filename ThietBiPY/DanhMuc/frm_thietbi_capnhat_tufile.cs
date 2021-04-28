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
    public partial class frm_thietbi_capnhat_tufile : DevComponents.DotNetBar .Office2007Form 
    {
        public frm_thietbi_capnhat_tufile()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("Đơn vị tính", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Bảo hành(tháng)", 100);
            lv_thietbi.Columns.Add("Thông số kỹ thuật", 200);

            LST_DVT = new DONVITINH_BLL().donvitinh_danhsach().ToList();
        }

        //
        List<DONVITINH> LST_DVT = new List<DONVITINH>();
        List<THIETBI> LST_THIETBICHON = new List<THIETBI>();
        public void Mofile()
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Nhập thiết bị từ file Excel..";
            diag.Filter = "File Excel (XLS,XLSX)|*.xls;*.xlsx|Tất cả|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                lv_thietbi.Items.Clear();
                DataTable dt = new DataTable();
                dt = new LopHoTro.OLEDB(diag.FileName).docfile("DanhSachThietBi");

                //var LST_DSTHIEBI = new THIETBI_BLL().thietbi_danhsach().Select(c => new { c.MaThietBi, c.SoHieu }).ToList();
                ListViewItem item = null;
                int dem = 0;

                foreach (DataRow dr in dt.Rows)
                {
                   // if (LST_DSTHIEBI.SingleOrDefault(c => c.MaThietBi.Equals(dr[0].ToString().ToUpper()) || c.SoHieu.Equals(dr[3].ToString().ToUpper())) == null)
                   // {
                        LST_THIETBICHON.Add(new THIETBI
                        {
                            TenThietBi = dr[0].ToString(),
                            DVTID = (LST_DVT.SingleOrDefault(c => c.TenDVT.Equals(dr[1].ToString().ToUpper())) != null ? LST_DVT.SingleOrDefault(c => c.TenDVT.Equals(dr[1].ToString().ToUpper())).DVTID : 0),
                            SoHieu = dr[2].ToString().ToUpper(),
                            HanBaoHanh = (dr[3] != null ? Int16.Parse(dr[4].ToString()) : (short)0),
                            ThongSoKT=dr[4].ToString (),
                            //NuocSX = (int)dr[5],
                            //NamSX = (int)dr[6],
                            //ThongSoKT = dr[7].ToString(),
                            //TaiLieuKT = dr[8].ToString(),
                            //MoTaThem = dr[9].ToString(),
                        });
                    
                        dem++;
                        item = new ListViewItem(dem.ToString());
                        lv_thietbi.Items.Add(item);

                        item.SubItems.Add(dr[0].ToString());
                        item.SubItems.Add((LST_DVT.SingleOrDefault(c => c.TenDVT.ToUpper().Equals(dr[2].ToString().ToUpper())) != null ? LST_DVT.SingleOrDefault(c => c.TenDVT.ToUpper().Equals(dr[2].ToString().ToUpper())).TenDVT : "Chưa xác định"));
                        item.SubItems.Add(dr[2].ToString());

                        item.SubItems.Add(dr[3].ToString());
                        item.SubItems.Add(dr[4].ToString());
                            for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                            {
                                if (item.Index % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                            }
                       
               }
            }
        }
        private void btn_chonfile_Click(object sender, EventArgs e)
        {
            Mofile();
        }

        List<string> LST_TB = new List<string>();
        //
        public delegate void passData(List<string> LST_TB);
        public passData DuLieu;
        public void guidulieu(List<string> LST_TB)
        {
            if (DuLieu != null) DuLieu(LST_TB);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            List<THIETBI> TB = new List<THIETBI>();

            THIETBI_BLL THIETBI = new THIETBI_BLL();
            foreach (ListViewItem item in lv_thietbi.Items)
            {
               
            }
        }
    }
}
