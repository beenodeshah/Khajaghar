using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DataAccessLayer
{
    public class connectionClass
    {
        public static String connectionString
        {
            get { return System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString; }
        }
    }
}
