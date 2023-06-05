using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccessLayer
{
    public class itemClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageItems(int menuItemId,
            int categoryId,
            String itemName,
            Double rate,
            String remarks,
            int mode)
        {
            try
            {
                bool result = false;
                SqlCommand cmd = new SqlCommand("sp_managemenuItems", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@menuItemId", menuItemId);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@remarks", remarks);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int rs=cmd.ExecuteNonQuery();
                conn.Close();
                if(rs>0)
               result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable menuItemsDetails()
        {
            try
            {
                DataTable dt= new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select menuItemId,categoryName,itemname,rate,remarks  
                                                  from menuItemTable m inner join categoryTable c 
                                                  on m.category=c.categoryId", conn);
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
        public DataTable getItemsByCategory(int categoryId)
        {
            try
            {
                DataTable dt=new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select * form menuItemTable where categoryId=@categoryId",conn);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
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
