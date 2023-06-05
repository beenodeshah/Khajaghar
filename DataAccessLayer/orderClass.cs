using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;

namespace DataAccessLayer
{
    public class orderClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageOrders(int orderId,
            int KOTId,
            int menuItemId,
            Double quantity,
            String remarks, int mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_manageorders", conn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderId", orderId);
                cmd.Parameters.AddWithValue("@KOTId", KOTId);
                cmd.Parameters.AddWithValue("@menuItemId", menuItemId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@remarks", remarks);
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
        public DataTable getAllOrdersByKOT(int KOTId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select orderId,itemName,rate,quantity,amount=rate*quantity,o.remarks
                                                  from orderTable o,menuItemTable m where KOTId=@KOTId
                                                  and o.menuItemId=m.menuItemId",conn);
                cmd.Parameters.AddWithValue("@KOTId", KOTId);
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
    }
}
