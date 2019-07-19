using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCustom
{
    public class Log
    {
        public static void WriteLog(string message)
        {
            //string sPathName = HostingEnvironment.MapPath("~/App_Data/Exceptions/Error");
            string sPathName = ConfigurationManager.AppSettings["LogFolder"].ToString();
            string _sLogFormat = "********** " + DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " **********";
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            //sErrorTime = "_" + sMonth + "-" + sDay + "-" + sYear;
            string _sErrorTime = "_" + sMonth + "-" + sDay + "-" + sYear + ".txt";

            StreamWriter sw = new StreamWriter(sPathName + _sErrorTime, true);
            sw.WriteLine(_sLogFormat);
            sw.WriteLine(message);
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }

        /*
        #region :Properties
        //Read
        public string ID { get; set; }
        public string CreatedOn { get; set; }
        public string Website { get; set; }
        public string IpAddress { get; set; }
        public string IsoRegion { get; set; }
        public string IsoCountry { get; set; }
        public string ErrorMessage { get; set; }

        //Write
        private string _createdon { get; set; }
        private string _website { get; set; }
        private string _ipaddress { get; set; }
        private string _isoregion { get; set; }
        private string _isocountry { get; set; }
        private string _exception_caught { get; set; }
        #endregion

        #region :Table Column Name
        public enum ColumnName
        {
            ID,
            CreatedOn,
            Website,
            IpAddress,
            IsoRegion,
            IsoCountry,
            ErrorMessage,
        };

        static string col_ID = ColumnName.ID.ToString();
        static string col_CreatedOn = ColumnName.CreatedOn.ToString();
        static string col_Website = ColumnName.Website.ToString();
        static string col_IpAddress = ColumnName.IpAddress.ToString();
        static string col_IsoRegion = ColumnName.IsoRegion.ToString();
        static string col_IsoCountry = ColumnName.IsoCountry.ToString();
        static string col_ErrorMessage = ColumnName.ErrorMessage.ToString();
        #endregion

        #region :Variables
        private static string txtErrorFile = HostingEnvironment.MapPath("~/App_Data/Exceptions/Error"); //this append daily date to the file name
        private static string xmlErrorFile = HostingEnvironment.MapPath("~/App_Data/Exceptions/Errors.xml");
        #endregion

        #region :Construtor
        //Set variables
        public cl_ErrorLog(string exception_caught)
        {
            _createdon = cl_Utilities.getDateTimeNow;
            _website = cl_Utilities.ThisWebsiteURL;
            _ipaddress = cl_Utilities.getIPAddress;
            _isoregion = cl_Utilities.getISORegion;
            _isocountry = cl_Utilities.getISOCountry;
            _exception_caught = exception_caught;
        }

        #endregion

        #region :CREATE
        //Daily Error Text File
        public void WriteErrorTxt()
        {
            string sPathName = txtErrorFile; //HostingEnvironment.MapPath("~/App_Data/Exceptions/Error");
            string _sLogFormat = "********** " + DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " **********";
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            //sErrorTime = "_" + sMonth + "-" + sDay + "-" + sYear;
            string _sErrorTime = "_" + sMonth + "-" + sDay + "-" + sYear + ".txt";

            StreamWriter sw = new StreamWriter(sPathName + _sErrorTime, true);
            sw.WriteLine(_sLogFormat);
            sw.WriteLine("Website: " + _website);
            sw.WriteLine("IP Address: " + _ipaddress);
            sw.WriteLine("ISO Region: " + _isoregion);
            sw.WriteLine("ISO Country: " + _isocountry);
            sw.WriteLine("---Exception----");
            sw.WriteLine(_exception_caught);
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }

        //All Errors Xml File
        public void WriteErrorXml()
        {
            //Open the log file for append and write the log 
            DataSet ds = new DataSet();
            DataRow dr;

            int new_id = (cl_DAL.getLastID(xmlErrorFile, ID)) + 1;
            ds.ReadXml(xmlErrorFile);

            dr = ds.Tables[0].NewRow();
            dr[ID] = new_id;
            dr[CreatedOn] = _createdon;
            dr[Website] = _website;
            dr[IpAddress] = _ipaddress;
            dr[IsoRegion] = _isoregion;
            dr[IsoCountry] = _isocountry;
            dr[ErrorMessage] = _exception_caught;

            ds.Tables[0].Rows.Add(dr);
            ds.WriteXml(xmlErrorFile);
        }

        #endregion

        #region :READ

        #endregion
        */
    }
}
