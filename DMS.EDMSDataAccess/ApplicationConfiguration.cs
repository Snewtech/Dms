using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Common;
namespace DMS.EDMSDataAccess
{
    /// <summary>
    /// Summary description for ApplicationConfiguration
    /// </summary>
    public static class ApplicationConfiguration
    {

        private readonly static string dbConnectionString;
        private readonly static string dbProviderName;
        private readonly static string siteName;


        static ApplicationConfiguration()
        {
            dbConnectionString = ConfigurationManager.ConnectionStrings["EDMSConnection"].ConnectionString;
            dbProviderName = ConfigurationManager.ConnectionStrings["EDMSConnection"].ProviderName;
            siteName = ConfigurationManager.AppSettings["SiteName"];
        }

        public static string DbConnectionString
        {

            get
            {
                return dbConnectionString;

            }


        }

        public static string DbProviderName
        {

            get
            {
                return dbProviderName;

            }

        }

        public static string SiteName
        {

            get
            {
                return siteName;

            }

        }



    }

}