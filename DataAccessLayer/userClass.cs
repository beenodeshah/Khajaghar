using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public class userClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
		public bool manageUsers(int userId, 
			String userName, 
			String password,
			String role, int mode)
		{
			try
			{
				SqlCommand cmd = new SqlCommand("sp_manageusers",conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@userId", userId);
				cmd.Parameters.AddWithValue("@userName", userName);
				cmd.Parameters.AddWithValue("@password", password);
				cmd.Parameters.AddWithValue("@role", role);
				cmd.Parameters.AddWithValue("@mode", mode);
				conn.Open();
				int result = cmd.ExecuteNonQuery();
				conn.Close();
				if (result > 0)
					return true;
				else return false;

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally { conn.Close(); }
		}
		public DataTable getAllUsers()
		{
			try
			{
				SqlCommand cmd = new SqlCommand(@"Select * from userTable",conn);
				DataTable dt = new DataTable();
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
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
		public bool login(String userName,String password)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(@"Select role from userTable 
												where userName=@userName and password=@password", conn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@userName", userName);
				cmd.Parameters.AddWithValue("@password", password);
				DataTable dt=new DataTable();
				conn.Open();
				SqlDataReader dr = cmd.ExecuteReader();
				dt.Load(dr);
				conn.Close();
				if (dt.Rows.Count > 0) return true;
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
