﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    /// <summary>
    /// 职员控制器
    /// </summary>
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult List()
        {
            return View();
        }
	}
}