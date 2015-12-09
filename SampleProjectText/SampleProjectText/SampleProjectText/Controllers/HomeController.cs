using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProjectText.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Home()
        {
            DefaultMessage response = new DefaultMessage();
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "AllLocalCopy\\combine.bat";
                proc.StartInfo.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + "AllLocalCopy";
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.UseShellExecute = false;

                proc.Start();

                response.Success = true;
            }
            catch (Exception exception)
            {
                //Log.Error(exception.Message, exception);
            }
            return View(response);
        }

        public class DefaultMessage
        {
            public DefaultMessage()
            {
                Success = false;
                ErrorMessage = string.Empty;
            }

            public bool Success { get; set; }

            public string ErrorMessage { get; set; }
        }
    }
}
