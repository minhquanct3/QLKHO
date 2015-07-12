using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BUL;

namespace BUL
{
    public class Bientoancuc
    {
        public static string Fullname { get; set; }
        public static string Status { get; set; }
        public static string Role { get; set; }
        public static string Username { get; set; }       
    }

    public class UFC
    {
        //Mã hóa Data nhập vào theo chuẩn MD5.
        private byte[] encryptData(string data)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes = null;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }

        //Hàm MD5 mã hóa chuỗi Data dịch chuyển đi theo đơn vị thêm vào.
        public string md5(string data)
        {
            return BitConverter.ToString(encryptData(data + "999")).Replace("-", "").ToLower();
        }

        //Tạo STT trên Datagridview.
        public void AutoNumberNumber(System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.RowHeadersWidth = 50;
            if (dataGridView != null)
            {
                for (int i = 0; (i < dataGridView.Rows.Count); i++)
                    dataGridView.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
            }
        }

        Business BUL = new Business();
        //Ghi thog tin lich su truy cap nguoi dung.
        public void Ghilog(string Username, string Action, string Note)
        {
            if (BUL.Connect())
            {
                BUL.ExecuteCommandNonQuery("INSERT INTO tblHistory(Username,Date,[Action],Note) VALUES('" + Username + "',GETDATE(),'" + Action + "',N'" + Note + "')");
                BUL.close();
            }
        }
    }
}
