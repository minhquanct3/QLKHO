using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace ACL
{
    public class DataAccess
    {
       private SqlConnection m_Conn;
       public static string strcon = ConfigurationSettings.AppSettings["stconnect"];

       private SqlCommand m_Cmd;
       private SqlDataAdapter m_Adap;       

       public bool connect()
        {
            m_Conn = new SqlConnection(strcon);
	        try {
		        m_Conn.Open();
	        } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Kiểm tra lại thông tin kết nối. \n" + ex.Message, "Lỗi kết nối.");
                return false;
	        }return true;
        }

       public void Close()
       {
           try
           {
               m_Conn = new SqlConnection(strcon);
               if (m_Conn.State == ConnectionState.Open)
                   m_Conn.Close();
               m_Conn.Dispose();
               m_Conn = null;
           }
           catch (Exception ex)
           { System.Windows.Forms.MessageBox.Show(ex.Message, "Lỗi."); }
       }

       public SqlDataReader ExecuteCommandReader(string SqlCmd)
       {
           m_Cmd = new SqlCommand(SqlCmd, m_Conn);
           return m_Cmd.ExecuteReader();
       }

        //''' <summary>
        //''' thực thi các câu truy vấn T-SQL select, lưu trữ kết quả trả về trong DataSet
        //''' </summary>
        //''' <param name="SqlCmd">Lệnh T-SQL truy vấn</param>
        //''' <param name="strTableName">Tên bảng chứa kết quả truy vấn lưu trữ trong DataSet</param>
        //''' <returns></returns>
        //''' <remarks></remarks>
       public DataSet ExecuteCommandSelect(string SqlCmd, string strTableName)
       {
           DataSet dsDataSet = new DataSet();
           m_Adap = new SqlDataAdapter(SqlCmd, m_Conn);
           m_Adap.Fill(dsDataSet, strTableName);
           return dsDataSet;
       }

       public DataTable ExecuteCommandSelecttoDatatable(string SqlCmd)
       {
           DataTable dt = new DataTable();
           m_Cmd = new SqlCommand(SqlCmd, m_Conn);
           dt.Load(m_Cmd.ExecuteReader());           
           return dt;         
       }

        //    <summary>
        //''' Thực thi các câu truy vấn update, insert, delete. Kết quả trả về số dòng trong bảng chịu tác động bởi câu truy vấn
        //''' </summary>
        //''' <param name="SqlCmd"></param>
        //''' <returns></returns>
        //''' <remarks></remarks>
       public int ExecuteCommandNonQuery(string SqlCmd)
       {
           m_Cmd = new SqlCommand(SqlCmd, m_Conn);
           return m_Cmd.ExecuteNonQuery();
       }

       public SqlParameter GetParam(string ParamName, object Value)
       {
           return new SqlParameter(ParamName, Value);
       }

    // Thuc hien truy van ket qua tra ve luu trong Dataste.
       public DataSet ExecuteStoredProcedure(string spName, ArrayList Params, string strTableName)
       {        
           DataSet dsDataSet = new DataSet();
           m_Cmd = new SqlCommand(spName, m_Conn);
           m_Cmd.CommandType = CommandType.StoredProcedure;
           //đưa danh sách các tham số cho stored procedure
           foreach (SqlParameter param in Params)
           {
               m_Cmd.Parameters.Add(param);
           }           
           m_Adap = new SqlDataAdapter(m_Cmd);
           m_Adap.Fill(dsDataSet, strTableName);
           return dsDataSet;
       }

    //Thuc hien store ket qua tra ve Luu trong Datatable
       public DataTable  ExecuteStoredProceduretoDatatable(string spName, ArrayList Params)
       {
           DataTable dt = new DataTable();
           m_Cmd = new SqlCommand(spName, m_Conn);
           m_Cmd.CommandType = CommandType.StoredProcedure;
           //đưa danh sách các tham số cho stored procedure
           foreach (SqlParameter param in Params)
           {
               m_Cmd.Parameters.Add(param);
           }
           m_Adap = new SqlDataAdapter(m_Cmd);
           m_Adap.Fill(dt);
           return dt;
       }

       internal void close()
       {
           throw new NotImplementedException();
       }

       public SqlDataReader ExecuteStoredProcedureReader(string spName, ArrayList Params)
       {
           m_Cmd = new SqlCommand(spName, m_Conn);
           m_Cmd.CommandType = CommandType.StoredProcedure;

           //đưa danh sách các tham số cho stored procedure
           foreach (SqlParameter param in Params)
           {
               m_Cmd.Parameters.Add(param);
           }
           return m_Cmd.ExecuteReader();
       }

       public int Update(ref DataSet dsDataSet, string strTableName)
       {
           SqlCommandBuilder CmdBuilder = new SqlCommandBuilder(m_Adap);
           return m_Adap.Update(dsDataSet, strTableName);
       }
    }
}
