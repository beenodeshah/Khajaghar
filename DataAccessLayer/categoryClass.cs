using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class categoryClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageCategories(int categoryId,
            String categoryName,
            String description,
            int mode)
        {
            try
            {
                bool result = false;
                SqlCommand cmd = new SqlCommand("sp_managecategory", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@categoryName", categoryName);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                if (rs > 0)
                    result = true;
                else result = false;

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllCategories()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from categoryTable",conn);
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
