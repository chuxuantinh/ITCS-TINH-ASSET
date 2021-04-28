using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.Linq;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;

using System.Data.OleDb ;
using System.Data;
using System.Windows.Forms;

namespace ThietBiPY.LopHoTro
{

    //---- Kiểu giao nhận thiết bị
    public enum KIEUPHIEUNHAP
    {
        tunhacungcap=1,
        tunguonkhac=2,
    }
    public enum DIEUKHIEN
    {
        them = 1,
        sua = 2,
        xoa = 3,
        nhandoi = 4,
        lamtuoi = 5,
        invanban=6,
    }
    public enum QUYEN
    {
        quantrithietbi=1,
        quanlythietbidonvi=2,
        nhanviendonvi=0,
    }

    //
    public class PHANQUYEN
    {
        public static int quyen;
    }

    public class DOITUONG
    {
        public string name { get; set; }
        public int value { get; set; }
        public DOITUONG(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
        public override string ToString()
        {
            return name;
        }
    }
    public class CHUYENKIEU
    {
        public byte[] ImageToBinary(Image img)
        {
            MemoryStream mstr = new MemoryStream();
            img.Save(mstr, img.RawFormat);
            byte[] arrImage = mstr.GetBuffer();
            return arrImage;
        }
        public Image BinaryToImage(Binary binaryData)
        {
            if (binaryData == null) return null;

            byte[] buffer = binaryData.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return Image.FromStream(memStream);
        }

        //
        public byte[] FileToBinary(string filePath)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }

            finally
            {
                fileStream.Close();
            }
            return buffer;
        }
        public void BinaryToFile(System.Data.Linq.Binary br, string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            byte[] buffer = br.ToArray();
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();
        }

        //
        public string StringToMD5(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        //Đọc số tiền
        public string DecimalToString(decimal number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }
        public string DoubleString(double number)
        {
            string s = number.ToString("#");
            string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] hang = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, donvi, chuc, tram;
            string str = " ";
            bool booAm = false;
            double decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDouble(s.ToString());
            }
            catch
            {
            }
            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }
            i = s.Length;
            if (i == 0)
                str = so[0] + str;
            else
            {
                j = 0;
                while (i > 0)
                {
                    donvi = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        chuc = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        chuc = -1;
                    i--;
                    if (i > 0)
                        tram = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        tram = -1;
                    i--;
                    if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
                        str = hang[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((donvi == 1) && (chuc > 1))
                        str = "một " + str;
                    else
                    {
                        if ((donvi == 5) && (chuc > 0))
                            str = "lăm " + str;
                        else if (donvi > 0)
                            str = so[donvi] + " " + str;
                    }
                    if (chuc < 0)
                        break;
                    else
                    {
                        if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
                        if (chuc == 1) str = "mười " + str;
                        if (chuc > 1) str = so[chuc] + " mươi " + str;
                    }
                    if (tram < 0) break;
                    else
                    {
                        if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }

        //Lấy khoảng cách giữa 2 ngày
        public string DateDiff(DateTime startDate, DateTime endDate)
        {
            string timeStr = string.Empty;
            int yr = 0;
            int mth = 0;
            int days = 0;

            TimeSpan ts = new TimeSpan();
            ts = endDate.Subtract(startDate);
            yr = (ts.Days / 365);

            do
            {
                for (int i = 0; i <= 12; i++)
                {
                    if (endDate.Subtract(startDate.AddYears(yr).AddMonths(i)).Days > 0)
                    {
                        mth = i;
                    }
                    else
                    {
                        break;
                    }
                }

                if (mth > 12)
                    yr = yr + 1;
            } while (mth > 12);

            days = endDate.Subtract(startDate.AddYears(yr).AddMonths(mth)).Days;

            if (yr > 0)
                timeStr += yr.ToString() + "năm ";
            if (mth > 0)
                timeStr += mth.ToString() + "tháng ";
            if (days > 0)
                timeStr += days.ToString() + "ngày ";
            return (timeStr);
        }

        //
        public string Mahoa2Mahoa(string chuoi)
        {
            string kq = "";
            for (int i = 0; i < chuoi.Length; i++)
            {
                int S = (int)(char.Parse(chuoi.Substring(i, 1)));
                kq += ((char)(S < 128 ? S + 128 : S - 128)).ToString();
            }
            return kq;
        }
    }
    public class CAUHINHREGISTRY
    {
        //Tạo khóa
        public void datkhoa(string name, string value)
        {
            RegistryKey regkey = Registry.CurrentUser;
            regkey = regkey.CreateSubKey("Software\\ThietBiPY\\HeThong");
            if (regkey != null)
            {
                regkey.SetValue(name, value);
            }
            regkey.Close();
        }
        //Lay gia tri khoa
        public string laykhoa(string name)
        {
            RegistryKey regkey = Registry.CurrentUser;
            string giatri = "";
            regkey = regkey.OpenSubKey("Software\\ThietBiPY\\HeThong");
            if (regkey != null)
            {
                string giatri_name = "";
                if (regkey.GetValue(name) != null) giatri_name = regkey.GetValue(name).ToString();
                if (giatri_name != "")
                {
                    giatri = giatri_name;
                }

                regkey.Close();
            }

            return giatri;
        }
    }
    public class OLEDB
    {
        public OleDbConnection conn = new OleDbConnection();
        public string TepTin { get; set; }

        public OLEDB(string TepTin)
        {
            this.TepTin = TepTin;
        }
        public void ketnoi()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                switch (System.IO.Path.GetExtension(TepTin))
                {
                    case ".xls": //Office 2003
                        conn.ConnectionString = "Provider=Microsoft.Jet.OleDB.4.0;Data Source=" + TepTin + ";Extended Properties=Excel 8.0;";
                        break;

                    case ".xlsx": //Office 2007
                        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TepTin + ";Extended Properties=Excel 12.0 Xml;";
                        break;
                }
                conn.Open();
            }
        }
        public DataTable docfile(string TenSheet)
        {
            ketnoi();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from ["+TenSheet+"$]", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
    public class INPUTBOX
    {
        public DialogResult InputBox(string title, string promptText, ref string value)
        {
            //Form form = new Form();

            DevComponents.DotNetBar.Office2007Form form = new DevComponents.DotNetBar.Office2007Form();
            DevComponents.DotNetBar.LabelX label = new DevComponents.DotNetBar.LabelX();
            //Label label = new Label();
            //TextBox textBox = new TextBox();
            //Button buttonOk = new Button();
            //Button buttonCancel = new Button();

            DevComponents.DotNetBar.Controls.TextBoxX textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            DevComponents.DotNetBar.ButtonX buttonOk = new DevComponents.DotNetBar.ButtonX();
            DevComponents.DotNetBar.ButtonX buttonCancel = new DevComponents.DotNetBar.ButtonX();



            form.EnableGlass = false;
            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
