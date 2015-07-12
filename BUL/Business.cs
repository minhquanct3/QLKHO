using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using ACL;

namespace BUL
{
    public class Business
    {
        // Khai bao bien thuoc lop DataAccess trong DTA
        private DataAccess m_dataccess=new DataAccess();

        //xay dung ham connect() kiem tra ket noi toi CSDL, thanh cong ta ve gia tri True, ngc lai tra ve false
        public bool Connect()
        {
            m_dataccess = new DataAccess ();
            if (m_dataccess.connect() == true)
                return true;
            else
                return false;
        }

        public void close()
        {                      
            m_dataccess.Close();            
        }             
        
        //Kiểm tra đăng nhập
        public DataTable CheckLogin(string strUserName, string strPassword)
        {
            if (m_dataccess.connect())
            {
                ArrayList Params = new ArrayList();
                Params.Add(m_dataccess.GetParam("@Username", strUserName));
                Params.Add(m_dataccess.GetParam("@Pass", strPassword));
                DataTable bSuccess = m_dataccess.ExecuteStoredProceduretoDatatable("sp_CheckLogin", Params);
                m_dataccess.Close();
                return bSuccess;
            }return null;
        }       

        //Thay đổi mật khẩu.
        public int Thaydoimatkhau(string Username, string Pass)
        {
            int m_Hieuchinh;
            if (m_dataccess.connect())
            {
                m_Hieuchinh = m_dataccess.ExecuteCommandNonQuery("UPDATE tblDangnhap SET Pass = '" + Pass + "' WHERE Username='" + Username + "'");
                m_dataccess.Close();
                return m_Hieuchinh;
            } return 0;
        }

        //Select câu hỏi moi
        public DataSet Load(string strTableName)
        {
            DataSet m_Select = null;
            if (m_dataccess.connect())//mo ket noi khi thuc thi            
            {
                m_Select = m_dataccess.ExecuteCommandSelect("SELECT * FROM tblCauhoi ORDER BY Thutu ASC", strTableName);
                m_dataccess.Close();//thuc thi xong dong ket noi lai
                return m_Select;// tre ket qua ve luu trong bien thuoc kieu Dataset
            } return null;
        }           

        //Load URL mp4 theo Máy server
        public DataTable LoadURL(int IDServer)
        {
            if (m_dataccess.connect())//mo ket noi khi thuc thi            
            {
                DataTable dt = m_dataccess.ExecuteCommandSelecttoDatatable("SELECT TOP 1 URL FROM tblMedia tm WHERE tm.[URL] IS NOT NULL AND tm.IDServer = " + IDServer + " ORDER BY tm.Ngaytao DESC");
                m_dataccess.Close();//thuc thi xong dong ket noi lai
                return dt;
            } return null;
        }

        //Thực thi các câu truy vấn update, insert, delete. Kết quả trả về số dòng trong bảng chịu tác động bởi câu truy vấn
        public int ExecuteCommandNonQuery(string sqlcmd)
        {
            if (m_dataccess.connect())
            {
                int x = m_dataccess.ExecuteCommandNonQuery(sqlcmd);
                m_dataccess.Close();
                return x;
            }return 0;
        }       

        //Thuc thi truy van select ket qua tra ve luu trong datatable
        public DataTable ExecuteCommandSelect(string sqlcmd)
        {            
            if (m_dataccess.connect())
            {                
                DataTable dt = m_dataccess.ExecuteCommandSelecttoDatatable(sqlcmd);
                m_dataccess.Close();//thuc thi xong dong ket noi lai
                return dt;
            }return null;
        }

        //Thuc thi truy van select ket qua tra ve luu trong dataset
        public DataSet ExecuteCommandSelect_ds(string sqlcmd,string tableName)
        {
            if (m_dataccess.connect())//mo ket noi khi thuc thi            
            {
                DataSet ds = m_dataccess.ExecuteCommandSelect(sqlcmd, tableName);
                m_dataccess.Close();//thuc thi xong dong ket noi lai
                return ds;
            }return null;
        }
      
        //Load thong tin ty le NVL
        public DataSet LoadTyleNVL(string Date,string tablename)
        {            
            DataSet bSuccess = new DataSet();
            if (m_dataccess.connect())//Kiem tra va mo ket noi khi thuc thi            
            {
                ArrayList Params = new ArrayList();
                Params.Add(m_dataccess.GetParam("@Date", Date));
                bSuccess = m_dataccess.ExecuteStoredProcedure("sp_Tylenguyenvatlieu", Params, tablename);
                m_dataccess.Close();
                return bSuccess;
            } return null;
        }      

       //Cập nhập trực tieps trên lưới vào CSDL.
        public int CapNhapTrenLuoi(ref DataSet dsDataSet, string strTableName)
        {
            try
            {
                m_dataccess.connect();
                return m_dataccess.Update (ref dsDataSet, strTableName);                
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
