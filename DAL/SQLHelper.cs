using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AppManager.DAL
{
    public class SQLHelper
    {

        private static SqlConnection cnn;
        public void Connec()
        {
            string sqlconnec = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            cnn = new SqlConnection(sqlconnec);
        }
        // Mo Ket Noi
        public void Opencnn()
        {
            try
            {
                if (cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (Exception ex)
            {
                throw (ex.Message("Khong the ket noi duoc"));
            }

        }
        // DONG KET NOI
        public void Closecnn()
        {
            if(cnn.State = ConnectionState.Open)
            {
                cnn.Dispose();
            }
        }
        // THUC HIEN TRUY VAN
        public void ExcuteReader(string Strsql)
        {
            Opencnn();
            SqlCommand cm = new SqlCommand(Strsql,cnn);
            cm.ExecuteNonQuery();
            Closecnn();
        }

        // LAY DU LIEU TU BANG
         public DataTable Getdatatable(string Strsql )
        {
            try
            {
                Opencnn();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(Strsql, cnn);
                da.Fill(dt);
                Closecnn();
                return dt;
            }
            catch()
            {
                return null;

            }

        }
        // LAY Gia TRI DU LIEU
        public string Getvaluee(string Strsql)
        {
            string templ = null;
                Opencnn();
                SqlCommand cm = new SqlCommand(Strsql, cnn);
                SqlDataReader  sqlreder = cm.ExecuteReader();
                while(sqlreder.Read())
                {
                    templ = sqlreder[0].ToString();

                }
                Closecnn();
                return templ;
        }




    }
}
