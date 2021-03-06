using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHr.DataAccessLayer
{
    public enum ConnectionType
    {
        Sql,
        Text
    }
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnection(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.Sql:
                    Connection = new SqlConnector();
                    break;
                case ConnectionType.Text:
                    Connection = new TextConnector();
                    break;
            }
        }
        public static ConnectionType ConnectionType 
        { 
            get
            {
                string configValue = ConfigurationManager.AppSettings["ConnectionType"];
                ConnectionType value = (ConnectionType)Enum.Parse(typeof(ConnectionType), configValue);
                return value;
            }
        }
    }
}
