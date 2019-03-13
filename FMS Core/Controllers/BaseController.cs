using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FMS_Core.Controllers
{
    public class BaseController : Controller
    {
        public void InitializePageHeader(string headerTitle,string pageName , string id)
        {
            ViewData["HeaderTitle"] = headerTitle;
            ViewData["Name"] = pageName;
            ViewData["Id"] = id;
            ViewData["CreatedDatetime"] = DateTime.Now;
        }
    }
}