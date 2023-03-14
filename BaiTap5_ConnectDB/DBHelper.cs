using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap5_ConnectDB
{
    internal class DBHelper
    {
        private SqlConnection _cnn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DBHelper("Data Source=MSI\\SQLEXPRESS;Initial Catalog=QLSV;User ID=sa;Password=tuan261103");
                }
                return _Instance;
            }
            private set { }
        }
        private DBHelper(string stringConnection)
        {
            _cnn = new SqlConnection(stringConnection);
        }

        public int ExecuteScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            _cnn.Close();
            return count;
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _cnn);
            _cnn.Open();
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query,_cnn);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }

        public void ExecuteNonQuery(string query, SqlParameter[] listPar)
        {
            _cnn.Open();
            SqlCommand cmd = new SqlCommand(query,_cnn);
            if (listPar != null)
            {
                cmd.Parameters.AddRange(listPar);
            }
            cmd.ExecuteNonQuery();
            _cnn.Close();
        }

        public DataTable GetDataTable(string query, SqlParameter[] listPar)
        {
            DataTable dt = new DataTable() ;
            SqlCommand cmd = new SqlCommand(query , _cnn);
            if (listPar != null)
            {
                cmd.Parameters.AddRange(listPar);
            }
            SqlDataAdapter da = new SqlDataAdapter( cmd);
            _cnn.Open();
            da.Fill(dt);
            _cnn.Close();
            return dt;
        }
    }
}
