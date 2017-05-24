using System;
using System.Web.Mvc;

namespace OneDrive_CameraUploaderManager.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            if (!String.IsNullOrWhiteSpace(Request.Params["errormessage"]))
            {
                ViewBag.MensagemErro = Request.Params["errormessage"].ToString();
            }

            return View();
        }
    }
}