using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DbConnection
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-OIM98S0\\SQLEXPRESS;Initial Catalog=DigitalIDDB;Integrated Security=True");

        public SqlConnection getConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = getConnection();
                int rowsAffected = -1;
                rowsAffected = cmd.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public object ExeScaler(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            connection.Close();
            return obj;
        }

        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getConnection();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }
    }
}
