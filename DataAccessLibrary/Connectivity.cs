using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
   public class Connectivity
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["credentials"].ConnectionString;
        }
    }
}
