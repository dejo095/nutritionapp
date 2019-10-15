using NutritionLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection()
        {
            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
