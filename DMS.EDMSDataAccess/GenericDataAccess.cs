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
using System.Data.SqlClient;

namespace DMS.EDMSDataAccess
{
    /// <summary>
    /// Summary description for GenericDataAccess
    /// </summary>
    public static class GenericDataAccess
    {

        static GenericDataAccess()
        {

        }

        public static DataTable ExecuteSelectCommand(DbCommand Command)
        {
            DataTable table;

            try
            {
                Command.Connection.Open();
                DbDataReader reader = Command.ExecuteReader();
                table = new DataTable();
                table.Load(reader);
                reader.Close();

            }

            catch (Exception ex)
            {
                throw ex;

            }

            finally
            {
                Command.Connection.Close();

            }


            return table;


        }


        public static int ExecuteNonQuery(DbCommand command)
        {
            int affectedRows = -1;
            try
            {
                command.Connection.Open();
                affectedRows = command.ExecuteNonQuery();


            }


            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                command.Connection.Close();

            }

            return affectedRows;

        }

        public static object ExecuteScalar(DbCommand command)
        {
            object value;
            try
            {
                command.Connection.Open();
                value = command.ExecuteScalar();


            }

            catch (Exception ex)
            {

                throw ex;


            }


            finally
            {
                command.Connection.Close();


            }


            return value;


        }


        public static DbDataReader ExecuteOutput(DbCommand command)
        {
            DbDataReader reader;

            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();

            }

            catch (Exception ex)
            {

                throw ex;


            }


            finally
            {
                command.Connection.Close();


            }


            return reader;


        }



        public static DbCommand CreateCommand()
        {

            string dataProviderName = ApplicationConfiguration.DbProviderName;
            string connectionString = ApplicationConfiguration.DbConnectionString;
            DbProviderFactory factory = DbProviderFactories.GetFactory(dataProviderName);
            DbConnection conn = factory.CreateConnection();
            conn.ConnectionString = connectionString;
            DbCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.StoredProcedure;
            return comm;


        }

        public static void OpenConnection(DbCommand command)
        {
            try
            {
                command.Connection.Open();


            }

            catch (Exception ex)
            {

                throw ex;


            }






        }

        public static void CloseConnection(DbCommand command)
        {
            try
            {
                command.Connection.Close();


            }

            catch (Exception ex)
            {

                throw ex;


            }






        }






    }
}