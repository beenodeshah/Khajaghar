using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class billClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageBills(int billId,
            int KOTId,
            String transactionType,
            Double grandTotal,
            Double discount,
            int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_managebills", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@billId", billId);
                cmd.Parameters.AddWithValue("@KOTId", KOTId);
                cmd.Parameters.AddWithValue("@transactionType", transactionType);
                cmd.Parameters.AddWithValue("@grandTotal", grandTotal);
                cmd.Parameters.AddWithValue("@discount", discount);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
