using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealExceptions
{
    public class CreateLogFiles
    {
        private string sLogFormat;
        private string sPath;

        public CreateLogFiles()
        {
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
            sPath = ConfigurationManager.AppSettings["PATH_LOCAL_LOG"];
        }

        public void ErrorLog(string sName, string sErrMsg)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(sPath + sName + ".txt", true))
                {
                    sw.WriteLine(sLogFormat + sErrMsg);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception err)
            {

            }

        }
    }
}
