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
    /// Summary description for EDMSDataAccess
    /// </summary>
    public static class EDMSDataAccess
    {
        static EDMSDataAccess()
        {

        }



        public static bool AddUserLogin(string username, string userrole, string loginname, string password, string emailid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddUserLogin";
            DbParameter param = comm.CreateParameter();

            param.ParameterName = "@User_Name";
            param.Value = username;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User_Role";
            param.Value = userrole;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Login_Name";
            param.Value = loginname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Email_Id";
            param.Value = emailid;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateUserLogin(int userid, string username, string userrole, string loginname, string password, string emailid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateUserLogin";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@User_Id";
            param.Value = userid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User_Name";
            param.Value = username;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User_Role";
            param.Value = userrole;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Login_Name";
            param.Value = loginname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Email_Id";
            param.Value = emailid;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool DeleteUserLogin(int userid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteUserLogin";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@User_Id";
            param.Value = userid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }

        public static int AuthoriseUser(string loginname, string password)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AuthoriseUser";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Login_Name";
            param.Value = loginname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToInt32(a);

        }

        public static string SelectUserRole(string loginname, string password)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "SelectUserRole";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Login_Name";
            param.Value = loginname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToString(a);

        }

        public static string SelectUserName(string loginname, string password)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "SelectUserName";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Login_Name";
            param.Value = loginname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Password";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToString(a);

        }


        public static bool AddContractorDetails(string contractcode, string companyname)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddContractorDetails";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateContractorDetails(int contractid, string contractcode, string companyname)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateContractorDetails";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Id";
            param.Value = contractid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_Code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool DeleteContractorDetails(int contractorid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteContractorDetail";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Id";
            param.Value = contractorid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }

        public static DataTable SelectContractorDetails()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectContractorDetails";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectContractCodeUseContractId(string contractcode)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectContractCodeUseContractId";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        public static bool AddIncomingCorrespondence(int softwarerefno, string documentidno, string documentpath, DateTime documentdate, DateTime documentreceiveddate, string documenttype, string companyname, string recipientcompany, string contractcode, string majordiscipline, string minordiscipline, string inrefno, string indirectedorgreference, string documentsubject, string attachmentmedia, string totalattachedpages, string status, string action, string information, string comments, string replyreference, DateTime replydate, int delayeddays, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Path";
            param.Value = documentpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Document_Received_Date";
            param.Value = documentreceiveddate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Recipient_Company";
            param.Value = recipientcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@In_Reference_No";
            param.Value = inrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);
            //'@Indirected_Originated_Reference
            param = comm.CreateParameter();
            param.ParameterName = "@Indirect_Originated_Reference";
            param.Value = indirectedorgreference;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Subject";
            param.Value = documentsubject;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Action";
            param.Value = action;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Information";
            param.Value = information;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Comments";
            param.Value = comments;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);



            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Reference";
            param.Value = replyreference;
            param.DbType = DbType.String;
            param.Size = 2000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Date";
            param.Value = replydate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Delayed_Days";
            param.Value = delayeddays;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@FileNo_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdatingIncomingCorrespondence(int softwarerefno, string documentidno, string documentpath, DateTime documentdate, DateTime documentreceiveddate, string documenttype, string companyname, string recipientcompany, string contractcode, string majordiscipline, string minordiscipline, string inrefno, string indirectorgreference, string documentsubject, string attachmentmedia, string totalattachedpages, string status, string action, string information, string comments, string replyreference, DateTime replydate, int delayeddays, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Path";
            param.Value = documentpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Document_Received_Date";
            param.Value = documentreceiveddate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Recipient_Company";
            param.Value = recipientcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@In_Reference_No";
            param.Value = inrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Indirect_Originated_Reference";
            param.Value = indirectorgreference;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Subject";
            param.Value = documentsubject;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Action";
            param.Value = action;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Information";
            param.Value = information;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Comments";
            param.Value = comments;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Reference";
            param.Value = replyreference;
            param.DbType = DbType.String;
            param.Size = 2000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Date";
            param.Value = replydate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Delayed_Days";
            param.Value = delayeddays;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@FileNo_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool DeleteIncomingCorrespondence(int softwarerefno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteIncomingCorrespondence";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);


        }

        public static DataTable SelectIncomingCorrespondence()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingCorrespondence";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectIncomingCorSoftwareRefNo(string docidno)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingCorSoftwareRefNo";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = docidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectIncomingCorDocumentIdNo()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingCorDocumentIdNo";




            return GenericDataAccess.ExecuteSelectCommand(comm);

        }





        public static bool AddOutgoingCorrespondence(string documentidno, string documentpath, string incomingrefno, string issuer, DateTime documentdate, DateTime documentsentdate, string documenttype, string companyname, string issuingcompany, string contractcode, string majordiscipline, string minordiscipline, string indirectedorgreference, string documentsubject, string attachmentmedia, string totalattachedpages, string otherreferences, string status, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Path";
            param.Value = documentpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Incoming_Ref_No";
            param.Value = incomingrefno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuer";
            param.Value = issuer;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Document_Sent_Date";
            param.Value = documentsentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuing_Company";
            param.Value = issuingcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Indirected_Originated_Reference";
            param.Value = indirectedorgreference;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Subject";
            param.Value = documentsubject;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Other_References";
            param.Value = otherreferences;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdateOutgoingCorrespondence(string documentidno, string documentpath, string incomingrefno, string issuer, DateTime documentdate, DateTime documentsentdate, string documenttype, string companyname, string issuingcompany, string contractcode, string majordiscipline, string minordiscipline, string indirectedorgreference, string documentsubject, string attachmentmedia, string totalattachedpages, string otherreferences, string status, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Path";
            param.Value = documentpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Incoming_Ref_No";
            param.Value = incomingrefno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuer";
            param.Value = issuer;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Document_Sent_Date";
            param.Value = documentsentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuing_Company";
            param.Value = issuingcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Indirected_Originated_Reference";
            param.Value = indirectedorgreference;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Subject";
            param.Value = documentsubject;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Other_References";
            param.Value = otherreferences;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 5000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteOutgoingCorrespondence(string documentidno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteOutgoingCorrespondence";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 250;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }


        public static DataTable SelectOutgoingCorrespondence()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectOutgoingCorrespondence";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static bool AddIncomingDrawing(int softwarerefno, string drawingidno, string drawingpath, string revision, DateTime drawingdate, DateTime drawingreceiveddate, string companyname, string recipientcompany, string contractcode, string area, string majordiscipline, string minordiscipline, string inrefno, string drawingdescription, string attachmentmedia, string totalattachedpages, string status, string issuedto, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Path";
            param.Value = drawingpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Revision";
            param.Value = revision;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Received_Date";
            param.Value = drawingreceiveddate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Recipient_Company";
            param.Value = recipientcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area";
            param.Value = area;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@In_Ref_No";
            param.Value = inrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Description";
            param.Value = drawingdescription;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issued_To";
            param.Value = issuedto;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdateIncomingDrawing(int softwarerefno, string drawingidno, string drawingpath, string revision, DateTime drawingdate, DateTime drawingreceiveddate, string companyname, string recipientcompany, string contractcode, string area, string majordiscipline, string minordiscipline, string inrefno, string drawingdescription, string attachmentmedia, string totalattachedpages, string status, string issuedto, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Path";
            param.Value = drawingpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Revision";
            param.Value = revision;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Received_Date";
            param.Value = drawingreceiveddate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Recipient_Company";
            param.Value = recipientcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area";
            param.Value = area;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@In_Ref_No";
            param.Value = inrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Description";
            param.Value = drawingdescription;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issued_To";
            param.Value = issuedto;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteIncomingDrawing(int softwarerefno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteIncomingDrawing";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }


        public static DataTable SelectIncomingDrawing()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingDrawing";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectIncomingDraSoftwareRefNo(string drawingidno)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingDraSoftwareRefNo";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static bool AddOutgoingDrawing(string drawingidno, string drawingpath, string revision, DateTime drawingdate, DateTime drawingsentdate, string companyname, string issuingcompany, string contractcode, string area, string majordiscipline, string minordiscipline, string outrefno, string drawingdescription, string attachmentmedia, string totalattachedpages, string status, string issuedto, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Path";
            param.Value = drawingpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Revision";
            param.Value = revision;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Sent_Date";
            param.Value = drawingsentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuing_Company";
            param.Value = issuingcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area";
            param.Value = area;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Out_Ref_No";
            param.Value = outrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Description";
            param.Value = drawingdescription;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issued_To";
            param.Value = issuedto;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdateOutgoingDrawing(string drawingidno, string drawingpath, string revision, DateTime drawingdate, DateTime drawingsentdate, string companyname, string issuingcompany, string contractcode, string area, string majordiscipline, string minordiscipline, string outrefno, string drawingdescription, string attachmentmedia, string totalattachedpages, string status, string issuedto, string remarks, string filenolocation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Path";
            param.Value = drawingpath;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Revision";
            param.Value = revision;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Sent_Date";
            param.Value = drawingsentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issuing_Company";
            param.Value = issuingcompany;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract_code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area";
            param.Value = area;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Out_Ref_No";
            param.Value = outrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Description";
            param.Value = drawingdescription;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Attachment_Media";
            param.Value = attachmentmedia;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Total_Attached_Pages";
            param.Value = totalattachedpages;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 1000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Issued_To";
            param.Value = issuedto;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Remarks";
            param.Value = remarks;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fileno_Location";
            param.Value = filenolocation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteOutgoingDrawing(string drawingidno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteOutgoingDrawing";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Identity_No";
            param.Value = drawingidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }


        public static DataTable SelectOutgoingDrawing()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectOutgoingDrawing";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        //public static bool DeleteContractorDetail(int contractid)
        //{
        //    DbCommand comm = GenericDataAccess.CreateCommand();

        //    comm.CommandText = "DeleteContractorDetail";

        //    DbParameter param = comm.CreateParameter();
        //    param.ParameterName = "@Contract_Id";
        //    param.Value = contractid;
        //    param.DbType = DbType.Int32;
        //    comm.Parameters.Add(param);

        //    int result = -1;

        //    try
        //    {
        //        result = GenericDataAccess.ExecuteNonQuery(comm);

        //    }

        //    catch
        //    {

        //    }
        //    return (result != -1);



        //}



        public static bool AddMajorDiscipline(int majordisciplineid, string majordiscipline)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddMajorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);





            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateMajorMinorDiscipline(int majordisciplineid, string majordiscipline, int minordisciplineid, string minordiscipline, bool value)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateMajorMinorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline_Id";
            param.Value = minordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Value";
            param.Value = value;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteMajorMinorDiscipline(int majordisciplineid, bool value)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteMajorMinorDiscipline";

            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Value";
            param.Value = value;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);

            }

            catch
            {

            }
            return (result != -1);



        }

        public static bool AddMinorDiscipline(int minordisciplineid, string minordiscipline, int majordisciplineid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddMinorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline_Id";
            param.Value = minordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }



        public static bool UpdateMinorDiscipline(int minordisciplineid, string minordiscipline, int majordisciplineid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateMinorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline_Id";
            param.Value = minordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Minor_Discipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static DataTable SelectMajorDisciplineTable()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMajorDisciplineTable";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        public static DataTable SelectMajorDisciplineColumn()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMajorDisciplineColumn";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        public static DataTable SelectMinorDisciplineColumn(int majordisciplineid)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMinorDisciplineColumn";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Major_Discipline_Id";
            param.Value = majordisciplineid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);




            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectMinorDisciplineTable()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMinorDisciplineTable";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static bool AddAreaCodeDocument(string areacode, string areadesignation, string corridor)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddAreaCodeDocument";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Code";
            param.Value = areacode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Designation";
            param.Value = areadesignation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Corridor";
            param.Value = corridor;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateAreaCodeDocument(int areaid, string areacode, string areadesignation, string corridor)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateAreaCodeDocument";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Id";
            param.Value = areaid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Code";
            param.Value = areacode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Designation";
            param.Value = areadesignation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Corridor";
            param.Value = corridor;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteAreaCodeDocument(int areaid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteAreaCodeDocument";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Id";
            param.Value = areaid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static DataTable SelectAreaCodeDocument()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectAreaCodeDocument";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectAreaCode()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectAreaCode";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }
        public static DataTable SelectAreaCodeDocumentSpecificAreaCode(string areacode)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectAreaCodeDocumentSpecificAreaCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Code";
            param.Value = areacode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(comm);




            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static bool AddAreaCodeDrawing(string areacode, string areadesignation, string corridor)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddAreaCodeDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Code";
            param.Value = areacode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Designation";
            param.Value = areadesignation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Corridor";
            param.Value = corridor;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateAreaCodeDrawing(int areaid, string areacode, string areadesignation, string corridor)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateAreaCodeDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Id";
            param.Value = areaid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Code";
            param.Value = areacode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area_Designation";
            param.Value = areadesignation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Corridor";
            param.Value = corridor;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteAreaCodeDrawing(int areaid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteAreaCodeDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Area_Id";
            param.Value = areaid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static DataTable SelectAreaCodeDrawing()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectAreaCodeDrawing";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectAreaCodeDrawingAreaCode()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectAreaCodeDrawingAreaCode";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }
        //public static DataTable SelectAreaCodeDocumentSpecificAreaCode(string areacode)
        //{

        //    DbCommand comm = GenericDataAccess.CreateCommand();
        //    comm.CommandText = "SelectAreaCodeDrawingSpecificAreaCode";
        //    DbParameter param = comm.CreateParameter();
        //    param.ParameterName = "@Area_Code";
        //    param.Value = areacode;
        //    param.DbType = DbType.String;
        //    param.Size = 50;
        //    comm.Parameters.Add(comm);




        //    return GenericDataAccess.ExecuteSelectCommand(comm);

        //}

        public static bool AddDocumentType(string documenttype)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddDocumentType";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);




            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool UpdateDocumentType(int documenttypeid, string documenttype)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateDocumentType";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Documenttype_ID";
            param.Value = documenttypeid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Type";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool DeleteDocumentType(int documenttypeid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteDocumentType";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Documenttype_ID";
            param.Value = documenttypeid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);





            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }
        public static DataTable SelectDocumentType()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectDocumentType";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static bool AddEmbyeUsers(string username, string companyname, string trigram)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddEmbyeUsers";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@User_Name";
            param.Value = username;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Trigram";
            param.Value = trigram;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdateEmbyeUsers(int userid, string username, string companyname, string trigram)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateEmbyeUsers";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@User_Id";
            param.Value = userid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@User_Name";
            param.Value = username;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Company_Name";
            param.Value = companyname;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Trigram";
            param.Value = trigram;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool DeleteEmbyeUsers(int userid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteEmbyeUsers";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@User_Id";
            param.Value = userid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static DataTable SelectEmbyeUsers()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectEmbyeUsers";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static bool AddCompanyCode(string companycode, string designation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddCompanyCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Company_Code";
            param.Value = companycode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Designation";
            param.Value = designation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool UpdateCompanyCode(int companyid, string companycode, string designation)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateCompanyCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Company_Id";
            param.Value = companyid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Company_Code";
            param.Value = companycode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Designation";
            param.Value = designation;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);



            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static bool DeleteCompanyCode(int companyid)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "DeleteCompanyCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Company_Id";
            param.Value = companyid;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static DataTable SelectCompanyCode()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectCompanyCode";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectCompanyCodeTable()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectCompanyCodeTable";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static bool UpdateLastUpdatedSlNo(int slno, int slno1)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateLastUpdateSlno";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Slno";
            param.Value = slno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Slno1";
            param.Value = slno1;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static int SelectLastUpdatedSlno(int no)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "SelectLastUpdatedSlno";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@no";
            param.Value = no;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToInt32(a);

        }


        //Search Functions

        public static DataTable SearchIncomingCorrespondence(string searchtext, DateTime searchdate, int intsearch, bool documentdate, bool documentreceiveddate, bool replydate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SearchIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchdate";
            param.Value = searchdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Intsearch";
            param.Value = intsearch;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@DocumentDate";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DocumentReceivedDate";
            param.Value = documentreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ReplyDate";
            param.Value = replydate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable SearchOutgoingCorrespondence(string searchtext, DateTime searchdate, bool documentdate, bool documentsentdate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SearchOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchdate";
            param.Value = searchdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DocumentDate";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DocumentSentDate";
            param.Value = documentsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);


        }

        public static DataTable SearchIncomingDrawing(string searchtext, DateTime searchdate, int intsearch, bool drawingdate, bool drawingreceiveddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SearchIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchdate";
            param.Value = searchdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Intsearch";
            param.Value = intsearch;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DrawingDate";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DrawingReceivedDate";
            param.Value = drawingreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);




            return GenericDataAccess.ExecuteSelectCommand(comm);


        }

        public static DataTable SearchOutgoingDrawing(string searchtext, DateTime searchdate, bool drawingdate, bool drawingsentdate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SearchOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchdate";
            param.Value = searchdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DrawingDate";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DrawingSentDate";
            param.Value = drawingsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);


        }









        //public static DataTable FindtheRecord(string searchtext, int rank)
        //{

        //    DbCommand comm = GenericDataAccess.CreateCommand();
        //    comm.CommandText = "rptIncomingCorDocDateRange";
        //    DbParameter param = comm.CreateParameter();
        //    param.ParameterName = "@BeginDate";
        //    param.Value = begindate;
        //    param.DbType = DbType.DateTime;
        //    comm.Parameters.Add(param);

        //    param = comm.CreateParameter();
        //    param.ParameterName = "@EndDate";
        //    param.Value = enddate;
        //    param.DbType = DbType.DateTime;
        //    comm.Parameters.Add(param);



        //    return GenericDataAccess.ExecuteSelectCommand(comm);


        //}

        public static DataTable rptIncomingCorDateRange(DateTime begindate, DateTime enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptIncomingCorDocDateRange";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@BeginDate";
            param.Value = begindate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@EndDate";
            param.Value = enddate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectSearchDateField(string tablename)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectSearchDateField";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Tablename";
            param.Value = tablename;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptIncomingCorrespondence(bool documentdate, bool documentreceiveddate, bool replydate, string startdate, string enddate, string searchtext, string searchfield)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Received_Date";
            param.Value = documentreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Date";
            param.Value = replydate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchtext";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchField";
            param.Value = searchfield;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptDateIncomingCorrespondence(bool documentdate, bool documentreceiveddate, bool replydate, string startdate, string enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptDateIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Received_Date";
            param.Value = documentreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Date";
            param.Value = replydate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);


        }

        public static DataTable rptOutgoingCorrespondence(bool documentdate, bool documentsentdate, string startdate, string enddate, string searchtext, string searchfield)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Sent_Date";
            param.Value = documentsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchtext";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchField";
            param.Value = searchfield;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptDateOutgoingCorrespondence(bool documentdate, bool documentsentdate, string startdate, string enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptDateOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Date";
            param.Value = documentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Sent_Date";
            param.Value = documentsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptIncomingDrawing(bool drawingdate, bool drawingreceiveddate, string startdate, string enddate, string searchtext, string searchfield)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Received_Date";
            param.Value = drawingreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchtext";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchField";
            param.Value = searchfield;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptDateIncomingDrawing(bool drawingdate, bool drawingreceiveddate, string startdate, string enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptDateIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Received_Date";
            param.Value = drawingreceiveddate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptOutgoingDrawing(bool drawingdate, bool drawingsentdate, string startdate, string enddate, string searchtext, string searchfield)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Sent_Date";
            param.Value = drawingsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Searchtext";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchField";
            param.Value = searchfield;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptDateOutgoingDrawing(bool drawingdate, bool drawingsentdate, string startdate, string enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptDateOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Date";
            param.Value = drawingdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Drawing_Sent_Date";
            param.Value = drawingsentdate;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Start_Date";
            param.Value = startdate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@End_Date";
            param.Value = enddate;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);


        }


        public static DataTable rptReplyDateMorethanSpecificDay(int specificday)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptReplyDateMorethanSpecificDay";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@SpecificDay";
            param.Value = specificday;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable rptReplyDateRange(string startdate, string enddate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "rptReplyDateRange";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@StartDate";
            param.Value = startdate;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@EndDate";
            param.Value = enddate;
            param.DbType = DbType.String;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectSoftwareRefNoIncomingCorrespondence()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectSoftwareRefNoIncomingCor";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectSoftwareRefNoIncomingDrawing()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectSoftwareRefNoIncomingDrawing";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectDocumentIdNoOutgoingCor()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectDocumentIdNoOutgoingCor";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectDocumentIdNoOutgoingDrawing()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectDrawingIdNoOutgoingDrawing";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectRecordUsingSoftwareRefNo(int softwarerefno, bool tablename)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectRecordUsingSoftwareRef";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Software_Ref_No";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Table_Name";
            param.Value = tablename;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable SelectRecordUsingDocumentIdNo(string documentidno, bool tablename)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectRecordUsingDocumentIdNoOutCor";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 250;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Table_Name";
            param.Value = tablename;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static bool AddorUpdateIssuedToAction(string tablename, string documentidno, string receivername, bool action)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddorUpdateIssuedtoAction";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@TableName";
            param.Value = tablename;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Documentidno";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ReceiverName";
            param.Value = receivername;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Action";
            param.Value = action;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool AddorUpdateIssuedToInformation(string tablename, string documentidno, string receivername, bool information)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddorUpdateIssuedtoInformation";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@TableName";
            param.Value = tablename;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Documentidno";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ReceiverName";
            param.Value = receivername;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Information";
            param.Value = information;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static bool AddorUpdateIssuedToComments(string tablename, string documentidno, string receivername, bool comments)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "AddorUpdateIssuedtoComments";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@TableName";
            param.Value = tablename;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Documentidno";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ReceiverName";
            param.Value = receivername;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Comments";
            param.Value = comments;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);


            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static DataTable GetInReferenceNoIncomingCor()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GetInReferenceNoIncomingCor";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable ReportGeneral(DateTime fromdate, DateTime todate, int correspondencetype)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportGeneral";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        public static DataTable ReportArea(DateTime fromdate, DateTime todate, string area, int correspondencetype, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportArea";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Area";
            param.Value = area;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable ReportContractCode(DateTime fromdate, DateTime todate, int correspondencetype, string contractcode, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportContractCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ContractCode";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }
        public static DataTable ReportStatus(DateTime fromdate, DateTime todate, int correspondencetype, string status, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportStatus";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Status";
            param.Value = status;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable ReportDocumentType(DateTime fromdate, DateTime todate, int correspondencetype, string documenttype, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportDocumentType";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@DocumentType";
            param.Value = documenttype;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable ReportIssuedTo(DateTime fromdate, DateTime todate, bool action, bool information, bool comments, bool all, string trigram)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportIssuedTo";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@Action";
            param.Value = action;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Information";
            param.Value = information;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Comments";
            param.Value = comments;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);
            param = comm.CreateParameter();

            param.ParameterName = "@Receiver";
            param.Value = trigram;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable ReportMajorDiscipline(DateTime fromdate, DateTime todate, int correspondencetype, string majordiscipline, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportMajorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@MajorDiscipline";
            param.Value = majordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable ReportaMinorDiscipline(DateTime fromdate, DateTime todate, int correspondencetype, string minordiscipline, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportMinorDiscipline";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@MinorDiscipline";
            param.Value = minordiscipline;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable ReportReplyPending(DateTime fromdate, DateTime todate, bool contractcode, string contract, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportReplyPending";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ContractCode";
            param.Value = contractcode;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Contract";
            param.Value = contract;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static string GetFilePathIncoming(int softwarerefno, int table)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GetFilePathIncoming";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Softwarerefno";
            param.Value = softwarerefno;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToString(a);

        }


        public static string GetFilePathOutgoing(string documentidno, int table)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GetFilePathOutgoing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Documentidno";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToString(a);

        }

        public static bool ChangePassword(string userrole, string password)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "ChnagePassword";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@UserRole";
            param.Value = userrole;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@NewPassword";
            param.Value = password;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static DataTable FilterRecordYearBased(int table, string year, string month)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FilterRecordYearBased";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@year";
            param.Value = year;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@month";
            param.Value = month;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable FilterRecordPeriodBased(int table, DateTime fromdate, DateTime todate, string user)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FilterRecordPeriodBased";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Fromdate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Todate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User";
            param.Value = user;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }



        public static int GetSoftwareRefNoUsingDocumentIdno(string documentidno, bool table)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GetSoftwareRefNoUsingDocumentIdno";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Documentidentityno";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToInt32(a);

        }

        public static DataTable RevisionIndex(string keyvalue)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "RevisionIndex";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectMajorMinorDisciplineId()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMajorMinorDisciplineId";


            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectIncomingReferenceNo(string contractcode)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectIncomingReferenceNo";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable FilterDocumentIdentityNoYearBased(int table)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FilterDocumentIdentityNoYearBased";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable FilterRecordDocIdKeyValue(int table, string keyvalue)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FilterRecordDocIdKeyValue";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);


            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static int CheckLastUpdateSno(int table, string documentidno)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "CheckLastUpdateSno";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Table";
            param.Value = table;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToInt32(a);

        }

        public static DataTable GridSearchIncomingCorrespondence(DateTime fromdate, DateTime todate, string searchtext)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GridSearchIncomingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable GridSearchOutgoingCorrespondence(DateTime fromdate, DateTime todate, string searchtext, string user)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GridSearchOutgoingCorrespondence";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User";
            param.Value = user;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable GridSearchIncomingDrawing(DateTime fromdate, DateTime todate, string searchtext)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GridSearchIncomingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable GridSearchOutgoingDrawing(DateTime fromdate, DateTime todate, string searchtext, string user)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "GridSearchOutgoingDrawing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@SearchText";
            param.Value = searchtext;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User";
            param.Value = user;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable FindReplyReference(string keyvalue)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FindReplyReference";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static bool UpdateReplyReferenceFromOutgoing(string inreference, string outdocumentidentityno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateReplyReferenceFromOutgoing";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@In_Reference";
            param.Value = inreference;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Out_Document_Identity_No";
            param.Value = outdocumentidentityno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }


        public static DataTable revisionIndex(string keyvalue, int user)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "RevisionIndex";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@User";
            param.Value = user;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable RevisionIndexPostdocument(string keyvalue)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "RevisionIndexPostdocument";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectCompanyCodeFromContractor()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectCompanyCodefromContractor";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectCompanyCodeNameinContracCode(string contractcode, int value)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectCompanyCodeNameInContractCode";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Contract_Code";
            param.Value = contractcode;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Value";
            param.Value = value;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }
        public static DataTable SelectMajorMinorDiscipline()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectMajorMinorDiscipline";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable SelectStatusColumn(int correspondencetype)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectStatusColumn";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Correspondence_Type";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }


        public static DataTable FindIncomingDocumentIdNobyInrefno(string inrefno)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FindIncomingDocumentIdNobyInrefno";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Inreference_No";
            param.Value = inrefno;
            param.DbType = DbType.String;
            param.Size = 100;
            comm.Parameters.Add(param);



            return GenericDataAccess.ExecuteSelectCommand(comm);
        }


        public static string FindReplyReferenceImmediateDate(string keyvalue, DateTime incomingdocumentdate)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "FindReplyReference_ImmediateDate";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Keyvalue";
            param.Value = keyvalue;
            param.DbType = DbType.String;
            param.Size = 50;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Incoming_DocumentDate";
            param.Value = incomingdocumentdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            object a = GenericDataAccess.ExecuteScalar(comm);
            return Convert.ToString(a);
        }

        public static bool UpdateReplyReferenceandReplyDate(string replyreference, DateTime replydate, string documentidno)
        {
            DbCommand comm = GenericDataAccess.CreateCommand();

            comm.CommandText = "UpdateReplyReferenceIncoming";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@Reply_Reference";
            param.Value = replyreference;
            param.DbType = DbType.String;
            param.Size = 2000;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@Reply_Date";
            param.Value = replydate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "Document_Identity_No";
            param.Value = documentidno;
            param.DbType = DbType.String;
            param.Size = 260;
            comm.Parameters.Add(param);

            int result = -1;

            try
            {
                result = GenericDataAccess.ExecuteNonQuery(comm);


            }

            catch
            {


            }

            return (result != -1);


        }

        public static DataTable SelectUserTrigram()
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "SelectUserTrigram";



            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

        public static DataTable ReportContractCodeforCMRL(DateTime fromdate, DateTime todate, int correspondencetype, bool all)
        {

            DbCommand comm = GenericDataAccess.CreateCommand();
            comm.CommandText = "ReportContractCodeforCMRL";
            DbParameter param = comm.CreateParameter();
            param.ParameterName = "@FromDate";
            param.Value = fromdate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);

            param = comm.CreateParameter();
            param.ParameterName = "@ToDate";
            param.Value = todate;
            param.DbType = DbType.DateTime;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@CorrespondenceType";
            param.Value = correspondencetype;
            param.DbType = DbType.Int32;
            comm.Parameters.Add(param);


            param = comm.CreateParameter();
            param.ParameterName = "@All";
            param.Value = all;
            param.DbType = DbType.Boolean;
            comm.Parameters.Add(param);

            return GenericDataAccess.ExecuteSelectCommand(comm);

        }

    }
}