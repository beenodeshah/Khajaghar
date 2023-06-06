using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Configuration;

namespace DataAccessLayer
{
    public class customerClass
    {
        SqlConnection conn = new SqlConnection(connectionClass.connectionString);
        public bool manageCustomers(int customerId,
            String customerName,
            String address,
            string mobileNo,
            String email,
            String identificationType,
            String identificationNumber,
            int mode)
        {
            try
            {
                bool result = false;
                SqlCommand cmd = new SqlCommand("sp_managecustomers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerId", customerId);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobileNo", mobileNo);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@identificationType", identificationType);
                cmd.Parameters.AddWithValue("@identificationNumber", identificationNumber);
                cmd.Parameters.AddWithValue("@mode", mode);
                conn.Open();
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                if (rs > 0) result = true;
                else result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable getAllCustomers()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"select customerId as Id,
                                                    customerName as Name,
                                                    address as Address,
                                                    mobileNo as Mobile,
                                                    email as Email,
                                                    identificationType as [ID Type],
                                                    identificationNumber as [ID Number],
                                                    AccountNumber as [Acct. No.] from customerTable", conn);
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
        public DataTable getcustomerAccount()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select customerName,mobileNo,AccountNumber from customerTable", conn);
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
        public DataTable getcustomerAccountByAccountNumber(String AccountNumber)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"Select customerName,mobileNo,AccountNumber from customerTable
                                                where AccountNumber like '%' + @AccountNumber + '%'", conn);
                cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
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
    }
}
