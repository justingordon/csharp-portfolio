using System.Configuration;

namespace AstonTech.AstonEngineer.DAL
{
    public static class AppConfiguration
    {
        /// <summary>
        /// Returns the connectionstring for the application
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }

        /// <summary>
        /// Returns the name of the current connection string for the application
        /// </summary>
        public static string ConnectionStringName
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionStringName"];
            }
        }
    }
}
