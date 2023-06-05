using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public  class KOTClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageKOTs(int KOTId,
            DateTime KOTDate,
            String KOTBy,
            int Mode)
        {
            try
            {
                bool result = false;
                SqlCommand cmd = new SqlCommand("sp_managekots",conn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KOTId", KOTId);
                cmd.Parameters.AddWithValue("@KOTDate", KOTDate);
                cmd.Parameters.AddWithValue("@KOTBy", KOTBy);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                if(rs>0)
                {
                    result = true;
                }
                else { result = false; }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllKOT()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select * from KOTTable", conn);
                conn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public double getMaxKOT()
        {
            try
            {
                DataTable dt=new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select max(KOTId) from KOTTable", conn);
                conn.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                Double maxKOT = Double.Parse(dt.Rows[0][0].ToString());
                return maxKOT;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }

}
