using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iHRIS.Controllers
{
    public class SoftwareController : Controller
    {
        // GET: Software
        public ActionResult SysMenu()
        {
            return View();
        }
        public ActionResult MstEmployee()
        {
            return View();
        }
        public ActionResult MstEmployeeDetail()
        {
            return View();
        }
    }
}